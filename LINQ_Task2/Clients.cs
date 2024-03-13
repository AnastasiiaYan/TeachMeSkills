using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Task2
{
    internal class Clients
    {
        internal int code;
        internal int year;
        internal int month;
        internal int trainingDuration;

        public Clients(int code, int year, int month, int trainingDuration)
        {
            this.code = code;
            this.year = year;
            this.month = month;
            this.trainingDuration = trainingDuration;
        }        
    }
}