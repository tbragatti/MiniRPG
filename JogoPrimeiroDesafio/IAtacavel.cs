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

        int Atacar(Heroi alvo);

        int AtaqueEspecial(Heroi alvo); 

    }
}

