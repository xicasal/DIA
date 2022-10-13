namespace Practica_2.Core.Tipos_Reparacion; 

public class SustitucionPiezas : Reparacion {
    public SustitucionPiezas(Aparato aparato, double tiempo_reparacion)
        : base(aparato, tiempo_reparacion) {
    }
    public double coste_de_reparacion() {
        if (Tiempo_reparacion <= 0.5) {
            return Conversion_precio_en_media_hora;
        }
        return Conversion_precio_en_media_hora * 2;
    }

    public override string ToString() {
        return String.Format("Aparato de sustitución a piezas con nombre del modelo: {0}\n"
            + "Número de serie: {1}\nTiempo de reparacion: {2}" +
            "\nPrecio cada media hora: {3}\nCoste de la reparación: {4}",
            Aparato.Modelo, Aparato.Num_serie, Tiempo_reparacion, 
            Conversion_precio_en_media_hora, coste_de_reparacion());
    }
}