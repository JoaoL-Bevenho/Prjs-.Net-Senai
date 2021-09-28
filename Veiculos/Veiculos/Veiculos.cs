using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    class Veiculos : InterfaceVeiculos
    {
        private string cor;
        private string marca;
        private string modelo;
        private string motor;
        private double combustivel;
        private string combustiveltipo;
        private double velocidade;
        private double pedagio;

        public Veiculos() { }

        public Veiculos(string pCor, string pMarca, string pModelo, string pMotor, double pComubstivel, string pCombustivelTipo, double pVelocidade, double pPedagio)
        {
            this.cor = pCor;
            this.marca = pMarca;
            this.modelo = pModelo;
            this.motor = pMotor;
            this.combustivel = pComubstivel;
            this.combustiveltipo = pCombustivelTipo;
            this.velocidade = pVelocidade;
            this.pedagio = pPedagio;
        }

        public string getCor() { return cor; }
        public void setCor(string pCor) { this.cor = pCor; }

        public string getMarca() { return marca; }
        public void setMarca(string pMarca) { this.marca = pMarca; }

        public string getModelo() { return modelo; }
        public void setModelo(string pModelo) { this.modelo = pModelo; }

        public string getMotor() { return motor; }
        public void setMotor(string pMotor) { this.cor = pMotor; }

        public double getCombustivel() { return combustivel; }
        public void setCombustivel(double pCombustivel) { this.combustivel = pCombustivel; }

        public string getCombustivelTipo() { return combustiveltipo; }
        public void setCombustivelTipo(string pCombustivelTipo) { this.combustiveltipo = pCombustivelTipo; }

        public double getVelocidade() { return velocidade; }
        public void setVelocidade(double pVelocidade) { this.velocidade = pVelocidade; }

        public double getPedagio() { return pedagio; }
        public void setPedagio(double pPedagio) { this.pedagio = pPedagio; }

        public virtual string ligarVeiculo() { return ""; }
        public virtual string desligarVeiculo() { return ""; }
        public virtual string acelerar() { return ""; }
        public virtual string abastecer() { return ""; }
        public virtual string pagarPedagio() { return ""; }
    }
}
