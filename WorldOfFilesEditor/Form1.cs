using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorldOfFilesEditor
{
    public class Place
    {
        public string Name = "New Place";
        public int ID = -1;
        public string Description = "A lovely area, where nothing is in it.";

        public List<int> Connections = new List<int>();

        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public partial class Form1 : Form
    {
        bool isUpdating = false;
        BindingList<string> keys = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();

            // The Keys that will be used for the language map
            {
                // Button translation keys
                // NEW_BUTTON, Button to create a new player file
                keys.Add("NEW_BUTTON");
                // SAVE_BUTTON, Button to save a player's game
                keys.Add("SAVE_BUTTON");
                // LOAD_BUTTON, Button to load a player's savefile
                keys.Add("LOAD_BUTTON");
                // LANGUAGE_BUTTON, Button to change language
                keys.Add("LANGUAGE_BUTTON");
                // CONTINUE_BUTTON, Button to continue playing
                keys.Add("CONTINUE_BUTTON");
                // EXIT_BUTTON, Button to quit game
                keys.Add("EXIT_BUTTON");
                // MENU_BUTTON, Button to return to menu
                keys.Add("MENU_BUTTON");

                // Text Translation keys
                // ARRIVED_TEXT, tells the player where he has arrived at
                keys.Add("ARRIVED_TEXT");
                // WHERETO_TEXT, asks the player where he wants to go next
                keys.Add("WHERETO_TEXT");
            }

            PlacesList.DataSource = places;
            KeyListBox.DataSource = keys;

            numericUpDown1.Minimum = -1; numericUpDown1.Value = -1;
            numericUpDown2.Minimum = -1; numericUpDown2.Value = -1;
            numericUpDown3.Minimum = -1; numericUpDown3.Value = -1;
            numericUpDown4.Minimum = -1; numericUpDown4.Value = -1;
            numericUpDown5.Minimum = -1; numericUpDown5.Value = -1;

            foreach (var key in KeyListBox.Items)
            {
                languages[key.ToString()] = "";
            }
        }

        #region World Settings
        public BindingList<Place> places = new BindingList<Place>();

        private void SaveWorldButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog _SaveFileDialog = new SaveFileDialog();
            _SaveFileDialog.Filter = "World files|*.file";
            _SaveFileDialog.Title = "Save your World file";
            _SaveFileDialog.FilterIndex = 1;
            _SaveFileDialog.RestoreDirectory = true;

            _SaveFileDialog.FileName = "YourWorld.file";

            if (_SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream = new FileStream(_SaveFileDialog.FileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                {
                    places = new BindingList<Place>(places.OrderBy(x => x.ID).ToList());
                    PlacesList.DataSource = places;

                    string line;
                    writer.WriteLine("--WORLD--");
                    foreach (Place place in places)
                    {
                        line = place.Name + '|';
                        foreach (int num in place.Connections)
                        {
                            line += num.ToString() + ',';
                        }
                        line.TrimEnd(',');
                        line += "|" + place.Description.Replace('\n', '†');
                        writer.WriteLine(line);
                    }
                }
            }
        }

        private void LoadWorldButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenFileDialog = new OpenFileDialog();
            _OpenFileDialog.Filter = "World files|*.file| TEXT files|*.txt";
            _OpenFileDialog.Title = "Select your World file";
            _OpenFileDialog.Multiselect = false;

            if (_OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream = new FileStream(_OpenFileDialog.FileName, FileMode.Open);
                using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                {
                    // Example of a line, "Castle|4,5,8|A beautiful Castle on top of the Mountain
                    string line = null;
                    line = reader.ReadLine();

                    if (line.Contains("-WORLD-"))
                    {
                        places.Clear();
                        int ids = 0;
                        line = null;

                        do
                        {
                            if (line != null)
                            {
                                Place newPlace = new Place();
                                List<string> splitLine = line.Split('|').ToList();

                                newPlace.Name = splitLine[0];
                                newPlace.ID = ids;
                                newPlace.Description = splitLine[2].Replace('†', '\n');

                                int result;
                                foreach (string numb in splitLine[1].Split(',').ToList())
                                {
                                    if (int.TryParse(numb, out result))
                                    {
                                        newPlace.Connections.Add(result);
                                    }
                                }

                                places.Add(newPlace);
                                ids++;
                            }
                            line = reader.ReadLine();

                        } while (line != null);
                    }
                }
            }
        }

        private void AddPlaceButton_Click(object sender, EventArgs e)
        {
            Place newPlace = new Place();

            int id = 0;
            while (places.Count > id && places[id].ID == id)
            {
                id++;
            }
            newPlace.ID = id;
            places.Add(newPlace);

            places = new BindingList<Place>(places.OrderBy(x => x.ID).ToList());
            PlacesList.DataSource = places;
            PlacesList_SelectedIndexChanged(sender, e);
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (PlacesList.SelectedValue != null)
            {
                places.Remove((Place)PlacesList.SelectedValue);

                places = new BindingList<Place>(places.OrderBy(x => x.ID).ToList());
                PlacesList.DataSource = places;
                PlacesList_SelectedIndexChanged(sender, e);
            }
        }

        private void PlacesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlacesList.SelectedValue != null && places.Count > 0)
            {
                Place selectedPlace = (Place)PlacesList.SelectedValue;

                placeNameTextBox.Text = selectedPlace.Name;
                idLabel.Text = selectedPlace.ID.ToString();
                DesciptionRichTextBox.Text = selectedPlace.Description;

                isUpdating = true;
                if (selectedPlace.Connections.Count > 0) numericUpDown1.Value = selectedPlace.Connections[0];
                else numericUpDown1.Value = -1;
                if (selectedPlace.Connections.Count > 1) numericUpDown2.Value = selectedPlace.Connections[1];
                else numericUpDown2.Value = -1;
                if (selectedPlace.Connections.Count > 2) numericUpDown3.Value = selectedPlace.Connections[2];
                else numericUpDown3.Value = -1;
                if (selectedPlace.Connections.Count > 3) numericUpDown4.Value = selectedPlace.Connections[3];
                else numericUpDown4.Value = -1;
                if (selectedPlace.Connections.Count > 4) numericUpDown5.Value = selectedPlace.Connections[4];
                else numericUpDown5.Value = -1;
                isUpdating = false;

                ConnectionsChanged();
            }
            else
            {
                placeNameTextBox.Text = "";
                idLabel.Text = "";
                DesciptionRichTextBox.Text = "";

                numericUpDown1.Text = "";
                numericUpDown2.Text = "";
                numericUpDown3.Text = "";
                numericUpDown4.Text = "";
                numericUpDown5.Text = "";
            }
        }

        private void placeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PlacesList.SelectedValue != null)
            {
                Place selectedPlace = (Place)PlacesList.SelectedValue;

                selectedPlace.Name = placeNameTextBox.Text;
            }
        }

        private void DesciptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PlacesList.SelectedValue != null)
            {
                Place selectedPlace = (Place)PlacesList.SelectedValue;

                selectedPlace.Description = DesciptionRichTextBox.Text;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConnectionsChanged();
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ConnectionsChanged();
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            ConnectionsChanged();
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            ConnectionsChanged();
        }
        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            ConnectionsChanged();
        }

        private void ConnectionsChanged()
        {
            if (PlacesList.SelectedValue != null && !isUpdating)
            {
                Place selectedPlace = (Place)PlacesList.SelectedValue;

                List<int> connections = new List<int>();

                int parsed;
                if (int.TryParse(numericUpDown1.Value.ToString(), out parsed))
                    if (parsed > -1 && !connections.Contains(parsed)) connections.Add(parsed);
                if (int.TryParse(numericUpDown2.Value.ToString(), out parsed))
                    if (parsed > -1 && !connections.Contains(parsed)) connections.Add(parsed);
                if (int.TryParse(numericUpDown3.Value.ToString(), out parsed))
                    if (parsed > -1 && !connections.Contains(parsed)) connections.Add(parsed);
                if (int.TryParse(numericUpDown4.Value.ToString(), out parsed))
                    if (parsed > -1 && !connections.Contains(parsed)) connections.Add(parsed);
                if (int.TryParse(numericUpDown5.Value.ToString(), out parsed))
                    if (parsed > -1 && !connections.Contains(parsed)) connections.Add(parsed);

                selectedPlace.Connections = connections;
            }
        }
        #endregion

        #region Language Settings
        public Dictionary<string, string> languages = new Dictionary<string, string>();

        private void SaveLanguageButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog _SaveFileDialog = new SaveFileDialog();
            _SaveFileDialog.Filter = "Language files|*.file";
            _SaveFileDialog.Title = "Save your Language file";
            _SaveFileDialog.FilterIndex = 1;
            _SaveFileDialog.RestoreDirectory = true;

            _SaveFileDialog.FileName = "YourLanguage.file";

            if (_SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream = new FileStream(_SaveFileDialog.FileName, FileMode.Create);
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                {
                    string line;
                    writer.WriteLine("--LANGUAGE--");
                    foreach (string key in languages.Keys)
                    {
                        line = key + "|" + languages[key];
                        writer.WriteLine(line);
                    }
                }
            }
        }

        private void LoadLangaugeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog _OpenFileDialog = new OpenFileDialog();
            _OpenFileDialog.Filter = "Language files|*.file| TEXT files|*.txt";
            _OpenFileDialog.Title = "Select your Language file";
            _OpenFileDialog.Multiselect = false;

            if (_OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileStream stream = new FileStream(_OpenFileDialog.FileName, FileMode.Open);
                using (StreamReader reader = new StreamReader(stream, Encoding.Unicode))
                {
                    // Example of a line, "NEW_BUTTON|New Game
                    string line = null;
                    line = reader.ReadLine();

                    if (line.Contains("-LANGUAGE-"))
                    {
                        languages.Clear();
                        line = null;

                        do
                        {
                            if (line != null)
                            {
                                List<string> splitLine = line.Split('|').ToList();

                                if (splitLine.Count > 1)
                                    languages[splitLine[0]] = splitLine[1];
                                else if (splitLine.Count > 0)
                                    languages[splitLine[0]] = "";
                            }
                            line = reader.ReadLine();

                        } while (line != null);
                    }
                }
            }
        }

        private void KeyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (KeyListBox.SelectedItem != null)
            {
                string key = KeyListBox.SelectedItem.ToString();

                if (languages.ContainsKey(key) && !isUpdating)
                {
                    isUpdating = true;
                    TranslatedRichTextBox.Text = languages[key];
                    isUpdating = false;
                }
            }
        }

        private void TranslatedRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (KeyListBox.SelectedItem != null)
            {
                string key = KeyListBox.SelectedItem.ToString();

                if (languages.ContainsKey(key) && !isUpdating)
                {
                    isUpdating = true;
                    languages[key] = TranslatedRichTextBox.Text;
                    isUpdating = false;
                }
            }
        }
        #endregion
    }
}
