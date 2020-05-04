using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportBookBorrowingData.ExportData.VM
{
    public class Borrowing : IBorrowing
    {
        public int Id { get; set; }
        public string BookId { get; set; }
        public string SerialNumber { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string SeriesTitle { get; set; }
        public double Price { get; set; }
        public string ISBN { get; set; }
        public string PublishYear { get; set; }
        public string Version { get; set; }
        public string Category { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public string BorrowBookDay { get; set; }
        public string IsOverdue { get; set; }
        public string IsDiscard { get; set; }
        public double CompensationAmount { get; set; }
        public string Remarks { get; set; }
       
    }
}
