FROM mcr.microsoft.com/dotnet/core/sdk:3.1

# disable microsoft telematry
ENV DOTNET_CLI_TELEMETRY_OPTOUT = 'true'

WORKDIR /app

# Copy csproj and restore as distinct layers
COPY ./Hackney.Shared.ContactDetails.sln./
COPY./Hackney.Shared.ContactDetails/Hackney.Shared.ContactDetails.csproj./Hackney.Shared.ContactDetails/
COPY./Hackney.Shared.ContactDetails.Tests/Hackney.Shared.ContactDetails.Tests.csproj./Hackney.Shared.ContactDetails.Tests/

RUN dotnet restore./Hackney.Shared.ContactDetails/Hackney.Shared.ContactDetails.csproj
RUN dotnet restore ./Hackney.Shared.ContactDetails.Tests/Hackney.Shared.ContactDetails.Tests.csproj

# Copy everything else and build
COPY . .

RUN dotnet build -c debug -o out Hackney.Shared.ContactDetails.Tests/Hackney.Shared.ContactDetails.Tests.csproj

CMD dotnet test