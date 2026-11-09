using ExerciciosPoo;

//Exercício 1 - Apresentação de pessoas
// Pessoas p = new Pessoas();
// p.Nome = "João";
// p.Idade = 30;
// p.Cidade = "São Paulo";
// p.Apresentar();

//Exercício 2 - Métodos de instância e métodos estáticos
// Calculadora calc = new Calculadora();
// double resultado = calc.Somar(10, 5);
// Console.WriteLine($"Resultado da soma: {resultado}");

// resultado = calc.Subtrair(10, 5);
// Console.WriteLine($"Resultado da subtração: {resultado}");

// resultado = calc.Multiplicar(10, 5);
// Console.WriteLine($"Resultado da multiplicação: {resultado}");

// try
// {
//     resultado = Calculadora.Dividir(10, 0);
//     Console.WriteLine($"Resultado da divisão: {resultado}");
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine($"Erro: {ex.Message}");
// }

//Exercício 3 - Propriedades com validação
// Veiculo v = new Veiculo();
// v.Velocidade = 100;
// Console.WriteLine($"Velocidade do veículo: {v.Velocidade}");
// v.Velocidade = 150;
// Console.WriteLine($"Velocidade do veículo: {v.Velocidade}");
// v.Velocidade = 250;
// Console.WriteLine($"Velocidade do veículo: {v.Velocidade}");

//Exercício 4 - Propriedades e controle de acesso

// Funcionario f = new Funcionario("Maria", "Desenvolvedora", 5000m);
// f.ConsultarSalario();

// f.AumentarSalario(10); // aumento de 10%
// f.ConsultarSalario();

// Tentativa de alterar o salário diretamente pela propriedade:
// f.Salario = 9000m;
//
// EXPLICAÇÃO: essa linha NÃO compila. A propriedade Salario foi declarada
// com "private set", ou seja, só pode ser alterada por código DENTRO da
// própria classe Funcionario (como no construtor e no método AumentarSalario).
// Fora da classe, como aqui no Program, só é possível LER o valor (get público).
// O compilador mostra o erro CS0272: "O acessador set da propriedade
// 'Funcionario.Salario' está inacessível". Isso garante o encapsulamento:
// o salário só muda por meio de regras controladas pela classe.

// Exercício 5 - Construtores e sobrecarga

 Livro l1 = new Livro();
            Livro l2 = new Livro("Dom Casmurro");
            Livro l3 = new Livro("O Alquimista", "Paulo Coelho");
            Livro l4 = new Livro("Clean Code", "Robert C. Martin", 464);
 
            l1.ExibirDados();
            l2.ExibirDados();
            l3.ExibirDados();
            l4.ExibirDados();