using System;
using System.Collections.Generic; 

class Media {
  public static void Main (string[] args) {
    Console.WriteLine ("Calcular a Média");
    Console.Write("Quantos participantes: ");
    int qtde = Convert.ToInt32(Console.ReadLine());
    CalcularIdadeMedia(qtde);
  }

  public static void CalcularIdadeMedia(int qtde){
    List<int> idades = new List<int>();
    for(int i =0; i < qtde ; i++){
      try{
        Console.WriteLine("Digite a idade: ");
        idades.Add(Convert.ToInt32(Console.ReadLine()));
      }catch{
        Console.WriteLine("Digite uma idade válida: ");
        idades.Add(Convert.ToInt32(Console.ReadLine()));
      }
     

    }
    var media = String.Format("{0:0.00}",CalcularMedia(idades));
    Console.WriteLine($"Idade média {media}");
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
    return (double)soma / (double)idades.Count;;
  }
}