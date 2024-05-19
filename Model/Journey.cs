using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndBlazor.Model;
public class Journey
{
    public int Id { get; set;}
    public string Destination { get; set; }
    public string Origin { get; set; }
    public double Price { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
}