FBMetro
=======

FBMetro is a planned series of demo apps, to show how the Facebook C# SDK can be used to write compelling Metro apps, for Windows 8. 

As of now, the app authenticates you, and pulls your name and profile pic, from Facebook. I will add lots of more features to the code in the next few days.

To tinker with the code, you need a few things:
1) A valid App ID from Facebook - head over to http://developers.facebook.com/apps to get started with that.
2) Windows 8, as well as Visual Studio 2012. VS Express for Win8 would also work just fine - the code was written using the Express edition..
3) Nuget - once you're ready to compile the code yourself, there's one dependency you need to satisfy - the Facebook C# SDK. Install Nuget from http://nuget.org - it's a Visual Studio add-in. Once installed, open up the Package Manager Console(Tools-->Library Package Manager-->Package Manager Console), and punch in the following command, to install the SDK: Install-Package Facebook

..and you're all set! Feel free to drop in a line at rudimk.firefly@gmail.com, if there's something you'd like to ask, or if there's any way you feel I could write better code.


Rudi MK.