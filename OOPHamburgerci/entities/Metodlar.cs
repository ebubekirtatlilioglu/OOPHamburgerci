using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace OOPHamburgerci.entities
{
    public class Metodlar
    {
        public static void Temizle(ControlCollection gelenKontroller)
        {
            foreach (Control item in gelenKontroller)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
                else if (item is ComboBox)
                    ((ComboBox)item).SelectedIndex = 0;
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = ((NumericUpDown)item).Minimum;
                }
                else if (item is RadioButton)
                {
                    if (((RadioButton)(item)).Name.Contains("Kucuk"))
                    {
                        ((RadioButton)item).Checked = true;
                    }
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is GroupBox)
                    Temizle(((GroupBox)item).Controls);
                else if (item is FlowLayoutPanel)
                    Temizle(((FlowLayoutPanel)item).Controls);
            }
        }
    }
}
