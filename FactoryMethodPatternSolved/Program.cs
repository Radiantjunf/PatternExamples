namespace FactoryMethodPatternSolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeclarationFactory dmrFactory = new DmrFactory();
            DeclarationService dmrService = new DeclarationService(dmrFactory);
            dmrService.StartValidation();

            DeclarationFactory ivaFactory = new IvaFactory();
            DeclarationService ivaService = new DeclarationService(ivaFactory);
            ivaService.StartValidation();
        }
    }
}
