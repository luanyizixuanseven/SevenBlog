using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Seven.DAL
{
    public class BaseDBContext 
    {
        private DDLDBContext _ddlDB = null;
        private DMLDBContext _dmlDB = null;

        public BaseDBContext(DDLDBContext update, DMLDBContext read)
        {
            _ddlDB = update;
            _dmlDB = read;
        }

        public BaseDBContext() {
            _ddlDB = new DDLDBContext();
            _dmlDB = new DMLDBContext();
        }


    }
}
