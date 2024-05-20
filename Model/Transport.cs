
namespace FrontEndBlazor.Model;
public class Transports
{
    public int Id { get; set; }
    public string FlightCarrier { get; set; }
    public string FlightNumber { get; set; }
    public string Mostra { get => FlightCarrier + " " + FlightNumber; set {Mostra = value;} }
}
