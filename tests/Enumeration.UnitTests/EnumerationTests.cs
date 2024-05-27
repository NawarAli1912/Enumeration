using Enumeration.UnitTests.Utils;

namespace Enumeration.UnitTests;

public class EnumerationTests
{
    [Fact]
    public void FromValue_ReturnsCorrectEnumeration()
    {
        var status = Status.FromValue(1);
        Assert.NotNull(status);
        Assert.Equal(Status.Active, status);
    }

    [Fact]
    public void FromValue_ReturnsNullForInvalidValue()
    {
        var status = Status.FromValue(3);
        Assert.Null(status);
    }

    [Fact]
    public void FromName_ReturnsCorrectEnumeration()
    {
        var status = Status.FromName("Active");
        Assert.NotNull(status);
        Assert.Equal(Status.Active, status);
    }

    [Fact]
    public void FromName_ReturnsNullForInvalidName()
    {
        var status = Status.FromName("NonExistent");
        Assert.Null(status);
    }

    [Fact]
    public void Enumeration_Equals_ReturnsTrueForSameInstance()
    {
        var status = Status.Active;
        Assert.True(status.Equals(Status.Active));
    }

    [Fact]
    public void Enumeration_Equals_ReturnsFalseForDifferentInstances()
    {
        var activeStatus = Status.Active;
        var inactiveStatus = Status.Inactive;
        Assert.False(activeStatus.Equals(inactiveStatus));
    }

    [Fact]
    public void Enumeration_GetHashCode_ReturnsValueHashCode()
    {
        var activeStatus = Status.Active;
        Assert.Equal(activeStatus.Value.GetHashCode(), activeStatus.GetHashCode());
    }

    [Fact]
    public void Enumeration_ToString_ReturnsName()
    {
        var activeStatus = Status.Active;
        Assert.Equal("Active", activeStatus.ToString());
    }
}