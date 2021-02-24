FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
EXPOSE 80
ENTRYPOINT ["ls"]