namespace JogoPrimeiroDesafio.Personagem
{
    public abstract class Heroi
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }

        public virtual int Atacar(Heroi inimigo)
        {
            
            return 0;
        }

        public virtual int AtaqueEspecial(Heroi alvo)
        {
           
            return 0;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome}, Vida: {Vida}, Ataque: {Ataque}, Defesa: {Defesa}");
        }
    }
}
