# ConsoleAppExtended
Hi👋, ConsoleAppExtended is a console application template which contains dependency injection and logging.
This is intended to be a more serious form of a console application rather than a disposable one.

# Prerequisite
### .NET 6 with Visual Studio 2022
Download the latest .NET SDK from: https://dotnet.microsoft.com/en-us/download/dotnet/6.0.  
And the latest version of Visual Studio from: https://visualstudio.microsoft.com/

### Docker
Run the following command within Docker to host a Seq instance:
> docker run -d --name seq-dev --restart unless-stopped -p 5341:80 -v "<path_to_project>/seq-dev:/data" -e ACCEPT_EULA=Y datalust/seq

## To do:
- Make it a real template
- Make it createable from the commandline:  > dotnet new consoleappextended

