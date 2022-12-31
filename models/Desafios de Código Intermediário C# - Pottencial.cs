/*Dado um array nums de tamanho n, retorne o elemento majoritário, 
isto é, o elemento que aparece o maior número de vezes no seu array.*/

using System;
using System.Text.RegularExpressions;

public class Program1
{
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        for ( int i = 0; i < num.Length; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(MajorityElement(num));
        
    }
    public static int MajorityElement(int[] nums)
    {
        int major = nums[0];
        int count = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if ( major != nums[i])
            {
                major = nums[i];
                count = 0;
            }
            else
            {
                if (major == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}


/*Desafio
A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

Salário	Percentual de Reajuste
0 - 400.00		15%
400.01 - 800.00	12%
800.01 - 1200.00	10%
1200.01 - 2000.00	7%
Acima de 2000.00	4%
*/

//using System; 

class minhaClasse {
  static void Main(string[] args) { 
    double salario = 0.00;
    double reajuste = 0.00;
    double novoSalario = 0.00;
    double percentual = 0.00;

    salario = Convert.ToDouble(Console.ReadLine());
      
    if(salario < 0.00) {
      return;
    } else if (salario <= 400.00) {
      percentual = 0.15;
      reajuste = salario * percentual;
      novoSalario = salario + reajuste;
    } else if (salario <= 800.00) {
      percentual = 0.12;
      reajuste = salario * percentual;
      novoSalario = salario + reajuste;
    } else if (salario <= 1200.00) {
      percentual = 0.10;
      reajuste = salario * percentual;
      novoSalario = salario + reajuste;
    } else if (salario <= 2000.00) {
      percentual = 0.07;
      reajuste = salario * percentual;
      novoSalario = salario + reajuste;
    } else {
      percentual = 0.04;
      reajuste = salario * percentual;
      novoSalario = salario + reajuste;
    }
      
    Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
    Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
    Console.WriteLine("Em percentual: {0} %", percentual * 100.00);
  }
}

/*Desafio
A corrida de tartarugas é um esporte que cresceu muito nos últimos anos, fazendo com que vários competidores se dediquem a capturar tartarugas rápidas, e treina-las para faturar milhões em corridas pelo mundo. Porém a tarefa de capturar tartarugas não é uma tarefa muito fácil, pois quase todos esses répteis são bem lentos. Cada tartaruga é classificada em um nível dependendo de sua velocidade:


Nível 1: Se a velocidade é menor que 10 cm/h .
Nível 2: Se a velocidade é maior ou igual a 10 cm/h e menor que 20 cm/h .
Nível 3: Se a velocidade é maior ou igual a 20 cm/h .

Sua tarefa é identificar qual o nível de velocidade da tartaruga mais veloz de um grupo.*/

//using System;

class Desafio {
  public static void Main() {
    int quantidadeEntradas = 3;
      
    while (quantidadeEntradas > 0) {
      var numeroQuantidade = Int32.Parse(Console.ReadLine());
        
      if (numeroQuantidade >= 1 && numeroQuantidade <= 500) {
        string[] tartarugas = Console.ReadLine().Split(" ");
        var maiorVelocidade = Int32.Parse(tartarugas[0]);
          
        for (int i = 1; i < numeroQuantidade; i++) {
          var tartaruga = Int32.Parse(tartarugas[i]);
            
          if ( tartaruga > maiorVelocidade) {
            maiorVelocidade = tartaruga;
          }
        }

        if(maiorVelocidade < 10) {
          Console.WriteLine(1);
        } else if (maiorVelocidade >= 10 && maiorVelocidade < 20) {
          Console.WriteLine(2);
        } else if (maiorVelocidade >= 20) {
          Console.WriteLine(3);
        }
        quantidadeEntradas--;
      } else {
        Console.WriteLine("Insira um número entre 1 e 500");
      }
    }
  }
}