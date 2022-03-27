using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio1
{
    class DadosCliente
    {

        public string Nome;
        public int Idade;
        public double IMC;
        public double Altura; 
        public double Peso;

        //Metodo
        public void Situação()
        {
            if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine("Calculando sua situação");
                Console.WriteLine("...");
                Console.WriteLine("Sua situação é: Parabens você está no peso ideal");
            }
            else if (IMC >= 25.0 && IMC <= 29.9 )
            {
                Console.WriteLine("Calculando sua situação");
                Console.WriteLine("...");
                Console.WriteLine("Sua situação é: Você está acima de seu peso (sobrepeso).");
                Console.WriteLine("...");
            }
            else if(IMC >= 30.0 && IMC <= 34.9)
            {
                Console.WriteLine("Calculando sua situação");
                Console.WriteLine("...");
                Console.WriteLine("Sua situação é: Obesidade grau I.");
                Console.WriteLine("...");
            }
            else if (IMC >= 35.0 && IMC <= 39.9)
            {
                Console.WriteLine("Calculando sua situação");
                Console.WriteLine("...");
                Console.WriteLine("Suasituação é: Obesidade grau II.");
                Console.WriteLine("...");
            }
            else if (IMC >= 40.0)
            {
                Console.WriteLine("Calculando sua situação");
                Console.WriteLine("...");
                Console.WriteLine("Sua situação é: Obesidade graus III e IV.");
                Console.WriteLine("...");
            }
        }


       public void CalculoIMC()
        {
            double Alt = Math.Pow(Altura, 2);
            double IMC1 = Peso / Alt;           
            double IMC2 = Math.Round(IMC1);
            Console.WriteLine($"Seu IMC é: {IMC2}");
            IMC = IMC2;

        }

        public void Meta()
        {
            if (IMC > 24.9)
            {
                double IMCMeta = IMC - 24.9d;
                double Altura2 = Math.Pow(Altura, 2);
                double META = IMCMeta * Altura2;
                double META2 = Math.Round(META);
                Console.WriteLine($"Para vc estar no peso ideal é necessario perder: {META2} Quilos.");
            }
            else
            {
                Console.WriteLine("Continue assim. ^-^ ");
            }
        }
    }

    

}

