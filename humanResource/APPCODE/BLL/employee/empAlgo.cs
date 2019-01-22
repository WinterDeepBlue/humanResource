using System.Data;
using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.employee
{
    public class emp_
    {
        
        CoreX obj = new CoreX();
        #region employee_groupby

        #endregion

        #region base_employee_view
        //return_emp_with_id
        public DataSet emp_list()//list for dropdown
        {//on progress fetch department department description no of emplyee
            string query = "SELECT (emp_id,emp_name) FROM employee";
            DataSet dst = obj.FillAndReturnDataSet(query);
            return dst;
        }

        
        //search_employee
        //public DataSet search_data(int emp_id)
        //{
        //    string query = "SELECT (en.emp_name,ds.designation,dp.demp_name,en.joining_date,en.state) FROM employee as en JOIN department as dp ON en.deptId=dp.deptId and en.emp_id='" + emp_id + "' JOIN designation as ds ON en.divId=ds.divId and en.emp_id='" + emp_id + "'";
        //    DataSet dst = obj.FillAndReturnDataSet(query);
        //    return dst;
        //}
        #endregion

        #region insert_value_emp
        //for_fetch_corporate_bsc_info
        
        //for_fetch_work_info_work exp
        public int basic_info(string current_emplyr, string current_post, string from_d, string to_d, string desc)
        {
            string InsertQuery = "Insert into work_exp(job_title,fromDate,to_date,job_desc,previous_comp) Values(@job_title,@fromDate,@to_date,@job_desc,@previous_comp)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            //fetchin value from emp table...
            string query = "SELECT (emp_id)FROM employee";
            DataSet dst = obj.FillAndReturnDataSet(query);
            string id = dst.Tables[0].Rows[0][0].ToString();


            nameValuePairObject.Add(new NameValuePair("@previous_comp", current_emplyr));
            nameValuePairObject.Add(new NameValuePair("@job_title", current_post));
            nameValuePairObject.Add(new NameValuePair("@fromDate", from_d));
            nameValuePairObject.Add(new NameValuePair("@to_date", to_d));
            nameValuePairObject.Add(new NameValuePair("@job_desc", desc));
            //need to get emp id from another table guessing emp table
            nameValuePairObject.Add(new NameValuePair("emp_id", id));
            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }
        //to_address_line
        public int address_line(string block, string street, string city, int zipcode, string state, string district, string country, int emp_id)
        {
            string InsertQuery = "Insert into addressline(block,street,city,zipcode,state,district,country) Values(@block,@street,@city,@zipcode,@state,@district,@country)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@block", block));
            nameValuePairObject.Add(new NameValuePair("@street", street));
            nameValuePairObject.Add(new NameValuePair("@city", city));
            nameValuePairObject.Add(new NameValuePair("@zipcode", zipcode));
            nameValuePairObject.Add(new NameValuePair("@state", state));
            nameValuePairObject.Add(new NameValuePair("@district", district));
            nameValuePairObject.Add(new NameValuePair("@country", country));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }

        //update_division_department_designation

        //division
        public int division_update(string division)
        {
            string InsertQuery = "Insert into division(div_name) Values(@div_name)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@div_name", division));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }
        //department
        public int department_update(string department)
        {
            string InsertQuery = "Insert into department(demp_name) Values(@demp_name)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@demp_name", department));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }
        //designation
        public int designation_update(string designation)
        {
            string InsertQuery = "Insert into designation(designation) Values(@designation)";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@designation", designation));

            int Status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return Status;
        }
        #endregion

        #region search_sort
        //search_data using string_like
        public DataSet search_data(string name_like)
        {
            string query = "SELECT (en.emp_name,ds.designation,dp.demp_name,en.joining_date,en.state) FROM employee as en JOIN department as dp ON en.deptId=dp.deptId and en.emp_name LIKE '%" + name_like + "%' JOIN designation as ds ON en.divId=ds.divId and en.emp_name LIKE '%" + name_like + "%'";
            DataSet dst = obj.FillAndReturnDataSet(query);
            return dst;
        }
        #endregion

        #region select_query_emp_id
        //to_fetch_single_row#3table
        public DataSet fetchdata(int emp_id)//search_data too
        {
            string query = "SELECT (en.emp_name,ds.designation,dp.demp_name,en.joining_date,en.state) FROM employee as en JOIN department as dp ON en.deptId=dp.deptId and en.emp_id='" + emp_id + "' JOIN designation as ds ON en.divId=ds.divId and en.emp_id='" + emp_id + "'";
            DataSet dst = obj.FillAndReturnDataSet(query);
            return dst;
        }
        #endregion
        
    }
}