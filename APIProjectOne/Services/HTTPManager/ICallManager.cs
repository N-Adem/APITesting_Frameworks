using System;
using System.Collections.Generic;
using System.Text;

namespace APIProjectOne
{
    public interface ICallManager
    {
        string Response { get; set; }
        string Status { get; set; }
    }
}
