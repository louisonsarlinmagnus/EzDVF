FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
RUN mkdir /app/
#COPY /bin/Release/netcoreapp3.1/linux-x64 /app/
EXPOSE 80
ENTRYPOINT ["ls"]