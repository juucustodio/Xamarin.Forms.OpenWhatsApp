# Xamarin.Forms.OpenWhatsApp

Send message to specific number from your Xamarin.Forms application using this package.


 ###### This plugin, works on iOS, Android
 
 **NuGet**

|Name|Info|
| ------------------- | :------------------: |
|OpenWhatsApp|[![NuGet](https://img.shields.io/badge/nuget-1.0.1-blue.svg)](https://www.nuget.org/packages/Xamarin.Forms.OpenWhatsApp/)|



 **Platform Support**
 
 OpenWhatsApp is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms
 
 
 
 ## Setup / Usage

Install the package in the shared project and use.


Use the Open method

```csharp

  Chat.Open("Phone Number", "Message");

```

### iOS

Add this key in the Info.plist

```txt

	<key>LSApplicationQueriesSchemes</key>
	<array>
     		<string>whatsapp</string>
	</array>
 ```
