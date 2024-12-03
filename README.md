# KSU SWE 3643 Software Testing and Quality Assurance Semester Project: Web-Based Calculator

Quick note: When I tried to download the file from GitHub, my antivirus autoflagged it. I checked out what it was flagged as and pretty much the only results coming up were from developers who had also gotten similar flags, even including a university student developing a similar project to mine. It's more than likely a false positive, but I wanted to let you know in advance that it's a known potential issue.
## Table of Contents
+ [Environment](#environment)
+ [Executing the Web Application](#executing-the-web-application)
+ [Executing Unit Tests](#executing-unit-tests)
+ [Executing Unit Test Coverage](#executing-unit-test-coverage)
+ [Executing End-To-End Tests](#executing-end-to-end-tests)
+ [Final Video Presentation](#final-video-presentation)

## Team Members
+ Duncan Pegram

## Architecture
![image](SoftwareTestingUMLDiagram.png)
## Environment
This Application was designed and tested in Windows 11. I cannot promise that it will work on any other platform.
Ideally everything needed should work with what's included in the GitHub, at most you might need to download Playwright and PowerShell.
## Executing the Web Application
Open the command line, then type:
```
"<project file path>\src\Calculator\CalculatorWebServerApp\bin\Debug\net9.0\CalculatorWebServerApp.exe"
```
You should see a section of the running file that says "now listening on:" followed by a link to a localhost port. Copy that link into your browser to view the page while the program is running.
![image](SoftwareTestingWebAppSampleOutput.png)
## Executing Unit Tests
Open the command line, then type:
```
dotnet test "<project file path>\src\Calculator\CalculatorLogicUnitTests\bin\Debug\CalculatorLogicUnitTests.dll"
```
![image](SoftwareTestingUnitTestScreenshot.png)
## Reviewing Unit Test Coverage
![image](SoftwareTestingUnitTestCoverageScreenshot.png)
## Executing End-To-End Tests
Note: The web server app must be running to execute end-to-end tests.
Open the command line, then type:
```
dotnet test "<project file path>\src\Calculator\CalculatorEndToEndTests\bin\Debug\CalculatorEndToEndTests.dll"
```
![image](SoftwareTestingEndToEndTestScreenshot.png)
## Final Video Presentation
Link to video here: https://youtu.be/vwPGes3JpFU