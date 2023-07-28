// Records
// 1- Creo la estructura record
// 2- Copio las propiedades de mi clase
// 3- Creo un constructor

// La palabra reservada this, nos indica que la propiedad es de este elemento.
public record class recProductos 
{
    public int idProducto { get; set; }
    public string Description { get; set; }
    public string CodigoBarras { get; set; }

    public recProductos(int id, string description, string codigobarras) 
    {
        this.idProducto = id;
        this.Description = description; 
        this.CodigoBarras = codigobarras;
    }
}