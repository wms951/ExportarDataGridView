using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace Exemplos
{
    internal class GerarDadosAleatorios
    {


        public static DataTable gerarDataTable_tipo1(int qtd)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("COD", typeof(string));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("ESTADO", typeof(string));
            dt.Columns.Add("CARGO", typeof(string));
            dt.Columns.Add("SALÁRIO", typeof(string));


            for (int i = 0; i < qtd; i++)
            {
                dt.Rows.Add(i.ToString(), getNome(), getEstado(), getCargo(), getSalario(1212,3000));
            }

            return dt;
        }


        public static DataTable gerarDataTable_tipo2(int qtd)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("COD", typeof(string));
            dt.Columns.Add("NOME", typeof(string));
            dt.Columns.Add("IDADE", typeof(string));


            for (int i = 0; i < qtd; i++)
            {
                dt.Rows.Add(i.ToString(), getNome(), getRandom(18,60));
            }

            return dt;
        }


        //PRIVATE FUNCITONS 

        private static String getNome()
        {
            string[] nomes = new string[14];
            nomes[0] = "Miguel";
            nomes[1] = "Arthur";
            nomes[2] = "Gael";
            nomes[3] = "Heitor";
            nomes[4] = "Helena";
            nomes[5] = "Alice";
            nomes[6] = "Theo";
            nomes[7] = "Laura";
            nomes[8] = "Davi";
            nomes[9] = "Gabriel";
            nomes[10] = "Bernardo";
            nomes[11] = "Samuel";
            nomes[12] = "João";
            nomes[13] = "Sophia";

            int val = getRandom(0, 14);

            return nomes[val];
        }



        private static String getEstado()
        {
            string[] nomes = new string[27];
            nomes[0] = " Acre(AC)";
            nomes[1] = " Alagoas(AL)";
            nomes[2] = " Amapá(AP)";
            nomes[3] = " Amazonas(AM)";
            nomes[4] = " Bahia(BA)";
            nomes[5] = " Ceará(CE)";
            nomes[6] = " Distrito Federal(DF)";
            nomes[7] = " Espírito Santo(ES)";
            nomes[8] = " Goiás(GO)";
            nomes[9] = " Maranhão(MA)";
            nomes[10] = " Mato Grosso(MT)";
            nomes[11] = " Mato Grosso do Sul(MS)";
            nomes[12] = " Minas Gerais(MG)";
            nomes[13] = " Pará(PA)";
            nomes[14] = " Paraíba(PB)";
            nomes[15] = " Paraná(PR)";
            nomes[16] = " Pernambuco(PE)";
            nomes[17] = " Piauí(PI)";
            nomes[18] = " Rio de Janeiro(RJ)";
            nomes[19] = " Rio Grande do Norte(RN)";
            nomes[20] = " Rio Grande do Sul(RS)";
            nomes[21] = " Rondônia(RO)";
            nomes[22] = " Roraima(RR)";
            nomes[23] = " Santa Catarina(SC)";
            nomes[24] = " São Paulo(SP)";
            nomes[25] = " Sergipe(SE)";
            nomes[26] = " Tocantins(TO)";
            int val = getRandom(0, 27);

            return nomes[val];
        }

        private static String getCargo()
        {
            string[] nomes = new string[9];
            nomes[0] = " Assistente administrativo";
            nomes[1] = " Vendedor";
            nomes[2] = " Recepcionista";
            nomes[3] = " Estagiário administrativo";
            nomes[4] = " Técnico de segurança do trabalho";
            nomes[5] = " Auxiliar logístico";
            nomes[6] = " Assistente comercial";
            nomes[7] = " Analista contábil";
            nomes[8] = " Gerente de loja";
            int val = getRandom(0, 9);

            return nomes[val];
        }

        private static String getSalario(int min, int max)
        {

            return string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", getRandom(min,max)); 
        }



        private static int getRandom(int min, int max)
        {
            Random randObj = new Random();
            return randObj.Next(min, max);
        }


    }
}
