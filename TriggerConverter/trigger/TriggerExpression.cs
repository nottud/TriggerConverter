using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerExpression(string expression)
    {
        public string Expression { get; set; } = expression;
    }
}
