using NUnitPractice.Mocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitPractice.UnitTests
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string filePath)
        {
            return "";
        }
    }
}
