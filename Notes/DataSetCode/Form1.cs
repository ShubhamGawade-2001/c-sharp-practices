using Microsoft.Data.SqlClient;
using System.Data;

namespace DataSetCode
{
    public partial class Form1 : Form
    {
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=ActsJan25;Integrated Security=True";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Employees";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                ds = new DataSet();

                da.Fill(ds, "Emps");

                cmd.CommandText = "select * from Departments";
                da.Fill(ds, "Deps");

                //constraints
                //primary key constraint

                DataColumn[] arrCols = new DataColumn[1];
                arrCols[0] = ds.Tables["Emps"].Columns["EmpNo"];
                ds.Tables["Emps"].PrimaryKey = arrCols;

                //foreign key constraint
                ds.Relations.Add(ds.Tables["Deps"].Columns["DeptNo"],
                    ds.Tables["Emps"].Columns["DeptNo"]);

                //column level constraint
                ds.Tables["Deps"].Columns["DeptName"].Unique = true;

                //dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.DataSource = ds.Tables["Emps"];
                //dataGridView1.DataSource = ds.Tables["Deps"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDb)\MsSqlLocalDb;Initial Catalog=ActsJan25;Integrated Security=True";
            try
            {
                cn.Open();
                //SqlCommand cmd = cn.CreateCommand();
                SqlCommand cmdUpdate = new SqlCommand();
                cmdUpdate.Connection = cn;
                cmdUpdate.CommandType = CommandType.Text;
                cmdUpdate.CommandText = "update Employees set Name=@Name,Basic=@Basic,DeptNo=@DeptNo where EmpNo=@EmpNo";

                //SqlParameter p;
                //p = new SqlParameter();
                //p.ParameterName = "@Name";
                //p.SourceColumn = "Name";
                //p.SourceVersion = DataRowVersion.Current;
                //cmdUpdate.Parameters.Add(p);

                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdUpdate.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

                //insert

                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values(@EmpNo,@Name,@Basic,@DeptNo)";

                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                //delete
                SqlCommand cmdDelete = new SqlCommand();
                cmdDelete.Connection = cn;
                cmdDelete.CommandType = System.Data.CommandType.Text;
                cmdDelete.CommandText = "delete from Employees where EmpNo =@EmpNo"; ;

                cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = cmdInsert;
                da.UpdateCommand = cmdUpdate;
                da.DeleteCommand = cmdDelete;
                //da.ContinueUpdateOnError = true;
                da.Update(ds, "Emps");
                ds.AcceptChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ds.WriteXmlSchema("emps.xsd"); //schema/constraints
            ds.WriteXml("emps.xml", XmlWriteMode.DiffGram); //data

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            ds.ReadXmlSchema("emps.xsd");
            ds.ReadXml("emps.xml", XmlReadMode.DiffGram);
            dataGridView1.DataSource = ds.Tables["Emps"];

        }
    }
}
