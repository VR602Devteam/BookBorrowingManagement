using ExportBookBorrowingData.EntitiyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData.ExportData.VM
{
    public class TeacherBorrowing : Borrowing
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
