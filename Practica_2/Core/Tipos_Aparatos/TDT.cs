namespace Practica_2.Core.Tipos_Aparatos;

public class TDT : Aparato{
    public TDT(int num_serie, string modelo, int precio_por_horas, bool puede_grabar, float tiempo_grabacion) 
        : base(num_serie, modelo, precio_por_horas) {
        this.Puede_grabar = puede_grabar;
        if (puede_grabar == false) {
            tiempo_grabacion = 0;
        }
        this.Tiempo_grabacion = tiempo_grabacion;
    }
    
    public bool Puede_grabar { get; }
    public float Tiempo_grabacion { get; }
    
    public override string ToString() {
        return String.Format("El número de serie es: {0}\n" +
                             "El modelo: {1}\n" +
                             "El precio por hora: {2}\n" +
                             "Puede grabar: {3}\n" +
                             "Tiempo de grabación {4}",
            Num_serie, Modelo, Precio_por_horas, Puede_grabar, Tiempo_grabacion);
    }
}