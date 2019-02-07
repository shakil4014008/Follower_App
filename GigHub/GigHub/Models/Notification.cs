using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Notification
    {
        public int Id { get; private set; }
        public DateTime DateTime { get; private set; }
        public NotificationType Type { get; private set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }

        [Required]
        public Gig Gig { get; private  set; }

        protected Notification()
        {

        }

        public Notification(NotificationType type, Gig gig)
        {
            if(gig == null)
                throw  new ArgumentException();
           Gig = gig;
           DateTime = DateTime.Now;
           Type = type;
        }
    }
}