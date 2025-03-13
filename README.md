# Custom Attribute Example in C#

## Overview
This project demonstrates how to create and use a **custom attribute** in C# to **restrict method execution** based on user permissions.

## Features
- Defines a custom attribute **`IsAdmin`**.
- Uses it to **restrict access** to a method.
- Implements a function to **check permissions** before executing the method.

## How It Works
1. **Define a Custom Attribute**  
   The `IsAdmin` attribute takes a `bool` value to indicate if admin access is required.

2. **Apply the Attribute to a Method**  
   ```csharp
   [IsAdmin(true)]
   public void DeleteUser()
   {
       Console.WriteLine("User deleted successfully.");
   }
