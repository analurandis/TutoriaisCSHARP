using System;
using System.Collections.Generic; 

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Calcular a Média");
    Console.Write("Quantos participantes: ");
    int qtde = Convert.ToInt32(Console.ReadLine());
    CalcularIdadeMedia(qtde);
  }

  public static void CalcularIdadeMedia(int qtde){
    List<int> idades = new List<int>();
    for(int i =0; i < qtde ; i++){
      Console.WriteLine("Digite a Idade: ");
      idades.Add(Convert.ToInt32(Console.ReadLine()));

    }
    Console.WriteLine($"Idade média {CalcularMedia(idades).ToString()}");
   /* Console.WriteLine("Digite a Idade: ");
    int idade1 = Convert.ToInt32(Console.ReadLine());
    int idade2 = Convert.ToInt32(Console.ReadLine());
    int idade3 = Convert.ToInt32(Console.ReadLine());
    double media = (idade1 + idade2 + idade3) /3;
    Console.WriteLine($"Idade média {idade1.ToString()}");
    */
  }
  public static double CalcularMedia (List<int> idades) {
    int soma = 0;
    foreach(var i in idades){
      soma += i;
    }
    return soma / idades.Count;
  }
}