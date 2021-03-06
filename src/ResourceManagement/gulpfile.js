var path = require('path');
var gulp = require('gulp');
var args = require('yargs').argv;
var colors = require('colors');
var spawn = require('child_process').spawn;
var fs = require('fs');

const mappings = require('./api-specs.json');
const defaultSpecRoot = "https://raw.githubusercontent.com/Azure/azure-rest-api-specs/current";

gulp.task('default', function () {

    console.log("Usage: gulp codegen " +
        "[--spec-root <swagger specs root>] " +
        "[--projects <project names>] " +
        "[--autorest <autorest info>] " +
        "[--autorest-csharp <autorest.csharp info>] " +
        "[--debug] " +
        "[--autorest-args <AutoRest arguments>]\n");
        
    console.log("--spec-root");
    console.log(`\tRoot location of Swagger API specs, default value is "${defaultSpecRoot}"`);

    console.log("--projects");
    console.log("\tComma separated projects to regenerate, default is all. List of available project names:");
    Object.keys(mappings).forEach(function(i) {
        console.log('\t' + i.magenta);
    });

    console.log("--autorest");
    console.log("\tThe version of AutoRest. E.g. 2.0.9, or the location of AutoRest repo, e.g. E:\\repo\\autorest");
    
    console.log("--autorest-csharp");
    console.log("\tPath to an autorest.csharp generator to pass as a --use argument to AutoRest.");
    console.log("\tUsually you'll only need to provide this and not a --autorest argument in order to work on C# code generation.");
    console.log("\tSee https://github.com/Azure/autorest/blob/master/docs/developer/autorest-extension.md");
    
    console.log("--debug");
    console.log("\tFlag that allows you to attach a debugger to the autorest.csharp generator.");
    
    console.log("--autorest-args");
    console.log("\tPasses additional argument to AutoRest generator");
});

var specRoot = args['spec-root'] || defaultSpecRoot;
var projects = args['projects'];
var autoRestVersion = 'latest'; // default
if (args['autorest'] !== undefined) {
    autoRestVersion = args['autorest'];
}
var debug = args['debug'];
var autoRestArgs = args['autorest-args'] || '';
var autoRestExe;

gulp.task('codegen', function (cb) {
    if (autoRestVersion.match(/[0-9]+\.[0-9]+\.[0-9]+.*/) ||
        autoRestVersion == 'latest') {
        autoRestExe = 'autorest ---version=' + autoRestVersion;
        handleInput(projects, cb);
    } else {
        autoRestExe = "node " + path.join(autoRestVersion, "src/autorest-core/dist/app.js");
        handleInput(projects, cb);
    }
});

var handleInput = function (projects, cb) {
    if (projects === undefined) {
        Object.keys(mappings).forEach(function (proj) {
            codegen(proj, cb);
        });
    } else {
        projects.split(",").forEach(function (proj) {
            proj = proj.replace(/\ /g, '');
            if (mappings[proj] === undefined) {
                console.error('Invalid project name "' + proj + '"!');
                process.exit(1);
            }
            codegen(proj, cb);
        });
    }
}

var codegen = function (project, cb) {
    const regenManager = args['regenerate-manager'] ? ' --regenerate-manager=true ' : '';
    var outputDir = path.resolve(mappings[project].dir + '/Generated');
    if (!args['preserve']) {
        deleteFolderRecursive(outputDir);
    }
    console.log('Generating "' + project + '" from spec file ' + specRoot + '/' + mappings[project].source);
    var generator = '--fluent';
    if (mappings[project].fluent !== null && mappings[project].fluent === false) {
        generator = '';
    }
    
    const generatorPath = args['autorest-csharp']
        ? `--use=${path.resolve(args['autorest-csharp'])} `
        : '';

    cmd = autoRestExe + ' ' + specRoot + "/" + mappings[project].source +
        ' --csharp ' +
        ' --azure-arm ' +
        generator +
        ` --csharp.namespace=${mappings[project].package} ` +
        ` --csharp.output-folder=${outputDir} ` +
        ` --csharp.license-header=MICROSOFT_MIT_NO_CODEGEN ` +
        generatorPath +
        regenManager +
        autoRestArgs;

    if (mappings[project].args !== undefined) {
        cmd = cmd + ' ' + mappings[project].args;
    }
    
    if (debug) {
        cmd += ' --csharp.debugger';
    }

    console.log('Command: ' + cmd);
    spawn(cmd, [], { shell: true, stdio: "inherit" });
};

var deleteFolderRecursive = function (path) {
    if (fs.existsSync(path)) {
        fs.readdirSync(path).forEach(function (file, index) {
            var curPath = path + "/" + file;
            if (fs.lstatSync(curPath).isDirectory()) { // recurse
                deleteFolderRecursive(curPath);
            } else { // delete file
                fs.unlinkSync(curPath);
            }
        });
        fs.rmdirSync(path);
    }
};
