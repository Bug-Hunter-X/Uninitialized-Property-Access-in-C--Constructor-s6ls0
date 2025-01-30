# Uninitialized Property Access in C# Constructor

This example highlights a common error in C#: accessing a property that hasn't been properly initialized within a class's constructor.  This can lead to unpredictable results, such as default values (0 for integers, null for references), or even runtime exceptions.

The `Bug.cs` file demonstrates the problematic code.  The `BugSolution.cs` file presents a corrected version.

This repository is for educational purposes, showing how to avoid this coding pitfall.