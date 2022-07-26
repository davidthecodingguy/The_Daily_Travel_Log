# The_Daily_Travel_Log
This is a simple location-logging console application designed to record the computer's location when input by the user, and display previously entered location information within the program. The purpose of this application is mainly recreational and will serve as the basis for a more complex program in the future. 
<br />
<br />
The previously logged locations file can be found by searching your computer's files for PreviousLocations.csv and the error log file can be found by searching for DailyTravelLogErrors.csv, if you wish to view them. *Please note that occasionally the program will save locations and errors to new versions/instances of the files. This does not affect previous location retrieval and it is not necessary to find these files for program functionality.*
<br />
<br />
Project Features:
<br />
<br />
#1
Main menu that allows users to log their location, look at previous locations, and exit the program.
<br />
Required Feature Addressed: Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, including choosing to exit the program.
<br />
<br />
#2
*Please not that this feature did not appear on the original Project Plan.* Saves location information as input by the user and retrieves previously logged location information and displays said information to the user when requested via the corresponding menu option.
<br />
Required Feature Addressed: Read data from an external file, such as text, JSON, CSV, etc and use that data in your application.
<br />
<br />
#3
Logs invalid user inputs on the main menu and file not found errors and records them in a text file viewable by the user.
<br />
Required Feature Addressed: Implement a log that records errors, invalid inputs, or other important events and writes them to a text file.
<br />
<br />
#4
Retrieves previously logged location information and displays said information to the user when requested via the corresponding command from the main menu.
<br />
Required Feature Addressed: Use a LINQ query to retrieve information from a data structure (such as a list or array) or file.
