namespace CompoundInterestCalculator
{
    class program
    {
       static void Main(string[] args)
        {
            double p = 1000; // Initial Investment
            double r = 0.09; // Interest Rate
            double t = 10; // Duration of the Investment in Years
            double n = 1; // Compound Frequency
            





            Console.WriteLine("Input The Following Values");
            Console.WriteLine("Intial Investment: ");
            p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Interest Rate: ");
            r = Convert.ToDouble(Console.ReadLine()) /100 ;
            Console.WriteLine("Length of Time in Years: ");
            t = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("1. Annually");
            Console.WriteLine("2. Semiannually");
            Console.WriteLine("3. Quarterly");
            Console.WriteLine("4. Monthly");
            Console.WriteLine("5. Daily");
            Console.WriteLine("Compound Frequency: ");
            var option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    n = 1;
                    break;
                case 2:
                    n = 2;
                    break;
                case 3:
                    n = 4;
                    break;
                case 4:
                    n = 12;
                    break;
                case 5:
                    n = 365;
                    break;
                default:
                    break;
            }

            
            
           ComputeYearlyGrowth(p,r,t,n);
           Console.ReadLine();

            
            
           

        }

        private static void ComputeYearlyGrowth(double p, double r, double t, double n)
        {
            for(int i = 0; i < t+1; i++)
            {
                var growth = ComputeInterest(p, r, i, n);
                Console.WriteLine($"Year {i} growth is {growth:N2}");
            }
        }

        private static double ComputeInterest(double p, double r, double t, double n)
        {
            return  p * Math.Pow(1+r/n, n*t);
        }
    }
}






// a = p (1 + r/n)^nt


/*
daily = 365
monthly = 12
quarterly = 4
semiannually = 2
annually = 1 
*/