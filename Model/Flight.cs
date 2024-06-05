
namespace FrontEndBlazor.Model;
public class Flight
{
    public int Id { get; set; }
    public string Destination { get; set; }
    public string Origin { get; set; }
    public double Price { get; set; }
    public string DateStart { get ; set; } = null;
    public string DateEnd { get; set; } = null;
    public int IdTransportFK { get; set; } = 200;
}