using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Scalar.AspNetCore;
using Teqit.Api.Transforms;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers(x =>
{
    x.Conventions.Add(new RouteTokenTransformerConvention(new KebabCaseParameterTransformer()));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(x =>
    {
        x.Theme = ScalarTheme.DeepSpace;
    });
}

// app.UseHttpsRedirection();
app.MapControllers();

app.Run();
