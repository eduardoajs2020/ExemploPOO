using ExemploPOO.Models;
using ExemploPOO.interfaces;

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));
Console.WriteLine(calc.Dividir(3, 2));
Console.WriteLine(calc.Somar(3, 2));
Console.WriteLine(calc.Subtrair(3, 2));






// Computador c = new Computador();
// Console.WriteLine(c.ToString());






// Pessoa p1 = new Pessoa("Eduardo");
// Aluno a1 = new Aluno("Leonardo");
// a1.Apresentar();
// p1.Apresentar();

// Professor prof = new Professor("Girafales");
// prof.Apresentar();

// //ABSTRACT

// Corrente c = new Corrente();

// c.Creditar(500);
// c.ExibirSaldo();


// Aluno a1 = new Aluno();

// a1.Nome = "Leonardo";
// a1.Idade = 20;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();

// p1.Nome = "Eduardo";
// p1.Idade = 40;
// p1.Salario = 1000;
// p1.Apresentar();


// ContaCorrente c1 = new ContaCorrente(123, 1000);

// c1.ExibirSaldo();
// c1.Sacar(5000);
// c1.ExibirSaldo();




// Pessoa p1 = new Pessoa();

// p1.Nome = "Leonardo";
// p1.Idade = 20;

// p1.Apresentar();
