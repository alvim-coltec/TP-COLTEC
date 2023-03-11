using System;
using System.Threading;
public class Frog{
		public Thread process;
		string nome;
		public int disTotal, disPercorrida = 0, disPulo = 0, numPulos = 0;
		static int posicao;
		const int MAX_JUMP = 50;

		public Frog(string nome, int disTotal){
			this.nome = nome;
			this.disTotal = disTotal;
			this.process = new Thread(PulaPulaPepequinha);
		}

		public void PulaPulaPepequinha(){
			do{
				Thread.Sleep(500);
				numPulos++;
				disPulo = (new Random().Next() % MAX_JUMP);
				disPercorrida += disPulo;	
				aMimir();
			}while(disTotal >= disPercorrida);
			imprimeSapoStatus();
		}

		public void imprimeSapoStatus(){
			Console.WriteLine(nome + " pulou " + numPulos + "x \t e percorreu " + disPercorrida + "cm");
		}

		public void aMimir(){
			Thread.Sleep(1050);
		}

		public void Classificacao(){
			++posicao;
			Console.WriteLine(nome + " foi o " + posicao + "o colocado com " + numPulos + " pulos");
		}

	}

    public class Program {
        public static void Main(string[] args)
        {

            const int TT_DIST = 100;

            Frog Maluco = new Frog("Crazy Frog", TT_DIST);
            Frog Kermit = new Frog("Kermit", TT_DIST);

			Maluco.process.Start();
			Kermit.process.Start();

			Maluco.process.Join();
			Kermit.process.Join();

		if (Maluco.numPulos < Kermit.numPulos)
			Console.WriteLine("Kermit ganhou.");
		else if (Maluco.numPulos > Kermit.numPulos)
			Console.WriteLine("Maluco ganhou");
		else
			Console.WriteLine("Empate.");

			Console.ReadLine();
        }
    }