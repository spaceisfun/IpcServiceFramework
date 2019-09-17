using System;
using System.Collections.Generic;
using System.Text;

namespace IpcServiceFramework.Tcp
{
    public class TcpConcurrencyOptions
    {
        public int MaximumConcurrentCalls;

        public TcpConcurrencyOptions(int maximumConcurrentCalls)
        {
            this.MaximumConcurrentCalls = maximumConcurrentCalls;
        }
    }
}
