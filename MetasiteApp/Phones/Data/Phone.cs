using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MetasiteApp.Phones.Data
{
    public class Phone
    {
        public int PhoneId { get; set; }

        [Required]
        public string Number { get; set; }

        public List<Sms> Smses { get; set; }

        public List<Call> Calls { get; set; }
    }
}