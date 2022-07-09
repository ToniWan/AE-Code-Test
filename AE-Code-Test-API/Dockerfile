#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AE-Code-Test-API/AE-Code-Test-API.csproj", "AE-Code-Test-API/"]
RUN dotnet restore "AE-Code-Test-API/AE-Code-Test-API.csproj"
COPY . .
WORKDIR "/src/AE-Code-Test-API"
RUN dotnet build "AE-Code-Test-API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AE-Code-Test-API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AE-Code-Test-API.dll"]