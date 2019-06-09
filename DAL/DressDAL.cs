﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DressDAL: DBconnection
    {
        public DataTable InsertDress(DressDTO dress)
        {
            DataTable dtDress = new DataTable();
            con.Open();
            string SQL = string.Format("Insert into dress values ('{0}','{1}','{2}')",
                 dress.DressName, dress.DressDecription, dress.DressPrice);
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtDress);
            con.Close();
            return dtDress;
        }

        public bool UpdateDress(int DressID, string DressName, float DressPrice, string DressDecription)
        {
            try
            { 
                con.Open();
                string SQL = string.Format("Update Dress set DressName = '{0}', DressDecription = '{1}', Price = '{2}' where DressID = '{3}'",
                     DressName, DressDecription, DressPrice, DressID);
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

        public DataTable ShowAllDress()
        {
            DataTable dtDress = new DataTable();
            con.Open();
            string SQL = string.Format("select dress.DressID, dress.DressName, dress.DressDecription, dress.Price, Stock.DressQuant from dress join Stock on dress.DressID = Stock.DressID;");
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            adt.Fill(dtDress);
            con.Close();
            return dtDress;
        }

        public DataTable Display(string sql)
        {
            DataTable tblDress = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblDress);  //Fill vào một biến kiểu Datatable
                return tblDress;
            }

            catch (Exception e) { }

            finally
            {
                con.Close();
            }

            return null;
        }
    }
}
