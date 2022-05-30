using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Praktikum_30_Mei_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable Team = new DataTable();
        DataTable Goal = new DataTable(); 
        
        int PosisiSekarang = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name, concat(m.manager_name, ' (' ,n.nation, ')'), concat(t.home_stadium, ', ',  t.city, ' (',t.capacity,')'), team_id from team t, manager m, nationality n where t.manager_id = m.manager_id and n.nationality_id = m.nationality_id; ";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Team);
            DataPemain(0);




        }
        public void DataPemain(int posisi)
        {
            LblTeam.Text = Team.Rows[posisi][0].ToString();
            LblManager.Text = Team.Rows[posisi][1].ToString();
            LblStadium.Text = Team.Rows[posisi][2].ToString();

            sqlQuery = "select concat(p.player_name, ' ', sum(dm.type = 'GO' OR dm.type = 'GP'), '(', sum(dm.type = 'GP'),')') from dmatch dm, player p where p.team_id = '" + Team.Rows[posisi]["team_id"] + "' and (dm.type = 'GO' OR dm.type = 'GP') and dm.player_id = p.player_id group by dm.player_id order by 1 desc; ";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Goal);

            LblTopScorer.Text = Goal.Rows[posisi][0].ToString();
            PosisiSekarang = posisi;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(PosisiSekarang < Team.Rows.Count - 1)
            {
                PosisiSekarang++;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                DataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            
            DataPemain(0);
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            DataPemain(Team.Rows.Count - 1);    
        }
    }
}
