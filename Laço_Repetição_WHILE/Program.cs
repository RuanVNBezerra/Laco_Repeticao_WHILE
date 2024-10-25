namespace Laço_Repetição_WHILE;

internal class Program
{
    static void Main()
    {
        //criando uma variavel qualquer:
        int numero = 1;
        //criando o loop de repetição while
        while(numero == 1)
        { // como "numero" é sempre 1 nesse programa, será então um loop infinito
            Console.WriteLine("Loop infinito");
        }

        // outra forma de usar while sem ter um loop infinito:
        while(numero < 10)
        {
            Console.WriteLine("Repetindo 9 vezes");
            numero++; // incrementando 1 a cada loop para quando for 10 parar o loop
        }

        // OUTRO TIPO DE LOOP USANDO WHILE
        // o DO WHILE
        int numero2 = 10;
        do
        {
            Console.WriteLine("Verificando uma vez");
            numero2++;
        }
        while (numero2 < 10);
        // veja, se eu usasse o while ao invés do DO, o loop não iniciaria, já que 10 não é menor do que 10.
        // com o DO, ele faz uma checagem apenas no final quando chega no while.
        // ou seja, o codigo dentro do DO será executado apenas uma vez até chegar no while nesse exemplo.
    }
}
