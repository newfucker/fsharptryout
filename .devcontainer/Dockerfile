FROM ubuntu:latest

# general upgrade
RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get clean

# install dev tools
RUN apt-get install -y git
RUN apt-get install -y dotnet-sdk-8.0
RUN apt-get install -y curl htop

RUN git config --global --add safe.directory /workspaces/fsharptryout

# Linter. See https://fsprojects.github.io/fantomas/docs/end-users/GettingStarted.html
RUN dotnet tool install -g fantomas