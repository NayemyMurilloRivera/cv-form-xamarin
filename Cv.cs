using Xamarin.Forms;

namespace Cv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public Command CreateCVCommand => new Command(CreateCV);
        private void CreateCV()
        {

            var name = NameEntry.Text;
            var occupation = OccupationEntry.Text;
            var phone = PhoneEntry.Text;
            var email = EmailEntry.Text;
            var location = LocationEntry.Text;
            var linkedin = LinkedInEntry.Text;
            var profile = ProfileEditor.Text;
            var experience = ExperienceEditor.Text;
            var education = EducationEditor.Text;
            var skills = SkillsEditor.Text;
            var languages = LanguagesEditor.Text;

            DisplayAlert("CV Generado", $"Nombre: {name}\nOcupación: {occupation}\nTeléfono: {phone}\nCorreo: {email}\nUbicación: {location}\nLinkedIn: {linkedin}\nPerfil: {profile}\nExperiencia: {experience}\nEducación: {education}\nHabilidades: {skills}\nIdiomas: {languages}", "OK");
        }
    }
}


