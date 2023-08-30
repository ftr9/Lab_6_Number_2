# Create the Database for storing User Profile and Display the result connecting to this Database

# Step 1 - Write this

```
namespace Number2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
```

# Step -2 Write this

```
namespace Number2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Fetch = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(734, 188);
            dataGridView1.TabIndex = 0;
            //
            // Fetch
            //
            Fetch.Location = new Point(279, 321);
            Fetch.Name = "Fetch";
            Fetch.Size = new Size(182, 53);
            Fetch.TabIndex = 1;
            Fetch.Text = "Show Data";
            Fetch.UseVisualStyleBackColor = true;
            Fetch.Click += Fetch_Click;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Fetch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Fetch;
    }
}


```

# Step -3 - Draw this

![image](https://github.com/ftr9/Lab_6_Number_2/assets/60734475/4d240d57-5493-4c04-a11c-adf7c8cd8440)

# Step - 4 - write this

```
using System.Data;
using MySql.Data.MySqlClient;

namespace Number2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fetch_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "Server=localhost;Database=users;User=root;Password=letodluhar;Port=3306";


                MySqlConnection con = new MySqlConnection(str);
                con.Open();

                String query = "select * from userprofile";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                con.Close();

            }

            catch (Exception es)

            {
                MessageBox.Show(es.Message);
            }

        }
    }
}
```

# Step - 5 -Draw this - Jatha Haru Yehi Data Copy nahan ni

![image](https://github.com/ftr9/Lab_6_Number_2/assets/60734475/aa747c92-878f-4d17-8feb-defc177943d0)
