using System;
using System.Collections.Generic;
using System.Text;

namespace Nexawo.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildProductsFile(IEnumerable<dynamic> records);//<ProductRecordDto> records);
    }
}
