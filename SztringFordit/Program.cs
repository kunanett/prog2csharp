// See https://aka.ms/new-console-template for more information

using System;
using SztringFordit;
using static System.Console;


public class Program {
    public static void Main(string[] args) {
        string word = "hello";
        WriteLine(word.ReverseStr());
        WriteLine("world".ReverseStr());
    }
}