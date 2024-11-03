namespace Fundamentos
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Bem vindo ao Projeto de Fundamentos em C# :D");

            Console.WriteLine("----- Requisito 1 -----");
            new FirstReq().Exec();

            Console.WriteLine("----- Requisito 2 -----");
            new SecondReq().Exec();

            Console.WriteLine("----- Requisito 3 -----");
            new ThirdReq().Exec();

            Console.WriteLine("----- Requisito 4 -----");
            new FourthReq().Exec();

            Console.WriteLine("----- Requisito 5 -----");
            new FifthReq().Exec();

            Console.WriteLine("----- Requisito 6 -----");
            new SixtyReq().Exec();
        }
    }
}
