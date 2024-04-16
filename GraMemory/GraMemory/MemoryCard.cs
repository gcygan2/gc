using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraMemory
{
    public class MemoryCard : Label
    {
        public Image Tyl;
        public Image Obrazek;
        public Guid Id;
        public MemoryCard(Guid id, string tylPath, string obrazekPath)
        {
            Id = id;
            Obrazek = Image.FromFile (obrazekPath);
            BackgroundImageLayout = ImageLayout.Stretch;
        }
        public void Zakryj ()
        {
            BackgroundImage = Tyl;
        }
        public void Odkryj()
        {
            BackgroundImage = Obrazek;
        }
    }
}
