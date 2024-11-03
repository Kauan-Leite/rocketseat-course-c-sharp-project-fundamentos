namespace Fundamentos
{
    class SecondReq
    {
        public void Exec()
        {
            string firstName = "";
            string lastName = "";
            string fullName = "";


            Console.WriteLine("Digite seu Primeiro Nome:");
            firstName = Console.ReadLine();

            Console.WriteLine("Digite seu Sobrenome:");
            lastName = Console.ReadLine();

            fullName = $"{firstName} {lastName}";
            Console.WriteLine($"Nome Completo: {fullName}");
        }
    }
}
