﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillService
{
    public class Entity : IEntity
    {
        public Guid ID { get { return new Guid(); } set { throw new NotImplementedException(); } }
    }
}
