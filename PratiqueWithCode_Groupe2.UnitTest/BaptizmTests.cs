using EvaluationSampleCode;

namespace PratiqueWithCode_Groupe2.UnitTest;


[TestClass]
public class BaptizmTests
{
    [TestMethod]
    public void CanBeBaptizedBy_AnyPriest_ReturnsTrue()
    {
        // Arrange
        var clergyMember = new ClergyMember { IsPriest = true };

        // Act
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(clergyMember);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeBaptizedBy_AnyPope_ReturnsTrue()
    {
        // Arrange
        var clergyMember = new ClergyMember { IsPope = true };

        // Act
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(clergyMember);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeBaptizedBy_NonPriestNonPope_ReturnsFalse()
    {
        // Arrange
        var clergyMember = new ClergyMember();

        // Act
        var baptizm = new Baptizm(new ClergyMember());
        var result = baptizm.CanBeBaptizedBy(clergyMember);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_SameClergyMember_ReturnsTrue()
    {
        // Arrange
        var clergyMember = new ClergyMember();

        // Act
        var baptizm = new Baptizm(clergyMember);
        var result = baptizm.CanBeTeachedBy(clergyMember);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeTeachedBy_DifferentClergyMember_ReturnsFalse()
    {
        // Arrange
        var clergyMember1 = new ClergyMember();
        var clergyMember2 = new ClergyMember();

        // Act
        var baptizm = new Baptizm(clergyMember1);
        var result = baptizm.CanBeTeachedBy(clergyMember2);

        // Assert
        Assert.IsFalse(result);
    }
}

