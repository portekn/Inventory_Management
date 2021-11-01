using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InventoryMaintenance
{
    public static class StudentDB
    {
        private const string Path = @"..\..\Students.xml";

        public static List<Students> GetItems()
        {
            // create the list
            List<Students> items = new List<Students>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Book node
            if (xmlIn.ReadToDescendant("Item"))
            {
                // create one Product object for each Product node
                do
                {
                    Students item = new Students();
                    xmlIn.ReadStartElement("Item");
                    item.Name = xmlIn.ReadElementContentAsString();
                    item.score1 = xmlIn.ReadElementContentAsDecimal();
                    item.score2 = xmlIn.ReadElementContentAsDecimal();
                    item.score3 = xmlIn.ReadElementContentAsDecimal();
                    items.Add(item);
                }
                while (xmlIn.ReadToNextSibling("Item"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return items;
        }

        public static void SaveItems(List<Students> items)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Items");

            // write each product object to the xml file
            foreach (Students item in items)
            {
                xmlOut.WriteStartElement("Item");
                xmlOut.WriteElementString("Name", Convert.ToString(item.Name));
                xmlOut.WriteElementString("Score 1", Convert.ToString(item.score1));
                xmlOut.WriteElementString("Score 1", Convert.ToString(item.score2));
                xmlOut.WriteElementString("Score 1", Convert.ToString(item.score3));
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}

