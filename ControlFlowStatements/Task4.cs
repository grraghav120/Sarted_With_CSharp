namespace ConsoleApp1.ControlFlowStatements
{
    public class Task4
    {
        public void task4()
        {
            int speedLimit=Convert.ToInt32(Console.ReadLine());
            int speedCar=Convert.ToInt32(Console.ReadLine());
            if (speedCar < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                int differnce = (int)(speedCar - speedLimit);
                int demeritPoints = (int)(differnce / 5);
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended"); 
                }
                else
                {
                    Console.WriteLine(demeritPoints);
                }
            }
        }
    }
}
