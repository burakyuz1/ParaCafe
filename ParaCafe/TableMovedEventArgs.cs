using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaCafe
{
    public class TableMovedEventArgs : EventArgs
    {
        public TableMovedEventArgs(int oldTable, int newTable)
        {
            OldTable = oldTable;
            NewTable = newTable;
        }
        public int OldTable { get; }
        public int NewTable { get; }
    }
}
