using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAP_Dictionary_Service.DictionaryService;
using System.Net;

namespace SOAP_Dictionary_Service
{
    public partial class Form1 : Form
    {
        int totalDef = -1;
        int currDef = 0;
        string[] definitions;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetDefinition_Click(object sender, EventArgs e)
        {
            try
            {
                String word = txtWord.Text;

                DictionaryService.DictService service = new DictionaryService.DictService();

                WordDefinition defintion = service.Define(word);

                if (defintion.Definitions.Length == 0)
                {
                    txtDefintion.Text = "No definition for " + word;
                }
                else
                {
                    totalDef = defintion.Definitions.Count();
                    definitions = new string[totalDef + 1];
                    currDef = 0;
                    int i = 0;
                    foreach (Definition def in defintion.Definitions)
                    {
                        definitions[i] = "" + (def.WordDefinition);
                        i++;
                    }
                    txtDefintion.Text = "" + definitions[currDef].ToString();
                    labelPageNum.Text = (currDef + 1) + "/" + totalDef;
                }

            }
            catch (WebException)
            {
                MessageBox.Show("Webservice is down.");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (totalDef > 0)
            {
                if (currDef == totalDef - 1)
                {
                    currDef = 0;
                }
                else
                {
                    currDef = currDef + 1;
                }
                txtDefintion.Text = "" + definitions[currDef];
                labelPageNum.Text = (currDef + 1) + "/" + totalDef;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (totalDef > 0)
            {
                if (currDef == 0)
                {
                    currDef = totalDef - 1;
                }
                else
                {
                    currDef = currDef - 1;
                }
                txtDefintion.Text = "" + definitions[currDef];
                labelPageNum.Text = (currDef + 1) + "/" + totalDef;
            }
        }
    }
}
