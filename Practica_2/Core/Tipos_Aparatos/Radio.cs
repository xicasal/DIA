namespace Practica_2.Core.Tipos_Aparatos;

public class Radio : Aparato{
    public Radio(int num_serie, string modelo, int precio_por_horas, Bandas banda) 
        : base(num_serie, modelo, precio_por_horas) {
        this.Banda = banda;
    }

    public Bandas Banda { get; }

    public override string ToString() {
        return String.Format("El número de serie es: {0}\n" +
                             "El modelo: {1}\n" +
                             "El precio por hora: {2}\n" +
                             "El tipo de banda: {3}",
                Num_serie, Modelo, Precio_por_horas, Banda);
    }
}

public enum Bandas {
    AM,
    FM,
    AmFm
}