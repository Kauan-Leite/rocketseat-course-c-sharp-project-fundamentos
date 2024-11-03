namespace Fundamentos
{
    class SixtyReq
    {
        public void Exec()
        {
            var date = DateTime.UtcNow;

            Console.WriteLine(date.ToString("dddd, dd/MM/yyyy, HH:mm:s"));
            Console.WriteLine(date.ToString("d"));
            Console.WriteLine(date.ToString("HH:mm:s"));
            Console.WriteLine(date.ToString("dd MMMM yyyy"));

        }
    }
}
