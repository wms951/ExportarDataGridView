using System.Diagnostics;
using System.IO;

namespace Exemplos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GerarDadosAleatorios.gerarDataTable_tipo1(15);
            dataGridView1.Columns[0].FillWeight = 25;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GerarDadosAleatorios.gerarDataTable_tipo2(15);
            dataGridView1.Columns[0].FillWeight = 25;
        }

        private void bExportarExcel_Click(object sender, EventArgs e)
        {
            exportarParaExcel(dataGridView1);
        }
       

        private void exportarParaExcel(DataGridView dt)
        {

            FolderBrowserDialog fb = new FolderBrowserDialog();
            if(fb.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = @"" + fb.SelectedPath + "\\Report_excel" + DateTime.Now.ToShortTimeString().Replace(":", "") + ".xls";   


                    using(StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Unicode))
                    {

                        String cabecalho = "";

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            if (dt.Columns[i].Visible)
                            {
                                if(cabecalho == "")
                                {
                                    cabecalho = dataGridView1.Columns[i].HeaderCell.Value.ToString();
                                }
                                else
                                {
                                    cabecalho += "\t" + dataGridView1.Columns[i].HeaderCell.Value.ToString();
                                }
                            }
                        }

                        sw.WriteLine(cabecalho);

                        String linha = "";

                        for (int k = 0; k < dt.Rows.Count; k++)
                        {
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                String valor = dt.Rows[k].Cells[i].Value.ToString();

                                valor = valor.Replace("\n", "");
                                valor = valor.Replace("\r", "");

                                if (dt.Columns[i].Visible)
                                {
                                    if(linha == "")
                                    {
                                        linha = valor;
                                    }
                                    else
                                    {
                                        linha += "\t" + valor;
                                    }
                                }

                            }//FIM FOR COLUNAS

                            sw.WriteLine(linha);
                            linha = "";

                        }//FIM FOR LINHAS

                    } //FIM SW


                    Process.Start(new ProcessStartInfo(@path) { UseShellExecute = true });

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pasta selecionada!");
            }



        }


    }
}