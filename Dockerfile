FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR bin/Release/netcoreapp3.1/linux-x64
ENTRYPOINT ["EzDVF.dll"]