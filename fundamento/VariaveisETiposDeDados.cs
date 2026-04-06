 namespace Fundamentos;

public class VariaveisETiposDeDados
{
    
    string sobreNome = "Mutiz";
    
     public void Executar()
    {
        
        Console.WriteLine("📦 VARIÁVEIS E TIPOS DE DADOS");
        Console.WriteLine("Variáveis são espaços na memória para guardar informações.");
        Console.WriteLine();

        int Idade = 25;
        double altura = 1.75;
        float media = 1950;
        char letra = 'A';
        string nome = "Tony";
        string nomecomposto = nome + " filho"; //concatenação
        bool estudante = true;


        Console.WriteLine($" int -> Idade: {Idade} (números inteiros)");
        Console.WriteLine($"double -> altura: {altura} (números decimais)");
        Console.WriteLine($"media -> letra : {letra} (um único caracter)");
        Console.WriteLine($"string -> nomecomposto : {nomecomposto} (um texto)");
        Console.WriteLine($"variavel global -> sobreNome : {this.sobreNome} (Variavel Global)");
        Console.WriteLine($"bool -> estudante : {estudante} (booleano ou seja Verdadeira ou Falsa)");


    }

    

}//fim class 