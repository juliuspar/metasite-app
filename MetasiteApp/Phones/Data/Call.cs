using System;

namespace MetasiteApp.Phones.Data
{
    public class Call
    {
        public int CallId { get; set; }

        public int Duration { get; set; }

        public DateTime Date { get; set; }

        public int PhoneId { get; set; }
    }
}