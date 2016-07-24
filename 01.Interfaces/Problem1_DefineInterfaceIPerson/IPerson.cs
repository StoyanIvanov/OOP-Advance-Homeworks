using System.Security.Cryptography.X509Certificates;

namespace Problem1_DefineInterfaceIPerson
{
    public interface IPerson
    {
        string Name { get; }
        int Age { get; }
    }
}