namespace Practica_2.Core.Tipos_Aparatos;

public class Televisor : Aparato{
    public Televisor(int num_serie, string modelo, int precio_por_horas, double pulgadas) 
        : base(num_serie, modelo, precio_por_horas) {
        this.Pulgadas = pulgadas;
    }
    public double Pulgadas { get; }
    public override string ToString() {
        return String.Format("El número de serie es: {0}\n" +
                             "El modelo: {1}\n" +
                             "El precio por hora: {2}\n" +
                             "Número de pulgadas: {3}",
            Num_serie, Modelo, Precio_por_horas, Pulgadas);
    }
}