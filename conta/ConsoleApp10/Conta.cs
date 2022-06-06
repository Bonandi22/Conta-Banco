using System;

namespace ConsoleApp10
{
    internal class Conta
    {

        private double Saldo { get;  set; }
        public double Limite { get; set; }
        public double Deposito { get; set; }


        public void Deposita(Double Valor)
        {
            this.Saldo += Valor;
        }

        public void AdicionarLimite(Double Valor)
        {
            this.Limite = Valor;
        }

        public double ConsultaSaldo()
        {
            return this.Saldo + this.Limite;
        }








    }
}
