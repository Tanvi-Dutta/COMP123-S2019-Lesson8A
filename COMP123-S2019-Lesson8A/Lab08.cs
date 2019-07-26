﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8A
{
    public partial class Lab08 : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }


        /// <summary>
        /// this is the default constructor.
        /// </summary>
        public Lab08()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for Lab08 from load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab08_Load(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// This is the event handler for the submit button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            UserAge = float.Parse(AgeTextBox.Text);

            OutputLabel.Text = UserName + " " + UserAge;

            ClearForm();
        }

        /// <summary>
        /// This method clears the textboxes on the form and resets other properties
        /// </summary>
        private void ClearForm()
        {
            NameTextBox.Clear();
            AgeTextBox.Clear();
            SubmitButton.Enabled = false;
        }

        /// <summary>
        /// This is the event handler for the AgeTextBox TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
                
            }
            
        }

        /// <summary>
        /// This is the event handler for the name textbox  TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length >= 2) ? true : false;
        }
    }
}
