using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class PingService //class is reference type
    {
        public int Data {  get; set; } //class property
        public byte[] Buffer { get; set; } // class property
        public int Timeout { get; set; } // class property
        public string Address {  get; set; } // class property
        public Ping pingSender{ get; set; } // class property
        public PingOptions pingOptions { get; set; } //class property

        public PingService() //this is a constructor
        {
            Timeout = 120;
            Address = "4.2.2.2";
            Buffer = Encoding.ASCII.GetBytes("Learn C# OOP");
            pingSender = new Ping();
            pingOptions = new PingOptions();
            pingOptions.DontFragment = true;

        }

        public bool SendPing()
        {
          PingReply reply = pingSender.Send(Address,Timeout,Buffer,pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Address: {reply.Address}");
                Console.WriteLine($"RoundTrip time: {reply.RoundtripTime}");
                return true;
            }
            else
            {
                return  false;
            }
        }

    }
}
