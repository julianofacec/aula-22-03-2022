using Aula._22._03._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula._22._03._2022.Classes
{
    public class Abajur : IIluminacao
    {
        public void Desligar()
        {
            Console.Write($"{nameof(Abajur)} Desligou! \n");
        }

        public void Ligar()
        {
            Console.Write($"{nameof(Abajur)} Ligou!\n");
        }

        public void ObterPotenciaLampada()
        {
            Console.Write($"{nameof(Abajur)} " +
                $"possui lâmpada de 100w de potencia!\n");
        }
    }
}