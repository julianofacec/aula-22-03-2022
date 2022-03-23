using Aula._22._03._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula._22._03._2022.Classes
{
    public class Televisao : IEletroDomestico
    {
        public void Desligar()
        {
            Console.Write($"{nameof(Televisao)} Desligou! \n");
        }

        public void Ligar()
        {
            Console.Write($"{nameof(Televisao)} Ligou!\n");
        }
    }
}