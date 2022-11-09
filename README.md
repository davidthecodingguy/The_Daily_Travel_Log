# The_Daily_Travel_Log
This is a simple location-logging console application designed to record the computer's location when input by the user, and display previously entered location information within the program. The purpose of this application is mainly recreational and serves as a project for continued improvement and learning. 
<br />
<br />
The previously logged locations file can be found by searching your computer's files for PreviousLocations.csv and the error log file can be found by searching for DailyTravelLogErrors.txt, if you wish to view them. *Please note that occasionally the program will save locations and errors to new versions/instances of the files. This does not affect previous location retrieval and it is not necessary to find these files for program functionality.*
<br />
<br />
**Project Features:**
<br />
<br />
#1:
Improved program unit tests, to aid in continued program functionality. Unit tests will be saved to either a text file or a database.
<br />
**Required Feature Addressed:** Create 3 or more unit tests for your application.
<br />
<br />
#2:
Logs runtime errors and invalid inputs and records them in a database or file viewable by the user. Errors or exceptions will also be displayed to the user when encountered.
<br />
**Required Feature Addressed:** Implement a log that records errors, invalid inputs, or other important events and writes them to a text file.
<br />
<br />
#3:
The program will follow the Single Responsibility Principle and the Open/Closed Principle for ease of development and maintenance. The MainMenu, ErrorHandling, ProgramStart, RetreiveData, SaveData, ProgramLogo, RetrieveDataTests, and SaveDataTests all follow the Single Responsibility Principle. The RetrieveDataTests, SaveDataTests, and ErrorHandling classes all follow the Open/Closed Principle. Comments detailing each class's use of these principles can be found in comments in the respective class files. 
<br />
**Required Feature Addressed:** Add comments to your code explaining how you are using at least 2 of the SOLID Principles.
<br />
<br />
**Unimplemented Features:**
<br />
<br />
#4:
Swagger front-end will be connected to the Daily TravelTravel Log console application for simple web integration.
<br />
**Required Feature Addressed:** Make your application an API.
<br />
<br />
#5: 
At least one class will be generic to streamline development and ensure the code remains clean.
<br />
**Required Feature Addressed:** Make a generic class and use it.
