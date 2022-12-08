using System.Linq;
using System.Xml.Linq;
using System;
using System.IO;
public class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        XElement xmlFromFile = XElement.Load(@"XMLParse\XMLSources\myConfig.xml");
        //Console.WriteLine(xmlFromFile);
    }
}
