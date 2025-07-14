using JogoPrimeiroDesafio.Personagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPrimeiroDesafio
{
    public interface IAtacavel
    {

         virtual int Atacar(Heroi)
        {
            int dano = Ataque - oponente.Defesa;
            if (dano < 0) dano = 0; 
            oponente.vida -= dano;

            return dano;


        }
    }
}
