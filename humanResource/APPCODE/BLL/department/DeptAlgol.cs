using System.Data;
using System.Security.Cryptography;
using System.Text;
using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.department
{
//using humanResource.BLL.department;
    public class GUID//basic->hash
    {
        #region level_1
        public string hashFunc(string buffer)
        {
            using (MD5 mHash = MD5.Create())
            {
                string hash = GetM_hash(mHash, buffer);
                return hash;
            }
        }
        #endregion


        #region level_1>submethod
        //creating->hash(bundle)
        private string GetM_hash(MD5 mHash, string buffer)
        {
            byte[] hash = mHash.ComputeHash(Encoding.UTF8.GetBytes(buffer));
            //initiating string-?bundler>
            StringBuilder stBuild = new StringBuilder();
            //bundler
            for (int i = 0; i < hash.Length; i++)
                stBuild.Append(hash[i].ToString("x2"));
            //return->bundlestringcase->hashfunc
            return stBuild.ToString();
        }


        #endregion


    }

    public class Depts:Bundler
    {
        
    }
    
    public class Bundler
    {

        CoreX _dObj = new CoreX();
        //to add_all record at once-> return dataset on sucess
        public DataSet add_division(string divVal, string dept, string desg)
        {

            DivisionQuery divObj = new DivisionQuery();
            if (divVal != (null))
            {
                //divObj.division_insert(divVal);
            }
            DataSet ds = new DataSet();

            ds.Tables.Add("Properties");//table->name
            DataRow dr = ds.Tables[0].NewRow();
            // gu_id gu = new gu_id();



            // dr["div"] = div;//adding div with attribute_name_div
            dr["dept"] = dept;//adding dept with dept
            dr["division"] = desg;//adding division with desg
            ds.Tables[0].Rows.Add(dr);// adding rows to table->0 



            //update_state
            string dv_query = "INSERT INTO division(div_name) VALUES (@div_name)";
            string dp_query = "INSERT INTO department(demp_name) VALUES (@demp_name)";
            string ds_query = "INSERT INTO designation(designation)VALUES (@dsg_name)";

            return ds;
        }

    }
}