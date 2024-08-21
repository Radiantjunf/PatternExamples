namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDeclaration dmr = new Dmr();
            IDeclaration iva = new Iva();


            DeclarationService context = new DeclarationService(dmr);
            context.Validate();

            context.SetDeclaration(iva);
            context.Validate();
        }
    }
}
