using System;
using System.Collections.Generic;
using System.Text;

namespace PooApp
{
    class CanetaHerda : Caneta
    {
        public CanetaHerda() { setTampada(true); setCarga(100.0); }

        public CanetaHerda(bool pTampada, string pCor, string pMarca, string pModelo, double pCarga)
        {
            setTampada(pTampada);
            setCor(pCor);
            setMarca(pMarca);
            setModelo(pModelo);
            setCarga(pCarga);
        }

        public override void showCaneta()
        {
            string strTampada = "";
            if (getTampada() == true) { strTampada = "Sim"; }
            else if (this.getTampada() == false) { strTampada = "Não"; }
            Console.WriteLine("CanetaHerdada void = tampada: {0}, cor: {1}, marca: {2}, modelo: {3}, carga: {4}", strTampada, getCor(), getMarca(), getModelo(), Convert.ToString(getCarga()));
            Console.ReadLine();
        }

        public override string returnShowCaneta()
        {
            string strTampada = "";
            if (getTampada() == true) { strTampada = "Sim"; }
            else if (getTampada() == false) { strTampada = "Não"; }
            return "CanetaHerdada string = tampada: " + strTampada + ", cor: " + getCor() + ", marca: " + getMarca() + ", modelo: " + getModelo() + ", carga: " + Convert.ToString(getCarga());
        }
    }
}