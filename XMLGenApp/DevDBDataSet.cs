using System.Data;

namespace XMLGenApp
{



    partial class DevDBDataSet
    {
        DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter ta_msg_gr_1 = new DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter();
        DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter ta_msg_gr_2 = new DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter();
        DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter ta_msg_gr_3 = new DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter();

        public void Filltest(int group_ID)
        {

        }

        public DevDBDataSet TypedDataSet
        {
            get { return (DevDBDataSet)NotTypedDataSet; }
        }

        private DataSet notTypedDataSet;

        public DataSet NotTypedDataSet
        {
            get { return notTypedDataSet; }
            set { notTypedDataSet = value; }
        }


    }


}




