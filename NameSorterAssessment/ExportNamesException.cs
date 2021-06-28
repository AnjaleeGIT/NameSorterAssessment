using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterAssessment
{
    public class ExportNamesException : Exception
    {

        public ExportNamesException(string ex) : base(ex)
        { }
    }
}
