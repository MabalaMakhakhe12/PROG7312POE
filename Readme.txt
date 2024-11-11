PROG7312POE - Municipal Issue Reporting App
Overview
This application allows users to report municipal issues, such as crime, sanitation, roads, and utilities, in a South African municipality. The app leverages MaterialSkin for a modern, sleek UI and is developed in C# using WinForms.

Features
Report Issues: Users can report municipal issues by specifying a location, selecting a category, and providing a detailed description.
Attach Media: Users can attach images or documents to support their reports.
Motivational Progress: As users fill in their report details, a progress bar is updated with motivational statements.
View Reports: Users can view their previously reported issues.
Validation: The app validates the location format to ensure consistency and accuracy.
Installation
Clone the repository or download the source code.
Open the solution file in Visual Studio.
Install the MaterialSkin NuGet package for a modern UI:
bash
Copy code
Install-Package MaterialSkin
Build and run the application.
Usage
Reporting an Issue
Location: Enter the location of the issue using the format: Street, Suburb, City, Postal Code.
Category: Select a category from the dropdown list (e.g., Crime, Sanitation). If the category is "Other," an additional textbox appears for custom input.
Description: Provide a detailed description of the issue.
Attach Media: Optionally, attach an image or document to support the report.
Use the combobox that allows you to select file type in the Opendialog to 
switch between the Images and Documents.
Submit: Once all fields are filled, click the "Submit" button to save the report.
Viewing Reports
After submitting a report, users can click the "View Reports" button to review previously reported issues.
File Structure
IssueData struct: Stores the issue's location, category, description, attached media, and documents.
ReportIssues form: Main interface where users input issue details and submit reports.
ViewReportsForm: Displays submitted reports.
Dependencies
MaterialSkin: For modern UI elements and design.
System.Windows.Forms: For form controls and event handling.
System.Drawing: For handling image attachments.
System.Text.RegularExpressions: For validating location input.
License
This project is licensed under the MIT License.

(OpenAI, 2024)
Bibliography
OpenAI. (2024, 09 18). create a readme for this app. Retrieved from OpenAI: https://chatgpt.com/share/66eb45b5-b1a8-800e-b8f6-1536ba28be61

