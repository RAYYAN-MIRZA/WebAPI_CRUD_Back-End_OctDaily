	/***          HOW TO RUN THE BACK-END WEBSITE ON YOUR PC   *****/

Hello there, This is Rayyan Mirza, your guide to unfold this website and make it run on your computer.

First of all Download the repositories from GitHub of Both Back-end and Front-end to a known location in your Computer. 
The links are given below:

Front-End repository Link:


Back-End repository Link:


/*****************************************************************************************************************************/

	ESTABLISHING DATABASE AND CONNECTING IT WITH THE BACK-END!

HOW TO CREATE/RESTORE SQL DATA FROM BACK UP FILE USING MICROSOFT SQL SERVER MANAGEMENT STUDIO:

1- Open your sql server in 'sql server management studio' and connect your server.
2- Create a new temporary Database.
3- Right-Click on the Database (which you just created and) where you want the data to be saved.
4- From the menu, Left-Click on tasks.
5- Another menu will appear. Left-Click on the Restore option.
6- Another menu will appear. Left-Click on the Database option.
7- A new window will appear with three tabs.  
8- On the general tab, set the source button to 'device'. 
9- Manualy set the source location where you saved the backend repository and select the file named as "STUDENTS_DATA.bak".
10- Choose the destination database which you just created in step # 2.
11- Left-Click on the third Tab ,named as Options.
12- You will see three Restore options.
13- Select the First option which will be like " Overwrite the existing database( with Replace)".
14- Left-Click on the OK button. 
15- Small box will appear as "Restore Successfully".


HOW TO ESTABLISH SQL CONNECTION BETWEEN BACKEND AND SQL SERVER USING VISUAL STUDIO AND MICROSOFT SQL SERVER MANAGEMENT STUDIO:

1- Open the folder where you downloaded the backend repository.
2- Open the solution file named as "WebAPI.sln".
3- Microsoft Visual Studio will be open.
4- On the task bar Look for the View Option, Left-Click on it.
5- A menu will appear, Left-Click On the "Server Explorer".
6- A menu will Appear named as "Server Explorer", Left-Click on the "Connect to Database".
7- A new window will appear named as "Add Connection".
8- Set the Data Source as "Microsoft SQL Server (SqlClient)".
9- Write your Sql Server name( If you donot remember the name, Open 'MICROSOFT SQL SERVER MANAGEMENT STUDIO', and See your Server name while connecting it, and then Write it).
10- Select the Authentication method which you use whenever you connect your 'SQL Server' In 'MICROSOFT SQL SERVER MANAGEMENT STUDIO'. 	
11- In the Connect to database option, Left-Click on the "Select or enter a database name".
12- Left-Click on the input bar below, A List of your Databases will appear. Select the 'Temporary database' which you just created earlier.
13- Left-Click on the Test Connection Button.
14- Most probably you will see a window with message as 'Test Connection Succeeded'. 
15- Left-Click on the 'OK' button.
16- Left-Click on the 'Advanced..' on the button.
17- Above the 'OK' button you will see a some text written like this : (Note: The text will not be exaclty same like the given below , So donot panic if it is different from below)

	"Data Source=DESKTOP-4UGD3H3\SQLEXPRESS02;Initial Catalog=mydb;Integrated Security=True"

18- Please Copy all the text carefully. I repeat, COPY all the text like the above example.
	For those who donot know how to copy:
	{
	This can be done by placing the mouse cursor in the first letter of text which will be 'D' and then holding the Left-Click button and dragging it till the end of the text. After that Press CTRL + C. Text will be copied. 
	}	
19- After Copying, Open Visual Studio from the Task bar(Bottom bar in Windows) which you just opened in Step #2.  
20- Look for the 'View' option on Visual Studio tool bar, Left-Click on the 'Solution Explorer'.
21- 'Solution Explorer' window will pop up, Look for the File named as 'Web.config'. ( HINT: Most likely, It will be the last file in the list of Soltion Explorer).
22- Open that file by Left-Clicking. Now, on the 14th line of code you will see  :
	{
	<connectionStrings>   
    		<add name="STUDENTS_DATA"  connectionString="Data Source=DESKTOP-4UGD3H3\SQLEXPRESS02;Initial Catalog=mydb;Integrated Security=True"  providerName="System.Data.SqlClient" />
	</connectionStrings>	
	}
23- You only have to replace the part named as connectionString= "Data Source=DESKTOP-4UGD3H3\SQLEXPRESS02;Initial Catalog=mydb"
       with the text you just copied in Step # 18 (Note that the text is in Double Quotes like "this").
	For example:
	{
		connectionString="Text you copied".
	}
24- After replacement , The ConnectionString will look like this:
	{
	<connectionStrings>   
    		<add name="STUDENTS_DATA"  connectionString="Text you copied"  providerName="System.Data.SqlClient" />
	</connectionStrings>	
	}
(Note that: Only connectionString is changed while everything is same as before).

25- Congrats ,By following the above steps, You just connected your SQL database to the backend.

/******************************************************************************************************************/

HOW TO RUN THE BACK-END:

1- Locate the green Play button on Visual studio. Left-Click on it to run the Back-end(project).
2- After few moments, You will see your internet browser pop-up with new window with url as " localhost:53535".
3- Don't worry if you see a message like:
	"Server Error in '/' Application" 	
4- I assure you that there is no problem till here and your Backend is running successfully. 
(Note : Do not close the tab with url as " localhost:53535", even if it shows the message like "Server Error in '/' Application").

	
/*************		THE END IS ALWAYS NEAR    		************************************************/			
