using Rpg_Game.Units.Skills.SkillSet.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Units.Skills.SkillSet
{
    internal class Fireball : Magic
    {
        public override string Name { get; } = nameof(Fireball);

        public override int Cost { get; } = 5;

        public override int BaseDamage { get; } = 5;
    }
}
