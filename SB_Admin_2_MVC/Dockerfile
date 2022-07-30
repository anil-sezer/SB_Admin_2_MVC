FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SB_Admin_2_MVC/SB_Admin_2_MVC.csproj", "SB_Admin_2_MVC/"]
RUN dotnet restore "SB_Admin_2_MVC/SB_Admin_2_MVC.csproj"
COPY . .
WORKDIR "/src/SB_Admin_2_MVC"
RUN dotnet build "SB_Admin_2_MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SB_Admin_2_MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SB_Admin_2_MVC.dll"]
