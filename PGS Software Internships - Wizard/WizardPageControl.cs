using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace PGS_Software_Internships___Wizard
{
    public partial class WizardPageControl : UserControl
    {

        public string Info
        {
            get { return this.RtbxInfo.Text;  }
            set { this.RtbxInfo.Text = value; }
        }

        public string Title
        {
            get { return this.LblTitle.Text; }
            set { this.LblTitle.Text = value; }
        }

        public string Data
        {
            get { return this.RtbxData.Text;  }
            private set { this.RtbxData.Text = value; }
        }

        public string RegexPattern { get; set; }
        
        public string Page
        {
            get { return this.LblPage.Text; }
            set { this.LblPage.Text = value; }
        }

        public event EventHandler GoBack;
        public event EventHandler GoForward;

        public WizardPageControl()
        {
            InitializeComponent();
            this.RtbxData.TextChanged += RtbxData_TextChanged;
        }

        /// <summary>
        /// Focuses on text box for ease of input
        /// </summary>
        public void FocusData()
        {
            this.RtbxData.Focus();
            this.RtbxData.ScrollToCaret();
        }

        /// <summary>
        /// Chects if data provided by user is valid with specified regex pattern
        /// </summary>
        public void ValidateData()
        {
            string text = Data.Trim();
            bool match = Regex.IsMatch(text, RegexPattern);

            if (!match)
                RtbxData.BackColor = Color.LightPink;
            else if (match)
                RtbxData.BackColor = Color.LightGreen;
        }

        /// <summary>
        /// Value validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RtbxData_TextChanged(object sender, EventArgs e)
        {
            ValidateData();
        }
        
        /// <summary>
        /// Setups page view based on provided parameters
        /// </summary>
        /// <param name="title"></param>
        /// <param name="info"></param>
        /// <param name="data"></param>
        /// <param name="regexPattern"></param>
        /// <param name="number"></param>
        /// <param name="count"></param>
        public void Setup(string title, string info, string data, string regexPattern, int number, int count)
        {
            this.RegexPattern = regexPattern;
            this.Title = title;
            this.Info = info;
            this.Data = data;
            this.Page = string.Format("Strona {0} z {1}", number, count);
            
            BtnBack.Visible = (number > 1);
            BtnForward.Text = (number == count) ? "ZAKOŃCZ" : "DALEJ";

            ValidateData();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (this.GoForward != null)
                this.GoForward(this, e);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (this.GoBack != null)
                this.GoBack(this, e);
        }
    }
}
