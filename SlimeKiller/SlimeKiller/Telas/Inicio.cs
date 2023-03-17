using SlimeKiller.Telas.Mundos;
using System.Drawing.Text;
using System.Media;

namespace SlimeKiller.Telas
{
    public partial class Inicio : Form
    {
        private PrivateFontCollection _fontCollection;
        private SoundPlayer _simpleSound;

        public Inicio()
        {
            InitializeComponent();
            _fontCollection = new PrivateFontCollection();
            this.CarregarFonte();
            this.playSimpleSound();
        }

        private void CarregarFonte()
        {
            byte[] bytesDaFonte = Properties.Resources.ANDYB;
            _fontCollection.AddFontFile(@"C:\Users\android\Desktop\Jogo\Fontes\ANDYB.ttf");
            Font font = new(_fontCollection.Families[0], 26);
            Font fontbtn1 = new(_fontCollection.Families[0], 18);
            Font fontbtn2 = new(_fontCollection.Families[0], 48);

            labelSelect.Font = font;
            PlayBtn.Font = fontbtn2;
            SelectBtn.Font = fontbtn1;
        }


        private void playSimpleSound()
        {
            _simpleSound = new(@"C:\Users\android\Desktop\Jogo\SlimeKiller\SlimeKiller\Resources\InicioTheme.wav");
            _simpleSound.Play();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            Thread t = new(() => Application.Run(new OverWorld()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            _simpleSound.Stop();
            this.Close();
        }
    }
}
