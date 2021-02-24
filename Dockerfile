FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
RUN mkdir app
COPY bin/Release/netcoreapp3.1/linux-x64/* /app/
EXPOSE 81
ENTRYPOINT ["dotnet", "/app/EzDVF.dll"]