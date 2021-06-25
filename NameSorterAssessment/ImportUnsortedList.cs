using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameSorterAssessment
{
    /* Reads the file in the path that is provided, validates the given information and populates the Persons list*/

    class ImportUnsortedList
    {
        
        public static List<Person> ImportList(string filePath)
        {

           

            List<string> lines = new List<string> ();
            try {
                lines= File.ReadAllLines(filePath).ToList();
            } 
            catch (Exception) {
                throw new ImportNamesExceptions("File of unsorted names is not found");
            
            }
            

            List<Person> people = new List<Person>();


            foreach (string line in lines) {
                string[] entires = line.Split(' ');

                /*Check the number of names submitted per person as a person
                 must have a last name and a minimum of one given name and a maximum of three given names*/
                Person newPerson;
                switch (entires.Length)
                {
                    case 0:
                        throw new ImportNamesExceptions("Empty line provided in list");
                       
                    case 1:
                        throw new ImportNamesExceptions("A Person must have atleast one given name and one last name");
                       
                    case 2:
                        newPerson= new Person(entires[0], entires[1]);
    
                        break;
                    case 3:
                        newPerson = new Person(entires[0], entires[1], entires[2]);
                        break;
                    case 4:
                        newPerson = new Person(entires[0], entires[1], entires[2], entires[3]);
                        break;
                    default:
                        throw new ImportNamesExceptions("A Person may only have upto 3 given names");

                }
                people.Add(newPerson);
            }
            return people;

        }
    }

}

