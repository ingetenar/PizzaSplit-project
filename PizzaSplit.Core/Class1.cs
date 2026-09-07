namespace PizzaSplit.Core;

public static class BillCalculator
{
    public static bool TryCalculate(
        decimal total,
        int people,
        bool addTip,
        out decimal share,
        out string error)
    {
        share = 0;
        error = "";

        if (total <= 0 || total > 10000)
        {
            error = "Vale summa";
            return false;
        }

        if (people < 1 || people > 20)
        {
            error = "Vale inimeste arv";
            return false;
        }

        if (addTip)
        {
            total *= 1.10m;
        }

        share = Math.Round(
            total / people,
            2,
            MidpointRounding.AwayFromZero);

        return true;
    }
}