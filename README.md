## Development environment
Make sure you have installed latest .net core 1.1 on your system. To check write `dotnet --version`
 on command line. Result should be 1.0.4.

Recommended Editor: VS code (Supports GIT by GUI)

## Running the project
Go inside the Vpms.API folder and open command line there. Then you need to fire this command to 
run the project: `dotnet run`


## Doing migration
First go inside the Vpms.Data project. From there run following commands for migration.

dotnet ef --startup-project ../Vpms.API migrations add *yourMigrationName*

dotnet ef database update -s ../Vpms.API