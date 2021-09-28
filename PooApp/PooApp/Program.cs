using System;

namespace PooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string showResults;
            Console.WriteLine("Hello World!");

            //Caneta caneta1 = new Caneta();
            //caneta1.showCaneta();
            //showResults = caneta1.returnShowCaneta();
            //Console.WriteLine(showResults);
            //Console.ReadLine();
            //Caneta caneta2 = new Caneta(false, "azul", "Fiorino", "Esferográfica", 75.0);
            //caneta2.showCaneta();
            //showResults = caneta2.returnShowCaneta();
            //Console.WriteLine(showResults);
            //Console.ReadLine();
            //Caneta caneta3 = new Caneta();
            //caneta3.setCor("preta");
            //caneta3.setMarca("Bic");
            //caneta3.setModelo("Fountain");
            //caneta3.showCaneta();
            //showResults = caneta3.returnShowCaneta();
            //Console.WriteLine(showResults);
            //Console.ReadLine();

            CanetaHerda caneta1 = new CanetaHerda();
            caneta1.showCaneta();
            showResults = caneta1.returnShowCaneta();
            Console.WriteLine(showResults);
            Console.ReadLine();
            CanetaHerda caneta2 = new CanetaHerda(false, "azul", "Fiorino", "Esferográfica", 75.0); ;
            caneta2.showCaneta();
            showResults = caneta2.returnShowCaneta();
            Console.WriteLine(showResults);
            Console.ReadLine();
            CanetaHerda caneta3 = new CanetaHerda();
            caneta3.setCor("preta");
            caneta3.setMarca("Bic");
            caneta3.setModelo("Fountain");
            caneta3.showCaneta();
            showResults = caneta3.returnShowCaneta();
            Console.WriteLine(showResults);
            Console.ReadLine();
        }
    }
}
