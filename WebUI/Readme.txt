WebUI HomeWork

Should make 2 scenarios on the following site: https://opensource-demo.orangehrmlive.com/

The first scenario was to Login/Navigate to Pay Grades page/Add a new record/Check its existing
The second scenario was to Login/Navigate to Pay Grades page/Add a new record but cancel the action/Check its not existing

As an addition task and help to run the testcases had to make a hook to delete the created record after every scenario.

Used Specflow, Selenium, NUnit, FluertAssertion, etc. packages.

Used Xpath and Css selectors to find the elements, made the steps in BDD format.

A LivingDoc test report and a Postman collection are attached as well.

How to run tests from console:

Step 1 : Open CMD - type cmd in search bar and press enter
Step 2 : Locate the "nunit3-console" file and navigate to its folder like "cd C:\Users\User\Desktop\WEBUI\WebUI\Nunit\bin"
Step 3 : Type the following command with the location of your project.dll
"nunit3-console C:\Users\User\Desktop\WEBUI\WebUI\WebUIHomework\bin\Debug\net6.0\WebUIHomework.dll"
Step 4 : TestResult.xml generated in the Nunit folder

How to get testreport:

Step 1 : Open CMD - type cmd in search bar and press enter
Step 2 : Locate your project via console, like "cd C:\Users\User\Desktop\WEBUI\WebUI\WebUIHomework\bin\Debug\net6.0"
Step 3 : type in console "livingdoc test-assmebly WebUIHomeWork.dll -t TestExecution.json"
Step 4 : You will find the generated HTML file in the directory, named LivingDoc.html, you can open it manually or use the console and type: "C:\Users\User\Desktop\WEBUI\WebUI\WebUIHomework\bin\Debug\net6.0\LivingDoc.html"
