// Records
// 1- Creo la estructura record
// 2- Copio las propiedades de mi clase
// 3- Creo un constructor

// La palabra reservada this, nos indica que la propiedad es de este elemento.
public record class recProductos 
{
    public int idProducto { get; init; } // Modifico los productos para que sean solo de lectura, se coloca init para que solo atraves del contructor se coloque os valores
    public string Description { get; init; }
    public string CodigoBarras { get; init; }

    public recProductos(int id, string description, string codigobarras) 
    {
        this.idProducto = id;
        this.Description = description; 
        this.CodigoBarras = codigobarras;
    }

}
// Record para Iva y Ieps
public record struct recImpuestos // Record de tipo struct
{
    public decimal PorcentajeIva { get; set; }
    public decimal PorcentajeIeps { get; set; }
    // Constructor
    public recImpuestos(decimal porIva, decimal porIeps)
    {
        PorcentajeIva = porIva;
        PorcentajeIeps = porIeps;
    }
}
// Record para los montos
public record class recMontosImpuestos
{
    public decimal MontoIva { get; set; }
    public decimal MontoIeps { get; set; }

    // Constructor
    public recMontosImpuestos (decimal montoIva, decimal montoIeps)
    {
        MontoIva = montoIva;
        MontoIeps = montoIeps;
    }
}
