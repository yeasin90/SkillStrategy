using SkillService.SkillCriteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.Repository
{
    public class TrackRespotiroy : ITrackRespotiroy
    {
        public ICollection<ITrack> GetAll()
        {
            return new List<ITrack>()
            {
                new Track(){ Name = "Programmer", DisplayName = "Programmer"},
                new Track(){ Name = "Graphic designer", DisplayName = "Graphic designer"},
                new Track(){ Name = "Software Architect", DisplayName = "Software Architect"},
                new Track(){ Name = "System Administrator", DisplayName = "System Administrator"},
                new Track(){ Name = "Network Engineer", DisplayName = "Network Engineer"},
                new Track(){ Name = "UX Engineer", DisplayName = "UX Engineer"}
            };
        }
    }
}
