using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorterAssessment
{
    class ExportNamesException : Exception
    {

        public ExportNamesException(string ex) : base(ex)
        { }
    }
}
