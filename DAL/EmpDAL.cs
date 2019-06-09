﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using Dapper;

namespace DAL
{
    public class EmpDAL:DBconnection
    {

        public int CheckAccount(EmpDTO emp)
        {
            con.Open();
            string SQL = string.Format("SELECT * FROM employee WHERE EmployeeID = {0} AND [Password] = {1}", emp.EmployeeID, emp.password);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader rd = cmd.ExecuteReader();
            int loginSuccessful;
            rd.Read();
            if (rd.HasRows)
            {
                if (rd["IsAdmin"].ToString() == "admin")
                {
                    loginSuccessful = 2;
                }
                else
                {
                    loginSuccessful = 1;
                }
            }
            else
            {
                loginSuccessful = 0;
            }
            con.Close();
            return loginSuccessful;
        }

        public EmpDTO Get(int EID)
        {
            try
            {
                con.Open();
                return con.QueryFirst<EmpDTO>("select * from Employee where EmployeeID=@EID", new { EID });
            }

            catch (Exception e) { }

            finally
            { con.Close(); }


            return null;

        }

        public bool InsertEmp(EmpDTO emp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Insert into Employee(EmployeeName,[Password],[Status],IsAdmin) values ('{0}','{1}','{2}','{3}')", emp.EmployeeName, emp.password, emp.Status, emp.IsAdmin);

                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        /*Update Employee*/
        public bool UpdateEmp( int EmployeeID, string EmployeeName,string Password, string Status, string IsAdmin)
        {
            try
            {
                con.Open();
                string SQL = string.Format("Update employee set EmployeeName='{0}', Password='{1}', IsAdmin='{2}', Status='{3}' where EmployeeID ='{4}'",
                  EmployeeName, Password, IsAdmin, Status, EmployeeID);
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public DataTable Display(string sql)
        {
            DataTable tbemp = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd;
                adt.Fill(tbemp);
                return tbemp;
            }

            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }

    }
    }

