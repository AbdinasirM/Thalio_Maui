namespace Thalio
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        bool isPasswordVisible = false;

        private void OnEyeIconTapped(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            entryPassword.IsPassword = !isPasswordVisible;
            eyeIcon.Text = isPasswordVisible ? "\uf070" : "\uf06e"; // eye-slash : eye
        }

    }

}
