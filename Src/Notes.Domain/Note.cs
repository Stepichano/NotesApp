using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Notes.Domain
{
    public class Note
    {
        public Guid UserID { get; set; }
        public Guid Id { set; get; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? EditDate { get; set; }
        
    }
}
