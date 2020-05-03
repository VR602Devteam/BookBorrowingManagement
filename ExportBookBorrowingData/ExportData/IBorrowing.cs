using ExportBookBorrowingData.EntitiyModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData.ExportData.VM
{
    public interface IBorrowing
    {
        public int SerialNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string SeriesTitle { get; set; }
        public string SeriesAuthor { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public string Press { get; set; }
        public string PublishYear { get; set; }
        public string Pages { get; set; }
        public string Version { get; set; }
        public string Category { get; set; }
        public string Classification { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public string BorrowBookDay { get; set; }
        public bool IsOverdue { get; set; }
        public bool IsDiscard { get; set; }
        public string BorrowDay { get; set; }
        public double CompensationAmount { get; set; }
        public string Remarks { get; set; }

    }
}
