var builder = Host.CreateDefaultBuilder(args)
    .UseSerilog((hostingContext, loggerConfiguration) =>
    {
        loggerConfiguration
            .ReadFrom.Configuration(hostingContext.Configuration)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .WriteTo.File(
                path: Path.Combine(AppContext.BaseDirectory, "logs", "test-.txt"),
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: 7)
            .WriteTo.Seq("http://localhost:5341/");
    })
    .ConfigureServices(services =>
    {
        services.AddTransient<MyClass>();
    });

var host = builder.Build();

// Optional: run some startup code
var myClass = host.Services.GetRequiredService<MyClass>();
myClass.DoSomething();

await host.RunAsync(); // <-- Not really needed for a console app, but good practice if you want to add hosted services later