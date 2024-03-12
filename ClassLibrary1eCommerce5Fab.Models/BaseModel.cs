using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1eCommerce5Fab.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            this.IsActive = true;
        }
        public bool IsActive { get; set; }
    }
}
