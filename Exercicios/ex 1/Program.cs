using ex_1;

//Instanciando a classe Funcionário
Funcionario func1 = new Funcionario { Nome = "Rafael", Idade = 30 };
Funcionario func2 = new Funcionario { Nome = "Isadora", Idade = 20 };
Funcionario func3 = new Funcionario { Nome = "Roberto", Idade = 15 };
Funcionario func4 = new Funcionario { Nome = "João", Idade = 43 };
Funcionario func5 = new Funcionario { Nome = "Joana", Idade = 55 };

//chamando o metodo envelhecer
func1.Envelhecer(10); //somar a idade que voce passou para a variavel mais 10

//exibindo as informações dos funcionários
Console.WriteLine("\nIdade Envelhecida");

Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");
Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");
Console.WriteLine($"Nome: {func4.Nome}, Idade: {func4.Idade}");
Console.WriteLine($"Nome: {func5.Nome}, Idade: {func5.Idade}");

Console.WriteLine("\nIdade Rejuvenescida");
func1.Desenvelhecer(15); 
Console.WriteLine($"Nome: {func1.Nome}, Idade: {func1.Idade}");

func2.Desenvelhecer(15);
Console.WriteLine($"Nome: {func2.Nome}, Idade: {func2.Idade}");

func3.Desenvelhecer(15);
Console.WriteLine($"Nome: {func3.Nome}, Idade: {func3.Idade}");

func4.Desenvelhecer(15);
Console.WriteLine($"Nome: {func4.Nome}, Idade: {func4.Idade}");

func5.Desenvelhecer(15);
Console.WriteLine($"Nome: {func5.Nome}, Idade: {func5.Idade}");

//encerra o programa
Console.WriteLine("\nPressione qualquer tecla para sair");

Console.ReadKey();
