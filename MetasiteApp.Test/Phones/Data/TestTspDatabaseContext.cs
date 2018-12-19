using System;
using MetasiteApp.Phones.Data;
using Microsoft.EntityFrameworkCore;

namespace MetasiteApp.Test.Phones.Data
{
    public class TestTspDatabaseContext
    {
        public TspDatabaseContext InMemory() => 
            new TspDatabaseContext(
                new DbContextOptionsBuilder<TspDatabaseContext>().
                    UseInMemoryDatabase(Guid.NewGuid().ToString()).
                    Options);
    }
}
