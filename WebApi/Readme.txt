WebApiTest HomeWork

The goals of this project was to test the API of the following site: https://restful-booker.herokuapp.com/

Should test only CRUD operations, 1-1 test each case.

Used SpecFlow, NUnit, FluentAssertion, MicrosoftSDK, etc. packages.

Did the tests in BDD format

There is a LivingDoc report and Postman collection attached as well.

Create Op. Test : Creating a new booking - Get a booking as a result.
Update Op. Test : Fully updating a booking on a specified Id - Get a booking as a result.
POST Op. Test : Login - Get an authentication token as a result.
Delete Op. Test : Delete a booking by its Id - Get "Created" message as a confirmation.

How to get testreport:

Step 1 : Open CMD - type cmd in search bar and press enter
Step 2 : Locate your project via console, like "cd C:\Users\User\Desktop\WEBUI\WebApi\WebApiHomeWork\bin\Debug\net6.0
Step 3 : type in console "livingdoc test-assmebly WebApiHomeWork.dll -t TestExecution.json"
Step 4 : You will find the generated HTML file in the directory, named LivingDoc.html, you can open it manually or use the console and type: "C:\Users\User\Desktop\WEBUI\WebApi\WebApiHomeWork\bin\Debug\net6.0LivingDoc.html"



