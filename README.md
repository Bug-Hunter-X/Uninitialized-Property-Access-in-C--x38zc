# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property of a class before it has been assigned a value.  This can lead to unexpected exceptions or incorrect behavior.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file shows how to fix it.  The core issue is that the `MyProperty` is not initialized before its value is accessed in the `MyMethod` function.  This is easily addressed by assigning an initial value in the constructor or providing a default value.