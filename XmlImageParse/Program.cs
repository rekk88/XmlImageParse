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
        XElement xmlFromFile = XElement.Load(@"B:\Repos\rekk88\XmlImageParse\XmlImageParse\XMLParse\XMLSources\myConfig.xml");

        //var test = from glz in xmlFromFile.Element("myConfig")
        //           where glz.Elements("glz")
        //           select glz;
        //Console.WriteLine(XElement.Parse((string)xmlFromFile));
        XmlReader reader = xmlFromFile.CreateReader();
        while (reader.Read())
        {
            //Console.WriteLine(reader);
            Console.WriteLine(reader);
            //Console.WriteLine(reader.Value);
            //Console.WriteLine(reader.GetAttribute(reader.Name));
            //Console.WriteLine(reader.NameTable);
        }
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

//"B:\\Repos\\rekk88\\XmlImageParse\\XmlImageParse\\bin\\Debug\\net6.0\\XMLParse\\XMLSources\\myConfig.xml"
