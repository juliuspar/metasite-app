using System;
using System.Collections.Generic;
using System.Linq;
using MetasiteApp.Phones.Data;

namespace MetasiteApp.Test.Phones.Data
{
    public class PhoneBuilder
    {
        private readonly string _number;
        private readonly int _id;
        private readonly IEnumerable<Sms> _smses;
        private readonly IEnumerable<Call> _calls;

        public PhoneBuilder() : this(
            "",
            0,
            new Sms[] { },
            new Call[] { })
        {
        }

        private PhoneBuilder(
            string number,
            int id,
            IEnumerable<Sms> smses,
            IEnumerable<Call> calls)
        {
            _number = number;
            _id = id;
            _smses = smses;
            _calls = calls;
        }

        public PhoneBuilder Id(int id) =>
            new PhoneBuilder(_number, id, _smses, _calls);

        public PhoneBuilder Number(string number) =>
            new PhoneBuilder(number, _id, _smses, _calls);

        public PhoneBuilder AddSmsForNow(int amount) => new PhoneBuilder(
            _number,
            _id,
            _smses.Concat(
                Enumerable.Range(0, amount).Select(s => new Sms
                {
                    PhoneId = _id,
                    Date = DateTime.Now
                })),
            _calls);

        public PhoneBuilder AddCallForNow(int duration) => new PhoneBuilder(
            _number,
            _id,
            _smses,
            _calls.Concat(new[] {
                new Call
                {
                    PhoneId = _id,
                    Duration = duration,
                    Date = DateTime.Now
                }
            }));

        public Phone Build() => new Phone
        {
            PhoneId = _id,
            Number = _number,
            Calls = _calls.ToList(),
            Smses = _smses.ToList()
        };
    }
}
