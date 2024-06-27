using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Nop.Plugin.Misc.NopStationGallary.Models;
public class ConfigureModel 
{
    public List<IFormFile> ProfilePictures { get; set; } = new List<IFormFile>();
    public List<string> Names { get; set; } = new List<string>();
    public List<string> Designations { get; set; } = new List<string>();
}
