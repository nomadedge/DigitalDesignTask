# Digital Design Enrollment Task
App for Data Matrix generation from the text.  
## Development stack and technologies
 - Universal Windows Platform
 - Syncfusion.SfBarcode.UWP nuget package
## Deployment tutorial
You will need Visual Studio with UWP development workload. App is written for Windows 10 May 2019 Update (Windows 10, version 1903 - 10.0; Build 18362) and newer. So make sure you've installed all necessary updates for your OS.  
To run application open .sln file via Visual Studio, check if all nuget packages are correctly installed and press F5 to start application (Ctrl + F5 to do it without an attached debugger).  
Enter the text into the textbox and press the "Generate Data Matrix" button. Then you'll see Data Matrix barcode on the right side of the window. I personally have used Google Lens to check if the barcode is correct.  