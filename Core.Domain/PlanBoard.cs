using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class PlanBoard
    {
        public List<Column> Columns { get; set; }

        public PlanBoard() { 
            this.Columns = new List<Column>();
        }

        public void addColumns(Column column)
        {
            this.Columns.Add(column);
        }

        public void removeColumns(Column column)
        {
            this.Columns.Remove(column);
        }

        public void MoveColumn(Column column, int newIndex)
        {
            if (newIndex < 0 || newIndex > Columns.Count) {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            int currentIndex = this.Columns.IndexOf(column);
            this.Columns.RemoveAt(currentIndex);
            Columns.Insert(newIndex, column);


        }

    }
}
