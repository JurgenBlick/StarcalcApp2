using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StarcalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void CreateMyStatusBar()
        {
            // Create a StatusBar control.
            StatusBar statusBar1 = new StatusBar();
            // Create two StatusBarPanel objects to display in the StatusBar.
            StatusBarPanel panel1 = new StatusBarPanel();
            StatusBarPanel panel2 = new StatusBarPanel();

            // Display the first panel with a sunken border style.
            panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            // Initialize the text of the panel.
            panel1.Text = "Ready...";
            // Set the AutoSize property to use all remaining space on the StatusBar.
            panel1.AutoSize = StatusBarPanelAutoSize.Spring;

            // Display the second panel with a raised border style.
            panel2.BorderStyle = StatusBarPanelBorderStyle.Raised;

            // Create ToolTip text that displays time the application was started.
            panel2.ToolTipText = "Started: " + System.DateTime.Now.ToShortTimeString();
            // Set the text of the panel to the current date.
            panel2.Text = System.DateTime.Today.ToLongDateString();
            // Set the AutoSize property to size the panel to the size of the contents.
            panel2.AutoSize = StatusBarPanelAutoSize.Contents;
        }
        // Display panels in the StatusBar control.


        private void button1_Click(object sender, EventArgs e)

        {
            ////////////////////////////Test

             
            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text= textBox1.Text  + "A";
                textBox2.Text = textBox2.Text  + "Th";
               

            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "2")
            {
                
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";


            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Aries" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "S";
            }
            //throw new System.NotImplementedException();

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Taurus" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            //Gemini
            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if ((comboBox1.SelectedItem.ToString() == "Gemini") & (comboBox2.SelectedItem.ToString() == "24"))
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Gemini" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "SQ";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Cancer" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Leo" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Virgo" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Libra" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "4")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "h";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Scorpio" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "4")
               
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Sagittarius" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }
if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "O";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }
 if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "4")
               
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Capricorn" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }
             if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "H";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }
 if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "4")
               
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "L";
                textBox2.Text = textBox2.Text + "K";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Aquarius" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }
             if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "1")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
                // textBox4.Text = comboBox1.SelectedItem.ToString();
            }
 if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "2")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "3")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "4")
               
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "5")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "6")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "7")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "8")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "9")
            {
                textBox1.Text = textBox1.Text + "T";
                textBox2.Text = textBox2.Text + "N";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "10")
            {
                textBox1.Text = textBox1.Text + "I";
                textBox2.Text = textBox2.Text + "M";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "11")

            {
                textBox1.Text = textBox1.Text + "K";
                textBox2.Text = textBox2.Text + "L";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "12")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "13")
            {
                textBox1.Text = textBox1.Text + "M";
                textBox2.Text = textBox2.Text + "I";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "14")
            {
                textBox1.Text = textBox1.Text + "N";
                textBox2.Text = textBox2.Text + "T";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "15")
            {
                textBox1.Text = textBox1.Text + "S";
                textBox2.Text = textBox2.Text + "Ch";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "16")
            {
                textBox1.Text = textBox1.Text + "O";
                textBox2.Text = textBox2.Text + "Z";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "17")
            {
                textBox1.Text = textBox1.Text + "P";
                textBox2.Text = textBox2.Text + "V";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "18")
            {
                textBox1.Text = textBox1.Text + "Tz";
                textBox2.Text = textBox2.Text + "H";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "19")
            {
                textBox1.Text = textBox1.Text + "Q";
                textBox2.Text = textBox2.Text + "D";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "20")
            {
                textBox1.Text = textBox1.Text + "R";
                textBox2.Text = textBox2.Text + "G";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "21")
            {
                textBox1.Text = textBox1.Text + "Sh";
                textBox2.Text = textBox2.Text + "B";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "22")
            {
                textBox1.Text = textBox1.Text + "Th";
                textBox2.Text = textBox2.Text + "A";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "23")
            {
                textBox1.Text = textBox1.Text + "A";
                textBox2.Text = textBox2.Text + "Th";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "24")
            {
                textBox1.Text = textBox1.Text + "B";
                textBox2.Text = textBox2.Text + "Sh";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "25")
            {
                textBox1.Text = textBox1.Text + "G";
                textBox2.Text = textBox2.Text + "R";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "26")
            {
                textBox1.Text = textBox1.Text + "D";
                textBox2.Text = textBox2.Text + "Q";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "27")
            {
                textBox1.Text = textBox1.Text + "H";
                textBox2.Text = textBox2.Text + "Tz";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "28")
            {
                textBox1.Text = textBox1.Text + "V";
                textBox2.Text = textBox2.Text + "P";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "29")
            {
                textBox1.Text = textBox1.Text + "Z";
                textBox2.Text = textBox2.Text + "O";
            }

            if (comboBox1.SelectedItem.ToString() == "Pisces" && comboBox2.SelectedItem.ToString() == "30")
            {
                textBox1.Text = textBox1.Text + "Ch";
                textBox2.Text = textBox2.Text + "S";
            }

            textBox5.Text = comboBox1.SelectedItem.ToString() + " ";
            textBox4.Text = comboBox2.SelectedItem.ToString() + " Degree(s)";
            textBox6.Text = textBox1.Text ;
            
        }
 
        

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Want to exit", "StarCalc", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            textBox1.Text = textBox1.Text + "AL";
            textBox2.Text = textBox2.Text + "AL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
            StatusBar statusBar1 = new StatusBar();
            StatusBarPanel panel1 = new StatusBarPanel();
            StatusBarPanel panel2 = new StatusBarPanel();
            panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            panel1.Text = "The Magical Apprentice";
            statusBar1.Show();

        }

    }
}