FROM microsoft/dotnet:2.1-aspnetcore-runtime

COPY dist /app

WORKDIR /app

EXPOSE 80/tcp

ENTRYPOINT ["dotnet", "webmvc.dll"]