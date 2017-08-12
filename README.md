

## Doing migration
dotnet ef --startup-project ../Vpms.API migrations add Initial
dotnet ef database update -s ../Vpms.API