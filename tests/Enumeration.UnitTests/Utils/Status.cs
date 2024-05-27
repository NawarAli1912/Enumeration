namespace Enumeration.UnitTests.Utils;
public sealed class Status : Enumeration<Status>
{
    public static readonly Status Active = new Status(1, "Active");
    public static readonly Status Inactive = new Status(2, "Inactive");

    private Status(int value, string name) : base(value, name) { }
}
