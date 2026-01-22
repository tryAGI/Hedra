using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

openApiDocument.Servers?.Clear();
openApiDocument.Servers?.Add(new OpenApiServer
{
    Url = "https://mercury.dev.dream-ai.com/api"
});

openApiDocument.Security = new List<OpenApiSecurityRequirement>
{
    new()
    {
        {
            new OpenApiSecuritySchemeReference(referenceId: "APIKeyHeader", hostDocument: openApiDocument),
            new List<string>()
        }
    }
};

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);