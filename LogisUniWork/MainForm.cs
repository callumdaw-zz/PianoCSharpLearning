using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogisUniWork.Classes;
using Newtonsoft.Json;
using LogisUniWork.Models;

namespace LogisUniWork
{
    public partial class MainForm : Form
    {
        public MusicScore score = new MusicScore();
        public int NoteId = 3;
        public MainForm()
        {
            InitializeComponent();
            // Initialize all of the images
            staff1.Controls.Add(staff1_1);
            staff1_1.Location = new Point(0, 0);
            staff1_1.BackColor = Color.Transparent;

            staff2.Controls.Add(staff2_1);
            staff2_1.Location = new Point(0, 0);
            staff2_1.BackColor = Color.Transparent;

            staff3.Controls.Add(staff3_1);
            staff3_1.Location = new Point(0, 0);
            staff3_1.BackColor = Color.Transparent;

            staff4.Controls.Add(staff4_1);
            staff4_1.Location = new Point(0, 0);
            staff4_1.BackColor = Color.Transparent;

            staff5.Controls.Add(staff5_1);
            staff5_1.Location = new Point(0, 0);
            staff5_1.BackColor = Color.Transparent;

            staff6.Controls.Add(staff6_1);
            staff6_1.Location = new Point(0, 0);
            staff6_1.BackColor = Color.Transparent;

            staff7.Controls.Add(staff7_1);
            staff7_1.Location = new Point(0, 0);
            staff7_1.BackColor = Color.Transparent;

            staff8.Controls.Add(staff8_1);
            staff8_1.Location = new Point(0, 0);
            staff8_1.BackColor = Color.Transparent;

            staff9.Controls.Add(staff9_1);
            staff9_1.Location = new Point(0, 0);
            staff9_1.BackColor = Color.Transparent;

            staff10.Controls.Add(staff10_1);
            staff10_1.Location = new Point(0, 0);
            staff10_1.BackColor = Color.Transparent;

            staff11.Controls.Add(staff11_1);
            staff11_1.Location = new Point(0, 0);
            staff11_1.BackColor = Color.Transparent;

            staff12.Controls.Add(staff12_1);
            staff12_1.Location = new Point(0, 0);
            staff12_1.BackColor = Color.Transparent;

            staff13.Controls.Add(staff13_1);
            staff13_1.Location = new Point(0, 0);
            staff13_1.BackColor = Color.Transparent;

            staff14.Controls.Add(staff14_1);
            staff14_1.Location = new Point(0, 0);
            staff14_1.BackColor = Color.Transparent;

            staff15.Controls.Add(staff15_1);
            staff15_1.Location = new Point(0, 0);
            staff15_1.BackColor = Color.Transparent;

            staff16.Controls.Add(staff16_1);
            staff16_1.Location = new Point(0, 0);
            staff16_1.BackColor = Color.Transparent;

            staff17.Controls.Add(staff17_1);
            staff17_1.Location = new Point(0, 0);
            staff17_1.BackColor = Color.Transparent;

            staff18.Controls.Add(staff18_1);
            staff18_1.Location = new Point(0, 0);
            staff18_1.BackColor = Color.Transparent;

            staff19.Controls.Add(staff19_1);
            staff19_1.Location = new Point(0, 0);
            staff19_1.BackColor = Color.Transparent;

            staff20.Controls.Add(staff20_1);
            staff20_1.Location = new Point(0, 0);
            staff20_1.BackColor = Color.Transparent;
        }

        public MusicNote CreateNote(int pitch, int noteType, int noteDuration)
        {
            MusicNote note = new MusicNote();
            note.pitch = pitch;
            note.noteType = noteType;
            note.noteDuration = noteDuration;
            return note;
        }

        private void KeyPressed(int pitch)
        {
            NoteTypes noteType = GetNoteType();
            MusicNote note = CreateNote(pitch, noteType.noteType, noteType.noteDuration);
            play_note(note);
            CurrentNotes.Items.Add(note.pitch);
            CurrentNotes.SelectedIndex = CurrentNotes.Items.Count - 1;
            string pictureBoxName = string.Format("staff{0}", NoteId);
            foreach (Control item in this.Controls)
            {
                if (item.Name == pictureBoxName)
                {
                    int i = 0;
                }
            }
            staff3_1.Load(noteType.noteImagePath);
            score.notes.Add(note);
            NoteId = NoteId + 1;
        }

        private NoteTypes GetNoteType()
        {
            NoteTypes note = new NoteTypes();
            string noteTypeString = NoteType.SelectedItem.ToString();
            note.noteType = 0;
            note.noteDuration = 0;
            if (noteTypeString == "Crotchet")
            {
                note.noteType = 4;
                note.noteDuration = 256;
                note.noteImagePath = @"C:\Users\Callum\source\repos\LogisUniWork\LogisUniWork\Images\Crotchet.png";
            }
            else if (noteTypeString == "Minim")
            {
                note.noteType = 2;
                note.noteDuration = 512;
                note.noteImagePath = @"C:\Users\Callum\source\repos\LogisUniWork\LogisUniWork\Images\Minim.png";
            }
            else if (noteTypeString == "Semibreve")
            {
                note.noteType = 1;
                note.noteDuration = 1024;
                note.noteImagePath = @"C:\Users\Callum\source\repos\LogisUniWork\LogisUniWork\Images\SemiBreve.png";
            }
            else
            {
                note.noteType = 0;
                note.noteDuration = 0;
            }
            return note;
        }

        private void play_note (MusicNote note)
        {
            SoundPlayer player = new SoundPlayer(@"C:\Users\Callum\source\repos\LogisUniWork\LogisUniWork\Sounds\{0}.wav".Replace("{0}", note.pitch.ToString()));
            player.Play();
            System.Threading.Thread.Sleep(note.noteDuration);
        }

        private void c1_key_Click(object sender, EventArgs e)
        {
            int pitch = 1;
            KeyPressed(pitch);
        }

        private void c1_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 2;
            KeyPressed(pitch);
        }

        private void d1_key_Click(object sender, EventArgs e)
        {
            int pitch = 3;
            KeyPressed(pitch);
        }

        private void d1_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 4;
            KeyPressed(pitch);
        }

        private void e1_key_Click(object sender, EventArgs e)
        {
            int pitch = 5;
            KeyPressed(pitch);
        }

        private void f1_key_Click(object sender, EventArgs e)
        {
            int pitch = 6;
            KeyPressed(pitch);
        }

        private void f1_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 7;
            KeyPressed(pitch);
        }

        private void g1_key_Click(object sender, EventArgs e)
        {
            int pitch = 8;
            KeyPressed(pitch);
        }

        private void g1_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 9;
            KeyPressed(pitch);
        }

        private void a1_key_Click(object sender, EventArgs e)
        {
            int pitch = 10;
            KeyPressed(pitch);
        }

        private void a1_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 11;
            KeyPressed(pitch);
        }

        private void b1_key_Click(object sender, EventArgs e)
        {
            int pitch = 12;
            KeyPressed(pitch);
        }

        private void c2_key_Click(object sender, EventArgs e)
        {
            int pitch = 13;
            KeyPressed(pitch);
        }

        private void c2_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 14;
            KeyPressed(pitch);
        }

        private void d2_key_Click(object sender, EventArgs e)
        {
            int pitch = 15;
            KeyPressed(pitch);
        }

        private void d2_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 16;
            KeyPressed(pitch);
        }

        private void e2_key_Click(object sender, EventArgs e)
        {
            int pitch = 17;
            KeyPressed(pitch);
        }

        private void f2_key_Click(object sender, EventArgs e)
        {
            int pitch = 18;
            KeyPressed(pitch);
        }

        private void f2_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 19;
            KeyPressed(pitch);
        }

        private void g2_key_Click(object sender, EventArgs e)
        {
            int pitch = 20;
            KeyPressed(pitch);
        }

        private void g2_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 21;
            KeyPressed(pitch);
        }

        private void a2_key_Click(object sender, EventArgs e)
        {
            int pitch = 22;
            KeyPressed(pitch);
        }

        private void a2_keySharp_Click(object sender, EventArgs e)
        {
            int pitch = 23;
            KeyPressed(pitch);
        }

        private void b2_key_Click(object sender, EventArgs e)
        {
            int pitch = 24;
            KeyPressed(pitch);
        }

        private void c3_key_Click(object sender, EventArgs e)
        {
            int pitch = 25;
            KeyPressed(pitch);
        }

        private void Play_Click(object sender, EventArgs e)
        {
            foreach (MusicNote note in score.notes)
            {
                play_note(note);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            score.name = ScoreName.Text;
            score.tempo = 0;
            string output = JsonConvert.SerializeObject(score);
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(SaveFile.FileName, output);
            }
            else
            {
                MessageBox.Show("Error occured");
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string musicPath = "";
            if (LoadFile.ShowDialog() == DialogResult.OK)
            {
                musicPath = LoadFile.FileName;
            }
            
            if (File.Exists(musicPath))
            {
                using (StreamReader file = File.OpenText(musicPath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    MusicScore loadedScore  = (MusicScore)serializer.Deserialize(file, typeof(MusicScore));
                    score = loadedScore;
                    ScoreName.Text = score.name;
                    CurrentNotes.Items.Clear();
                    foreach (MusicNote note in score.notes)
                    {
                        CurrentNotes.Items.Add(note.pitch);
                        CurrentNotes.SelectedIndex = CurrentNotes.Items.Count - 1;
                    }
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            score = new MusicScore();
            CurrentNotes.Items.Clear();
            ScoreName.Text = "";
        }
    }
}
