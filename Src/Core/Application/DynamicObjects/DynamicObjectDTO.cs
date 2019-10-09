using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.DynamicObjects
{
    public class DynamicObjectDTO
    {        
        public string Service { get; set; }        
        public string Page { get; set; }
        public List<FieldsDetailDTO> FieldsDetailDTO { get; set; }
    }
}
