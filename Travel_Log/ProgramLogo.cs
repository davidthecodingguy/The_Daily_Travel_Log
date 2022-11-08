using System;
using System.Drawing;
using NUnit.Framework;
namespace The_Daily_Travel_Log
{
    //The ProgramLogo class has the single responsibility of menu logo display and follows the Single Responsibility Principle (Part of Feature #3)
    //The ProgramLogo class can be added to as new requirements arise, but should not be modified as it is functionally sound. This class follows the Open/Closed Principle (Part of Feature 3)
    public class ProgramLogo
    {
        public static void WriteLogo()
        {
            string logo = @"
_______
|_   _| __  __ _____                                              ___ ____ 
  | |   ||__|| | __|                                             \\ \\  // 
  | |   ||__|| | _|                                               \\ \\// 
  |_|   ||  || |   |                                              // //\\ 
 ____                                                            //_//__\\
|  _  \        __ || _  _                                          .
| | | |   /\   || || \\//                                        .
| |_| |  /  \  || ||  ||                                       .
|____ / / /\ \ || ||  ||                                       .
_______                                                        .
|_   _| ___               ____ ||                              .
  | |  |   \   /\  \ \/ / | _| ||                        . . . . . . . . . . . . 
  | |  |   /  /  \  \  /  | _| ||                      .       .                . 
  |_|  |/\ \ / /\ \  \/   |  | ||                    .         .                 .
___                                                .           .                  .
| |                  _____                       .             .                   .
| |         ___     //  \_\                    .               .                    .
| |       /  _  \  ||   ___  . . . . . . . . .                 . . . . . . . . . . . .
| |_____ |  |_|  | \\  |__ | 
|_|_____| \     /   \\    /  
                             
            ";
            Console.WriteLine(logo, Color.Green);
        }
    }
}