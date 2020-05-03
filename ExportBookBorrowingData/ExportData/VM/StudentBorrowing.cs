using ExportBookBorrowingData.EntitiyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData.ExportData.VM
{
    public class StudentBorrowing :Borrowing
    {
        public string Name { get; set; }
        public string Class { get; set; }
    }
}
