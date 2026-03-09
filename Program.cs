using ELPROJECTO;
using System;
using System.Net.Http.Headers;

Console.WriteLine("Digite o nome do aluno: ");
Boletim NmA = new Boletim();
NmA._aluno.Name = Console.ReadLine();
Console.WriteLine("Digite a idade do aluno: ");
Boletim IDA = new Boletim();
IDA._aluno.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a matrícula do aluno: ");
Boletim Mma = new Boletim();
Mma._aluno.Matricula = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nome do professor: ");
Boletim NmP = new Boletim();
NmP._CD.Nome = Console.ReadLine();
Console.WriteLine("Digite o código do professor: ");
Boletim CdP = new Boletim();
CdP._CD.Codigo = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a formação do professor: ");
Boletim Formado = new Boletim();
Formado._CD.Formation = Console.ReadLine();
Console.WriteLine("Digite o código da disciplina: ");
Boletim CodigoDD = new Boletim();
CodigoDD._Dis.Codigod = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o nome da disciplina ");
Boletim NomeD = new Boletim();
NomeD._Dis.NomeD = Console.ReadLine();
Console.WriteLine("Digite a carga horária: ");
Boletim CagaH = new Boletim();
CagaH._Dis.CargaH = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da primeira prova: ");
Boletim N1 = new Boletim();
N1._Nota.Nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da segunda prova: ");
Boletim N2 = new Boletim();
N2._Nota.Nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a nota da terceira prova: ");
Boletim N3 = new Boletim();
N3._Nota.Nota3 = double.Parse(Console.ReadLine());

double media = (N1._Nota.Nota1 + N2._Nota.Nota2 + N3._Nota.Nota3) / 3;

Console.WriteLine("Aluno: " + NmA);
Console.WriteLine("Disciplina: " + NomeD);
Console.WriteLine("Professor: " + NmP);
Console.WriteLine("Nota 1: " + N1);
Console.WriteLine("Nota 2: " + N2);
Console.WriteLine("Nota 3: " + N3);

Console.WriteLine("Média: " + media);

if(media >= 7) 
{
    Console.WriteLine("Aprovado.");
}
else 
{
    Console.WriteLine("Reprovado.");
}