using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace wpfImajeLibrary
{
  public  class Product
    {

       public string Articul { get; set; }
       public string Name { get; set; }
        public Image img;
        public List<Image> Images { get; set; }

    }
}
