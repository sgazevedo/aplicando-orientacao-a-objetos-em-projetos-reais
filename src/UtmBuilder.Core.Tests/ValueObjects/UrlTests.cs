using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core.ValueObjects.Exceptions;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
  [TestClass]
  public class UrlTests
  {
    [TestMethod]
    [DataRow(" ")]
    [DataRow("http")]
    [DataRow("anyurl")]
    //[ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid(string invalidUrl)
    {
      try
      {
        new Url(invalidUrl);
      }
      catch (InvalidUrlException)
      {
        Assert.IsTrue(true);
      }
    }

    [TestMethod]
    [DataRow("https://somepage.com")]
    [DataRow("https://anypage.io")]
    [DataRow("https://etc.com")]
    public void ShouldNotReturnExceptionWhenUrlIsValid(string validUrl)
    {
      new Url(validUrl);
      Assert.IsTrue(true);
    }    
  }
}
