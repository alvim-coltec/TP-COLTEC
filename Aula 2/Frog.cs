using System;
using System.ComponentModel.Design;
using System.Threading;

namespace frog
{
	public class Frog{
		private Thread process;
		string nome;
		int disTotal, disPercorrida = 0, disPulo = 0, numPulos = 0;
		static int posicao;
		const int MAX_JUMP = 50;

		public Frog(string nome, int disTotal){
			base.nome;
			this.nome = nome;
			this.disTotal = disTotal;
			this.process = new Thread(PulaPulaPepequinha);
		}

		public void PulaPulaPepequinha(){
			do{
				Thread.Sleep(500);
				numPulos++;
				disPulo = (int)(new Random().Next() * MAX_JUMP);
				disPercorrida += disPulo;
				if (disTotal < disPercorrida)
					disPercorrida = disTotal;	
				if (disPercorrida == MAX_JUMP)
					aMimir();
			}while(disTotal < disPercorrida);
			imprimeSapoStatus();
		}

		public void imprimeSapoStatus(){
			Console.WriteLine(nome + "pulou " + disPulos + "cm \t e percorreu " + disPercorrida + "cm");
		}

		public void aMimir(){
			Thread.Sleep(1050);
		}

		public void Classificacao(){
			++posicao;
			Console.WriteLine(nome + " foi o " + posicao + "o colocado com " + numPulos + " pulos");
		}

	}
}