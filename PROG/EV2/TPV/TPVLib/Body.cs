using System.ComponentModel.DataAnnotations;

namespace TPVLib
{
    public class Body
    {
        public TicketLine[]? lines { get; set; }

        public void AddLine(TicketLine line)
        {
            if (line == null)
                return;
            if (lines == null)
                lines = new TicketLine[0];

            int count = lines.Length;
            TicketLine[] aux= new TicketLine[++count];
            for (int i = 0; i < count; i++)
            {
                aux[i] = lines[i];
            }
            aux[count-1] = line;
            lines = aux;
        }
    }
}