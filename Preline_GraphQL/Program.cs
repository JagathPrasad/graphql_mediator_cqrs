var builder = WebApplication.CreateBuilder(args);

builder.AddGraphQL().AddTypes();
builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(typeof(Program).Assembly));

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
