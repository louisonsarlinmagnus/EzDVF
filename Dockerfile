FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
ENTRYPOINT ["dotnet", "EzDVF.dll"]