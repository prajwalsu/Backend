using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationEmpty.Modal;



//view model:data transfer object-> strictly typed view
namespace WebApplicationEmpty.ViewModels

{
    public class HomeDetailsViewModel
    {
        public Employee employee { get; set; }
        public string Title { get; set; }
    }
}
