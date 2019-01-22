using System.Data;
using humanResource.APPCODE.DAL;

namespace humanResource.APPCODE.BLL.employee
{
    public class EmployeeInfo
    {
        CoreX obj= new CoreX();
        #region InsertQuery
        //for_insertE_info
        public int Employee(string empId,string empName,string phoneNo,string altPhoneNo,string officeMail,string alterMail,string state,string joiningDate,string techPreview,string language,string gender,string age,string desgId,string deptId)
        {
            string InsertQuery = "Insert into employee(empId,empName,phoneNo,altPhoneNo,officeMail,alterMail,state,joiningDate,tech_priview,language,gender,age,divId,desgId,deptId) Values(@empId,@empName,@phoneNo,@altPhoneNo,@officeMail,@alterMail,@state,@joiningDate,@tech_priview,@language,@gender,@age,@desgId,@deptId)";
            //change#_highlights empid to type->guid

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empId));
            nameValuePairObject.Add(new NameValuePair("@empName", empName));
            nameValuePairObject.Add(new NameValuePair("@phoneNo", phoneNo));
            nameValuePairObject.Add(new NameValuePair("@altPhoneNo", altPhoneNo));
            nameValuePairObject.Add(new NameValuePair("@officeMail", officeMail));
            nameValuePairObject.Add(new NameValuePair("@alterMail", alterMail));
            nameValuePairObject.Add(new NameValuePair("@state", state));
            nameValuePairObject.Add(new NameValuePair("@joiningDate", joiningDate));
            nameValuePairObject.Add(new NameValuePair("@techPreview", techPreview));
            nameValuePairObject.Add(new NameValuePair("@language", language));
            nameValuePairObject.Add(new NameValuePair("@genger", gender));
            nameValuePairObject.Add(new NameValuePair("@age", age));
            nameValuePairObject.Add(new NameValuePair("@desgId", desgId));
            nameValuePairObject.Add(new NameValuePair("@deptId", deptId));
            
            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }

        //for_insert_basic_info
        public int BasicInfo(string empId, string empType, string grad, string mName, string fName,string citizenship,string dob,string maritialStatus)
        {
            string InsertQuery = "Insert into employee(empId,empType,grad,mname,fname,citizenship,dob,maritalStatus) Values (@empId,@empType,@grad,@mname,@fname,@citizenship,@dob,@maritalStatus)";
            //change#_highlights empid to type->guid

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empId));
            nameValuePairObject.Add(new NameValuePair("@empType", empType));
            nameValuePairObject.Add(new NameValuePair("@grad", grad));
            nameValuePairObject.Add(new NameValuePair("@mname", mName));
            nameValuePairObject.Add(new NameValuePair("@fname", fName));
            nameValuePairObject.Add(new NameValuePair("@citizenship", citizenship));
            nameValuePairObject.Add(new NameValuePair("@dob", dob));
            nameValuePairObject.Add(new NameValuePair("@maritalStatus", maritialStatus));
            
            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }

        //for_addressline
        public int Addressline(string addressId, string block, string street, string city, string zipcode, string state, string district, string origin,string country,string empId)
        {
            string InsertQuery = "Insert into employee(addressLineId,block,street,city,zipcode,state,district,origin,country,empId) Values(@addressLineId,@block,@street,@city,@zipcode,@state,@district,@origin,@country,@empId)";
            //change#_highlights empid to type->guid

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@addressLineId", addressId));
            nameValuePairObject.Add(new NameValuePair("@block", block));
            nameValuePairObject.Add(new NameValuePair("@street", street));
            nameValuePairObject.Add(new NameValuePair("@city", city));
            nameValuePairObject.Add(new NameValuePair("@zipcode", zipcode));
            nameValuePairObject.Add(new NameValuePair("@state", state));
            nameValuePairObject.Add(new NameValuePair("@district", district));
            nameValuePairObject.Add(new NameValuePair("@origin", origin));
            nameValuePairObject.Add(new NameValuePair("@country", country));
            nameValuePairObject.Add(new NameValuePair("@empId", empId));
           
            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }

        //traning&-development
        public int TraningNdevop(int srNo, int traningS , string traningCode, string traningName, string empId)
        {
            string InsertQuery = "Insert into employee(srNo,traningSessionId,traningCode,traningName,empId)Values(@srNo,@traningSessionId,@traningCode,@traningName,@empId)";
            //change#_highlights empid to type->guid

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@srNo", srNo));
            nameValuePairObject.Add(new NameValuePair("@traningSessionId", traningS));
            nameValuePairObject.Add(new NameValuePair("@traningCode", traningCode));
            nameValuePairObject.Add(new NameValuePair("@traningName", traningName));
            nameValuePairObject.Add(new NameValuePair("@empId", empId));

            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }

        //work&-exp
        public int WorkExp(int workPid, int jobTitle, string fromDate, string toDate, string jobDesc,string previousComp,string empId)
        {
            string InsertQuery = "Insert into employee(empName,joiningDate,empId,alterMail,officeMail,phoneNo,gender,maritalStatus,citizenship,altPhoneNo,empType,state,grad) Values(@empName,@joiningDate,@empId,@alterMail,@officeMail,@phoneNo,@gender,@maritalStatus,@citizenship,@altPhoneNo,@empType,@state,@grad)";
            //change#_highlights empid to type->guid

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@workPid",workPid));
            nameValuePairObject.Add(new NameValuePair("@fromDate", fromDate));
            nameValuePairObject.Add(new NameValuePair("@toDate", toDate));
            nameValuePairObject.Add(new NameValuePair("@jobDesc", jobDesc));
            nameValuePairObject.Add(new NameValuePair("@previoudComp", previousComp));
            nameValuePairObject.Add(new NameValuePair("@empId", empId));
            int status = obj.InsertUpdateOrDelete(InsertQuery, nameValuePairObject);
            return status;
        }
        #endregion

        #region SelectQuery

        #region Employee
            public DataSet Ftechbyempid(string empid)
                        {
                            string squery="SELECT * FROM employee WHERE empId='"+empid+"'";
                            DataSet data = obj.FillAndReturnDataSet(squery);
                            return data;
                        }
        #endregion

        #region Basic
            public DataSet FetchBasic(string empid)
                        {
                            string squery="SELECT * FROM employee WHERE empId='"+empid+"'";
                            DataSet data = obj.FillAndReturnDataSet(squery);
                            return data;
                        }
        #endregion

        #region addressline
            public DataSet FetchAddressline(string empid)
                        {
                            string squery="SELECT * FROM employee WHERE empId='"+empid+"'";
                            DataSet data = obj.FillAndReturnDataSet(squery);
                            return data;
                        }
        #endregion

        #region WorkExperiance
            public DataSet FetchWorkep(string empid)
                        {
                            string squery="SELECT * FROM employee WHERE empId='"+empid+"'";
                            DataSet data = obj.FillAndReturnDataSet(squery);
                            return data;
                        }
        public DataSet FetchWorkepByName(string ename)
        {
            string squery="SELECT * FROM employee WHERE empName LIKE '%" + ename + "%'";
            DataSet data = obj.FillAndReturnDataSet(squery);
            return data;
        }
        #endregion
            
        #region  BulckView
            public DataSet FtechBulkInfo(string empid)
            {
                string query = "SELECT (en.empName,ds.designation,dp.dempName,en.joiningDate,en.state) FROM employee as en JOIN department as dp ON en.deptId=dp.deptId and en.empId='" + empid + "' JOIN designation as ds ON en.divId=ds.divId and en.empId='" + empid + "'";
                DataSet data = obj.FillAndReturnDataSet(query);
                return data;
            }
        #endregion
        
        #region EnameSearch
            public DataSet EmpSearchbyName(string empname)
            {
                string query = "SELECT (en.empName,ds.designation,dp.dempName,en.joiningDate,en.state) FROM employee as en JOIN department as dp ON en.deptId=dp.deptId and en.empName LIKE '%" + empname + "%' JOIN designation as ds ON en.divId=ds.divId and en.empName LIKE '%" + empname + "%'";
                DataSet dst = obj.FillAndReturnDataSet(query);
                return dst;
            }
        #endregion
        
        #endregion

        #region updateQuery
        
        

        #endregion

        #region deleteQuery
        //--------------------------------employee----------------------------
        public int DELemployee(string empid)
        {
            string delQuery = "DELETE FROM employee WHERE empId='"+empid+"'";
            
            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empid));
            
            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        //--------------------------------------------addressline---------------
        public int DELaddressline(string empid)
        {
            string delQuery = "DELETE FROM addressline WHERE empId='" + empid + "'";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empid));

            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        //--------------------------------basic------------------------
        public int DELbasic(string empid)
        {
            string delQuery = "DELETE FROM basic WHERE empId='" + empid + "'";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empid));

            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        //-----------------------------------traningNdev---------------------------------
        public int DELtraningNdev(string empid)
        {
            string delQuery = "DELETE FROM workExp WHERE empId='" + empid + "'";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empid));

            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        public int DELworkExp(string empid)
        {
            string delQuery = "DELETE FROM workExp WHERE empId='" + empid + "'";

            NameValuePairList nameValuePairObject = new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empId", empid));

            int status = obj.InsertUpdateOrDelete(delQuery, nameValuePairObject);
            return status;
        }
        //-------------------------------from-employee-by name----------------------------------
        public int DeleteByName(string empname)
        {
            string delquery="DELETE FROM employee WHERE empName LIKE '%"+empname+"%'";
            NameValuePairList nameValuePairObject =new NameValuePairList();
            nameValuePairObject.Add(new NameValuePair("@empName",empname));
            int status = obj.InsertUpdateOrDelete(delquery, nameValuePairObject);
            return status;
        }
        #endregion
    }


}