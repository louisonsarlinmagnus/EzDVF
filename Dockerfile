FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
 COPY bin/Release/netcoreapp3.1/publish/ app/
WORKDIR /app
ENTRYPOINT ["dotnet", "EzDVF.dll"]