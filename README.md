#  Create a .NET console application using Visual Studio

This tutorial shows how to create and run a .NET console application in Visual Studio 2019.


# Prerequisites

[Visual Studio 2019 version 16.8 or a later version](https://visualstudio.microsoft.com/downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=inline+link&utm_content=download+vs2019)  with the  **.NET Core cross-platform development**  workload installed. The .NET 5.0 SDK is automatically installed when you select this workload.

For more information, see  [Install the .NET SDK with Visual Studio](https://docs.microsoft.com/en-us/dotnet/core/install/windows#install-with-visual-studio).

##  Create the app
Create a .NET console app project named "HelloWorld".

1.  Start Visual Studio 2019.
    
2.  Select  **Tools**  >  **Options**  >  **Environment**  >  **Preview features**, and then select  **Show all .NET Core templates in the New project (requires restart)**.
    
    ![Show all .NET templates option](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/dotnet-options.png)
    
3.  Close and reopen Visual Studio.
    
4.  On the start page, choose  **Create a new project**.
    
    ![Create a new project button selected on the Visual Studio start page](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/start-window.png)
    
5.  On the  **Create a new project**  page, enter  **console**  in the search box. Next, choose  **C#**  or  **Visual Basic**  from the language list, and then choose  **All platforms**  from the platform list. Choose the  **Console Application**  template, and then choose  **Next**.
    
    ![Create a new project window with filters selected](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/create-new-project.png)
    
    Tip
    
    If you don't see the .NET templates, you're probably missing the required workload. Under the  **Not finding what you're looking for?**  message, choose the  **Install more tools and features**  link. The Visual Studio Installer opens. Make sure you have the  **.NET Core cross-platform development**  workload installed.
    
6.  In the  **Configure your new project**  dialog, enter  **HelloWorld**  in the  **Project name**  box. Then choose  **Create**.
    
    ![Configure your new project window with Project name, location, and solution name fields](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/configure-new-project.png)
    
7.  In the  **Additional information**  dialog, select  **.NET 5.0 (Current)**, and then select  **Create**.
    
    ![Additional information dialog](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/additional-info.png)
    

The template creates a simple "Hello World" application. It calls the  [Console.WriteLine(String)](https://docs.microsoft.com/en-us/dotnet/api/system.console.writeline#System_Console_WriteLine_System_String_)  method to display "Hello World!" in the console window.

The template code defines a class,  `Program`, with a single method,  `Main`, that takes a  [String](https://docs.microsoft.com/en-us/dotnet/api/system.string)  array as an argument:

C#Copy

```
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```

`Main`  is the application entry point, the method that's called automatically by the runtime when it launches the application. Any command-line arguments supplied when the application is launched are available in the  _args_  array.

If the language you want to use is not shown, change the language selector at the top of the page.
## Run the app

1.  Press  Ctrl+F5  to run the program without debugging.
    
    A console window opens with the text "Hello World!" printed on the screen.
    
    ![Console window showing Hello World Press any key to continue](https://docs.microsoft.com/en-us/dotnet/core/tutorials/media/with-visual-studio/hello-world-console.png)
    
2.  Press any key to close the console window.
