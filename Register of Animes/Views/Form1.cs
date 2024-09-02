using System.Data;
using Register_of_Animes.Data;
using Register_of_Animes.Models;

namespace Register_of_Animes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvData.CellClick += dgvData_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DALRegister.CreateDataSQLite();
            DALRegister.CreateTableSQLite();
            ShowData();
            lblData.Text = DALRegister.path;
        }
        private void ShowData()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DALRegister.GetAnimes();
                dgvData.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Anime anime = new Anime();
                anime.Id = Convert.ToInt32(txtId.Text);
                anime.Name = txtName.Text;
                anime.Gender = txtGender.Text;
                anime.Episode = txtEpisode.Text;

                DALRegister.Add(anime);
                ShowData();

                txtId.Clear();
                txtName.Clear();
                txtEpisode.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Anime anime = new Anime();
                anime.Id = Convert.ToInt32(txtId.Text);
                anime.Name = txtName.Text;
                anime.Gender = txtGender.Text;
                anime.Episode = txtEpisode.Text;


                DALRegister.Update(anime);
                ShowData();

                txtId.Clear();
                txtName.Clear();
                txtEpisode.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvData.SelectedRows[0].Cells["Id"].Value);
                    DALRegister.Delete(id);
                    ShowData();

                    txtId.Clear();
                    txtName.Clear();
                    txtEpisode.Clear();
                }
                else
                {
                    MessageBox.Show("Select register to delete.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (txtId.Text != "")
                {
                    int id = Convert.ToInt32(txtId.Text);
                    dt = DALRegister.GetAnime(id);
                }
                else
                {
                    string nome = txtName.Text;
                    dt = DALRegister.GetAnimes(nome);
                }
                dgvData.DataSource = dt;
                txtId.Clear();
                txtName.Clear();
                txtEpisode.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtEpisode.Text = row.Cells["Episode"].Value.ToString();
            }
        }
    }
}