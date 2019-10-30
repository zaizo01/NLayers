using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace NLayers
{
    class Class_D
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
        public DataTable D_login(Class_E obj) {
            SqlCommand cmd = new SqlCommand("sp_Login", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user", obj.user);
            cmd.Parameters.AddWithValue("@pass", obj.pass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtabla = new DataTable();
            da.Fill(dtabla);
            return dtabla;
        }
    }
}
