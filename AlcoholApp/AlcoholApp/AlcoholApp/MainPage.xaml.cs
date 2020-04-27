using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlcoholApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int countryAge = 0;
        string country = "";
        int age = 0;
        void NewDate(object sender, EventArgs e)
        {

        }
        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex == -1 || selectedIndex == 0)
            {
                countryAge = 21;
                country = "USA";
            }
            else if (selectedIndex == 1)
            {
                countryAge = 18;
                country = "France";
            }
            else if (selectedIndex == 2)
            {
                countryAge = 16;
                country = "Germany";
            }
            else if (selectedIndex == 3)
            {
                countryAge = 18;
                country = "Mexico";
            }
        }
        void Btn_Clicked(object sender, System.EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime dob = DOBPicker.Date;
            age = (today.Year - dob.Year) - (today.DayOfYear < dob.DayOfYear ? 1 : 0);
            //int age = Int32.Parse(Inp_age.Text);
            string name = Inp_Name.Text;
            if (age >= countryAge)
            {
                Lbn_Answer2.Text = $"{name} is able to buy alcohol in {country}. {name} is {age} years old.";
            }
            else
            {
                //Lbn_Answer.Text = $"You are not able to buy alcohol in {country}.";
                Lbn_Answer2.Text = $"{name} is {(countryAge - age)} years from being able to buy alcohol in {country}. {name} is {age} years old.";
            }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
//Created by Sean Larsen