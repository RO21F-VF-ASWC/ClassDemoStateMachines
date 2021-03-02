using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemoStateMachines
{
    public interface IStateMachine<Tin>
    {
        bool NextInput(Tin input);
    }
}
