FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
EXPOSE 80
ENTRYPOINT ["dotnet", "bin/Release/netcoreapp3.1/linux-x64/EzDVF.dll"]