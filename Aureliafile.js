var aurelia = require("aurelia-cli");

aurelia.command("bundle", {
    js: {
        "wwwroot/appbundle": {
            modules: [
                "app",
                "aurelia-bootstrapper",
                "aurelia-framework",
                "aurelia-router",
                "aurelia-http-client",
                "aurelia-validation"
            ], 
            options: {
                inject: true
            }
        }
    },
    template: {}
});