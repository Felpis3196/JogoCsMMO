using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MMOCS
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int QI { get; set; }
        public int Agilidade { get; set; }
        public int Vida { get; set; }
        public string Raca { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int ID { get; set; }
        public void apresentar()
        {
            Console.WriteLine($"Me chamo {Nome} sou um(a) {Raca}");
            Console.WriteLine($"Tenho estes atributos \n Vida: {Vida} \n Força: {Forca} \n Defesa : {Defesa}  \n Agilidade: {Agilidade} \n Nivel: {Nivel} " +
                $"Com um overral de {(Vida + Forca + Defesa + Agilidade) / 4}"
                );
        }
        public virtual void atacar(Personagem inimigo)
        {
            int dano = Math.Max(0, Forca - inimigo.Defesa);
            inimigo.Vida -= dano;
            Console.WriteLine($"{Nome} ataca {inimigo.Nome} e causa {dano} de dano.");
        }
        public void regenerarVida()
        {
            int quantidadeRegenerada = QI / 2;
            Vida = Math.Min(100, Vida + quantidadeRegenerada);
            Console.WriteLine($"{Nome} regenera {quantidadeRegenerada} de vida.");
        }
        public void subirNivel()
        {
            Nivel++;
            QI += 10;
            Forca += 5;
            Defesa += 4;
            Console.WriteLine($"{Nome} subiu para o nível {Nivel}!");
        }
    }
}
