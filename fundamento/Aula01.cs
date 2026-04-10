using Fundamentos01;

namespace Fundamentos;

public class Aula01
{
    
  public void ExecutarAula01() 
    {
        
     //inicio
     this.ExibirCabecalho();
     VariaveisETiposDeDados VariaveisETiposDeDados = new VariaveisETiposDeDados();
     VariaveisETiposDeDados.Executar();

     Console.WriteLine();
     //Operadores Aritméticos
     OperadoresAritmeticos operadoresAritmeticos = new OperadoresAritmeticos();
     operadoresAritmeticos.Executar();

    Console.WriteLine();
//Operadores de Comparação
     OperadoresComparacao operadoresComparacao = new OperadoresComparacao();
     operadoresComparacao.Executar();

     Console.WriteLine();
     //Operadores Lógicos
     OperadoresLogicos operadoresLogicos = new OperadoresLogicos();
     operadoresLogicos.Executar();





     //fim

     this.ResumoAula();

    }
 

   








private void ExibirCabecalho()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("   AULA 01 - FUNDAMENTOS DE ALGORITMIA");
        Console.WriteLine("======================================");
        Console.WriteLine();
    }
 
    private void ResumoAula()
    {
        Console.WriteLine();
        Console.WriteLine("======================================");
        Console.WriteLine("   FIM DA AULA - RESUMO");
        Console.WriteLine("======================================");
        Console.WriteLine("✓ O que é algoritmia");
        Console.WriteLine("✓ Variáveis e tipos de dados");
        Console.WriteLine("✓ Operadores aritméticos, comparação e lógicos");
        Console.WriteLine("✓ Estruturas de controle básicas");
    }

}//fim da aula01