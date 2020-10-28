using CodingChallenge.DataAccess.Interfaces;
using FakeItEasy;
using StructureMap;

namespace CodingChallenge.UnitTests
{
    public class FakeStructureMapRegistry : Registry
    {
        public FakeStructureMapRegistry()
        {
           For<ILibraryService>().Use(A.Fake<ILibraryService>());
        }
         
    }
}
