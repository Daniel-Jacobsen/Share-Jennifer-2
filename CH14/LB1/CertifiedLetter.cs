using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14LB1
{
    public class CertifiedLetter : Letter
    {
        //INSTANCE FIELD
        protected string _trackingNumber;
        //CONSTRUCTORS
        public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber)
        {
            _recipient = recipient;
            _sentDate = sentDate;
            _trackingNumber = trackingNumber; 
        }
        //EMPTY CONSTRUCTORS
     
        public CertifiedLetter()
        {

        }
        public string TrackingNumber
        {
            get => _trackingNumber;
        }

        public override Double Price
        {
            get => .65;
        }
        public override string ToString()
        {
            return base.ToString() + "," + _trackingNumber;
        }
    }
}
