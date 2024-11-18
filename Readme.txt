🛠️ Service Request Management System
📖 Overview
This project is a Service Request Management System that allows users to manage service requests using binary search trees and graph data structures. The system provides functionalities to:

➕ Add service requests
🗑️ Delete service requests
🔍 Search service requests
🔃 Sort service requests
🛑 Prerequisites
Ensure you have the following before getting started:

✅ Visual Studio 2019 or later
✅ .NET Framework 4.8
📁 Project Structure
Here's what each file does:

ServiceRequestStatus.cs: Handles service request status functionalities.
Dashboard: Displays the dashboard page.
ReportIssues.cs: Manages the reporting of new issues.
LocalEventsForm: Allows users to search for upcoming events.
BinarySearchTree.cs: Implements a binary search tree.
Graph.cs: Implements a graph data structure.
🚀 How to Compile and Run
Step 1: Extract the ZIP
Extract the file st10150497 PROG POE PART 3.Zip.
Step 2: Open the Solution
Navigate to the file PROG7312POE.sln and double-click to open it in Visual Studio.
Step 3: Build the Project
In Visual Studio, go to Build > Build Solution or press Ctrl+Shift+B.
Ensure there are no build errors.
Step 4: Run the Project
Click the Start button or press F5 to run the project.
🖱️ How to Use the Program
1️⃣ Report an Issue
Click the Report Issues button on the sidebar.
Enter your location in the following format:
"Street Name, Neighbourhood, City, Area Code"
Example: "Florence, Observatory, Cape Town, 7700"
Select a category from the dropdown menu. If you choose "Other," a new text box will appear for a custom category.
Provide a detailed issue description.
Optionally, click the Attach Media button to upload an image.
Click Submit to save the report.
Optionally, view your last submitted report by clicking View Reports.
2️⃣ Manage Service Requests
Click the Service Request button on the sidebar. You’ll see a list of all submitted reports.
Use the Sort by Priority button to organize reports, with the highest priority at the top.
Use the Refresh button to update the list after any action.
Use the ReportID textbox to input a specific Report ID.
Click Find All Related Requests to view related requests.
Click Find Closest Related Request to identify the most closely related report.
Don’t forget to click Refresh after each action!
🧮 Data Structures Used
1️⃣ Binary Search Tree 🌳
The Binary Search Tree was generated using OpenAI’s ChatGPT and is used for:

Storing and managing service requests with the key as the Report ID and the value as request details.
Performing operations such as:
Insert: Add new service requests.
TryGetValue: Retrieve service request details.
Traversal: Display service requests using in-order, pre-order, or post-order traversals.
2️⃣ Graph 📈
The Graph was also generated using OpenAI’s ChatGPT and is used to:

Represent relationships between service requests (e.g., same category or location).
Perform operations like:
AddVertex: Add new service requests as vertices.
AddEdge: Create relationships between service requests.
DFS/BFS: Traverse the graph to find related requests.
3️⃣ Heap 🗂️
The Heap (also generated using ChatGPT) is used to:

Sort service requests by priority. High-priority items are pushed to the top, while low-priority items remain at the bottom.
Example operations:
Insert: Add all items from the ListView into the heap.
RemoveMax: Retrieve items in priority order for display.
📜 Sample Code for Sorting with Heap
csharp
Copy code
// Initialize a heap with a custom comparison function
var heap = new Heap<ListViewItem>((item1, item2) =>
{
    int priority1 = int.Parse(item1.SubItems[4].Text);
    int priority2 = int.Parse(item2.SubItems[4].Text);
    return priority1.CompareTo(priority2);
});

// Insert all items into the heap
foreach (ListViewItem item in listViewRequests.Items)
{
    heap.Insert(item);
}

// Clear the ListView and add sorted items
listViewRequests.Items.Clear();
while (heap.Count > 0)
{
    listViewRequests.Items.Add(heap.RemoveMax());
}
📜 MIT License
sql
Copy code
MIT License

Copyright (c) 2024 Mabala Makhakhe

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
🤝 Acknowledgments
OpenAI ChatGPT: For generating the Binary Search Tree, Graph, and Heap classes, as well as providing insights and suggestions for improving the project.
Reference: OpenAI. (2024). ChatGPT. Available at: https://openai.com/chatgpt [Accessed 18 Nov. 2024].