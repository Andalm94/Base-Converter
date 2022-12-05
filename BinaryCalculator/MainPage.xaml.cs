using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BinaryCalculator
{
    public partial class MainPage : ContentPage
    {
        private int btnFromSelected;
        private int btnToSelected;

        public MainPage()
        {
            InitializeComponent();


        }


        private void btnCalculate_Clicked(object sender, EventArgs e)
        {
            try
            {
                string calcResult = "";

                if (btnFromSelected == 2)
                {

                    switch (btnToSelected)
                    {
                        case 2:
                            throw new Exception("Please, select two different number systems");
                        case 10:
                            calcResult = Calcs.ConvertBinToDec(input.Text);
                            break;
                        case 16:
                            calcResult = Calcs.ConvertBinToHex(input.Text);
                            break;
                    }

                }
                else if (btnFromSelected == 10)
                {

                    switch (btnToSelected)
                    {
                        case 2:
                            calcResult = Calcs.ConvertDecToBin(input.Text);
                            break;
                        case 10:
                            throw new Exception("Please, select two different number systems");
                        case 16:
                            calcResult = Calcs.ConvertDecToHex(input.Text);
                            break;
                    }

                }
                else if (btnFromSelected == 16)
                {

                    switch (btnToSelected)
                    {
                        case 2:
                            calcResult = Calcs.ConvertHexToBin(input.Text);
                            break;
                        case 10:
                            calcResult = Calcs.ConvertHexToDec(input.Text);
                            break;
                        case 16:
                            throw new Exception("Please, select two different number systems");
                    }

                }

                lblResultTo.Text = calcResult;
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "ok");
            }
            
        }



        //================= BUTTONS (from/to) =========================

        private void btnFromBin_Clicked(object sender, EventArgs e)
        {
            SetBtnFrom(2);
            if (btnToSelected == 2)
            {
                SetBtnTo(10);
            }

        }
        private void btnFromDec_Clicked(object sender, EventArgs e)
        {
            SetBtnFrom(10);
            if (btnToSelected == 10)
            {
                SetBtnTo(2);
            }

        }
        private void btnFromHex_Clicked(object sender, EventArgs e)
        {
            SetBtnFrom(16);
            if (btnToSelected == 16)
            {
                SetBtnTo(10);
            }

        }
        private void btnToBin_Clicked(object sender, EventArgs e)
        {
            SetBtnTo(2);
            if (btnFromSelected == 2)
            {
                SetBtnFrom(10);
            }
        }
        private void btnToDec_Clicked(object sender, EventArgs e)
        {
            SetBtnTo(10);
            if (btnFromSelected == 10)
            {
                SetBtnFrom(2);
            }
        }
        private void btnToHex_Clicked(object sender, EventArgs e)
        {
            SetBtnTo(16);
            if (btnFromSelected == 16)
            {
                SetBtnFrom(10);
            }
        }


    
        private void SetBtnFrom(int btnFrom)
        {
            switch (btnFrom)
            {
                case 2:
                    btnFromSelected = 2;
                    btnFromBin.TextColor = Color.Black;
                    btnFromBin.BackgroundColor = Color.FromHex("#20C20E");
                    btnFromDec.TextColor = Color.FromHex("#20C20E");
                    btnFromDec.BackgroundColor = Color.Black;
                    btnFromHex.TextColor = Color.FromHex("#20C20E");
                    btnFromHex.BackgroundColor = Color.Black;
                    input.Keyboard = Xamarin.Forms.Keyboard.Numeric;
                    lblResultFromNumberSystem.Text = "BIN";
                    break;
                case 10:
                    btnFromSelected = 10;
                    btnFromBin.TextColor = Color.FromHex("#20C20E");
                    btnFromBin.BackgroundColor = Color.Black;
                    btnFromDec.TextColor = Color.Black;
                    btnFromDec.BackgroundColor = Color.FromHex("#20C20E");
                    btnFromHex.TextColor = Color.FromHex("#20C20E");
                    btnFromHex.BackgroundColor = Color.Black;
                    input.Keyboard = Xamarin.Forms.Keyboard.Numeric;
                    lblResultFromNumberSystem.Text = "DEC";
                    break;
                case 16:
                    btnFromSelected = 16;
                    btnFromBin.TextColor = Color.FromHex("#20C20E");
                    btnFromBin.BackgroundColor = Color.Black;
                    btnFromDec.TextColor = Color.FromHex("#20C20E");
                    btnFromDec.BackgroundColor = Color.Black;
                    btnFromHex.TextColor = Color.Black;
                    btnFromHex.BackgroundColor = Color.FromHex("#20C20E");
                    input.Keyboard = Xamarin.Forms.Keyboard.Plain;
                    lblResultFromNumberSystem.Text = "HEX";
                    break;
            }
        }
    
        private void SetBtnTo(int btnTo)
        {
            switch (btnTo)
            {
                case 2:
                    btnToSelected = 2;
                    btnToBin.TextColor = Color.Black;
                    btnToBin.BackgroundColor = Color.FromHex("#20C20E");
                    btnToDec.TextColor = Color.FromHex("#20C20E");
                    btnToDec.BackgroundColor = Color.Black;
                    btnToHex.TextColor = Color.FromHex("#20C20E");
                    btnToHex.BackgroundColor = Color.Black;
                    lblResultToNumberSystem.Text = "BIN";
                    break;
                case 10:
                    btnToSelected = 10;
                    btnToBin.TextColor = Color.FromHex("#20C20E");
                    btnToBin.BackgroundColor = Color.Black;
                    btnToDec.TextColor = Color.Black;
                    btnToDec.BackgroundColor = Color.FromHex("#20C20E");
                    btnToHex.TextColor = Color.FromHex("#20C20E");
                    btnToHex.BackgroundColor = Color.Black;
                    lblResultToNumberSystem.Text = "DEC";
                    break;
                case 16:
                    btnToSelected = 16;
                    btnToBin.TextColor = Color.FromHex("#20C20E");
                    btnToBin.BackgroundColor = Color.Black;
                    btnToDec.TextColor = Color.FromHex("#20C20E");
                    btnToDec.BackgroundColor = Color.Black;
                    btnToHex.TextColor = Color.Black;
                    btnToHex.BackgroundColor = Color.FromHex("#20C20E");
                    lblResultToNumberSystem.Text = "HEX";
                    break;
            }
        }
    }


}
