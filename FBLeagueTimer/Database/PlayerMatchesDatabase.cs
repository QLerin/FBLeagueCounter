using FBLeagueTimer.Entities;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Database
{
    //https://www.litedb.org/
    public class PlayerMatchesDatabase
    {
        public void GetDatabase(List<MatchReferenceDto> matchesCollection, string playerName)
        {
            using (var db = new LiteDatabase($"{playerName}.db"))
            {
                var matchesDatabase = db.GetCollection<MatchReferenceDto>("Matches");
                matchesDatabase.InsertBulk(matchesCollection);
            }
        }
    }
}
