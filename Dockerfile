FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
ENTRYPOINT ["dotnet", "EzDVF.dll"]