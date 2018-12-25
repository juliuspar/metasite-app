FROM microsoft/dotnet:2.2-sdk AS build

RUN curl -sL https://deb.nodesource.com/setup_10.x | bash -
RUN apt-get install -y nodejs
COPY ./MetasiteApp/*.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish "MetasiteApp" --configuration Release --output "dist"

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build "/MetasiteApp/dist" .
ADD https://github.com/vishnubob/wait-for-it/blob/master/wait-for-it.sh /wait-for-it.sh
RUN chmod +x /wait-for-it.sh
EXPOSE 80
ENTRYPOINT ["dotnet", "MetasiteApp.dll"]