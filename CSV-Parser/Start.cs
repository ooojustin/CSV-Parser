using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Parser {

    public partial class Start : Form {

        private string FilePath;

        public Start() {

            InitializeComponent();

        }

        private void Start_Load(object sender, EventArgs e) {

            SelectCSV();

        }

        private bool SelectCSV() {

            // make sure they didn't cancel
            DialogResult result = ofd.ShowDialog();
            if (result != DialogResult.OK)
                return false;

            // make sure it exists
            string file = ofd.FileName;
            if (!File.Exists(file))
                return false;

            // make sure its a .csv file
            if (Path.GetExtension(file).ToLower() != ".csv")
                return false;

            // it's good :)
            FilePath = ofd.FileName;
            return true;

        }

    }

}
