﻿using System;

namespace VariablePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            string characterName = "Ralph";
            int characterAge = 17;

            Console.WriteLine($"There once was a man named {characterName}");
            Console.WriteLine($"He was {characterAge} years old ");

            characterName = "Mike";
            Console.WriteLine($"He really liked the name {characterName}");
            Console.WriteLine($"But didnt like being {characterAge}, due to being underage");
        }
    }
}
