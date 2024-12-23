# C# NullReferenceException: Uninitialized Property

This repository demonstrates a common C# error: a `NullReferenceException` caused by accessing a class property before it's been initialized.

## The Bug

The `bug.cs` file contains a simple class with a property. The `MyMethod` attempts to access this property without first ensuring it has a value. If the property is null, a `NullReferenceException` is thrown.

## The Solution

The `bugSolution.cs` file provides a solution by initializing the property in the class constructor or before accessing it in the method.