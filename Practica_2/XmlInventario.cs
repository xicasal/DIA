using System.Xml;
using System.Xml.Linq;
using Practica_2.Core;
using Practica_2.Core.Tipos_Aparatos;
using Practica_2.Core.Tipos_Reparacion;

public class XmlInventario {
    public const string etq_tienda = "Tienda";
    public const string etq_aparato = "Aparato";
    public const string etq_reparacion = "Reparación";
    public const string etq_dvd = "DVD";
    public const string etq_radio = "Radio ";
    public const string etq_tdt = "TDT";
    public const string etq_televisor = "Televisor";
    public const string etq_reparacion_compleja = "Reparacion Compleja";
    public const string etq_sustitucion_a_piezas = "Sustitución a Piezas";

    public XmlInventario(Tienda tienda) {
        this.Tienda = tienda;
    }
    public Tienda Tienda { get; }

    public XElement toXml() {
        return new XElement(etq_tienda, 
            new XElement(etq_aparato, 
                new XElement(etq_dvd, Tienda.Inventario_dvds)),
            new XElement(etq_aparato, 
                new XElement(etq_radio, Tienda.Inventario_radios)),
            new XElement(etq_aparato, 
                new XElement(etq_tdt, Tienda.Inventario_tdts)), 
            new XElement(etq_aparato, 
                new XElement(etq_televisor, Tienda.Inventario_televisores))
                );
    }

}