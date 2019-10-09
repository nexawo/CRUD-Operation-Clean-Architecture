using CsvHelper;
using Nexawo.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nexawo.Infrastructure.Files
{
    public class CsvFileBuilder: ICsvFileBuilder
    {
        public byte[] BuildProductsFile(IEnumerable<dynamic> records) //<ProductRecordDto> records)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var streamWriter = new StreamWriter(memoryStream))
                using (var csvWriter = new CsvWriter(streamWriter))
                {
                    //csvWriter.Configuration.RegisterClassMap<ProductFileRecordMap>();
                    csvWriter.WriteRecords(records);
                }

                return memoryStream.ToArray();
            }
        }
    }
}
