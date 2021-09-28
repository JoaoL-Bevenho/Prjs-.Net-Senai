using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string strMsg;
            Carros carro1 = new Carros("azul", "Renault", "Offroad Duster", "148 cv", 48.5, "Flex", 100.0, 12.5);
            strMsg = carro1.ligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro1.desligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro1.acelerar();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro1.abastecer();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro1.pagarPedagio();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            Carros carro2 = new Carros("preto", "Chevrolet", "Sedan Astra", "8v",  60.4, "Gasolina", 80.0, 15.0);
            strMsg = carro2.ligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro2.desligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro2.acelerar();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro2.abastecer();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = carro2.pagarPedagio();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            Caminhoes caminhao1 = new Caminhoes("cinza", "Peugot", "Caminhão", "V8", 120.6, "Diesel", 120.5, 20.0);
            strMsg = caminhao1.ligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = caminhao1.desligarVeiculo();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = caminhao1.acelerar();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = caminhao1.abastecer();
            Console.WriteLine(strMsg);
            Console.ReadLine();
            strMsg = caminhao1.pagarPedagio();
            Console.WriteLine(strMsg);
            Console.ReadLine();

        }
    }
}
