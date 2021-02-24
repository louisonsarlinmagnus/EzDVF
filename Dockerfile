FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
EXPOSE 80
ENTRYPOINT ["dotnet ", "bin/Release/netcoreapp3.1/linux-x64/EzDVF.dll"]