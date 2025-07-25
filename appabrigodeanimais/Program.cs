using System.Collections.Generic;

public class Animais
{
    public int IDdoanimal;
    public string? especie;
    public int Idade;
    public string? descricao;
    public string? personalidade;
    public string? apelido;

    // Lista para guardar os animais
    public static List<Animais> listaDeAnimais = new List<Animais>();

    public Animais(int ID, string esp, int idade, string desc, string perso, string apeli)
    {
        IDdoanimal = ID;
        Idade = idade;
        descricao = desc;
        personalidade = perso;
        apelido = apeli;
    }
    public void Guarda()
    {
        listaDeAnimais.Add(this);

    }
    public static void MostrarAnimais()
     {
    foreach (Animais a in listaDeAnimais)
    {
        Console.WriteLine($"ID: {a.IDdoanimal}, Espécie: {a.especie}, Idade: {a.Idade}, Apelido: {a.apelido}");
    }
     }



}

public class Programa
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Digite o ID do animal:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a espécie:");
            string? especie = Console.ReadLine();

            Console.WriteLine("Digite a idade:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição:");
            string? descricao = Console.ReadLine();

            Console.WriteLine("Digite a personalidade:");
            string? personalidade = Console.ReadLine();

            Console.WriteLine("Digite o apelido:");
            string? apelido = Console.ReadLine();

            // Cria o objeto com os dados informados
            Animais novoAnimal = new Animais(id, especie, idade, descricao, personalidade, apelido);

            // Guarda na lista
            novoAnimal.Guarda();
            Console.WriteLine("Vai cadastrar mais um animal? [S/N]");
            string? resp = Console.ReadLine();
            if (resp != null && resp.Equals("N",StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

      Animais.MostrarAnimais();  
    }

    
}