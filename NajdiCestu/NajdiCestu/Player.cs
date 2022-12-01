using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Player : Cube
    {
        string name; 
        
        public Player(Form1 form, string name) : base(form) {
            this.name = name;
            p.Location = new Point(form.Width / 2 - p.Width, form.Height / 2 - p.Height -10);
        }
    }
}
