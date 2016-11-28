using Xunit;
namespace LeapYear
{
  public class IsLeapYearTest
  {
    [Fact]
    public void IsLeapYear_IsDivisibleByFour_True()
    {
      LeapYearClass TestIsLeapYear = new LeapYearClass();
      Assert.Equal(true, TestIsLeapYear.IsLeapYear(2004));
    }
    [Fact]
    public void IsLeapYear_IsDivisibleByOneHundered_False()
    {
      LeapYearClass TestIsLeapYear = new LeapYearClass();
      Assert.Equal(false, TestIsLeapYear.IsLeapYear(1900));
    }
    [Fact]
    public void IsLeapYear_IsDivisibleByFourHundered_True()
    {
      LeapYearClass TestIsLeapYear = new LeapYearClass();
      Assert.Equal(true, TestIsLeapYear.IsLeapYear(2000));
    }
  }
}
