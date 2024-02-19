using DateTestUnitaire;

namespace UnitTests.cs;

[TestClass]
public class UnitTest1
{
    DateValidator _date;


    [TestInitialize]
    public void Init()
    {
        _date = new DateValidator();
    }

    [TestMethod]
    public void IsDateValid_DateIsValid_ShouldReturnTrue()
    {
        string TestDate = "14-04-2021";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsTrue(isValid);
    }

    [TestMethod]
    public void IsDateValid_DateIsInValid_ShouldReturnTrue()
    {
        string TestDate = "lkd-zdz-sqd";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }


    [TestMethod]
    public void IsDateValid_ThreeHyphen_ShouldReturnFalse()
    {
        string TestDate = "10-02-200-4";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsDateValid_TwoHyphen_ShouldReturnTrue()
    {
        string TestDate = "12-02-2023";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsTrue(isValid);
    }


    [TestMethod]
    public void IsDateValid_MonthBiggerThanTwelve_ShouldReturnFalse()
    {
        string TestDate = "14-14-2004";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsDateValid_DayIsBiggerThan31_ShouldReturnFalse()
    {
        string TestDate = "32-8-2004";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsDateValid_YearIsBiggerThanCurrentYear_ShouldReturnFalse()
    {
        string TestDate = "12-10-2025";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsDateValid_DayOutOfLeapYear_ShouldReturnFalse()
    {
        string TestDate = "29-02-2023";


        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }

    [TestMethod]
    public void IsDateValid_31DaysInApril_ShouldReturnFalse()
    {
        string TestDate = "31-04-2004";

        bool isValid = _date.IsDateValid(TestDate);

        Assert.IsFalse(isValid);
    }


}
