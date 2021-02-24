FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN mkdir /app
COPY bin/Release/netcoreapp3.1/linux-x64 app/
WORKDIR app/
ENTRYPOINT ["ls"]