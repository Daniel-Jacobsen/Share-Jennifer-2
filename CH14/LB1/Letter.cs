using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14LB1
{
   public class Letter
    {
        //INstance fields
        protected string _recipient;
        protected DateTime _sentDate;
       
        //CONSTRUCTOR
        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }
        public Letter()
        {

        }

        public override string ToString()
        {
            return $"{_sentDate.ToShortDateString()}, " +
                $"{_recipient}, {Price.ToString("C")}";
        }
        public string Recipient
        {
            get => _recipient;
        }

        public DateTime SentDate
        {
            get => _sentDate;
        }

        public virtual  double Price
        {
            get => .5;
        }

    }



}
