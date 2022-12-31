using DIO_explorando.NET_C_.models;
using System.Globalization; // necessario para usar o cultureInfo defaut para pt-br
using Newtonsoft.Json;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

List<Vendas> listaVendas = new List<Vendas>();

Vendas v1 = new Vendas(1, "material de escritorio", 25.00M);
Vendas v2 = new Vendas(2, "material de construção", 110.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serialization = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("files/vendas.json",serialization);

Console.WriteLine(serialization);













/*
ExampleTupla arquivo = new ExampleTupla();
//colocar o _ assim descartando um return por exemplo no lugar do quantidadeLinhas
var (sucesso, linhasArquiv, quantidadeLinhas) = arquivo.LeituraTupla("files/leitura.txt"); 
//new ExampleTupla().TUPLA();
if (sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
    foreach (var item in linhasArquiv)
    {
        Console.WriteLine(item);
    }
}
else
{
    Console.WriteLine("não foi possível ler o arquivo");
}
*/

//new Example().Metodo1();




/*try
{
    string[] lines = File.ReadAllLines("files/leitura.txt");
    
    foreach (var line in lines) { Console.WriteLine(line); }
}

catch (Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("chegou no finally");
}*/
    
















/*decimal valorCapital = 1530.40M;
double valorPorcentagem = .3421;

DateTime date = DateTime.Now;

Console.WriteLine(date.ToString("dd/MM/yyyy"));

Console.WriteLine(date.ToShortDateString()); // "dd/MM/yyyy

Console.WriteLine(date.ToShortTimeString()); // HH:mm 

string dataText = "2022-12-25 16:30";


DateTime.TryParseExact(dataText, "yyyy-MM-dd HH:mm",
                          CultureInfo.InvariantCulture,
                           DateTimeStyles.None, out DateTime dateTimeText);


Console.WriteLine(dateTimeText);



Console.WriteLine($"{valorCapital:C}"); // :C -> coloca o valor na moeda da cultura do seu PC

Console.WriteLine(valorCapital.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // :C -> coloca o valor na moeda

Console.WriteLine($"{valorPorcentagem.ToString("P")}");

Console.WriteLine(valorCapital.ToString("##-##"));*/

/*Pessoa varPessoa = new Pessoa(nome: "Gabriel", sobrenome: "Henrique");
Pessoa varPessoa2 = new Pessoa(nome: "Pedro", sobrenome: "Santos");

Curso varCurso = new Curso();
varCurso.Nome = "Informatica";
varCurso.Alunos = new List<Pessoa>();

varCurso.AddAluno(varPessoa);
varCurso.AddAluno(varPessoa2);
varCurso.ListarAlunos();*/





/*Pessoa varPessoa = new Pessoa();

varPessoa.Nome= "Gabriel"; varPessoa.Sobrenome= "Henrique"; varPessoa.Idade= 18;
varPessoa.Apresentar();*/