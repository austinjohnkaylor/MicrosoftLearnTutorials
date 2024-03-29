# ------------------- Start of deploy image -------------------=
# Pull the mcr.microsoft.com/dotnet/sdk:7.0 image and name the image build
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build 
# Set the working directory within the image to /src
WORKDIR /src
# Copy the file named backend.csproj found locally to the /src directory that you created
COPY backend.csproj .
# Calls dotnet restore on the backend project
RUN dotnet restore
# Copy everything in the local working directory to the image
COPY . .
# Calls dotnet publish on the project
RUN dotnet publish -c release -o /app
# ------------------- End of build image -------------------

# ------------------- Start of deploy image -------------------
# Pull the mcr.microsoft.com/dotnet/aspnet:7.0 image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
# Set the working directory within the image to /app
WORKDIR /app
# Exposes port 80 and 443
EXPOSE 80
EXPOSE 443
# Copy everything from the /app directory of the build image created above into the app directory of this image
COPY --from=build /app .
# Sets the entrypoint of this image to dotnet and passes backend.dll as an argument, meaning it targets the backend project to run
ENTRYPOINT ["dotnet", "backend.dll"]
# ------------------- End of deploy image -------------------
