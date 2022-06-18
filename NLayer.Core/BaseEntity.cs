using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    //Bu bir base yapı olduğu için abstract yapıyoruz ve newlenmesini istemiyoruz. 
    //Genelde abstract classlar projemizde ortak olan propları veya methodları kodladığımız yerlerdir.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
