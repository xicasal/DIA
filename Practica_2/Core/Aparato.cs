namespace Practica_2.Core;

public class Aparato {
    public Aparato(int num_serie, string modelo, double precio_por_horas) {
        this.Num_serie = num_serie;
        this.Modelo = modelo;
        this.Precio_por_horas = precio_por_horas;
    }
    public int Num_serie { get; }
    public string Modelo { get; }
    public double Precio_por_horas { get; }

    public override string ToString()
    {
        return $"{Num_serie} {Modelo} {Precio_por_horas}";
    } 

}