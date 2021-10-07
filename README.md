# Fear Generator

#### Create a watch list for the spooky season with all your horror movie favorites!

#### By Anna Clarke, Melissa Schatz-Miller, Diego Serafico

<p align="center">
  <img src="FearGenerator/wwwroot/img/dataSchema.png">  
</p>

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_
* _NuGet_

## Description

This web application will allow users to create horror subgenres to organize their horror movie watch list. They can then add movies to each subgenre, giving each one a rating, number of stars, release year etc. Users can edit movies and search for a movie by title.

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* _Clone this repository to your desktop_
* _Open in text editor_
* _Create appsettings.json in /FearGenerator/ directory_
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:_
```{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=fear_generator;uid=root;pwd=YOUR_PASSWORD;"
  }
}```
* _open new terminal and run SQL ($ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In the Navigator > Administration window, select Data Import/Restore.
* _In Import Options select Import from Self-Contained File_
* _Navigate to fear_generator.sql_
* _Under Default Schema to be Imported To, select the New button & Enter fear_generator as name of database_
* _Click Ok_
* _Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window_
* _After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The fear_generator database should appear._
* _In terminal, navigate into Fear-Generator.Solution/FearGenerator/ and enter the command $ dotnet restore, to install necessary packages_
* _enter command $ dotnet build, to build program_
* _enter command $ dotnet run, to view program in your browser_
* _follow instructions on the website and have a spooky time!_

## Known Bugs

* _Delete functionality coming soon!_

## License
_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information
                       🍃  
Anna Clarke: <anclarkie@gmail.com>    
🍃 Melissa Schatz-Miller: <melissa.scmi@gmail.com>    
Diego Serafico: <dseraficohernandez@gmail.com> 🍃


