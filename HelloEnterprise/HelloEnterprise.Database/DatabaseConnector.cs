namespace HelloEnterprise.Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DatabaseConnector
    {
        private readonly ModelDto dummyData = new ModelDto();
        public ModelDto GetData(string id)
        {
            return dummyData;

        }
    }
}
