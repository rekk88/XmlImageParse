using System.Linq;
using System.Xml.Linq;
using System.Xml;
using System;
using System.IO;
using XmlImageParse.XMLParse.Helpers;

public class Program
{

    internal static void Main(string[] args)
    {
        Console.WriteLine(Helpers.getProjectDirectory());
        string xmlPath = Helpers.getProjectDirectory() + @"XMLParse\XMLSources\myConfig.xml";
        XElement xmlFromFile = XElement.Load(xmlPath);
        XmlDocument doc = new XmlDocument(); //creates a new XmlDocument obj
        doc.Load(xmlPath); //loads the xml file content in the XmlDocument doc
        Console.WriteLine(doc);
        //while doc.hasChildNodes 
        //append the node name to the child child node
        //i want this part of code to be recursive
        XmlNodeList nodes = doc.ChildNodes;
        XmlReader reader = xmlFromFile.CreateReader();
        while (reader.Read())
        {
            //Console.WriteLine(reader);
            Console.WriteLine(reader.LocalName);
            Console.WriteLine(reader);
            

            //Console.WriteLine(reader.Value);
            //Console.WriteLine(reader.GetAttribute(reader.Name));
            //Console.WriteLine(reader.NameTable);
            //reader.MoveToNextAttribute();
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



//https://www.c-sharpcorner.com/UploadFile/mahesh/reading-xml-in-ado-net/
//"B:\\Repos\\rekk88\\XmlImageParse\\XmlImageParse\\bin\\Debug\\net6.0\\XMLParse\\XMLSources\\myConfig.xml"
