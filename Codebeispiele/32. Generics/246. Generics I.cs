public class Box
{
    // Die Box hat eine unveraenderliche Groesse
    private readonly int groesse;
    // Die Box wird durch ein Array vom Typ object dargestellt
    private object[] elemente;
    // Zeiger, der fuer das Hinzufuegen und Entfernen gebraucht wird
    private int zeiger = 0;

    // Beim Erzeugen einer Box muss dessen Groesse angegeben werden
    public Box(int groesse)
    {
        this.groesse = groesse;
        elemente = new object[groesse];
    }

    public void Add(object value)
    {
        if (zeiger < groesse)
        {
            elemente[zeiger] = value;
            zeiger++;
        }
        else
        {
            throw new InvalidOperationException();
        }
    }

    public object Remove()
    {
        zeiger--;
        if (zeiger >= 0)
        {
            return elemente[zeiger];
        }
        else
        {
            zeiger = 0;
            throw new InvalidOperationException();
        }
    }
}