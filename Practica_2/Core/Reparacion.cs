using Practica_2.Core.Tipos_Reparacion;

namespace Practica_2.Core; 

public class Reparacion {
    private double precio_base = 10;
    public Reparacion(Aparato aparato, double tiempo_reparacion) {
        this.Precio_base = precio_base;
        this.Conversion_precio_en_media_hora = aparato.Precio_por_horas / 2;
        this.Aparato = aparato;
        this.Tiempo_reparacion = tiempo_reparacion;
    }
    public double Precio_base { get; }
    public double Conversion_precio_en_media_hora { get; }
    public Aparato Aparato { get; }
    public double Tiempo_reparacion { get; }

    public override string ToString() {
        return String.Format("Reparación del aparato {0}. Con id: {1}\nTiempo de reparación: {2}", 
                            Aparato.Modelo, Aparato.Num_serie, Tiempo_reparacion);
    }
}
