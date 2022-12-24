using DIO_explorando.NET_C_.models;


Pessoa varPessoa = new Pessoa(nome: "Gabriel", sobrenome: "Henrique");
Pessoa varPessoa2 = new Pessoa(nome: "Pedro", sobrenome: "Santos");

Curso varCurso = new Curso();
varCurso.Nome = "Informatica";
varCurso.Alunos = new List<Pessoa>();

varCurso.AddAluno(varPessoa);
varCurso.AddAluno(varPessoa2);
varCurso.ListarAlunos();





/*Pessoa varPessoa = new Pessoa();

varPessoa.Nome= "Gabriel"; varPessoa.Sobrenome= "Henrique"; varPessoa.Idade= 18;
varPessoa.Apresentar();*/