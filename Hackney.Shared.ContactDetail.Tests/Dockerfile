FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT='true'

ARG LBHPACKAGESTOKEN
ENV LBHPACKAGESTOKEN=$LBHPACKAGESTOKEN
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.ContactDetail.sln ./
COPY ./Hackney.Shared.ContactDetail/Hackney.Shared.ContactDetail.csproj ./Hackney.Shared.ContactDetail/
COPY ./Hackney.Shared.ContactDetail.Tests/Hackney.Shared.ContactDetail.Tests.csproj ./Hackney.Shared.ContactDetail.Tests/
COPY /nuget.config /root/.nuget/NuGet/NuGet.Config

RUN dotnet restore ./Hackney.Shared.ContactDetail/Hackney.Shared.ContactDetail.csproj
RUN dotnet restore ./Hackney.Shared.ContactDetail.Tests/Hackney.Shared.ContactDetail.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.ContactDetail.Tests/Hackney.Shared.ContactDetail.Tests.csproj

CMD dotnet test