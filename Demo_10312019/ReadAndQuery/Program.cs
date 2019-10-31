using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// make sure to add all components you need
using System.Xml;
using System.Xml.Linq;
// allows you to omit the Console.(...)
using static System.Console;

namespace ReadAndQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Loading an XML doc");
            XDocument myDoc = XDocument.Load("Inventory3.xml");
            WriteLine(myDoc);
            WriteLine();

            // looking for car objects
            // LINQ query?
            // all data is strings bc doc is text-based
            // finding a car with ID 2
            // deferred execution
            var result = from car in myDoc.Descendants("Car")
                         where ((string)car.Attribute("ID")).Equals("2")
                         select car;
            // to make this an immediate execution: set the query within parens
            // and add a ToArray, ToList, or another object in order for it to 
            // contain the info.
            // then call from a method?
            foreach (var car in result)
            {
                WriteLine(car);
            }
        }
    }
}

/*
    Most all supporting files Visual Studio builds are XML files. 
    This is called "metadata".
*/
