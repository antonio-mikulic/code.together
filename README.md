# Introduction

# Technologies
## [ABP](https://aspnetboilerplate.com)
Used for fast startup, so we can focus on business logic and not basic project setup. 

## [WebRTC](https://webrtc.org/) 
Used for live video chat

## SignalR
Used for real time notifications between users in interview group. This includes information about room they are in, sending chat messages, and updating task solver area.
 
# Setup
## Required programs
1. Install .NET 5 SDK
2. Install NodeJs, Angular CLI and Yarn to your machine


## Database
1. Code.Together is currently setup to use [SQL Server 2019 Developer](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) server. For basic setup, ensure you have SQL Server installed locally. 
2. Once you have a database installed, go to aspnet-core\src\Code.Together.Web.Host\appsettings.json, and configure "ConnectionStrings:Default" to match your database. If you are using standard SQL Server 2019 Developer installed on local machine, you can skip this step.
3. Open your IDE of choice (or use CMD to run Migrator)
4. Set "Code.Together.Migrator" as startup project, and run it
5. Type in "y" when asked

## Backend
1. Open your preffered IDE (Rider and Visual Studio suggested)
2. Set "Code.Together.Web.Host" as startup project, and run it
3. Swagger is available at: http://localhost:21021/swagger/index.html

## Frontend
1. Use your IDE/Editor of choice (suggested Visual Studio Code)
2. Open angular folder with your editor
3. Open terminal
4. Start the application by writing "npm run start"
5. UI is available at: http://localhost:4200. You can login using tenant "default", user: "admin", password: "123qwe". If you leave out the tenant you will be loged in as host, and you will be able to create more tenants

# License
[MIT](LICENSE).
