using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace NameSorterAssessment
{
    /*Sort the list of names first by last name, then by any given names the person may have*/
    class SortList
    {
        public static List<Person> SortNames(List<Person> people)
        {

            return people.OrderBy(x => x.lastName).ThenBy(x => x.givenName1).ThenBy(x=>x.givenName2).ThenBy(x=>x.givenName3).ToList(); ;
        }

    }
}
