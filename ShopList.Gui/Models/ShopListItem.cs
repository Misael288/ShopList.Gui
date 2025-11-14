namespace ShopList.Gui.Models
{
    public class ShopListItem
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Cantidad {  get; set; }
        public bool Comprado {  get; set; }
        public override string ToString()
        {
            return $"{Nombre}:{Cantidad}";
        }

    }
}
