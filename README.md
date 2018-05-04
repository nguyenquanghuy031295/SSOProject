# Introduction
This project is a demo for sharing between main application and sub-domain applications.

Like:
    *Google.com* is main domain, and  *drive.google.com* is a sub-domain.

In this, we have 2 projects:

  1. LoginCentral: we will login at here for all applications.
  2. AuthenticationApplication: a test app used shared cookie which get from *LoginCentral* for authentication.

# How to run
  In each project's appsetting.json , we have property is `SharedKeyLocation`. 
  
  This is place where we store key for encrypt/decrypt cookies. Applications if using this key could be authenticated by *LoginCentral*

  In *AuthenticationApplication* project, we have property `LoginUrl`, this is login page from *LoginCentral*. So if you change port of *LoginCentral*, you should change in here too :)

  Now, *LoginCentral* is using port 5000 and *AuthenticationApplication* is using port 4000.

  Follow this to run demo :
1. Open cmd in each project and run `dotnet run`
2. In *LoginCentral* page (localhost:5000), register an account and log in.
3. Go to *AuthenticationApplication* page (localhost:4000), you will see name of user. If still not logged in, you will be redirected to *LoginCentral* page.

P/S: In Program.cs of *AuthenticationApplication* project, there is a line `UseUrls`, if you want to deploy to IIS, remove or comment that line.