using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpLib
{
    public class Father : Talents
    {
        //permitting different logic in derived 
        public virtual string Settle()
        {
            return "Get a government job, retire by 60 and settle in native";
        }
        public string GetMarried()
        {
            return "Match horoscope, marry person from same religion, caste, settle in joint family";
        }
        public override string Drawing()
        {
            return "Drwaing portraits, Tanjore paintings";
        }
        public override string WhatIsDating()
        {
            return "Meeting special friend at restaurant";
        }
        
    }
    //abstract == Incomplete
    public abstract class Talents
    {
        public abstract string WhatIsDating();
        public abstract string Drawing();



    }

    public class Child : Father
    {
        public override string Drawing()
        {
            return "drawing abstract art, mandala art";
        }
        public override string WhatIsDating()
        {
            return "use tinder app";
        }
        public override string Settle()
        {
            string howToLive = "Get a fat salaried job in fortune 500 company, visit different countries, live outside hometown";
            howToLive = $"{howToLive} and later follow this: {base.Settle()}";
            return howToLive;

        }
        new public string GetMarried()
        {
            return "Register marriage, surprise parents and settle abroad";
        }

    } 
}
