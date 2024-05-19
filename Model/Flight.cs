
namespace FrontEndBlazor.Model;
public class Flight
{
    public string Destination { get; set; }
    public string Origin { get; set; }
    public double Price { get; set; }
    public int IdTransportFK { get; set; } = 200;
}