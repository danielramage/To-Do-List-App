using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List_App
{
    internal class ListOfTasks
    {

        List<ListEntry> tasks;

        public ListOfTasks() {
        
            tasks = new List<ListEntry>();
        
        }

        public void AddTask(String entry)
        {

            tasks.Add(new ListEntry(entry));

        }

        public void RemoveTask(int index)
        {

            tasks.RemoveAt(index);

        }

        public void UpdateTask(int index, String entry)
        {

            tasks[index].SetEntry(entry);

        }

        public List<ListEntry> GetList()
        {

            return tasks;

        }

        public int ListSize()
        {

            return tasks.Count;

        }

    }
}
