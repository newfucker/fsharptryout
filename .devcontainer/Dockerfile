FROM ubuntu:latest

# general upgrade
RUN apt-get update
RUN apt-get upgrade -y
RUN apt-get clean

# install dev tools
RUN apt-get install -y git-all
RUN apt-get install -y dotnet-sdk-8.0

RUN git config --global --add safe.directory /workspaces/fsharptryout