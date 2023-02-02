using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BTPITControl
{
    public partial class MainPage : ContentPage
    {
        private BTPITControl BTPITControl = new BTPITControl();
        string[] nameDay = new string[] { "понедельник", "вторник", "среда", "четверг", "пятница" }; 
        int day = 0;
        public MainPage()
        {
            InitializeComponent();
            BTPITControl.AutoSet();
            if (!Preferences.Get("isWelcome",true))
            {
                welcomForm.IsVisible = false;
                mainForm.IsVisible = true;
            }
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            welcomForm.IsVisible = false;
            mainForm.IsVisible = true;
            if (checkBoxIsWelcom.IsChecked)
            {
                Preferences.Set("isWelcome", false);
            }
        }

        private void ButtonPreviousDay(object sender, EventArgs e)
        {
            if (day != 0)
            {
                day--;
            }
            else
            {
                day = 4;
            }
            name1.Text = BTPITControl.GetDataDay(day)[0];
            name2.Text = BTPITControl.GetDataDay(day)[1];
            name3.Text = BTPITControl.GetDataDay(day)[2];
            name4.Text = BTPITControl.GetDataDay(day)[3];
            labelTitl.Text = nameDay[day];

        }

        private void ButtonNextDay(object sender, EventArgs e)
        {
            if (day!=4)
            {
                day++;
            }
            else
            {
                day = 0;
            }
            name1.Text = BTPITControl.GetDataDay(day)[0];
            name2.Text = BTPITControl.GetDataDay(day)[1];
            name3.Text = BTPITControl.GetDataDay(day)[2];
            name4.Text = BTPITControl.GetDataDay(day)[3];
            labelTitl.Text = nameDay[day];
        }
    }
}
