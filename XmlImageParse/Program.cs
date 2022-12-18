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
        //get Xml File Path
        Console.WriteLine(Helpers.getProjectDirectory());
        string xmlPath = Helpers.getProjectDirectory() + @"XMLParse\XMLSources\myConfig.xml";
        
        //Load Xml
        XElement xmlFromFile = XElement.Load(xmlPath);

        //read Xml content
        foreach(var child in xmlFromFile.Elements())
        {
            Console.WriteLine(child);
            Console.WriteLine(child.Name.LocalName); //xml node type

            //read node attribute if there's any
            if (child.HasAttributes) 
            {
                foreach(var attribute in child.Attributes())
                {
                    Console.WriteLine(attribute); //attribute obj
                    Console.WriteLine(attribute.Name); //attribute name
                    Console.WriteLine(attribute.Value); //attribure value
                }
            }

            //var test2 = child.Elements();
            //var t = child.HasElements;
            //Console.WriteLine();
        }
       
    }
}