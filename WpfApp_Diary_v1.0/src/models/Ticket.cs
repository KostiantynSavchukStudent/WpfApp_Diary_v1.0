using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Diary_v1._0.src.models
{
    public class Ticket
    {
        long IdTicket { get; set; }
        long IdUser { get; set; }
        long IdTrip { get; set; }
        DateTime CreatedAt { get; set; }

        public Ticket(long IdUser, long IdTrip)
        {
            this.IdUser = IdUser;
            this.IdTrip = IdTrip;
            CreatedAt = DateTime.Now;
        }
    }
}
