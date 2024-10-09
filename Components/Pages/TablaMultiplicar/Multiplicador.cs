class Tabla
{

    public List<int> Tablat { get; set; } = new List<int>();

    public int GeneradorMultiplicacion(int Number)
    {
        for (int i = 0; i <= 12; i++)
        {
            Tablat.Add(Number * i);
        }
        return Number;
    }

    public List<int> Result()
    {
        return Tablat;
    }
}