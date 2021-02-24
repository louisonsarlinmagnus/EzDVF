FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
COPY home/runner/work/EzDVF/EzDVF/bin/Release/net5.0/linux-x64/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "aspnetapp.dll"]
