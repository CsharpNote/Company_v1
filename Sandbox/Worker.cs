using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        private String skill;

        public Worker(String name, int salaryPerMonth, String skill)
            : base(name, salaryPerMonth)
        {
            this.skill = skill;
        }

        public String GetSkill()
        {
            return skill;
        }

        public void SetSkill(String skill)
        {
            this.skill = skill;
        }
    }
}
