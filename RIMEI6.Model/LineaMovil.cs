namespace RIMEI6.Model
{
    public class LineaMovil
    {
        public string imsi { get; set; }
        public ulong consumoBajada { get; set; }
        public ulong consumoSubida { get; set; }
        public ulong consumoTotal { get; set; }
        public LineaMovil(string imsi, ulong consumoBajada = 0, ulong consumoSubida = 0)
        {
            this.imsi = imsi;
            this.consumoBajada = consumoBajada;
            this.consumoSubida = consumoSubida;
            this.consumoTotal = consumoBajada + consumoSubida;
        }

        public void sumaConsumos(ulong consumoBajada, ulong consumoSubida)
        {
            this.consumoBajada += consumoBajada;
            this.consumoSubida += consumoSubida;
            this.consumoTotal += consumoBajada + consumoSubida;
        }
    }
}
