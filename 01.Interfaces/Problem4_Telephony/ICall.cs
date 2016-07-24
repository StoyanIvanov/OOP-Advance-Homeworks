namespace Problem4_Telephony
{
    public interface ICall
    {
        string Call { get; }
        string AddCall(string phoneNumber);
    }
}