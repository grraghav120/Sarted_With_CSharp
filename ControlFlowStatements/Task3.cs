

namespace ConsoleApp1.ControlFlowStatements
{
    public class Task3
    {
        public void task3()
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            if (height > width)
            {
                Console.WriteLine("Potrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }
        }
    }
}
