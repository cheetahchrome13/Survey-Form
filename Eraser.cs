using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7SurveyForm
{
    /// <summary>
    /// Class: Eraser
    /// Task: Resets/clears all controls in Form
    /// </summary>
    class Eraser
    {
        /// <summary>
        /// Iterate through Controls in Form and reset/clear all
        /// </summary>
        /// <param name="form"></param>
        public static void ClearForm(Control form)
        {
            foreach (Control control in form.Controls)
            {
                // Reset calendar
                if (control is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)control;
                    mc.SetDate(DateTime.Now);
                }

                // Reset Controls in GroupBox 
                if (control is GroupBox)
                {
                    GroupBox gbx = (GroupBox)control;
                    foreach(Control c in gbx.Controls)
                    {
                        if(c is RadioButton)
                        {
                            RadioButton rad = (RadioButton)c;
                            rad.Checked = false;
                        }
                        if(c is CheckBox)
                        {
                            CheckBox chk = (CheckBox)c;
                            chk.Checked = false;
                        }
                    }
                }

                // Reset NumericUpDown to Maximum
                if (control is NumericUpDown)
                {
                    NumericUpDown num = (NumericUpDown)control;
                    num.Value = num.Maximum;
                }

                // Clear TextBox
                if (control is TextBox)
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = null;
                }
            }
        }
    }
}
