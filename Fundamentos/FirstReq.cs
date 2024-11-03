namespace Fundamentos;
class FirstReq
{
    public void Exec()
    {
        Console.WriteLine("Digite o seu nome: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Olá {name}! Seja muito bem-vindo!");
    }
}