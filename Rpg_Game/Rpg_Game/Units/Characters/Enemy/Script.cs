using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Units.Characters.Enemy
{
    public  class Script
    {
        private Enemy Enemy { get; }

        public Script(Enemy enemy)
        {
            Enemy = enemy;
        }

        public void RandomActOnHero(Hero.Hero hero) 
        {
            int random = new Random().Next();
            switch(random % 3)
            {
                case 0:
                    Enemy.BattleActions.Attack(hero);
                    break;
                case 1:
                    Enemy.BattleActions.Magics[0].Cast(hero);
                    break;
                case 2:
                    Enemy.BattleActions.Magics[1].Cast(hero);
                    break;
            }
        }
    }
}
