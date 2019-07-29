using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class SuggestRepository
    {
        private SQLContext _sqlContext;
        public SuggestRepository()
        {
            _sqlContext = new SQLContext();
        }

        public Suggest Save(Suggest suggest)
        {
            _sqlContext._suggests.Add(suggest);
            //_sqlContext.SaveChanges();
            return suggest;
        }
    }
}
