namespace ConstrantsForGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car<RollsRoyce> rollsRoyce = new Car<RollsRoyce>(); // genericnya harus dimasukkin class, di class Car ada kondisi where
            Car<string> bmw = new Car<string>(); // ini harusnya gabisa, soalnya genericnya diisi string, bukan class
        }
    }

    class RollsRoyce
    {
        public int HorsePower { get; set; }
        public int Model { get; set; }
    }
}
