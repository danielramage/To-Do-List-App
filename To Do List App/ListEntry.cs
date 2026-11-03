using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_App
{
    internal class ListEntry
    {

        String entry;
        bool isComplete;

        public ListEntry(String e) 
        { 
        
            entry = e;
            isComplete = false;
        
        }

        public void SetEntry(String e)
        {
            entry = e;
        }

        public void SetIsComplete(bool complete)
        {
            isComplete = complete;
        }

        public String GetEntry() {
        
            return entry;
        
        }

        public bool GetIsComplete()
        {

            return isComplete;

        }

    }
}
