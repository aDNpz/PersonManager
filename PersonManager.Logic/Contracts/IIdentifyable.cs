using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager.Logic.Contracts
{
    public interface IIdentifyable
    {
        int Id { get; internal set; }
    }
}
