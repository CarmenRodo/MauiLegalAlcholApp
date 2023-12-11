namespace MauiLegalAlcholApp
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        void OnDateSelected(object sender, System.EventArgs e)
        {
            double UsAge = DateTime.Now.Year - birthDate.Date.Year;
            Out_text.Text = UsAge.ToString();
            if (UsAge >= 21)
            {
                Out_text.Text = "It's legal to drink in the United States.";
            }
            else if (UsAge == 0)
            {
                Out_text.Text = "You've got 21 year(s) to go";
            }
            else
            {
                Out_text.Text = "You've got " + (21 - (DateTime.Now.Year - birthDate.Date.Year)) + " year(s) to go";
                
            }


        }


    }

}
