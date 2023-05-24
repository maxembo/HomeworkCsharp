using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RallyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenMessageBox(bool check, string message)
        {
            if (check) MessageBox.Show(message);
        }

        private void button_Click(object sender, EventArgs e)
        {
            OpenMessageBox(string.IsNullOrEmpty(EventNameText.Text), "Введите название события!");

            int numberOfSpeakers = (int)numOfSpeakers.Value;
            OpenMessageBox(numberOfSpeakers <= 0, "Введите кол-во ораторов!");

            int numberOfParticipants = (int)numOfParticipants.Value;
            OpenMessageBox(numberOfParticipants <= 0, "Введите кол-во участников!");

            int numberOfSpeakerGroups = (int)numIfSpeakerGroups.Value;

            Rally rally;
            rally = (numberOfSpeakerGroups > 0)
                ? rally = new CountryRally(EventNameText.Text, numberOfSpeakers, numberOfParticipants, numberOfSpeakerGroups)
                : rally = new Rally(EventNameText.Text, numberOfSpeakers, numberOfParticipants);


            if (numberOfSpeakers > 0 && numberOfParticipants > 0)
            {
                labelResult.Text = rally.ToString();
                MessageBox.Show(rally.ToString());
            }
        }
    }
}
