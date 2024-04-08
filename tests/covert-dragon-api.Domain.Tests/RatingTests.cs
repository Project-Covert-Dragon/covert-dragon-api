namespace covert_dragon_api.Domain.Tests;
using covert_dragon_api.Domain;
using NuGet.Frameworks;

[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        var rating = new Rating(1, "Mike", "Great fit!");

        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.userName);
        Assert.AreEqual("Greate fit!", rating.Review);
    }
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Cannot_Create_Rating_Wtih_Invalid_Stars()
    {
        var rating = new Rating(0, "Mike", "Great fit!");
    }
}