using System.Media;

namespace SlimeKiller.Telas.Mundos
{
    public partial class OverWorld : Form
    {
        public OverWorld()
        {
            InitializeComponent();
            this.playSimpleSound();
        }

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new(@"C:\Users\android\Desktop\Jogo\SlimeKiller\SlimeKiller\Resources\BattleMusic.wav");
            simpleSound.Play();
        }
    }
}
