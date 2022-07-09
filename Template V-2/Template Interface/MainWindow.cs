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
using System.Net;
using System.Diagnostics;
using System.Threading;
using Interface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Interface
{
    public partial class MainWindow : MaterialForm
    {
        public MaterialSkinManager Manager;        

        public MainWindow() => InitializeComponent();

        private void OnLoad(object sender, EventArgs e)
        {
            Manager = MaterialSkinManager.Instance;
            Manager.EnforceBackcolorOnAllComponents = true;
            Manager.AddFormToManage(this);
            Manager.Theme = MaterialSkinManager.Themes.DARK;
            Manager.ColorScheme = new ColorScheme(Primary.Indigo600, Primary.Indigo700, Primary.Grey100, Accent.Indigo200, TextShade.WHITE);
        }

        public List<iScript.iItem> ScriptList = new List<iScript.iItem>();

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TitleBox.Text) || string.IsNullOrWhiteSpace(DescriptionBox.Text))
                MessageBox.Show("Can't Add Null Values To Script Item", "Failed To Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var Extension = DescriptionBox.Text.Split(':');

            var Item = new iScript.iItem
            {
                Title = TitleBox.Text,
                Description = Extension[0],
                Script = ScriptBox.Text,
                Thumbnail = Extension[1]
            };
            ScriptList.Add(Item);

            var ListItem = new MaterialListBoxItem
            {
                Text = Item.Title,
                Tag = Item.Title,
                SecondaryText = Item.Description
            };
            ItemList.AddItem(ListItem);

            if (!Debugger.IsAttached)
                MessageBox.Show($"Added {Item.Title} To Scripts List", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string Path = "./Scripts.json";

            if (File.Exists(Path))
            {
                foreach (var Item in ScriptList)
                {
                    using (var Writer = File.AppendText(Path))
                        Writer.Write(JsonConvert.SerializeObject(Item));
                };
            }

            var Json = JsonConvert.SerializeObject(new iScript { Scripts = ScriptList }, Formatting.Indented);
            File.WriteAllText(Path, Json);

            if (EncodeBox.Checked == true)
            {
                var Base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(File.ReadAllText(Path)));
                File.Delete(Path);
                File.WriteAllText("./Scripts.bin", Base64);
            }

            if (!Debugger.IsAttached)
                MessageBox.Show($"Successfully Built Json Check {Path}", "Successfully Compiled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public iScript.iItem GetItem(int Index) => ScriptList[Index];

        private void ItemList_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            var Item = GetItem(ItemList.SelectedIndex);

            if (!Debugger.IsAttached)
                MessageBox.Show($"Removed {Item.Title} From Script List", "Remove Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ScriptList.Remove(Item);
            ItemList.RemoveItem(selectedItem);
        }

        private void TitleBox_MouseDown(object sender, MouseEventArgs e) => TitleBox.Text = null;

        private void DescriptionBox_MouseDown(object sender, MouseEventArgs e) => DescriptionBox.Text = null;

        private void ScriptBox_MouseDown(object sender, MouseEventArgs e) => ScriptBox.Text = null;
    }
}
