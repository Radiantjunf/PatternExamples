namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeclarationService service = new DeclarationService();
            service.Validate("dmr");
            service.Validate("iva");
        }
    }
}
