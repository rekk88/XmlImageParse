using System.Linq;
using System.Xml.Linq;
using System;
using System.IO;
public class Program
{
    internal static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //string path = @"\XMLParse\XMLSources\myConfig.xml";
        XElement xmlFromFile = XElement.Load(Path.GetFullPath(@"B:\Repos\rekk88\XmlImageParse\XmlImageParse\XMLParse\XMLSources\myConfig.xml"));
        Console.WriteLine(xmlFromFile);
        //System.IO.DirectoryNotFoundException: 'Could not find a part of the path 'B:\XMLParse\XMLSources\myConfig.xml'.'
    }
}
