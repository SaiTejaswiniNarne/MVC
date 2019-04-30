# MVC

<b>Team Members/ Developers:</b> <br>
<ul>
<li>Gadekari Sonam</li>
<li>Naidu Harika</li>
<li>Narne Sai Tejaswini</li>
</ul>

<h1>Getting Started</h1>
<p>Recommended: Visual Studio 2017 Community</p>

<p>Run Build / Build Solution and make sure the project compiles.</p>

<p>Go to Tools / NuGet Package Manager / Package Manager Console.</p>

<p>To add migrations use the following commands</p>

<p>add-migration initial</p>
<p>Using Package Manager Console: Add-Migration [migrationname]</p>

<p>If the SQL Server LocalDB 'MyDegree' is not already available, then execute the migration scripts with:</p>

<p>update-database</p>
<p>Using Package Manager Console: Update-Migration</p>
<h1>Commands</h1>
<p>To restore the dependencies and tools: dotnet restore</p>
<p>Build project & dependencies into set of binary files :dotnet build</p>
<p>To execute the project :dotnet run</p>

<h6>How to run our application.</h6>
<p>1)Got to the folder where the application is present and type dotnet run applicationname in powershell.</p>
<p>2)Open the solution .sln file and click on the run button in visual studio.</p>

<pre>
+---------------+---------------+-------------------------------------------------------------------+<br/>
| Takehome      | Multiplier    | Billing            |Estimated hours  per week   | Developers| Cost|<br/>
+===============+===============+====================+================+===========+===========+======<br/>
| 30            | 2.5           | 60                 | 6                          |3          |5400 |<br/>
+---------------+---------------+--------------------+----------------------------+-----------+------<br/>
</pre>

Takehome-->30/hr
Multiplier-->2.5 to 3.0
Billing rate-->2*30-->60 $/hr
Estimated hours-->
6 hrs/week *4 wks* 3 Developers

Cost = Billing rate* Total hours.

<h6>Azure Deployment:</h6>
<p>Resource group name: ResourceGroup</p>
<p>Free Location: "West Europe"</p>
<p>Azure deployment user-name: team06group</p>
<p>AppServicePlan Name is : AppServicePlan</p>
<p>app name: AppUsingDotnetMVC</p>
<p> Deployed link</p>
https://appusingdotnetmvc.azurewebsites.net/

<h6>git commands to push to cloud repoitory:</h6>

<p>git add .</p>
<p>git commit -m "connect to SQLDB in Azure"</p>
<p>git remote add azure https://AppDotnetMVC@appusingdotnetmvc.scm.azurewebsites.net/AppUsingDotnetMVC.git</p>
<p>git push azure master</p>

<p>Link for the Issues</p>
https://github.com/SaiTejaswiniNarne/MVC/issues?q=is%3Aissue+is%3Aclosed

<p>Link To the Repository:</p>
https://github.com/SaiTejaswiniNarne/MVC

Link to the commits:
https://github.com/SaiTejaswiniNarne/MVC/commits/master

Link To Team Slide:
![image](https://user-images.githubusercontent.com/42949313/56475016-1983c600-6448-11e9-8983-806de5933526.png)

Link to the Commits History(Contributions):
https://github.com/SaiTejaswiniNarne/MVC/graphs/contributors

Link to the Issues:
https://github.com/SaiTejaswiniNarne/MVC/issues

Credits Running:
![Credits](https://user-images.githubusercontent.com/42949313/56475388-2fe05080-644d-11e9-92bf-d4fb3c0fd4fa.PNG)

Credits Create:
![CreditAdd](https://user-images.githubusercontent.com/42949313/56475396-59997780-644d-11e9-914f-c3e3ac9d3088.PNG)

Degree Credits:
![Degree Credits](https://user-images.githubusercontent.com/42949313/56475419-a2e9c700-644d-11e9-9572-2e219a537bd1.PNG)

Degree Credits Create:
![Degree Credits Add](https://user-images.githubusercontent.com/42949313/56475421-a8dfa800-644d-11e9-83eb-d9d9250dc8be.PNG)

Degree Plan:
![Degree Plan](https://user-images.githubusercontent.com/42949313/56475441-ef350700-644d-11e9-9bf0-460ddf3a1470.PNG)

Degree Plam Credit:
![Degree Plan Add](https://user-images.githubusercontent.com/42949313/56475445-f5c37e80-644d-11e9-9bb4-3ba104399a47.PNG)


