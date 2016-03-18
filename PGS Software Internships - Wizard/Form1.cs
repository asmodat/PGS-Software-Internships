using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PGS_Software_Internships___Wizard
{
    public partial class Form1 : Form
    {
        string stepGreeting = "Proszę w poniższym polu umieścić ";
        string stepFarewell = 
@", a następnie nacisnąć przycisk 'DALEJ' lub 'ZAKOŃCZ' aby kontynuować. 
Przycisk 'WSTECZ' pozwala na cofnięcie się do poprzedniego kroku w celu edycji wprowadzonych wcześniej informacji.
Jeśli podane przez Państwa informacje są nietypowego formatu (i prawdopodobnie zawierają błąd) lub zbyt krótkie, wtedy pole wprowadzania danych zapali się na czerwono, w przeciwnym wypadku na zielono, jeśli formt danych nie budzi podejrzeń.";
        string[] stepNames = new string[] { "Imię","Nazwisko","Adres Zamieszkania", "Numer Telefonu" };
        string[] regexPatterns = new string[] 
        {
            @"^[\p{L} \.'\-]{1,1024}$",
            @"^[\p{L} \.'\-]{1,1024}$",
            @"^[(\s*(\S)\s*)]{1,2048}$",
            @"^[\+]{0,1}[\-\b\)\({0,1}\s\d]{6,1024}$" };

        List<string> pageSteps = new List<string>();
        List<string> pageResults = new List<string>();

        int pageIndex = 0;
        int pageCount = 0;

        private void Initialize()
        {
            foreach (string s in stepNames)
                pageSteps.Add(stepGreeting + s + stepFarewell);

            this.pageCount = pageSteps.Count;
            pageResults = new string[this.pageCount].ToList();

            this.WizardPage.GoBack += WizardPage_GoBack;
            this.WizardPage.GoForward += WizardPage_GoForward;
            this.TbCntrlMain.SelectedIndexChanged += TbCntrlMain_SelectedIndexChanged;

            pageIndex = 0;
            this.SetupPage(pageIndex);
            this.UpdateSummary();
        }

        private void TbCntrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SavePage();
            this.UpdateSummary();
        }

        public bool summaryIsValid { get; private set; }

        /// <summary>
        /// Updates Summary page
        /// </summary>
        private void UpdateSummary()
        {
            string nl = @" \line ";
            string summary = @"{\rtf1\ansi ";

            for (int i = 0; i < pageCount; i++)
                summary += @" \b " + stepNames[i] + @": \b0  \line " + pageResults[i] + nl + nl;

            summary = summary.Replace("\n", nl);
            summary = summary.Substring(0, summary.Length - nl.Length);

            RtbxSummary.Rtf = summary + @" }";

            summaryIsValid = true;
            for (int i = 0; i < pageResults.Count; i++)
            {
                if (pageResults[i] == null || !Regex.IsMatch(pageResults[i], regexPatterns[i]))
                {
                    summaryIsValid = false;
                    break;
                }
            }
            
            if (!summaryIsValid)
                RtbxSummary.BackColor = Color.LightPink;
            else if (summaryIsValid)
                RtbxSummary.BackColor = Color.LightGreen;
        }


        private void SetupPage(int index)
        {
            this.WizardPage.Setup(
                "Wprowadź " + stepNames[index], 
                pageSteps[index], 
                pageResults[index],
                regexPatterns[index], 
                index + 1, 
                pageCount);
            WizardPage.FocusData();
        }

        /// <summary>
        /// Trims and saves in 'pageResults' list data provided by the user.
        /// </summary>
        private void SavePage()
        {
            pageResults[pageIndex] = this.WizardPage.Data.Trim();
        }

        private void WizardPage_GoForward(object sender, EventArgs e)
        {
            this.SavePage();

            if (pageIndex < pageCount - 1)
                this.SetupPage(++pageIndex);
            else if(pageIndex == pageCount - 1)
                TbCntrlMain.SelectedIndex = 2;

            this.UpdateSummary();
        }

        private void WizardPage_GoBack(object sender, EventArgs e)
        {
            this.SavePage();

            if (pageIndex > 0)
                this.SetupPage(--pageIndex);
            
            this.UpdateSummary();
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Initialize();
        }

        private void BtnSTART_Click(object sender, EventArgs e)
        {
            TbCntrlMain.SelectedIndex = 1;
            WizardPage.FocusData();
        }

        private void BtnBACK_Click(object sender, EventArgs e)
        {
            TbCntrlMain.SelectedIndex = 1;
            WizardPage.FocusData();
        }


        private void BtnEXIT_Click(object sender, EventArgs e)
        {
            string message = "";

            if (!summaryIsValid) message = "Wygląda na to, że niektóre z wprowadzonych danych są niepoprawne.";
            else message = "Wygląda na to, że wprowadzone dane są poprawne.";

            message += "\nCzy sprawdził(eś/aś) poprawność udzielonych informacji i na pewno chcesz zakończyć działanie programu ?";
            var result = MessageBox.Show(message, "UWAGA !", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

       
    }
}
