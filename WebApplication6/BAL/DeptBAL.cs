using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication6.BAL
{
    public class DeptBAL
    {
        DALL.DeptDALL objdeptd1 = new DALL.DeptDALL();
        public int _Depid;
        public string _desginationname;
        public string _Desid;

        public string Desginationname
        {
            get
            {
                return _desginationname;

            }
            set
            {
                _desginationname = value;
            }
        }

        public int Depid
        
        {
            get
            {
                return _Depid;

            }
            set
            {
                _Depid = value;
            }

        }
        public string Desid

        {
            get
            {
                return _Desid;

            }
            set
            {
                _Desid= value;
            }

        }

        public int insertdepartment()
        {
            return objdeptd1.deptmentInsert(this);
        }
        
        public DataTable viewdept()
        {
            return objdeptd1.ViewDepartment();
        }


        public int updatedept()
        {
            return objdeptd1.departmentupdate(this);
        }

        public int Deletdept()
        {
            return objdeptd1.departmentdelet(this);
        }
        public DataTable GetProduct()
        {
            return objdeptd1.GetProductDetails(this);
        }
    }
}