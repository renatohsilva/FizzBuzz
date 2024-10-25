// Criar os manipuladores
using FizzBuzz;

var fizzBuzzHandler = new FizzBuzzHandler();
var fizzHandler = new FizzHandler();
var buzzHandler = new BuzzHandler();

// Configurar a cadeia
fizzBuzzHandler.SetNext(fizzHandler).SetNext(buzzHandler);

// Processar números de 1 a 100
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(fizzBuzzHandler.Handle(i));
}

Console.ReadLine();
