/// <summary>
/// **********************************************
/// * Terminal.cs
/// *---------------------------------------------
/// Descripción: Este fichero define los paráme-
///     tros básicos de un terminal almacenado
///     en la BBDD de terminales. Contiene infor-
///     mación sobre su TAC y tecnologías sopor-
///     tadas, como OTA, web, etc...
/// Autor:  Fernando Gallego Fernández
/// Rev:    1.0
/// </summary>

namespace RIMEI6.Model
{
    /// <summary>
    /// Clase descriptiva de Terminal
    /// </summary>
    public class Terminal
    {
        /// <summary>
        /// TAC del terminal
        /// </summary>
        public string TAC { get; set; }
        /// <summary>
        /// Nombre del terminal
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Modelo del terminal
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Sistema operativo del terminal
        /// </summary>
        public string OS { get; set; }
        /// <summary>
        /// Fabricante del terminal
        /// </summary>
        public string Manufacturer { get; set; }
        public string bookmark { get; set; }
        public string data { get; set; }
        public string datacsd { get; set; }
        /// <summary>
        /// Soporte OTA
        /// </summary>
        public string datagprs { get; set; }
        public string email { get; set; }
        public string mmscsd { get; set; }
        public string mmsgprs { get; set; }
        public string wapcsd { get; set; }
        public string wapgprs { get; set; }
        public string waphscsd { get; set; }
        public string web { get; set; }
        public string omadmbs { get; set; }
        public string streaming { get; set; }
        public string syncml { get; set; }
        public string imgprs { get; set; }
        public string pocgprs { get; set; }

        /// <summary>
        /// Instancia de nuevo terminal.
        /// </summary>
        /// <param name="tac">TAC del terminal</param>
        public Terminal(string tac)
        {
            this.datagprs = "-";
            this.TAC = tac;
            this.bookmark = "-";
            this.data = "-";
            this.datacsd = "-";
            this.email = "-";
            this.imgprs = "-";
            this.Manufacturer = "-";
            this.mmscsd = "-";
            this.mmsgprs = "-";
            this.Model = "-";
            this.Name = "-";
            this.omadmbs = "-";
            this.OS = "-";
            this.pocgprs = "-";
            this.streaming = "-";
            this.syncml = "-";
            this.wapcsd = "-";
            this.wapgprs = "-";
            this.waphscsd = "-";
            this.web = "-";
        }
    }
}
