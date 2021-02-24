FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR bin/Release/netcoreapp3.1/linux-x64
ENTRYPOINT ["dotnet", "EzDVF.dll"]