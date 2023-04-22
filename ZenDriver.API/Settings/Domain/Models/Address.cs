using ZenDriver.API.Security.Domain.Models;
using System.Text.Json.Serialization;

namespace ZenDriver.API.Settings.Domain.Models;
public class Address
{
    public int Id { get; set; }
    public string NameAddress { get; set; }

    //Relationships
    public int UserId { get; set; }
    public User User { get; set; }

}
