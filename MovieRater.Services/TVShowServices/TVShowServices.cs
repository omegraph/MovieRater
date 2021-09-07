using MovieRater.Data;
using MovieRater.Models.TVShowModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Services.TVShowServices
{
    public class TVShowServices
    {
        private readonly Guid _Id; // make an _id of type Guid

        public TVShowServices(Guid id)
        {
            _Id = id;
        }
        public async Task<bool> Put(TVShowEdit show, int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var oldTVShowData = await ctx.TVShows.FindAsync(id);
                if (oldTVShowData is null)
                {
                    return false;
                }

                oldTVShowData.Id = show.Id;
                oldTVShowData.Title = show.Title;
                oldTVShowData.ReleaseDate = show.ReleaseDate;
                oldTVShowData.Genre = show.Genre;
                oldTVShowData.Genre = show.Genre;
                oldTVShowData.Description = show.Description;
                oldTVShowData.MainCharacters = show.MainCharacters;

                return await ctx.SaveChangesAsync() > 0;
            }
        }
    }
}
