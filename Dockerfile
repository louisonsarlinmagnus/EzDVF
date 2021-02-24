FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /EzDVF

RUN mkdir aspnetapp/
COPY *.sln .
COPY *.csproj ./aspnetapp/
RUN dotnet restore

COPY /. ./aspnetapp/
WORKDIR /aspnetapp/
RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /appCOPY --from=build /app ./
ENTRYPOINT ["ls"]