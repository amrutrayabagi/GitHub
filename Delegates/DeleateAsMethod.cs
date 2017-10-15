using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void NotifyDelegate(string message);


    public class SaveFileToDatabase
    {
        public void Start(NotifyDelegate nd)
        {
            string message = string.Empty;
            if (DateTime.Now.Second > 30)
            {
                message = "Success";

            }
            else
                message = "failure";


            nd.Invoke(message);
        }

    }
}
