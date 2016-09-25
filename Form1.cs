using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Beatmapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Initialize timers
            timerBeat.Interval = 100;
            timerBeat.Tick += new EventHandler(timerBeat_Tick);
            timerBeat.Enabled = true;
            timerBeat.Stop();
            timerScreenRefresh.Interval = 16;
            timerScreenRefresh.Tick += new EventHandler(timerScreenRefresh_Tick);
            timerScreenRefresh.Enabled = true;
            timerScreenRefresh.Stop();
            timerD.Interval = 100;
            timerD.Tick += new EventHandler(timerD_Tick);
            timerD.Enabled = true;
            timerD.Stop();
            timerF.Interval = 100;
            timerF.Tick += new EventHandler(timerF_Tick);
            timerF.Enabled = true;
            timerF.Stop();
            timerJ.Interval = 100;
            timerJ.Tick += new EventHandler(timerJ_Tick);
            timerJ.Enabled = true;
            timerJ.Stop();
            timerK.Interval = 100;
            timerK.Tick += new EventHandler(timerK_Tick);
            timerK.Enabled = true;
            timerK.Stop();
            timerEffects.Interval = 500;
            timerEffects.Tick += new EventHandler(timerEffects_Tick);
            timerEffects.Enabled = true;
            timerEffects.Stop();
            timerGameEnder.Interval = 500;
            timerGameEnder.Tick += new EventHandler(timerGameEnder_Tick);
            timerGameEnder.Enabled = true;
            timerGameEnder.Stop();
            timerMusicStart.Interval = 100;
            timerMusicStart.Tick += new EventHandler(timerMusicStart_Tick);
            timerMusicStart.Enabled = true;
            timerMusicStart.Stop();

            //Make Bitmaps Transparent
            D.MakeTransparent(D.GetPixel(0, 0));
            F.MakeTransparent(F.GetPixel(0, 0));
            J.MakeTransparent(J.GetPixel(0, 0));
            K.MakeTransparent(K.GetPixel(0, 0));
            fD.MakeTransparent(fD.GetPixel(0, 0));
            fF.MakeTransparent(fF.GetPixel(0, 0));
            fJ.MakeTransparent(fJ.GetPixel(0, 0));
            fK.MakeTransparent(fK.GetPixel(0, 0));
            bD.MakeTransparent(bD.GetPixel(0, 0));
            bF.MakeTransparent(bF.GetPixel(0, 0));
            bJ.MakeTransparent(bJ.GetPixel(0, 0));
            bK.MakeTransparent(bK.GetPixel(0, 0));
            Miss.MakeTransparent(Miss.GetPixel(0, 0));
            Ok.MakeTransparent(Ok.GetPixel(0, 0));
            Good.MakeTransparent(Good.GetPixel(0, 0));
            Fabulous.MakeTransparent(Fabulous.GetPixel(0, 0));
            NoEffect.MakeTransparent(NoEffect.GetPixel(0, 0));
        }
        //Declare Timers
        Timer timerBeat = new Timer();
        Timer timerScreenRefresh = new Timer();
        Timer timerD = new Timer();
        Timer timerF = new Timer();
        Timer timerJ = new Timer();
        Timer timerK = new Timer();
        Timer timerEffects = new Timer();
        Timer timerGameEnder = new Timer();
        Timer timerMusicStart = new Timer();
        Stopwatch Time = new Stopwatch();

        //Public Variables
        int bpm = 110, BeatCount = -4, Speed = 10, TimeRemainder = 0, Combo = 0, LongestCombo = 0;
        long TimeAtLastScreenRefresh = 0, TotalTime = 0;
        double Multiplyer = 1, Score = 0;
        Boolean Dclick = false, Fclick = false, Jclick = false, Kclick = false, Denabled = true, Fenabled = true, Jenabled = true, Kenabled = true, PlayingGame = false;
        String Beatmap = "";
        Bitmap Beats = new Bitmap(584, 620), tmpBeats = new Bitmap(584, 620), tmppicbox = new Bitmap(584, 620);

        //Public Brushes
        Pen DarkGray = new Pen(Color.DimGray, 3);

        //Bitmaps from Resources
        Bitmap D = Properties.Resources.ButtonD;
        Bitmap F = Properties.Resources.ButtonF;
        Bitmap J = Properties.Resources.ButtonJ;
        Bitmap K = Properties.Resources.ButtonK;
        Bitmap fD = Properties.Resources.tmpButtonD;
        Bitmap fF = Properties.Resources.tmpButtonF;
        Bitmap fJ = Properties.Resources.tmpButtonJ;
        Bitmap fK = Properties.Resources.tmpButtonK;
        Bitmap bD = Properties.Resources.BeatD;
        Bitmap bF = Properties.Resources.BeatF;
        Bitmap bJ = Properties.Resources.BeatJ;
        Bitmap bK = Properties.Resources.BeatK;
        Bitmap Miss = Properties.Resources.Miss_;
        Bitmap Ok = Properties.Resources.Ok;
        Bitmap Good = Properties.Resources.Good_;
        Bitmap Fabulous = Properties.Resources.Fabulous_;
        Bitmap NoEffect = Properties.Resources.No_Effect;

        //Draw UI at the start of the program
        private void DrawUI(Graphics g)
        {
            g.Clear(Color.Gainsboro);
            DrawLines(g);
            DrawD(g);
            DrawF(g);
            DrawJ(g);
            DrawK(g);
            picboxEffects.Image = NoEffect;
        }
        private void picbox_Paint_1(object sender, PaintEventArgs e) { DrawUI(e.Graphics); }
        //Draw Verticle Lines
        private void DrawLines(Graphics g)
        {
            g.DrawLine(DarkGray, picbox.Width / 10, picbox.Height / 10 + picbox.Height / 20 + 2, picbox.Width / 10, picbox.Height);
            g.DrawLine(DarkGray, 2 * picbox.Width / 10 + picbox.Width / 20 - 1, picbox.Height / 10 + picbox.Height / 20 + 2, 2 * picbox.Width / 10 + picbox.Width / 20 - 1, picbox.Height);
            g.DrawLine(DarkGray, 3 * picbox.Width / 10 + 2 * picbox.Width / 20 - 2, picbox.Height / 10 + picbox.Height / 20 + 2, 3 * picbox.Width / 10 + 2 * picbox.Width / 20 - 2, picbox.Height);
            g.DrawLine(DarkGray, 4 * picbox.Width / 10 + 3 * picbox.Width / 20 - 3, picbox.Height / 10 + picbox.Height / 20 + 2, 4 * picbox.Width / 10 + 3 * picbox.Width / 20 - 3, picbox.Height);
        }
        //Draw the Buttons and Notes
        private void DrawD(Graphics g) { g.DrawImage(D, picbox.Width / 20, picbox.Height / 20 + 2); }
        private void DrawF(Graphics g) { g.DrawImage(F, 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 2); }
        private void DrawJ(Graphics g) { g.DrawImage(J, 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 2); }
        private void DrawK(Graphics g) { g.DrawImage(K, 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10) - 1, picbox.Height / 20 + 2); }
        private void FlashD(Graphics g) { g.DrawImage(fD, picbox.Width / 20, picbox.Height / 20 + 2); }
        private void FlashF(Graphics g) { g.DrawImage(fF, 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 2); }
        private void FlashJ(Graphics g) { g.DrawImage(fJ, 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 2); }
        private void FlashK(Graphics g) { g.DrawImage(fK, 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10) - 1, picbox.Height / 20 + 2); }
        private void BeatD(Graphics b) { b.DrawImage(bD, picbox.Width / 20, 550); }
        private void BeatF(Graphics b) { b.DrawImage(bF, 2 * (picbox.Width / 20) + picbox.Width / 10, 550); }
        private void BeatJ(Graphics b) { b.DrawImage(bJ, 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), 550); }
        private void BeatK(Graphics b) { b.DrawImage(bK, 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10) - 1, 550); }
        //Create effects and score when points are scored
        private void MISS()
        {
            Combo = 0;
            Multiplyer = 1;
            Score = Score - 25;
            lblScore.Text = Score.ToString();
            lblMultiplyer.Text = "1.00x";
            picboxEffects.Image = null;
            picboxEffects.Image = Miss;
            timerEffects.Start();
        }
        private void OK()
        {
            Combo++;
            if (Combo > LongestCombo) LongestCombo = Combo;
            Multiplyer += 0.02;
            Score = Score + 50 * Multiplyer;
            lblScore.Text = Score.ToString();
            lblMultiplyer.Text = Multiplyer.ToString("0.00") + "x";
            picboxEffects.Image = NoEffect;
            picboxEffects.Image = Ok;
            timerEffects.Start();
        }
        private void GOOD()
        {
            Combo++;
            if (Combo > LongestCombo) LongestCombo = Combo;
            Multiplyer += 0.02;
            Score = Score + 100 * Multiplyer;
            lblScore.Text = Score.ToString();
            lblMultiplyer.Text = Multiplyer.ToString("0.00") + "x";
            picboxEffects.Image = null;
            picboxEffects.Image = Good;
            timerEffects.Start();
        }
        private void FABULOUS()
        {
            Combo++;
            if (Combo > LongestCombo) LongestCombo = Combo;
            Multiplyer += 0.02;
            Score = Score + 300 * Multiplyer;
            lblScore.Text = Score.ToString();
            lblMultiplyer.Text = Multiplyer.ToString("0.00") + "x";
            picboxEffects.Image = null;
            picboxEffects.Image = Fabulous;
            timerEffects.Start();
        }
        //Sets the bpm and starts the beat timer to start the game
        private void Play_Click_1(object sender, EventArgs e)
        {
            timerBeat.Start();
            timerScreenRefresh.Start();
            Time.Start();
            if (rbtnNormal.Checked) { Speed = 40000; timerMusicStart.Interval = 4000; Beatmap = Properties.Resources.Normal; player.Stream = Properties.Resources.I_Can_t_Stop; }
            if (rbtnHard.Checked) { Speed = 25000; timerMusicStart.Interval = 2500; Beatmap = Properties.Resources.Hard; player.Stream = Properties.Resources.New_Divide; }
            if (rbtnInsane.Checked) { Speed = 20000; timerMusicStart.Interval = 2000; Beatmap = Properties.Resources.Insane; player.Stream = Properties.Resources.Bleed; }
            if (rbtnFabulous.Checked) { Speed = 10000; timerMusicStart.Interval = 1000; Beatmap = Properties.Resources.Fabulous; player.Stream = Properties.Resources.Razor_Sharp; }
            bpm = Convert.ToInt32(Beatmap.Substring(0, 3));
            timerBeat.Interval = 1000 / (bpm / 60);
            rbtnNormal.Enabled = false;
            rbtnHard.Enabled = false;
            rbtnInsane.Enabled = false;
            rbtnFabulous.Enabled = false;
            PlayingGame = true;
            Play.Visible = false;
            timerMusicStart.Start();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        //Wait until notes hit the buttons to start playing the song
        private void timerMusicStart_Tick(object sender, EventArgs e)
        {
            End.Visible = true;
            player.Play();
            timerMusicStart.Stop();
        }

        // Read the beatmap and create notes in the appropriate column when the beat hits
        private void timerBeat_Tick(object sender, EventArgs e)
        {
            if (BeatCount < Beatmap.Length)
            {
                try
                {
                    BeatCount = BeatCount + 5;
                    if (Beatmap[BeatCount] == ' ')
                    {
                        if (Beatmap[1 + BeatCount] == '1')
                            BeatD(Graphics.FromImage(Beats));
                        if (Beatmap[2 + BeatCount] == '1')
                            BeatF(Graphics.FromImage(Beats));
                        if (Beatmap[3 + BeatCount] == '1')
                            BeatJ(Graphics.FromImage(Beats));
                        if (Beatmap[4 + BeatCount] == '1')
                            BeatK(Graphics.FromImage(Beats));
                    }
                }
                catch { timerGameEnder.Start(); }
            }
        }
        //Redraw the screen and move notes up on tick
        private void timerScreenRefresh_Tick(object sender, EventArgs e)
        {
            tmppicbox = new Bitmap(584, 620);
            Graphics g = Graphics.FromImage(tmppicbox);
            g.Clear(Color.Gainsboro);
            DrawLines(g);
            tmpBeats = Beats;
            Beats = new Bitmap(584, 620);
            TotalTime = Convert.ToInt32(Time.Elapsed.Ticks);
            Graphics.FromImage(Beats).DrawImage(tmpBeats, 0, -1 * (TotalTime - TimeAtLastScreenRefresh + TimeRemainder) / Speed);
            TimeRemainder = ((int)TotalTime - (int)TimeAtLastScreenRefresh + TimeRemainder) % Speed;
            TimeAtLastScreenRefresh = TotalTime;
            g.DrawImage(Beats, 0, 0);
            if (Dclick)
                FlashD(g);
            else
                DrawD(g);
            if (Fclick)
                FlashF(g);
            else
                DrawF(g);
            if (Jclick)
                FlashJ(g);
            else
                DrawJ(g);
            if (Kclick)
                FlashK(g);
            else
                DrawK(g);
            picbox.CreateGraphics().DrawImage(tmppicbox, 0, 0);
        }
        //Turn on the buttons when the key is pressed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = picbox.CreateGraphics();
            if (e.KeyCode == Keys.D && Denabled && PlayingGame)
            {
                if (Beats.GetPixel(29 + picbox.Width / 20, picbox.Height / 20 + 27) == Color.FromArgb(255, 255, 254))
                    FABULOUS();
                else if (Beats.GetPixel(29 + picbox.Width / 20, picbox.Height / 20 + 2) == Color.FromArgb(255, 255, 255) || Beats.GetPixel(29 + picbox.Width / 20, picbox.Height / 20 + 53) == Color.FromArgb(255, 255, 255))
                    GOOD();
                else if (Beats.GetPixel(29 + picbox.Width / 20, picbox.Height / 20 + 2) != Color.FromArgb(0, 0, 0, 0) || Beats.GetPixel(29 + picbox.Width / 20, picbox.Height / 20 + 53) != Color.FromArgb(0, 0, 0, 0))
                    OK();
                else
                    MISS();
                FlashD(g);
                Dclick = true;
                timerD.Stop();
                timerD.Start();
                Denabled = false;
            }
            else if (e.KeyCode == Keys.F && Fenabled && PlayingGame)
            {
                if (Beats.GetPixel(29 + 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 27) == Color.FromArgb(255, 255, 254))
                    FABULOUS();
                else if (Beats.GetPixel(29 + 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 2) == Color.FromArgb(255, 255, 255) || Beats.GetPixel(29 + 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 53) == Color.FromArgb(255, 255, 255))
                    GOOD();
                else if (Beats.GetPixel(29 + 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 2) != Color.FromArgb(0, 0, 0, 0) || Beats.GetPixel(29 + 2 * (picbox.Width / 20) + picbox.Width / 10, picbox.Height / 20 + 53) != Color.FromArgb(0, 0, 0, 0))
                    OK();
                else
                    MISS();
                FlashF(g);
                Fclick = true;
                timerF.Stop();
                timerF.Start();
                Fenabled = false;
            }
            else if (e.KeyCode == Keys.J && Jenabled && PlayingGame)
            {
                if (Beats.GetPixel(29 + 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 27) == Color.FromArgb(255, 255, 254))
                    FABULOUS();
                else if (Beats.GetPixel(29 + 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 2) == Color.FromArgb(255, 255, 255) || Beats.GetPixel(29 + 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 53) == Color.FromArgb(255, 255, 255))
                    GOOD();
                else if (Beats.GetPixel(29 + 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 2) != Color.FromArgb(0, 0, 0, 0) || Beats.GetPixel(29 + 3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), picbox.Height / 20 + 53) != Color.FromArgb(0, 0, 0, 0))
                    OK();
                else
                    MISS();
                FlashJ(g);
                Jclick = true;
                timerJ.Stop();
                timerJ.Start();
                Jenabled = false;
            }
            else if (e.KeyCode == Keys.K && Kenabled && PlayingGame)
            {
                if (Beats.GetPixel(28 + 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10), picbox.Height / 20 + 27) == Color.FromArgb(255, 255, 254))
                    FABULOUS();
                else if (Beats.GetPixel(28 + 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10), picbox.Height / 20 + 2) == Color.FromArgb(255, 255, 255) || Beats.GetPixel(28 + 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10), picbox.Height / 20 + 53) == Color.FromArgb(255, 255, 255))
                    GOOD();
                else if (Beats.GetPixel(28 + 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10), picbox.Height / 20 + 2) != Color.FromArgb(0, 0, 0, 0) || Beats.GetPixel(28 + 4 * (picbox.Width / 20) + 3 * (picbox.Width / 10), picbox.Height / 20 + 53) != Color.FromArgb(0, 0, 0, 0))
                    OK();
                else
                    MISS();
                FlashK(g);
                Kclick = true;
                timerK.Stop();
                timerK.Start();
                Kenabled = false;
            }
        }
        //Flip off the D button if it's been on for over a tenth of a second
        private void timerD_Tick(object sender, EventArgs e)
        {
            if (Dclick)
            {
                DrawD(picbox.CreateGraphics());
                Dclick = false;
                timerD.Stop();
            }
        }
        //Flip off the F button if it's been on for over a tenth of a second
        private void timerF_Tick(object sender, EventArgs e)
        {
            if (Fclick)
            {
                DrawF(picbox.CreateGraphics());
                Fclick = false;
                timerF.Stop();
            }
        }
        //Flip off the J button if it's been on for over a tenth of a second
        private void timerJ_Tick(object sender, EventArgs e)
        {
            if (Jclick)
            {
                DrawJ(picbox.CreateGraphics());
                Jclick = false;
                timerJ.Stop();
            }
        }
        //Flip off the K button if it's been on for over a tenth of a second
        private void timerK_Tick(object sender, EventArgs e)
        {
            if (Kclick)
            {
                DrawK(picbox.CreateGraphics());
                Kclick = false;
                timerK.Stop();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //Flip off the D button if the key is released
            if (e.KeyCode == Keys.D)
            {
                Denabled = true;
                Dclick = false;
                timerD.Stop();
                DrawD(picbox.CreateGraphics());
            }
            //Flip off the F button if the key is released
            if (e.KeyCode == Keys.F)
            {
                Fenabled = true;
                Fclick = false;
                timerF.Stop();
                DrawF(picbox.CreateGraphics());
            }
            //Flip off the J button if the key is released
            if (e.KeyCode == Keys.J)
            {
                Jenabled = true;
                Jclick = false;
                timerJ.Stop();
                DrawJ(picbox.CreateGraphics());
            }
            //Flip off the K button if the key is released
            if (e.KeyCode == Keys.K)
            {
                Kenabled = true;
                Kclick = false;
                timerK.Stop();
                DrawK(picbox.CreateGraphics());
            }
        }
        private void timerEffects_Tick(object sender, EventArgs e) { picboxEffects.Image = NoEffect; timerEffects.Stop(); }
        //Close the program if the exit button is pressed
        private void Exit_Click_1(object sender, EventArgs e) { Application.Exit(); }
        //End the game when the song ends or the game is exited
        private void EndGame()
        {
            Multiplyer = 1;
            lblMultiplyer.Text = "1.00x";
            timerGameEnder.Stop();
            BeatCount = -4;
            timerBeat.Stop();
            timerScreenRefresh.Stop();
            rbtnNormal.Enabled = true;
            rbtnHard.Enabled = true;
            rbtnInsane.Enabled = true;
            rbtnFabulous.Enabled = true;
            Time.Stop();
            Time.Reset();
            PlayingGame = false;
            Play.Visible = true;
            End.Visible = false;
            lblScore.Text = "0";
            player.Stop();
            TotalTime = 0;
            TimeAtLastScreenRefresh = 0;
            MessageBox.Show("Final Score : " + Score.ToString() + System.Environment.NewLine + "Longest Combo : " + LongestCombo.ToString());
            Score = 0;
        }
        private void timerGameEnder_Tick(object sender, EventArgs e)
        {
            int i = 0;
            if (Beats.GetPixel(picbox.Width / 20, i) != Color.FromArgb(0, 0, 0, 0)) return;
            if (Beats.GetPixel(2 * (picbox.Width / 20) + picbox.Width / 10, i) != Color.FromArgb(0, 0, 0, 0)) return;
            if (Beats.GetPixel(3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), i) != Color.FromArgb(0, 0, 0, 0)) return;
            if (Beats.GetPixel(4 * (picbox.Width / 20) + 3 * (picbox.Width / 10) - 1, i) != Color.FromArgb(0, 0, 0, 0)) return;
            for (i = 0; i < 620; i = i + 10)
            {
                if (Beats.GetPixel(picbox.Width / 20, i) != Color.FromArgb(0, 0, 0, 0)) return;
                if (Beats.GetPixel(2 * (picbox.Width / 20) + picbox.Width / 10, i) != Color.FromArgb(0, 0, 0, 0)) return;
                if (Beats.GetPixel(3 * (picbox.Width / 20) + 2 * (picbox.Width / 10), i) != Color.FromArgb(0, 0, 0, 0)) return;
                if (Beats.GetPixel(4 * (picbox.Width / 20) + 3 * (picbox.Width / 10) - 1, i) != Color.FromArgb(0, 0, 0, 0)) return;
            }
            EndGame();
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void End_Click(object sender, EventArgs e)
        {
            Beats = new Bitmap(584, 620);
            DrawUI(picbox.CreateGraphics());
            EndGame();
        }

        private void picbox_Click(object sender, EventArgs e)
        {

        }
    }
}