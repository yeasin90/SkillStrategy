using Ninject;
using SkillService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService.SkillEvaluation
{
    public class TrackInfluenceSkill : ISkills//Skills
    {
        private ITrackRespotiroy _trackRepository;

        [Inject]
        public TrackInfluenceSkill(ITrackRespotiroy trackRepository)
        {
            _trackRepository = trackRepository;
        }

        public Dictionary<string, int> FormulateScore(IEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
