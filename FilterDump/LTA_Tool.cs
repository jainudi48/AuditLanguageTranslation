using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilterDump
{
    public partial class LTA_Tool : Form
    {
        string catelogId = null;
        string brandId = null;
        string chassisId = null;
        string language = null;
        string orderStatusCode = null;
        public LTA_Tool()
        {
            InitializeComponent();

            setDefaultParams();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            getParamValues();
            try
            {
                ParseSqlData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                Console.WriteLine("\n\n\n" + ex.ToString());

            }
        }

        public void setDefaultParams()
        {
            catelogText.Text = "232380";
            brandText.Text = "2,3,1166";
        }
        public void getParamValues()
        {
            catelogId = catelogText.Text.ToString().Trim();
            brandId = brandText.Text.ToString().Trim();
            chassisId = chassisText.Text.ToString().Trim();
            Item languageItem = (Item)languageCombo.SelectedItem;
            language = languageItem.Value.ToString().Trim();
            Item orderStatusCodeItem = (Item)orderStatusCombo.SelectedItem;
            orderStatusCode = orderStatusCodeItem.Name.ToString().Trim();
        }

        public DataTable Delete(DataTable table, string filter)
        {
            table = Delete(table, table.Select(filter));
            return table;
        }
        public DataTable Delete(DataTable table, DataRow[] rows)
        {
            foreach (var row in rows)
                row.Delete();
            return table;
        }
        public void ParseSqlData()
        {
            string connetionString = null;
            string queryString = "select * from Logfile";
            /*string queryString = "select DISTINCT" +
       "c.catalog_id," +
       "a1.catalog_name," +
       "g.brand_id," +
       "g.brand_name," +
       "a.chassis_id," +
       "e.external_name [chasis_external_name]," +
       "c.order_code_ext_id [order_code], " +
       "b.status [Order code status]," +
       "a.Module_id," +
       "a2.internal_name [Module Name]," +
       "a.legend_id [option_ID]," +
       "d.sales_channel_visibility [Sales Media (1=offline/2=online/3=both)]," +
       "d.[default] [Default status (True=Default/False=Non Default)]," +
        "h.language_id, h.external_name [UK_English]," +
        "LANG_Norwegian.language_id, LANG_Norwegian.external_name [NORWEGIAN] " +
        ",a.current_status_code" +
        ",a.sales_media_code" +
        ",i.reason [Inactive status]" +
        ",l.item_unit_price [Option price]" +

 "FROM " +
       "CHASSIS_LEGEND (NOLOCK) a" +
       "JOIN order_code (NOLOCK) b on b.chassis_id = a.chassis_id and b.status in ('A','N') and b.order_code_type_id = 1" +
       "JOIN ORDER_CODE_CATALOG (NOLOCK) c on c.order_code_id = b.order_code_id" +
       "JOIN ORDER_CODE_OPTION (NOLOCK) d on d.order_code_id = b.order_code_id and d.module_id = a.module_id and d.option_id = a.legend_id " +
       "JOIN CHASSIS (NOLOCK) e on e.chassis_id = b.chassis_id and e.current_status_code = 'A'" +
       "JOIN SYSTEM_FAMILY (NOLOCK) f on f.family_id = e.family_id" +
       "JOIN BRAND (NOLOCK) g on g.brand_id = f.brand_id" +
       "JOIN CHASSIS_LEGEND_TEXT (NOLOCK) h on h.chassis_id = b.chassis_id and h.module_id = d.module_id and h.legend_id = d.option_id" +
 "LEFT JOIN CHASSIS_LEGEND_TEXT (NOLOCK) LANG_Norwegian on LANG_Norwegian.chassis_id = b.chassis_id and LANG_Norwegian.module_id = d.module_id and LANG_Norwegian.legend_id = d.option_id and LANG_Norwegian.language_id in (13)" +


       "JOIN CATALOG (NOLOCK) a1 on a1.catalog_id = c.catalog_id" +
       "JOIN Module (NOLOCK) a2 on a2.module_id = a.module_id" +
       "LEFT JOIN broken_legend_configs (NOLOCK) i on i.catalog_id = c.catalog_id and i.family_id = f.family_id and i.chassis_id = a.chassis_id and i.legend_id = a.legend_id" +
       "LEFT JOIN chassis_legend_item (NOLOCK) k on k.module_id = a.module_id and k.chassis_id = a.chassis_id and k.legend_id = a.legend_id" +
       "LEFt JOIN ITEM_CATALOG (NOLOCK) l on l.catalog_id = c.catalog_id and l.sku_num = k.sku_num" +
  "Where " +
        "h.language_id in (" + language + ")" +
       "and c.catalog_id in (" + catelogText + ")" +
        "and g.brand_id in (" + brandText + ")" +
        "and b.status in ('" + orderStatusCode + "')" +
        "and d.sales_channel_visibility in ('2','3')" +
        "and a.current_status_code = 'A'" +
         "and a.sales_media_code in ('B','W')" +

 "group by              " +
       "c.catalog_id, " +
       "a1.catalog_name," +
       "g.brand_id," +
       "g.brand_name," +
       "a.Chassis_id," +
       "e.external_name, " +
       "c.order_code_ext_id," +
       "b.status, " +
       "a.module_id," +
       "a.current_status_code," +
       "a2.internal_name," +
       "a.legend_id," +
       "d.sales_channel_visibility," +
       "d.[default]," +
       "--d.required, " +
       "h.language_id, h.external_name, " +
       "LANG_Norwegian.language_id, LANG_Norwegian.external_name" +
       ",a.current_status_code" +
       ",a.sales_media_code" +
       ",i.reason" +
       ",l.item_unit_price;";*/


            //connetionString = "Data Source=AUSOLDBPSRPT02.PRODUCTION.ONLINE.DELL.COM;Initial Catalog=ConfigStaging_Emea;Integrated Security=True";
            connetionString = @"Data Source=W10H6DGPF2\SQLEXPRESS;Initial Catalog=Sample;Integrated Security=True";
            SqlConnection connection = null;
            using (connection = new SqlConnection(connetionString))
            {
                DataSet dataSet = new DataSet();
                //command = new SqlCommand(queryString, connection);
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    adapter.Fill(dataSet);
                    
                    DataTable dtOrigCloned = dataSet.Tables[0];
                    DataTable dtFiltered = filterData(dtOrigCloned);
                    createLookupCols(dtOrigCloned, dtFiltered);
                    deletedLookedUpRows(dtOrigCloned, dtFiltered);
                    dtOrigCloned = deleteDuplicateRows(dtOrigCloned, "como");
                    //DataRow[] drs = dtOrigCloned.Select("[" + dtOrigCloned.Columns["Option price"] + "]" + " is null ");
                    
                    /*foreach(DataRow dr in drs)
                    {
                        dts.ImportRow(dr);
                        dr.Delete();
                    }*/
                    
                    dataGridView1.DataSource = dtOrigCloned;
                    lblNumLines.Text = dtOrigCloned.Rows.Count.ToString();
                    
                    //dtOrigCloned = Delete(dtOrigCloned, dtOrigCloned.Select("[" + dtOrigCloned.Columns["Option price"] + "]" + " is null "));
                    //dtOrigCloned = Delete(dtOrigCloned, dtOrigCloned.Select("[" + dtOrigCloned.Columns["Default status (True=Default/False=Non Default)"] + "]" + " in ('FALSE') AND " + "[" + dtOrigCloned.Columns["sales_media_code"] + "]" + " in ('B') AND " + "[" + dtOrigCloned.Columns["Option price"] + "]" + " in (999999.99, 9999999.99)"));

                    string filter2 = dtOrigCloned.Columns["catalog_id"] + " = " + "[" + dtFiltered.Columns["catalog_id"] + "]" + " AND " + "[" + dtOrigCloned.Columns["order_code"] + "]" + " = " + "[" + dtFiltered.Columns["order_code"] + "]" + " AND " + "[" + dtOrigCloned.Columns["Module_id"] + "]" + " = " + "[" + dtFiltered.Columns["Module_id"] + "]" + " AND " + "[" + dtOrigCloned.Columns["option_ID"] + "]" + " = " + "[" + dtFiltered.Columns["option_ID"] + "]";
                    DataRow[] drs3 = dtOrigCloned.Select(filter2);
                    
                    /*foreach(DataRow dr in drs3)
                    {
                        dtOrigCloned.Rows.Remove(dr);
                    }*/
                    //dataGridView1.DataSource = dtOrigCloned;
                    //lblNumLines.Text = dtOrigCloned.Rows.Count.ToString();

                    //dtOrigCloned = Delete(dtOrigCloned, filter2);
                    //dataGridView1.DataSource = dtOrigCloned;
                    //lblNumLines.Text = dtOrigCloned.Rows.Count.ToString();
                    /*dataGridView1.DataSource = dts;
                    lblNumLines.Text = dts.Rows.Count.ToString();
                    //dataGridView1.DataSource = dtOrigCloned;
                    foreach(DataRow dr in dtOrigCloned.Rows)
                    {
                        dtOrig.ImportRow(dr);
                    }
                    DataRow[] drFiltered1 = dtOrig.Select("["+dtOrig.Columns["Default status (True=Default/False=Non Default)"]+"]" + " in ('FALSE') or " + "["+dtOrig.Columns["sales_media_code"]+"]" + " in ('B') or " + "["+dtOrig.Columns["Option price"]+"]" + " in (999999.99, 9999999.99) or ["+dtOrig.Columns["Option price"]+"] is null");

                    DataTable dtFiltered1 = dtOrig.Clone();
                    foreach (DataRow dr in drFiltered1)
                    {
                        dtFiltered1.ImportRow(dr);
                    }

                    dataGridView1.DataSource = dtFiltered1;
                    lblNumLines.Text = dtFiltered1.Rows.Count.ToString();
                    string filter = "[" + dtOrig.Columns["Default status (True=Default/False=Non Default)"] + "]" + " in ('FALSE') AND " + "[" + dtOrig.Columns["sales_media_code"] + "]" + " in ('B') AND " + "[" + dtOrig.Columns["Option price"] + "]" + " in (999999.99, 9999999.99, )"; 
                    dtOrig = Delete(dtOrig, filter);
                    
                    //lblNumLines.Text = dtFiltered1.Rows.Count.ToString();
                    string filter2 = dtOrigCloned.Columns["catalog_id"] + " = " + "[" + dts.Columns["catalog_id"] + "]" + " AND " + "[" + dtOrigCloned.Columns["order_code"] + "]" + " = " + "[" + dts.Columns["order_code"] + "]" + " AND " + "[" + dtOrigCloned.Columns["Module_id"] + "]" + " = " + "[" + dts.Columns["Module_id"] + "]" + " AND " + "[" + dtOrigCloned.Columns["option_ID"] + "]" + " = " + "[" + dts.Columns["option_ID"] + "]";
                    DataRow[] drFiltered2 = dtOrigCloned.Select(filter2);
                    DataTable dtFiltered2 = dtOrig.Clone();
                    foreach (DataRow dr in drFiltered2)
                    {
                        dtFiltered2.ImportRow(dr);
                    }
                    dataGridView1.DataSource = dtFiltered2;
                    lblNumLines.Text = dtFiltered2.Rows.Count.ToString();*/
               }
               finally
               {
                    connection.Close();
               }
            }
        }

        private DataTable filterData(DataTable dtOrigCloned)
        {
            dtOrigCloned.Columns.Add("SNo", typeof(Int32));
            int i = 1;
            foreach (DataRow dr in dtOrigCloned.Rows)
            {
                dr["SNo"] = i++;
            }

            DataTable dts = dtOrigCloned.Clone();
            DataRow[] drs2 = dtOrigCloned.Select("[" + dtOrigCloned.Columns["Default status (True=Default/False=Non Default)"] + "]" + " in ('FALSE') AND " + "[" + dtOrigCloned.Columns["sales_media_code"] + "]" + " in ('B') AND " + "([" + dtOrigCloned.Columns["Option price"] + "]" + " in (999999.99, 9999999.99, null)" + " or [" + dtOrigCloned.Columns["Option price"] + "]" + " is null )");
            foreach (DataRow dr in drs2)
            {
                dts.ImportRow(dr);
                dtOrigCloned.Rows.Remove(dr);
            }
            return dts;
        }

        private void createLookupCols(DataTable dtOrigCloned, DataTable dtFiltered)
        {
            dtOrigCloned.Columns.Add("como", typeof(string));
            dtFiltered.Columns.Add("como", typeof(string));
            foreach(DataRow dr in dtOrigCloned.Rows)
            {
                dr["como"] = dr["catalog_id"].ToString().Trim() + dr["order_code"].ToString().Trim() + dr["Module_id"].ToString().Trim() + dr["option_ID"].ToString().Trim();  
            }
            foreach(DataRow dr in dtFiltered.Rows)
            {
                dr["como"] = dr["catalog_id"].ToString().Trim() + dr["order_code"].ToString().Trim() + dr["Module_id"].ToString().Trim() + dr["option_ID"].ToString().Trim();  
            }
        }

        private void deletedLookedUpRows(DataTable dtOrigCloned, DataTable dtFiltered)
        {
            List<DataRow> deletedRows = new List<DataRow>();
            foreach(DataRow dr1 in dtOrigCloned.Rows)
            {
                foreach(DataRow dr2 in dtFiltered.Rows)
                {
                    if(dr1["como"].Equals(dr2["como"]))
                    {
                        deletedRows.Add(dr1);
                    }
                }
            }
            foreach(DataRow dr in deletedRows)
            {
                dtFiltered.ImportRow(dr);
                dtOrigCloned.Rows.Remove(dr);
            }
        }

        private DataTable deleteDuplicateRows(DataTable dTable, string colName)
        {
            Dictionary<string, string> hTable = new Dictionary<string, string>();
            List<DataRow> duplicateList = new List<DataRow>();

            //Add list of all the unique item value to hashtable, which stores combination of key, value pair.
            //And add duplicate item value in arraylist.
            foreach (DataRow drow in dTable.Rows)
            {
                if (hTable.ContainsKey(drow[colName].ToString()))
                    duplicateList.Add(drow);
                else
                    hTable.Add(drow[colName].ToString(), string.Empty);
            }

            //Removing a list of duplicate items from datatable.
            foreach (DataRow dRow in duplicateList)
                dTable.Rows.Remove(dRow);

            //Datatable which contains unique records will be return as output.
            return dTable;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadComboValues();
        }
        public void loadComboValues()
        {
            languageCombo.Items.Add(new Item("Arabic",1));
            languageCombo.Items.Add(new Item("Czech",2));
            languageCombo.Items.Add(new Item("Danish",3));
            languageCombo.Items.Add(new Item("Dutch",4));
            languageCombo.Items.Add(new Item("Finnish",5));
            languageCombo.Items.Add(new Item("FR_French",6));
            languageCombo.Items.Add(new Item("German",7));
            languageCombo.Items.Add(new Item("Greek",8));
            languageCombo.Items.Add(new Item("Hebrew",9));
            languageCombo.Items.Add(new Item("Hungarian",10));
            languageCombo.Items.Add(new Item("IN_English",11));
            languageCombo.Items.Add(new Item("Italian",12));
            languageCombo.Items.Add(new Item("Japanese",13));
            languageCombo.Items.Add(new Item("Korean",14));
            languageCombo.Items.Add(new Item("Norwegian",15));
            languageCombo.Items.Add(new Item("Polish",16));
            languageCombo.Items.Add(new Item("Portuguese",17));
            languageCombo.Items.Add(new Item("Russian",18));
            languageCombo.Items.Add(new Item("Simplified_Chinese",19));
            languageCombo.Items.Add(new Item("Slovakian",20));
            languageCombo.Items.Add(new Item("Spanish",21));
            languageCombo.Items.Add(new Item("Sweish",22));
            languageCombo.Items.Add(new Item("Taiwan_Chinese",23));
            languageCombo.Items.Add(new Item("Turkish",24));
            languageCombo.Items.Add(new Item("Ukranian",25));
            languageCombo.Items.Add(new Item("UK English",26));

            orderStatusCombo.Items.Add(new Item("A"));
            orderStatusCombo.Items.Add(new Item("N"));
            orderStatusCombo.Items.Add(new Item("A and N"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private class Item
        {
            public string Name;
            public int Value;
            public Item(string name, int value)
            {
                Name = name; Value = value;
            }
            public Item(string name)
            {
                Name = name;
                Value = -1;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }
    }
}