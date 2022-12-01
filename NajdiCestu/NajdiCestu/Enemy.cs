using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Enemy : Cube
    {
        public Enemy(Form1 form) : base(form)
        {
            p.BackColor = Color.Red;
        }
        public static void CreateEnemy(int number, Form1 form) {
            for (int i = 0; i < number; i++)
            {
                new Enemy(form);
            }
        }
    }
}
