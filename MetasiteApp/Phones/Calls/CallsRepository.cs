using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetasiteApp.Phones.Data;
using MetasiteApp.Phones.Extensions;
using Microsoft.EntityFrameworkCore;

namespace MetasiteApp.Phones.Calls
{
    public class CallsRepository
    {
        private readonly TspDatabaseContext _context;

        public CallsRepository(TspDatabaseContext context)
            => _context = context;
        
        public async Task<IList<string>> Top5PhoneNumbersWithLongestCalls(DateTime from, DateTime to) 
            => await _context.Phones.Include(phone => phone.Calls).
                OrderByDescending(p => p.Calls.Sum(c => c.Duration)).
                Select(s => s.Number).
                Take(5).
                ToArrayAsync();

        public async Task<int> Total(DateTime from, DateTime to)
            => await _context.Calls.
                Where(s => s.Date.Between(from, to)).
                CountAsync();
    }
}
