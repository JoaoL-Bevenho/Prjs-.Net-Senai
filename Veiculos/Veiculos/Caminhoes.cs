using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculos
{
    class Caminhoes : Veiculos
    {
        public Caminhoes() { }

        public Caminhoes(string pCor, string pMarca, string pModelo, string pMotor, double pComubstivel, string pCombustivelTipo, double pVelocidade, double pPedagio)
        {
            setCor(pCor);
            setMarca(pMarca);
            setModelo(pModelo);
            setMotor(pMotor);
            setCombustivel(pComubstivel);
            setCombustivelTipo(pCombustivelTipo);
            setVelocidade(pVelocidade);
            setPedagio(pPedagio);
        }

        public override string ligarVeiculo() { return " O caminhão " + getModelo() + " foi ligado."; }
        public override string desligarVeiculo() { return "O caminhão " + getModelo() + " foi desligado"; }
        public override string acelerar() { return "O caminhão " + getModelo() + " foi acelerado à velocidade de " + getVelocidade(); }
        public override string abastecer() { return "O caminhão " + getModelo() + " abasteceu " + getCombustivel() + "L do tipo " + getCombustivelTipo(); }
        public override string pagarPedagio() { return "O caminhão " + getModelo() + " pagou um pedagio na quantia de: " + getPedagio(); }
    }
}
