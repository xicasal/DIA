using System.Xml;
using System.Xml.Linq;
using Practica_2.Core;
using Practica_2.Core.Tipos_Aparatos;
using Practica_2.Core.Tipos_Reparacion;

public class XmlInventario {
    
    public XmlInventario(Tienda tienda) {
        this.Tienda = tienda;
    }
    public Tienda Tienda { get; }

    public void GuardaInventario() {
        var raiz = new XElement("Aparatos");

        foreach (var dvds in this.Tienda.Inventario_dvds) {
            var nodo_dvd = new XElement("DVD",
                new XElement("Num_serie", dvds.Num_serie),
                new XElement("Modelo", dvds.Modelo), 
                new XElement("Precio_por_horas", dvds.Precio_por_horas), 
                new XElement("Tiene_BlueRay", dvds.Tiene_BlueRay), 
                new XElement("Puede_grabar", dvds.Puede_grabar), 
                new XElement("Tiempo_grabación", dvds.Tiempo_grabacion)
            );
            raiz.Add(nodo_dvd);
        }
        
        foreach (var radios in this.Tienda.Inventario_radios) {
            var nodo_radio = new XElement("Radio",
                new XElement("Num_serie", radios.Num_serie),
                new XElement("Modelo", radios.Modelo), 
                new XElement("Precio_por_horas", radios.Precio_por_horas), 
                new XElement("Banda", radios.Banda)
            );
            raiz.Add(nodo_radio);
        }
        
        foreach (var tdts in this.Tienda.Inventario_tdts) {
            var nodo_tdt = new XElement("TDT",
                new XElement("Num_serie", tdts.Num_serie),
                new XElement("Modelo", tdts.Modelo), 
                new XElement("Precio_por_horas", tdts.Precio_por_horas),
                new XElement("Puede_grabar", tdts.Puede_grabar), 
                new XElement("Tiempo_grabación", tdts.Tiempo_grabacion)
            );
            raiz.Add(nodo_tdt);
        }
        
        foreach (var televisores in this.Tienda.Inventario_televisores) {
            var nodo_televisor = new XElement("Televisor",
                new XElement("Num_serie", televisores.Num_serie),
                new XElement("Modelo", televisores.Modelo), 
                new XElement("Precio_por_horas", televisores.Precio_por_horas), 
                new XElement("Pulgadas", televisores.Pulgadas)
            );
            raiz.Add(nodo_televisor);
        }
        raiz.Save("inventario.xml");
    }

}