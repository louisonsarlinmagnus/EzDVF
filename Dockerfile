FROM mcr.microsoft.com/dotnet/core/aspnet:5.0
COPY bin/Release/net5.0/linux-x64/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "aspnetapp.dll"]
