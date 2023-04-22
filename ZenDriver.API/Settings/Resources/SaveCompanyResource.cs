using ZenDriver.API.Settings.Domain.Models;
using ZenDriver.API.Security.Domain.Models;

namespace ZenDriver.API.Settings.Resources;

public class SaveCompanyResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RUC { get; set; }
    public string Owner { get; set; }
    public string Imagen_url { get; set; }
}