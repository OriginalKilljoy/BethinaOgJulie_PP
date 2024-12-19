using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethinaOgJulie_PP
{
    internal class Magic
    {
        public string SpellName;
        public string Effect;

        public Magic(string spellname, string effect)
        {
            SpellName = spellname;
            Effect = effect;
        }

        public Magic()
        {
            
        }

        public string DoMagic(string item, Character character)
        {
            string sentence = "";
            for (int i = 0; i < Effect.Length; i++)
            {
                if (Effect[i] == '_')
                {
                    sentence += item;
                }
                else if (Effect[i] == '-')
                {
                    sentence += character.Patronus;
                }
                else
                {
                    sentence += Effect[i];
                }
         
            }
            return sentence;
        }

    }
}
