using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeheveManagementSystem
{
    class Bee
    {
        public virtual float CostPerShift {  get; }
        public string Job {  get; private set; }
        public Bee(string job)
        {
            Job = job;
        }
        public void WorkTheNextShift()
        {
            if (HoneyVault.ConsumeHoney(CostPerShift))
            {
                DoJob();
            }
        }
        protected virtual void DoJob() { }
    }
}
