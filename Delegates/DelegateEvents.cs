using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    /// <summary>
    /// In this class i have created a delegate of type decimal and accepting parameters of decimal type.
    /// Here i am going to demonstrate how a  event is created using the delegates.(Usually subscriber and consumer pattern
    /// I have created an event for price changed,if any change in the object price value, then i am raising an event.
    /// </summary>
    /// 
    public delegate decimal PriceChangedHandler(decimal oldPrice, decimal newPrice);
    class DelegateEvents
    {

        public event PriceChangedHandler PriceChanged;

        private decimal _Price;

        public decimal Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (_Price == value)
                {
                    return;
                }
                else
                {
                    decimal oldPrice = _Price;
                    _Price = value;
                    if (_Price != null)
                    {
                        PriceChanged(oldPrice, value);
                    }
                }
            }

        }
    }
}
