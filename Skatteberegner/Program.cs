public class Beregning
{
    static void Main(string[] args)
    {

    }

    // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
    public double SkatVedJulegave(double julegave, double andenGave)
    {
        var total = julegave + andenGave;
        if (total <= 1200 || julegave <= 900 && andenGave <= 300)
        {
            return 0;
        }
        else if (julegave > 900 && andenGave <= 300)
        {
            return julegave + andenGave;
        }
        else if (julegave <= 900 && andenGave > 300)
        {
            return andenGave;
        }
        else
        {
            return julegave + andenGave;
        }
    }
}