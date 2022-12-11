using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System;
using System.IO;
public class Program
{

    internal static void Main(string[] args)
    {
        string dir = Directory.GetCurrentDirectory() + @"\XMLParse\XMLSources\myConfig.xml";
        XElement xmlFromFile = XElement.Load(dir);
        Console.WriteLine(XElement.Parse((string)xmlFromFile));
        
        // Console.WriteLine(xmlFromFile); //check file
        // XmlTextReader reader = new XmlTextReader(dir);
        // reader.WhitespaceHandling = WhitespaceHandling.None;
        // while (reader.Read())
        // {
        //     Console.WriteLine(reader.Name);
        //     Console.WriteLine(reader.ValueType);
        //     Console.WriteLine("value : ",reader.Value);
        // }

    }
}
