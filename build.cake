//#addin "Cake.WebDeploy"
#addin "nuget:?package=Cake.Watch"
#addin "nuget:?package=Cake.UServer"

Task("Server").Does(() => {
    var settings = new UServerSettings {
        Port = 9000,
        Path = "./hello"
    };
    UServer(settings);
});

Task("Watch").Does(() => {
    var settings = new ProcessSettings {
        Arguments = "--watch"
    };
    StartProcess("webpack", settings);
});


var target = Argument("target", "default");
RunTarget(target);