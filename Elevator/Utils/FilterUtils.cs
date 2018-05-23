using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Utils
{
    public class FilterUtils
    {
        public class FilterFormatter
        {
            private ArrayList values;
            public FilterFormatter()
            {
                values = new ArrayList();
            }

            public void addValueWithRegisters(string key, string value)
            {
                if (value != null && value != "")
                    values.Add(string.Format(" UPPER(REPLACE({0},' ','')) LIKE(UPPER(REPLACE('{1}',' ','')))", key, "%" + value + "%"));
            }

            public void addValue(string key, string value)
            {
                if (value != null && value != "")
                    values.Add(string.Format(" {0} = '{1}'", key, value));
            }

            public string getFormattedRequestForTransportation(string nameTable, string[] columns)
            {
                string res = string.Format("Select d.id_raw, c.name_contr, c.subdivision, r.name_raw, t.name_type_raw, s.name_subtype, d.{1}, st.year_crop, " +
                    "d.{2}, d.{3} From Contractor c join {0} d " +
                    "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw join Raw r on st.id_NameRaw = " +
                    "r.id_NameRaw left join Subtype_raw s on s.id_subtype = st.id_subtype left join Type_raw t on s.id_type = t.id_type where",
                    nameTable, columns[0], columns[1], columns[2]);
                if (values.Count == 0) return null;
                res += values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    res += " AND " + values[i];
                }
                return res;
            }
            public string getFormattedRequestForFindRaw()
            {
                string res = string.Format("Select st.id_raw, c.name_contr, r.name_raw, d.date_delivery From Contractor c join Delivery d " +
                    "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw join Raw r on st.id_NameRaw = " +
                    "r.id_NameRaw where ");
                if (values.Count == 0) return null;
                res += values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    res += " AND " + values[i];
                }
                return res;
            }
            public string getFormattedRequestForFindRawDate()
            {
                string res = string.Format("Select d.id_raw, c.name_contr, r.name_raw, t.name_type_raw, s.name_subtype, d.date_delivery, c.id_contractor From Contractor c join Delivery d " +
                    "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw join Raw r on st.id_NameRaw = " +
                    "r.id_NameRaw left join Subtype_raw s on s.id_subtype = st.id_subtype left join Type_raw t on s.id_type = t.id_type where ");
                if (values.Count == 0) return null;
                res += values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    res += " AND " + values[i];
                }
                return res;
            }
            public string getFormattedRequestForFindRawStorage()
            {
                string res = string.Format("Select d.id_raw, c.name_contr, r.name_raw, t.name_type_raw, s.name_subtype, cl.number_class, d.date_delivery, st.weight, c.id_contractor From Contractor c join Delivery d " +
                    "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw join Raw r on st.id_NameRaw = " +
                    "r.id_NameRaw left join Subtype_raw s on s.id_subtype = st.id_subtype left join Type_raw t on s.id_type = t.id_type " +
                    "left join Class cl on st.id_class = cl.id_class where ");
                if (values.Count == 0) return null;
                res += values[0];
                for (int i = 1; i < values.Count; i++)
                {
                    res += " AND " + values[i];
                }
                return res;
            }
        }
    }
}
