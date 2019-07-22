using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UdemyTutorialApps
{
    public partial class MainPage : ContentPage
    {
        private readonly string[] words;
        private int wordPos = 0;

        public MainPage()
        {
            InitializeComponent();

            words = new[] { "quote1", "quote2", "quote3" };

            QuoteLabel.Text = words[wordPos];
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            wordPos++;
            if (wordPos > words.Length - 1)
            {
                wordPos = 0;
            }

            QuoteLabel.Text = words[wordPos];
        }
    }
}
