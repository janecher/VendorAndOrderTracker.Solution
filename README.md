# Vendor and Order tracker

#### C# .Net Application, 07/24/2020

#### By **Evgeniya Chernaya**

## Description

This application creates and manipulate with list of vendors in bakery shop, and list of orders for each vendor.

## Setup/Installation Requirements

* Click the green "Clone or download" button at the right of the screen.
* Select "Download ZIP."
* Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
* In your browser, navigate to https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer for Mac or https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer for Windows and click the link "click here to download manually" if the download for .NET Core 2.2 SDK does not start automatically.
* Double-click the downloaded .NET Core 2.2 SDK file and run the installer.
* Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
* Enter the command "dotnet build" in the terminal.
* Enter the command "dotnet run" in the terminal. The program should begin to run in the browser.

## Specification

| Behavior | Input | Output|
|----------|-------|-------|
| Create Vendor class instance by calling constructor method | Vendor vendor = new Vendor(name, description); | vendor.GetType() = Vendor |
| Create Order class instance by calling constructor method | Order order = new Order(title, description, price, date); | order.GetType() = Order |
| Return all vendor orders | List<Order> orderList = {order1, order2} | Order.GetAll() = {order1, order2} |
| Return Id of Order | order3 | order3.Id = 3 |
| Find Order by Id | 3 | order3 |
| Return vendor list | List<Vendor> vendorList = {vendor1, vendor2} | Vendor.GetAll() = {vendor1, vendor2} |
| Return Id of Vendor | vendor3 | vendor3.Id = 3 |
| Find Order by Id | 3 | vendor3 |
| Add vendor (and order to that vendor) | newVendor.AddOrder(newOrder) | _vendor odject added to the vendorList_ |

## Known Bugs

_No known bugs_

## Technologies Used

  * C# .Net
  * Visual Studio Code

### License

_This software is licensed under the MIT license_

Copyright (c) 2020 **Evgeniya Chernaya**.