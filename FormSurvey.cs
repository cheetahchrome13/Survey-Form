using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Project: Survey Form
/// Tasks: 1) Creates an instance of Form with various Controls
///        2) Takes user mouse and key input
///        3) Displays results of user survey
/// Dev: Justin Mangan
/// Date: 16 April 2018
/// </summary>
namespace Project7SurveyForm
{
    /// <summary>
    /// Class: FormSurvey
    /// Task: Creates a Form with custom fields, controls, and methods
    /// </summary>
    public partial class FormSurvey : Form
    {
        /// <summary>
        /// Form instantiates itself
        /// </summary>
        public FormSurvey()
        {
            InitializeComponent();
        }

        string name;
        string date;
        string meal;
        string rating;
        string comments;
        static List<string> mealItems = new List<string>();

        /// <summary>*************************************************
        /// Submit Button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>++++++++++++++++++++++++++++++++++
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get customer name       
            name = txtBxName.Text == "" ? "Anonymous customer" : "Customer " + txtBxName.Text.ToString();
              
            // Get date
            date = monthCalendar.SelectionRange.Start.ToShortDateString();

            // Iterate through groupBox to find checked radio
            foreach (RadioButton rad in groupService.Controls)
            {
                if (rad.Checked)
                {
                    meal = rad.Text.ToString().ToLower();
                }
            }
            // Iterate through checkedListBox to find all checked instances
            foreach (CheckBox chk in groupMenuItems.Controls)
            {
                if (chk.Checked)
                {
                    mealItems.Add(chk.Text.ToString().ToLower());
                }
            }
            // Get rating from NumericUpDown 
            rating = numRating.Value.ToString();

            // Get comments from textBox
            comments = txtBxComment.Text.ToString();

            // Populate native TextBox Array with strings
            txtBxResults.Lines = new string[] {
                String.Format("{0} ate {1} at Mel's Diner on {2}.", name, meal, date),
                String.Format("Customer had the following items as part of their meal: {0}.", getStringFromList()),
                String.Format("On a scale of 1-5, customer rated their dining experience as a \"{0}\".", rating),
                String.Format(txtBxComment.Text == "" ? "Customer left no comments" : "Customer left the following comments:\r\n\"{0}\"", comments)
            };
            
            // Display customer input in TextBox
            Height = 900;
            lblResults.Show();
            txtBxResults.Show();
        }

        /// <summary>
        /// Reverses and iterates through List of meal items 
        /// </summary>
        /// <returns></returns>
        public static string getStringFromList()
        {
            mealItems.Reverse();
            string result = "";
            for(int i = 0; i < mealItems.Count; i++)
            {
                result = i < mealItems.Count - 1 ? result + mealItems[i] + ", " : result + mealItems[i]; 
            }
            return result;
        }

        /// <summary>
        /// Clear Button handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            mealItems.Clear();
            Height = 780;
            Eraser.ClearForm(this);
            lblResults.Hide();
            txtBxResults.Hide();
            txtBxName.Focus();

            /* This code created a new Form to reset Controls but left 
             * program in an endless loop when you closed the form*/
            //FormSurvey NewForm = new FormSurvey();
            //NewForm.Show();
            //this.Dispose(false);
        }
    
        /// <summary>
        /// Initialize settings on load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSurvey_Load(object sender, EventArgs e)
        {
            Height = 780;
            monthCalendar.MaxSelectionCount = 1;
            numRating.Minimum = 1;
            numRating.Maximum = 5;
        }
    }
}
