using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace std_calculator_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //List<string> possible_std = new List <string>();
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void about_button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("STD Risk Calculator Version 1.0 © 2021 Deniz K Acikbas.");
            dialog.ShowAsync();
        }

        private void analyze_button_Click(object sender, RoutedEventArgs e)
        {
            result update_list = new result();

            // Anal sex without Condom or PreP
            if (anal_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true))
            {
                result.possible_std.Add("HIV/AIDS");
                result.possible_std.Add("Hepatitis B");
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("Hepatitis C");
            }

            // Vaginal sex without Condom or PreP
            if (vaginal_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true))
            {
                result.possible_std.Add("HIV/AIDS");
                result.possible_std.Add("Hepatitis B");
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("Hepatitis C");
            }

            // Oral sex without Condom or PreP
            if (oral_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true))
            {
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("HIV/AIDS");
                result.likely_std.Add("Hepatitis B");
                result.no_std.Add("Hepatitis C");
            }

            // Anal sex with Condom or PreP or both
           if (condom.IsChecked == true || (condom.IsChecked == true && prep.IsChecked == true) && anal_sex_radio_button.IsChecked == true  && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true))
            {
              result.likely_std.Add("HIV/AIDS");
              result.likely_std.Add("Hepatitis B");
              result.likely_std.Add("Herpes Simplex");
              result.likely_std.Add("Syphilis");
              result.likely_std.Add("Gonorrhea");
              result.likely_std.Add("Chlamydia");
              result.possible_std.Add("Genital Warts (HPV)");
              result.possible_std.Add("Trichomonas");
              result.likely_std.Add("Hepatitis C");
            }

            // Vaginal sex with Condom or PreP or both
            if (condom.IsChecked == true || (condom.IsChecked == true && prep.IsChecked == true) && vaginal_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true) && ((condom.IsChecked == true || prep.IsChecked == true) || ((condom.IsChecked == true && prep.IsChecked == true))))
            {
                result.likely_std.Add("HIV/AIDS");
                result.likely_std.Add("Hepatitis B");
                result.likely_std.Add("Herpes Simplex");
                result.likely_std.Add("Syphilis");
                result.likely_std.Add("Gonorrhea");
                result.likely_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("Hepatitis C");
            }

            // Oral sex with Condom or Prep or both
            if (condom.IsChecked == true || (condom.IsChecked == true && prep.IsChecked == true) && oral_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_positive_partner.IsChecked == true || hiv_unknown_partner.IsChecked == true) && ((condom.IsChecked == true || prep.IsChecked == true) || ((condom.IsChecked == true && prep.IsChecked == true))))
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.no_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.likely_std.Add("Genital Warts (HPV)");
                result.likely_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }
            // Fingering with STD
            if(fingering_radio_button.IsChecked == true && std_positive_radio_button.IsChecked == true && (std_positive_partner_radio_button.IsChecked == true || std_unknown_partner_radio_button.IsChecked == true))
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.no_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.no_std.Add("Genital Warts (HPV)");
                result.likely_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            //Fingering without STD
            if (fingering_radio_button.IsChecked == true && std_negative_radio_button.IsChecked == true && std_negative_partner_radio_button.IsChecked == true )
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.no_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.no_std.Add("Genital Warts (HPV)");
                result.no_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            // Kissing with STD
            if (deep_kissing_radio_button.IsChecked == true && std_positive_radio_button.IsChecked == true && (std_positive_partner_radio_button.IsChecked == true || std_unknown_partner_radio_button.IsChecked == true))
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.likely_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.likely_std.Add("Genital Warts (HPV)");
                result.likely_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            // Kissing without STD
            if (deep_kissing_radio_button.IsChecked == true && std_negative_radio_button.IsChecked == true && std_negative_partner_radio_button.IsChecked == true)
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.no_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.no_std.Add("Genital Warts (HPV)");
                result.no_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            // Touching with STD
            if (genital_touching_radio_button.IsChecked == true && std_positive_radio_button.IsChecked == true && (std_positive_partner_radio_button.IsChecked == true || std_unknown_partner_radio_button.IsChecked == true))
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.likely_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.likely_std.Add("Genital Warts (HPV)");
                result.likely_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            // Touching without STD
            if (genital_touching_radio_button.IsChecked == true && std_negative_radio_button.IsChecked == true && std_negative_partner_radio_button.IsChecked == true)
            {
                result.no_std.Add("HIV/AIDS");
                result.no_std.Add("Hepatitis B");
                result.no_std.Add("Herpes Simplex");
                result.no_std.Add("Syphilis");
                result.no_std.Add("Gonorrhea");
                result.no_std.Add("Chlamydia");
                result.no_std.Add("Genital Warts (HPV)");
                result.no_std.Add("Trichomonas");
                result.no_std.Add("Hepatitis C");
            }

            // Anal sex with HIV Negative or Undetectable partner
            if (anal_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_negative_partner.IsChecked == true || hiv_undetectable_partner.IsChecked == true))
            {
                result.no_std.Add("HIV/AIDS");
                result.possible_std.Add("Hepatitis B");
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("Hepatitis C");
            }

            // Vaginal sex with HIV Negative or Undetectable partner
            if (vaginal_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_negative_partner.IsChecked == true || hiv_undetectable_partner.IsChecked == true))
            {
                result.no_std.Add("HIV/AIDS");
                result.possible_std.Add("Hepatitis B");
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.likely_std.Add("Hepatitis C");
            }

            // Oral sex with HIV Negative Partner or Undetectable Partner
            else if (oral_sex_radio_button.IsChecked == true && (insertive_radio_button.IsChecked == true || receptive_radio_button.IsChecked == true || versatile_radio_button.IsChecked == true) && (hiv_negative_partner.IsChecked == true || hiv_undetectable_partner.IsChecked == true))
            {
                result.possible_std.Add("Herpes Simplex");
                result.possible_std.Add("Syphilis");
                result.possible_std.Add("Gonorrhea");
                result.possible_std.Add("Chlamydia");
                result.possible_std.Add("Genital Warts (HPV)");
                result.possible_std.Add("Trichomonas");
                result.no_std.Add("HIV/AIDS");
                result.likely_std.Add("Hepatitis B");
                result.no_std.Add("Hepatitis C");
            }
            this.Frame.Navigate(typeof(result));
        }
    }
}
