using System.Xml.Linq;

namespace Practica_2; 

public class XmlReparaciones {
    public XmlReparaciones(Tienda tienda) {
        this.Tienda = tienda;
    }
    
    public Tienda Tienda { get; }

    public void GuardaReparaciones() {
        var raiz = new XElement("Reparaciones");

        foreach (var sustitucion in Tienda.Inventario_sustitucion_a_piezas) {
            var nodo_sustitucion_a_piezas = new XElement("Sustitución_a_piezas",
                new XElement("Modelo_aparato", sustitucion.Aparato.Modelo),
                new XElement("Num_serie_Aparato", sustitucion.Aparato.Num_serie),
                new XElement("Tiempo_reparacion", sustitucion.Tiempo_reparacion)
            );
            raiz.Add(nodo_sustitucion_a_piezas);
        }
        
        foreach (var compleja in Tienda.Inventario_reparacion_compleja) {
            var nodo_reparacion_compleja = new XElement("Reparación_compleja",
                new XElement("Modelo_aparato", compleja.Aparato.Modelo),
                new XElement("Num_serie_Aparato", compleja.Aparato.Num_serie),
                new XElement("Tiempo_reparacion", compleja.Tiempo_reparacion)
            );
            raiz.Add(nodo_reparacion_compleja);
        }
        raiz.Save("Reparaciones.xml");
    }

    /*
    public static Tienda Recupera() {
        var toret = new Tienda();

        var raiz = XElement.Load("Reparaciones.xml");
        var reparaciones = raiz.Elements("Reparaciones");

        foreach (XElement nodo_reparacion in reparaciones) {
            
        }
    }
    */
}