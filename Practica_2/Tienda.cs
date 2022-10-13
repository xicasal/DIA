
using Practica_2;
using Practica_2.Core;
using Practica_2.Core.Tipos_Aparatos;
using Practica_2.Core.Tipos_Reparacion;

public class Tienda {
    public Tienda() {
        List<DVD> inventario_dvds = new List<DVD>();
        this.Inventario_dvds = inventario_dvds;
        
        List<Radio> inventario_radios = new List<Radio>();
        this.Inventario_radios = inventario_radios;
        
        List<TDT> inventario_tdts = new List<TDT>();
        this.Inventario_tdts = inventario_tdts;
        
        List<Televisor> inventario_televisores = new List<Televisor>();
        this.Inventario_televisores = inventario_televisores;

        List<Reparacion> inventario_reparaciones = new List<Reparacion>();
        this.Inventario_reparaciones = inventario_reparaciones;

        List<SustitucionPiezas> inventario_sustitucion_a_piezas = new List<SustitucionPiezas>();
        this.Inventario_sustitucion_a_piezas = inventario_sustitucion_a_piezas;

        List<ReparacionCompleja> inventario_reparacion_compleja = new List<ReparacionCompleja>();
        this.Inventario_reparacion_compleja = inventario_reparacion_compleja;
    }

    public List<DVD> Inventario_dvds { get; }
    public List<Radio> Inventario_radios { get; }
    public List<TDT> Inventario_tdts { get; }
    public List<Televisor> Inventario_televisores { get; }
    public List<Reparacion> Inventario_reparaciones { get; }
    public List<SustitucionPiezas> Inventario_sustitucion_a_piezas { get; }
    public List<ReparacionCompleja> Inventario_reparacion_compleja { get; }
    
    public void añadir_aparato_a_reparar(Reparacion reparacion) {
        Inventario_reparaciones.Add(reparacion);
    }

    public void añadir_a_tipo_de_reparacion(Reparacion reparacion) {
        if (reparacion.Tiempo_reparacion < 1) {
            var Sustitucion_piezas = new SustitucionPiezas(reparacion.Aparato, reparacion.Tiempo_reparacion);
            Inventario_sustitucion_a_piezas.Add(Sustitucion_piezas);
        }

        if (reparacion.Tiempo_reparacion >= 1) {
            var Reparacion_compleja = new ReparacionCompleja(reparacion.Aparato, reparacion.Tiempo_reparacion);
            Inventario_reparacion_compleja.Add(Reparacion_compleja);
        }
    }

    public override string ToString() {
        string resultado = "";
        int cont_dvds = 1;
        int cont_radios = 1;
        int cont_tdts = 1;
        int cont_televisores = 1;
        int cont_reparaciones = 1;
        int cont_sustitucion_piezas = 1;
        int cont_reparacion_compleja = 1;
        foreach (var dvd in Inventario_dvds) {
            resultado += String.Format("DVD Número: " + cont_dvds + "\n" + dvd + "\n\n");
            cont_dvds++;
        }
        foreach (var radio in Inventario_radios) {
            resultado += String.Format("Radio Número: " + cont_radios + "\n" + radio + "\n\n");
            cont_radios++;
        }
        foreach (var tdt in Inventario_tdts) {
            resultado += String.Format("TDT Número: " + cont_tdts + "\n" + tdt + "\n\n");
            cont_tdts++;
        }
        foreach (var televisor in Inventario_televisores) {
            resultado += String.Format("Televisor Número: " + cont_televisores + "\n" + televisor + "\n\n");
            cont_televisores++;
        }
        foreach (var reparacion in Inventario_reparaciones) {
            resultado += String.Format("Reparación Número: " + cont_reparaciones + 
                "\n" + reparacion + "\n\n");
            cont_reparaciones++;
        }
        foreach (var reparacion in Inventario_sustitucion_a_piezas) {
            resultado += String.Format("Sustitución de Piezas Número: " + cont_sustitucion_piezas + 
                                       "\n" + reparacion + "\n\n");
            cont_sustitucion_piezas++;
        }
        foreach (var reparacion in Inventario_reparacion_compleja) {
            resultado += String.Format("Reparación Compleja Número: " + cont_reparacion_compleja + 
                                       "\n" + reparacion + "\n\n");
            cont_reparacion_compleja++;
        }

        return resultado;
    }

    public static void Main() {
       //Creamos la tienda para almacenar los objetos
        var tienda_benito_y_manolo = new Tienda();
        
        //Creamos los DVDs y los metemos en el inventario
        var DVD_reparado1 = new DVD(15467, "E500", 20,
            true, true, 180);
        var DVD_reparado2 = new DVD(14692, "G507", 15,
            false, false, 0);
        var DVD_por_reparar1 = new DVD(33476, "EJ407", 15,
            false, true, 120);
        var DVD_por_reparar2 = new DVD(24678, "JQ200", 20,
            true, false, 20);
        
        tienda_benito_y_manolo.Inventario_dvds.Add(DVD_reparado1);
        tienda_benito_y_manolo.Inventario_dvds.Add(DVD_reparado2);
        tienda_benito_y_manolo.Inventario_dvds.Add(DVD_por_reparar1);
        tienda_benito_y_manolo.Inventario_dvds.Add(DVD_por_reparar2);
        
        
        //Creamos las Radios y las metemos en el inventario
        var Radio_reparada1 = new Radio(45459, "OnlyRadioMaria",
            30, Bandas.FM);
        var Radio_reparada2 = new Radio(67980, "RadioVigo",
            10, Bandas.AmFm);
        var Radio_por_reparar1 = new Radio(33356, "CatastrofeFm",
            25, Bandas.AM);
        var Radio_por_reparar2 = new Radio(12345, "Tostadora",
            15, Bandas.FM);
        
        tienda_benito_y_manolo.Inventario_radios.Add(Radio_reparada1);
        tienda_benito_y_manolo.Inventario_radios.Add(Radio_reparada2);
        tienda_benito_y_manolo.Inventario_radios.Add(Radio_por_reparar1);
        tienda_benito_y_manolo.Inventario_radios.Add(Radio_por_reparar2);
        
        
        //Creamos los TDTs y los metemos en el inventario
        var TDT_reparado1 = new TDT(51345, "yaloves", 20,
            false, 0);
        var TDT_reparado2 = new TDT(56923, "luegoloves", 25,
            true, 300);
        var TDT_por_reparar1 = new TDT(55779, "TDTodo", 10,
            false, 0);
        var TDT_por_reparar2 = new TDT(12679, "NoSintoniza", 30,
            true, 20);
        
        tienda_benito_y_manolo.Inventario_tdts.Add(TDT_reparado1);
        tienda_benito_y_manolo.Inventario_tdts.Add(TDT_reparado2);
        tienda_benito_y_manolo.Inventario_tdts.Add(TDT_por_reparar1);
        tienda_benito_y_manolo.Inventario_tdts.Add(TDT_por_reparar2);
        
        
        //Creamos los televisores y los metemos en el inventario
        var Televisor_reparado1 = new Televisor(30002, "sinMando",
            40, 16.5);
        var Televisor_reparado2 = new Televisor(30003, "esUnCuadro",
            50, 30.6);
        var Televisor_por_reparar1 = new Televisor(30012, "Forest Gump",
            20, 12.4);
        var Televisor_por_reparar2 = new Televisor(30007, "malviviendo",
            35, 20.8);
        
        tienda_benito_y_manolo.Inventario_televisores.Add(Televisor_reparado1);
        tienda_benito_y_manolo.Inventario_televisores.Add(Televisor_reparado2);
        tienda_benito_y_manolo.Inventario_televisores.Add(Televisor_por_reparar1);
        tienda_benito_y_manolo.Inventario_televisores.Add(Televisor_por_reparar2);
        
        
        //Creamos unas reparaciones y las añadimos al inventario
        var Reparacion_radio1 = new Reparacion(Radio_por_reparar1, 1.5);
        var Reparacion_TDT1 = new Reparacion(TDT_por_reparar2, 0.5);
        var Reparacion_DVD1 = new Reparacion(DVD_por_reparar1, 2.5);
        
        tienda_benito_y_manolo.añadir_aparato_a_reparar(Reparacion_radio1);
        tienda_benito_y_manolo.añadir_aparato_a_reparar(Reparacion_TDT1);
        tienda_benito_y_manolo.añadir_aparato_a_reparar(Reparacion_DVD1);
        
        // Clasificamos las reparaciones dependiendo del tiempo de reparación
        
        tienda_benito_y_manolo.añadir_a_tipo_de_reparacion(Reparacion_radio1);
        tienda_benito_y_manolo.añadir_a_tipo_de_reparacion(Reparacion_TDT1);
        tienda_benito_y_manolo.añadir_a_tipo_de_reparacion(Reparacion_DVD1);
        
        Console.WriteLine(tienda_benito_y_manolo);
        
        var xml_inventario = new XmlInventario(tienda_benito_y_manolo);
        xml_inventario.GuardaInventario();

        var xml_reparaciones = new XmlReparaciones(tienda_benito_y_manolo);
        xml_reparaciones.GuardaReparaciones();
    }
}
