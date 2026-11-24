
Console.WriteLine("quantas moedas tem seu personagem:");
int moedasJogador = int.Parse(Console.ReadLine()!);

Console.WriteLine("quantas poções deseja comprar?");
int pocoes = int.Parse(Console.ReadLine()!);
int valorPocoes = 15;
if (moedasJogador >= valorPocoes)
{
    Console.WriteLine("compra concluida");
}
else
{
    Console.WriteLine("saldo insuficiente");

}