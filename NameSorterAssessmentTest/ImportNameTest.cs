using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NameSorterAssessment;

namespace NameSorterAssessmentTest
{
    public class ImportNameTest
    {
        [Fact]
        public void FileNotFound()
        {
            Assert.Throws<ImportNamesExceptions>(() => ImportUnsortedList.ImportList("../../../TestData/NoFile.txt"));
        }

        [Fact]
        public void EmptyNameInput()
        {
            Assert.Throws<ImportNamesExceptions>(() => ImportUnsortedList.ImportList("../../../TestData/EmptyName.txt"));
        }

        [Fact]
        public void OneNameInput()
        {
            Assert.Throws<ImportNamesExceptions>(() => ImportUnsortedList.ImportList("../../../TestData/OneName.txt"));
        }

        [Fact]
        public void TooManyNamesInput()
        {
            Assert.Throws<ImportNamesExceptions>(() => ImportUnsortedList.ImportList("../../../TestData/TooManyNames.txt"));
        }
    }
}
