using Core.Domain.Forums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Planboard
{
    public class PlanBoard
    {
        public List<Column> Columns { get; set; }
        public Forum Forum { get; set; }

        public PlanBoard()
        {
            Columns = new List<Column> {
                new Column("Todo"),
                new Column("Doing"),
                new Column("ReadyForTesting"),
                new Column("Testing"),
                new Column("Done")
            };
            Forum = new Forum();
        }

        public void addColumns(Column column)
        {
            Columns.Add(column);
        }

        public void removeColumns(Column column)
        {
            Columns.Remove(column);
        }

        public void MoveColumn(Column column, int newIndex)
        {
            if (newIndex < 0 || newIndex > Columns.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            int currentIndex = Columns.IndexOf(column);
            Columns.RemoveAt(currentIndex);
            Columns.Insert(newIndex, column);


        }

    }
}
