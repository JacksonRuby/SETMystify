using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SETMystify
{
    class threadObj
    {

        private Thread thisThread;
        private LINE thisLine;

        public Thread ThisThread
        {
            get { return thisThread; }
            set { thisThread = value; }
        }

        public LINE ThisLine
        {
            get { return thisLine; }
            set { thisLine = value; }
        }
        public threadObj(LINE lineObj, Thread newThread)
        {
            thisThread = newThread;
            thisLine = lineObj;
        }
    }
}
