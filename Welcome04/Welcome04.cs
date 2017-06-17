// Figure 3.13: Welcome04.cs
// Inserting content into a  string with string interpolation

using System;

class Welcome04 // Begin class Welcome04
{
   static void Main() // Begin Main methoc
   {
      string person = "Paul"; // Declare string variable person, and initialize with vlaue "Paul"
      Console.WriteLine($"Welcome to C# Programming, {person}!");

   } // End Main method

} //End class Welcome04



//using System;

//class Welcome04
//{
//   static void Main()
//   {
//      string person = "George";
//      Console.WriteLine($"Welcome to C# Programming {person}");
//   }
//}

//using System;

//namespace Welcome04
//{
//   class Welcome04
//   {
//      static void Main()
//      {
//         string person = "George";
//         Console.WriteLine($"Welcome to C# Programming, {person}!");
//      }
//   }
//}