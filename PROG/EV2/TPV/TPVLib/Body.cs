using System.ComponentModel.DataAnnotations;

namespace TPVLib
{
    public class Body
    {
        public TicketLine[]? Lines { get; set; }

        public void AddLine(TicketLine line)
        {
            if (line == null)
                return;
            if (Lines == null)
                Lines = new TicketLine[0];

            int count = Lines.Length;
            TicketLine[] aux= new TicketLine[++count];
            for (int i = 0; i < count; i++)
            {
                aux[i] = Lines[i];
            }
            aux[count-1] = line;
            Lines = aux;
        }
    }
}