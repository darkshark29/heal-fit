# heal-fit

## Required
- You need the C# extension for Visual Studio Code :
[C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)

- Use this command to be able to create the edatabase : 
	```shell
	dotnet tool install --global dotnet-ef
	```

## Database creation
- In order to create the data base, use this command :
	```shell
	dotnet ef database update
	```

## Seed the database
- The seeder is launched whith the API :
	```shell
	dotnet build
	dotnet run
	```