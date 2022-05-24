using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._2
{
    public abstract class Banks_piece
    {
        public int GUID { get; set; }
        public Banks_piece()
        {

        }
        public Banks_piece(int new_guid)
        {
            this.GUID = new_guid;
        }
    }
}
