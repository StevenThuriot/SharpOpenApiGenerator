﻿namespace dotnet.openapi.generator;

internal class SwaggerPathRequestBodyContentOctetStream
{
    public SwaggerSchemaProperty schema { get; set; } = default!;

    public string GetBody()
    {
        return (schema.ResolveType() ?? "object") + " body, ";
    }

    public string ResolveType()
    {
        return schema.ResolveType() ?? "object";
    }
}