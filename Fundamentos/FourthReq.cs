namespace Fundamentos
{
    class FourthReq
    {
        public void Exec()
        {
            Console.WriteLine("Digite sua Mensagem");
            string text = Console.ReadLine();
            Console.WriteLine($"A Mensagem possui {text.Length} Caracteres");
        }
    }
}
