#!/bin/sh
VERSION="7.3.0"
if [ ! -f "openapi-generator-cli-$VERSION.jar" ]; then wget https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/"$VERSION"/openapi-generator-cli-"$VERSION".jar -O openapi-generator-cli-"$VERSION".jar; fi

# Dotnet (shared)
rm -rf ./api/src
java -jar openapi-generator-cli-"$VERSION".jar generate -i ./WebApplication1/Swagger/public-api.json -o ./api -g csharp -c ./api/config.yaml --library httpclient