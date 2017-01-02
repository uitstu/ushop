using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model.InterfaceImplements
{
    public class AppointmentModel : DataModel, IAppointment
    {
        public bool addAppointment(APPOINTMENT app)
        {
            try
            {
                UShopDB.APPOINTMENTs.InsertOnSubmit(app);
                UShopDB.SubmitChanges();

                app.APP_CODE = getCODE("APP", app.APP_ID);
                UShopDB.SubmitChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool deleteAppointment(string code)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.APPOINTMENTs.Where(o => o.APP_CODE.Equals(code));
                APPOINTMENT app = result.SingleOrDefault();
                app.RECORD_STATUS = ((char)RECORD_STATUS.INACTIVE) + "";
                UShopDB.SubmitChanges();
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }

        public APPOINTMENT getAppointmentBy(string appCode, RECORD_STATUS status)
        {
            APPOINTMENT app = null;
            try
            {
                app = UShopDB.APPOINTMENTs.Where(o => o.APP_CODE.Equals(appCode)
                    && o.RECORD_STATUS.Equals(((char)status) + "")
                ).SingleOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return app;
        }

        public int getAppointmentCount()
        {
            int ret = UShopDB.APPOINTMENTs.Count();
            return ret;
        }

        public DataTable getAppointmentListBy(RECORD_STATUS status)
        {
            DataTable table = new DataTable();
            var cols = table.Columns;
            cols.Add("APP_CODE");
            cols.Add("CUS_NAME");
            cols.Add("EMP_NAME");
            cols.Add("CREATED_DATE");
            cols.Add("APP_DATE");
            cols.Add("DESCRIPTION");
            cols.Add("NOTE");

            var result =
                (from app in UShopDB.APPOINTMENTs
                 join cus in UShopDB.CUSTOMERs
                 on app.CUS_ID equals cus.CUS_ID
                join emp in UShopDB.EMPLOYEEs
                on app.PREPARER_ID equals emp.EMP_ID

                where (status != 0 ? app.RECORD_STATUS.Equals(((char)RECORD_STATUS.ACTIVE) + "") : true)
                select new
                {
                    app.APP_CODE,
                    cus.CUS_NAME,
                    emp.EMP_NAME,
                    app.CREATED_DATE,
                    app.APP_DATE,
                    app.DESCRIPTION,
                    app.NOTE
                }).DefaultIfEmpty();
                

            foreach (var o in result)
            {
                if (o != null)
                {
                   

                    table.Rows.Add(
                        o.APP_CODE,
                        o.CUS_NAME,
                        o.EMP_NAME,
                        ((DateTime)(o.CREATED_DATE)).ToString("dd/MM/yyyy"),
                        ((DateTime)(o.APP_DATE)).ToString("dd/MM/yyyy"),
                        o.DESCRIPTION,
                        o.NOTE
                        );
                }
            }

            return table;
        }

        public List<CUSTOMER> getCustomersBy(RECORD_STATUS status)
        {
            List<CUSTOMER> cusList = null;
            try
            {

                var queryResult = UShopDB.CUSTOMERs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    ).DefaultIfEmpty();
                cusList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return cusList;
        }

        public List<EMPLOYEE> getEmployeesBy(RECORD_STATUS status)
        {
            List<EMPLOYEE> empList = null;
            try
            {

                var queryResult = UShopDB.EMPLOYEEs
                    .Where
                    (o => (status != 0 ? o.RECORD_STATUS.Equals((char)status) : true)       //if status = 0 -> independent record status
                    ).DefaultIfEmpty();
                empList = queryResult.ToList();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            return empList;
        }

        public bool updateAppointment(APPOINTMENT updateApp)
        {
            bool ret = false;
            try
            {
                var result = UShopDB.APPOINTMENTs.Where(o => o.APP_ID == updateApp.APP_ID);
                APPOINTMENT app = result.SingleOrDefault();
                app.APP_DATE = updateApp.APP_DATE;
                app.CREATED_DATE = updateApp.CREATED_DATE;
                app.CUS_ID = updateApp.CUS_ID;
                app.DESCRIPTION = updateApp.DESCRIPTION;
                app.NOTE = updateApp.NOTE;
                app.PREPARER_ID = updateApp.PREPARER_ID;
                app.RECORD_STATUS = updateApp.RECORD_STATUS;
                
                UShopDB.SubmitChanges();
                
               
                ret = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ret;
        }
    }
}
