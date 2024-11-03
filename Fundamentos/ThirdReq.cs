namespace Fundamentos
{
    class ThirdReq
    {
        public void Exec() {
            Console.WriteLine("Digite o Primeiro Número:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Número:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Soma: {number1 + number2}");
            Console.WriteLine($"Subtração: {number1 - number2}");
            Console.WriteLine($"Multiplicação: {number1 * number2}");

            if (number2 == 0)
            {
                Console.WriteLine($"Divisão: Impossivel Dividir por 0");
            }
            else
            {
                Console.WriteLine($"Divisão: {number1 / number2}");
            }
            Console.WriteLine($"Media: {(number1 + number2) / 2}");

        }
    }
}
