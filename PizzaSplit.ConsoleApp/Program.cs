using PizzaSplit.Core;

Console.Write("Sisesta summa: ");
decimal total = decimal.Parse(Console.ReadLine());

Console.Write("Mitu inimest: ");
int people = int.Parse(Console.ReadLine());

Console.Write("Jootraha (true/false): ");
bool addTip = bool.Parse(Console.ReadLine());

if (BillCalculator.TryCalculate(
    total,
    people,
    addTip,
    out decimal share,
    out string error))
{
    Console.WriteLine($"Ühe inimese osa: {share:F2} €");
}
else
{
    Console.WriteLine(error);
}