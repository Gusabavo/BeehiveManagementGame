using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeheveManagementSystem
{
    internal interface IWorker
    {
        string Job { get; }
        void WorkTheNextShift();
    }
}
