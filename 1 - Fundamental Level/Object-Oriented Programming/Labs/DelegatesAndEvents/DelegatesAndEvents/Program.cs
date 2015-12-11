namespace DelegatesAndEvents
{
    public class Program
    {
        public Program(string name, int age)
        {
            Name = name;
            Age = age;
        }


        public string Name { get; set; }
        public int Age { get; set; }

        public static void Main(string[] args)
        {
            var program = new Program("Tosho", 7);
        }
    }
}