using System.Text.RegularExpressions;

namespace Fundamentos
{
    class FifthReq
    {
        public void Exec()
        {
            Console.WriteLine("Insira a Placa:");
            string plate = Console.ReadLine();
            if (plate.Length != 7)
            {
                Console.WriteLine("Placa Invalida, O Tamanho esperado é 7");
                return;
            }

            for (int i = 0; i < plate.Length; i += 1) {
                if (i < 3 && !char.IsLetter(plate[i]))
                {
                    Console.WriteLine($"Placa Invalida, {plate[i]} must be a character type string");
                    break;
                } else if (i > 2 && !char.IsDigit(plate[i]))
                {
                    Console.WriteLine($"Placa Invalida, {plate[i]} must be a number");
                    break;
                }
            }

            Console.WriteLine("Placa Válida");
        }
    }
}
