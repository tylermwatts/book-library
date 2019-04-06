using book_library.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookLibraryApi.Tests
{
  [TestClass]
  public class ValuesControllerTests
  {
    private ValuesController valuesController;

    [TestInitialize]
    public void Initialize()
    {
      valuesController = new ValuesController();
    }

    [TestMethod]
    public void Get_ReturnsValues()
    {
      var result = valuesController.Get();

      Assert.IsNotNull(result);
    }
  }
}
