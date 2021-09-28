using System;
using System.Collections.Generic;
using System.Text;

namespace PooApp
{
    class Caneta : InterfacePrincipal
    {
        private bool tampada;
        private string cor;
        private string marca;
        private string modelo;
        private double carga;


        public Caneta() { this.tampada = true; this.carga = 100.0; }

        public Caneta(bool pTampada, string pCor, string pMarca, string pModelo, double pCarga)
        {
            this.tampada = pTampada;
            this.cor = pCor;
            this.marca = pMarca;
            this.modelo = pModelo;
            this.carga = pCarga;
        }

        public bool getTampada() { return this.tampada; }
        public void setTampada(bool pTampada) { this.tampada = pTampada; }

        public string getCor() { return this.cor; }
        public void setCor(string pCor) { this.cor = pCor; }

        public string getMarca() { return this.marca; }
        public void setMarca(string pMarca) { this.marca = pMarca; }

        public string getModelo() { return this.modelo; }
        public void setModelo(string pModelo) { this.modelo = pModelo; }

        public double getCarga() { return this.carga; }
        public void setCarga(double pCarga) { this.carga = pCarga; }

        public virtual void showCaneta()
        {
            string strTampada = "";
            if (tampada == true) { strTampada = "Sim"; }
            else if (tampada == false) { strTampada = "Não"; }
            Console.WriteLine("Caneta = tampada: {0}, cor: {1}, marca: {2}, modelo: {3}, carga: {4}", strTampada, cor, marca, modelo, Convert.ToString(carga));
            Console.ReadLine();
        }

        public virtual string returnShowCaneta()
        {
            string strTampada = "";
            if (tampada == true) { strTampada = "Sim"; }
            else if (tampada == false) { strTampada = "Não"; }
            return "Caneta = tampada: "+ strTampada + ", cor: "+ cor + ", marca: "+ marca + ", modelo: "+ modelo + ", carga: " + Convert.ToString(carga);
        }
    }
}
