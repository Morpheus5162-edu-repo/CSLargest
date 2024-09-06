using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Activity
{
    public partial class CSLargest : Form
    {
        public CSLargest()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.LblFirstValue = new System.Windows.Forms.Label();
            this.TxtFvalue = new System.Windows.Forms.TextBox();
            this.TxtSvalue = new System.Windows.Forms.TextBox();
            this.LblSecondValue = new System.Windows.Forms.Label();
            this.TxtTvalue = new System.Windows.Forms.TextBox();
            this.LblThirdValue = new System.Windows.Forms.Label();
            this.btnIdentify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblFirstValue
            // 
            this.LblFirstValue.AutoSize = true;
            this.LblFirstValue.Location = new System.Drawing.Point(56, 46);
            this.LblFirstValue.Name = "LblFirstValue";
            this.LblFirstValue.Size = new System.Drawing.Size(56, 13);
            this.LblFirstValue.TabIndex = 0;
            this.LblFirstValue.Text = "First Value";
            // 
            // TxtFvalue
            // 
            this.TxtFvalue.Location = new System.Drawing.Point(118, 43);
            this.TxtFvalue.Name = "TxtFvalue";
            this.TxtFvalue.Size = new System.Drawing.Size(82, 20);
            this.TxtFvalue.TabIndex = 1;
            this.TxtFvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtSvalue
            // 
            this.TxtSvalue.Location = new System.Drawing.Point(118, 69);
            this.TxtSvalue.Name = "TxtSvalue";
            this.TxtSvalue.Size = new System.Drawing.Size(82, 20);
            this.TxtSvalue.TabIndex = 3;
            this.TxtSvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblSecondValue
            // 
            this.LblSecondValue.AutoSize = true;
            this.LblSecondValue.Location = new System.Drawing.Point(38, 72);
            this.LblSecondValue.Name = "LblSecondValue";
            this.LblSecondValue.Size = new System.Drawing.Size(74, 13);
            this.LblSecondValue.TabIndex = 2;
            this.LblSecondValue.Text = "Second Value";
            // 
            // TxtTvalue
            // 
            this.TxtTvalue.Location = new System.Drawing.Point(118, 95);
            this.TxtTvalue.Name = "TxtTvalue";
            this.TxtTvalue.Size = new System.Drawing.Size(82, 20);
            this.TxtTvalue.TabIndex = 5;
            this.TxtTvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LblThirdValue
            // 
            this.LblThirdValue.AutoSize = true;
            this.LblThirdValue.Location = new System.Drawing.Point(51, 98);
            this.LblThirdValue.Name = "LblThirdValue";
            this.LblThirdValue.Size = new System.Drawing.Size(61, 13);
            this.LblThirdValue.TabIndex = 4;
            this.LblThirdValue.Text = "Third Value";
            // 
            // btnIdentify
            // 
            this.btnIdentify.Location = new System.Drawing.Point(59, 134);
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(126, 21);
            this.btnIdentify.TabIndex = 6;
            this.btnIdentify.Text = "Find The largest Value";
            this.btnIdentify.UseVisualStyleBackColor = true;
            this.btnIdentify.Click += new System.EventHandler(this.button1_Click);
            // 
            // CSLargest
            // 
            this.ClientSize = new System.Drawing.Size(249, 208);
            this.Controls.Add(this.btnIdentify);
            this.Controls.Add(this.TxtTvalue);
            this.Controls.Add(this.LblThirdValue);
            this.Controls.Add(this.TxtSvalue);
            this.Controls.Add(this.LblSecondValue);
            this.Controls.Add(this.TxtFvalue);
            this.Controls.Add(this.LblFirstValue);
            this.Name = "CSLargest";
            this.Text = "CSLargest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int firstValue, secondValue, thirdValue;

            bool isFirstValid = int.TryParse(TxtFvalue.Text, out firstValue);
            bool isSecondValid = int.TryParse(TxtSvalue.Text, out secondValue);
            bool isThirdValid = int.TryParse(TxtTvalue.Text, out thirdValue);

            if (!isFirstValid || !isSecondValid || !isThirdValid)
            {
                //Message box to show the error
                MessageBox.Show("Please enter valid integers in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Decision structure to clear the textbox of
                //the invalid input so that user can re-enter ASAP
                if (!isThirdValid)
                {
                    TxtTvalue.Text = "";
                    TxtTvalue.Focus();
                }

                if (!isSecondValid)
                {
                    TxtSvalue.Text = "";
                    TxtSvalue.Focus();
                }

                if (!isFirstValid)
                {
                    TxtFvalue.Text = "";
                    TxtFvalue.Focus();
                }

                return;
            }

            //Decision to identify the largest value
            int largestValue = firstValue;

            if(secondValue > largestValue)
            {
                largestValue = secondValue;
            }
            
            if(thirdValue > largestValue)
            {
                largestValue = thirdValue;
            }

            //Message box to show the output
            MessageBox.Show("The Lagest Value is: " + largestValue.ToString(), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Clear the input fields after showing the result
            ClearAllInputs();
        }

        // Method to clear all of the textboxes
        private void ClearAllInputs()
        {
            TxtFvalue.Text = "";
            TxtSvalue.Text = "";
            TxtTvalue.Text = "";
            TxtFvalue.Focus();  // Optionally set focus back to the first input field
        }
    }
}