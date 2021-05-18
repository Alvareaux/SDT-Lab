using System;
using System.Collections.Generic;
using System.Text;

namespace Lab.DAL.Entities
{
    public enum state
    {
        record_new = 0,
        record_edited = 1,
        record_deleted = -1
    }

    public enum valid
    {
        record_new = 0,
        record_accepted = 1,
        record_added = 2,
        record_rejected = -1
    }

    public class Record
    {
        public int record_id { get; set; }
        public state record_state { get; set; }
        public valid record_valid { get; set; }

    }
}
