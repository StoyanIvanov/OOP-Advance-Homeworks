using System.Security.Cryptography.X509Certificates;

namespace Problem3_Ferrari
{
    public interface ICar
    {
        string Model { get; }
        string Driver { get; }
        string Break();
        string PushGas();
    }
}