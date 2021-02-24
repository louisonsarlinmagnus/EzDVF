FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY bin/Release/net3.1/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "aspnetapp.dll"]