# Enumeration
The Enumeration<TEnum> class is a base class for creating enumeration types in C#. It extends the functionality of traditional enums by allowing you to add custom behavior. This class provides methods for retrieving instances of the enumeration by value or name and ensures proper equality checks. It is intended to be inherited by specific enumeration types.

## API Reference

### Properties

#### `int Value`
- Gets the integer value associated with the enumeration.

#### `string Name`
- Gets the name of the enumeration.

### Methods

#### `static TEnum? FromValue(int value)`
- Retrieves an enumeration instance by its value.
- **Parameters:**
  - `int value`: The value to search for.
- **Returns:** 
  - `TEnum?`: The enumeration instance if found, otherwise `null`.

#### `static TEnum? FromName(string name)`
- Retrieves an enumeration instance by its name.
- **Parameters:**
  - `string name`: The name to search for.
- **Returns:**
  - `TEnum?`: The enumeration instance if found, otherwise `null`.

#### `bool Equals(Enumeration<TEnum>? other)`
- Checks if two enumeration instances are equal.
- **Parameters:**
  - `Enumeration<TEnum>? other`: The other enumeration instance to compare.
- **Returns:**
  - `bool`: `true` if both instances are equal, otherwise `false`.

#### `override bool Equals(object? obj)`
- Overrides the base `Equals` method to compare enumeration instances.

#### `override int GetHashCode()`
- Overrides the base `GetHashCode` method to provide a hash code for the enumeration instance.

#### `override string ToString()`
- Overrides the base `ToString` method to return the name of the enumeration.

## Example

Here's an example of how to create and use a custom enumeration by inheriting from `Enumeration<TEnum>`:

```csharp
using System;

namespace EnumerationExample
{
    public class Color : Enumeration<Color>
    {
        public static readonly Color Red = new Color(1, "Red");
        public static readonly Color Green = new Color(2, "Green");
        public static readonly Color Blue = new Color(3, "Blue");

        private Color(int value, string name) : base(value, name) { }
        
        // Custom behavior can be added here
        public void PrintColor()
        {
            Console.WriteLine($"Color: {Name}, Value: {Value}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var red = Color.FromValue(1);
            var green = Color.FromName("Green");

            Console.WriteLine(red); // Output: Red
            Console.WriteLine(green); // Output: Green

            red?.PrintColor(); // Output: Color: Red, Value: 1
            green?.PrintColor(); // Output: Color: Green, Value: 2
        }
    }
}
