using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        #region Connection
        string connectionString = @"Data Source=VANDUNXG;Initial Catalog=BookManagement;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection); // Sửa đổi đối số thứ hai thành query

                if (parameter != null)
                {
                    string[] listQuery = query.Split(' '); // Split chuỗi query để lấy tên tham số
                    int index = 0;

                    foreach (string item in listQuery)
                    {
                        if (item.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(item, parameter[index]);
                            index++;
                        }
                    }
                }

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        #endregion

        #region Events

        private void HomePage_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.Product";
            DataTable data = ExcuteQuery(query);
            dgv_ProductData.DataSource = data;

            DataTable dataCmb = ExcuteQuery("SELECT * FROM dbo.Category");
            cmb_CategoryID.DataSource = dataCmb;
            cmb_CategoryID.DisplayMember = "CategoryName";
            cmb_CategoryID.ValueMember = "CategoryID";
            cmb_CategoryID.SelectedIndex = -1;
            cmb_CategoryID.Text = "Loại sách";

            txt_Description.Enabled = false;
            txt_OnHandQuatity.Enabled = false;
            txt_ProductCode.Enabled = false;
            txt_UnitPrice.Enabled = false;

            btn_Add.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            txt_Description.Enabled = true;
            txt_OnHandQuatity.Enabled = true;
            txt_ProductCode.Enabled = true;
            txt_UnitPrice.Enabled = true;

            btn_Save.Enabled = true;
        }

        #endregion

        #region Method

        public void clearInput()
        {
            cmb_CategoryID.SelectedIndex = -1;
            cmb_CategoryID.Text = "Loại sách";
            txt_Description.Text = string.Empty;
            txt_OnHandQuatity.Text = string.Empty;
            txt_ProductCode.Text = string.Empty;
            txt_UnitPrice.Text = string.Empty;
        }

        #endregion

        private void dgv_ProductData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_ProductData.Rows.Count && e.ColumnIndex < dgv_ProductData.Columns.Count)
            {

                

                txt_ProductCode.Text = dgv_ProductData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_Description.Text = dgv_ProductData.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_UnitPrice.Text = dgv_ProductData.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_OnHandQuatity.Text = dgv_ProductData.Rows[e.RowIndex].Cells[3].Value.ToString();
                string CategoryID = dgv_ProductData.Rows[e.RowIndex].Cells[4].Value.ToString();
                DataTable data = ExcuteQuery("SELECT CategoryName FROM Category WHERE CategoryID = @CategoryID", new object[] {CategoryID} );
                cmb_CategoryID.SelectedIndex = cmb_CategoryID.FindString(data.Rows[0]["CategoryName"].ToString());
            }
        }

        private void cmb_CategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (cmb_CategoryID.SelectedIndex != -1 && txt_Description.Text.ToString() != "" && txt_OnHandQuatity.Text.ToString() != ""
               && txt_ProductCode.Text.ToString() != "" && txt_UnitPrice.Text.ToString() != "")
            {

                string CategoryID = cmb_CategoryID.SelectedValue.ToString();
                string ProductCode = txt_ProductCode.Text.ToString();
                string Description = txt_Description.Text.ToString();
                string UnitPrice = txt_UnitPrice.Text.ToString();
                string OnHandQuantity = txt_OnHandQuatity.Text.ToString();


                if (txt_ProductCode.Text.Length > 10)
                {
                    MessageBox.Show("Mã sản phẩm chỉ tối đa 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = "INSERT INTO Product (ProductCode , Desciption , UnitPrice , OnHandQuantity, CategoryID) VALUES (  @ProductCode , @Desciption , @UnitPrice , @OnHandQuantity , @CategoryID );";
                DataTable data = ExcuteQuery(query, new object[] { ProductCode, Description, UnitPrice, OnHandQuantity, CategoryID });

                HomePage_Load(sender, e);

                clearInput();
            }
        }
    }
}
