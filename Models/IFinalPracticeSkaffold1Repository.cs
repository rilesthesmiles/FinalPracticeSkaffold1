using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeSkaffold1.Models
{
    public interface IFinalPracticeSkaffold1Repository
    {
        IQueryable<Responses> Responses { get; }

        void InsertResponse(Responses ar);
        void Save();
        void UpdateResponse(Responses responses);
        void DeleteResponse(int movieForumID);
        void DeleteOneResponse(Responses responses);
    }
}
