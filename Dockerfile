# The following is borrowed heavily from https://docs.microsoft.com/en-us/dotnet/core/docker/build-container?tabs=windows


# Step to create a running container
# 1 Publish : `dotnet publish -c Release`
# 2 Build image: `docker build -t dotnettest-image -f Dockerfile .`
# 3 Create container: docker create --name dotnettest-container dotnettest-image
# 4 Start container: docker start dotnettest-container

# The FROM keyword requires a fully qualified Docker container image name.
# The Microsoft Container Registry (MCR, mcr.microsoft.com) is a syndicate of
# Docker Hub - which hosts publicly accessible containers. The dotnet/core
# segment is the container repository, where as the aspnet segment is the
# container image name. The image is tagged with 3.1, which is used for
# versioning. Thus, mcr.microsoft.com/dotnet/aspnet:3.1 is the .NET Core 3.1
# runtime. Make sure that you pull the runtime version that matches the
# runtime targeted by your SDK. For example, the app created in the previous
# section used the .NET Core 3.1 SDK and the base image referred to in the
# Dockerfile is tagged with 3.1.

FROM mcr.microsoft.com/dotnet/aspnet:5.0

# The COPY command tells Docker to copy the specified folder on your computer to a folder in the container.
# In this example, the publish folder is copied to a folder named App in the container.
# The WORKDIR command changes the current directory inside of the container to App.
# The next command, ENTRYPOINT, tells Docker to configure the container to run as an executable.
# When the container starts, the ENTRYPOINT command runs. When this command ends, the container will automatically stop
COPY bin/Release/net5.0/publish/ App/
WORKDIR /App
ENTRYPOINT ["dotnet", "dotnettest.dll"]
