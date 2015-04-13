using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Power4
{
    class Power4
    {
        private IPlayer p1;
        private IPlayer p2;
        private IArrayFormatter format;
        private IArrayStock stock;
        private CheckEnd end;
        private IOutput output;
        private IInput input;

        public Power4(IPlayer p1, IPlayer p2, IArrayFormatter format, IArrayStock stock, CheckEnd end, IOutput output, IInput input)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.format = format;
            this.stock = stock;
            this.end = end;
            this.output = output;
            this.input = input;
        }

        internal void run()
        {
            throw new NotImplementedException();
        }
    }
}
