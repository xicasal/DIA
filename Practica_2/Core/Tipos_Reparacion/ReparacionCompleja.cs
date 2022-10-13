namespace Practica_2.Core.Tipos_Reparacion; 

public class ReparacionCompleja : Reparacion{
    public ReparacionCompleja(Aparato aparato, double tiempo_reparacion) 
        : base(aparato, tiempo_reparacion) {
    }

    public double incremento_precio() {
        return Conversion_precio_en_media_hora * (25 / 100);
    }
    public double coste_de_reparacion() {
        double cont_tiempo = 0;
        double coste_reparacion = 0;
        while (cont_tiempo < Tiempo_reparacion) {
            coste_reparacion += Conversion_precio_en_media_hora;
            cont_tiempo += 0.5;
        }
        return coste_reparacion;
    }
    
    public override string ToString() {
        return String.Format("Aparato de Reparación Compleja con nombre del modelo: {0}\n"
                             + "Número de serie: {1}\nTiempo de reparacion: {2}" +
                             "\nPrecio cada media hora: {3}\nCoste de la reparación: {4}",
            Aparato.Modelo, Aparato.Num_serie, Tiempo_reparacion, 
            Conversion_precio_en_media_hora, coste_de_reparacion());
    }
}