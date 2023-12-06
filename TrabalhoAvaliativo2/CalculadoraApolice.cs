using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAvaliativo2
{
    internal class CalculadoraApolice
    {
        private Boolean roubo;
        private Boolean granizo;
        private Boolean acidentes;
        private Boolean terceiros;
        private Boolean franquiaReduzida;
        private int experiencia;
        private double valorPremio;
        private double valorApolice;
        private double valorCarro;
        private double valorFranquia;

        public CalculadoraApolice()
        {
        }
        public CalculadoraApolice(double valorCarro)
        {
            this.valorCarro = valorCarro;
        }


        public void calculaApolice()
        {
            valorApolice = valorCarro * 1.1;
        }
        public void calculaPremio() 
        {

            valorPremio = valorApolice * 0.015;
            valorPremio = roubo ? valorPremio * 1.12 : valorPremio;
            valorPremio = granizo ? valorPremio * 1.01 : valorPremio;
            valorPremio = acidentes ? valorPremio * 1.04 : valorPremio;
            valorPremio = terceiros ? valorPremio * 1.05 : valorPremio;
            valorPremio = franquiaReduzida ? valorPremio * 1.03 : valorPremio;

            if (experiencia > 2 && experiencia <= 5)
            {
                valorPremio = valorPremio * 0.97;
            }
            else if (experiencia > 5 && experiencia <= 10)
            {
                valorPremio = valorPremio * 0.95;
            }
            else if (experiencia > 10 && experiencia <= 20)
            {
                valorPremio = valorPremio * 0.94;
            } else
            {
                valorPremio = valorPremio * 0.9;
            }

        }
        public void calculaFranquia()
        {
            valorFranquia = valorCarro * 0.06;
            if (franquiaReduzida)
            {
                valorFranquia = valorFranquia / 2;
            }
                
        }

        public void calculaTudo()
        {
            try
            {
                calculaApolice();
                calculaPremio();
                calculaFranquia();
            } catch (Exception ex)
            {
                Console.WriteLine("Valor do carro nao inicializado");
            }
        }
    }
}

