using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPracticeSkaffold1.Models
{
    public class EFFinalPracticeSkaffold1Repository : IFinalPracticeSkaffold1Repository
    {
        private MovieForumContext context { get; set; }
        public EFFinalPracticeSkaffold1Repository(MovieForumContext temp)
        {
            context = temp;
        }

        public IEnumerable<Responses> GetResponses()
        {
            return context.Responses.ToList();
        }

        public Responses GetResponsesByID(int id)
        {
            return context.Responses.Find(id);
        }

        public void InsertResponse(Responses responses)
        {
            context.Responses.Add(responses);
        }

        public void DeleteResponse(int movieForumID)
        {
            Responses responses = context.Responses.Find(movieForumID);
            context.Responses.Remove(responses);
        }

        public void DeleteOneResponse(Responses responses)
        {
            context.Responses.Remove(responses);
        }

        public void UpdateResponse(Responses responses)
        {
            context.Entry(responses).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
        public IQueryable<Responses> Responses => context.Responses;
    }
}
