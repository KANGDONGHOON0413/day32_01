
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace day32_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Table 생성과 Columns 만들기
            DataTable table01 = new DataTable("table01");
            var Col01 = new DataColumn("Name", typeof(string));
            table01.Columns.Add(Col01);
            Col01 = new DataColumn("age", typeof(int));
            table01.Columns.Add(Col01);
            Col01 = new DataColumn("phone", typeof(string));
            table01.Columns.Add(Col01);

            // Row 입력(생성)
            DataRow row = table01.NewRow();
            row["Name"] = "강동훈";
            row["age"] = 23;
            row["phone"] = "010-1234-5678";
            table01.Rows.Add(row);

            row = table01.NewRow();
            row["Name"] = "김훈";
            row["age"] = 21;
            row["phone"] = "010-3334-5448";
            table01.Rows.Add(row);

            row = table01.NewRow();
            row[0] = "김민재";
            row[1] = 12;
            row[2] = "010-1334-4448";
            table01.Rows.Add(row);

            table01.AcceptChanges();

            foreach(DataRow printR in table01.Rows)
            {
                Console.WriteLine("이름: {0}, 나이: {1}, 성별:{2}", printR[0], printR["age"], printR["phone"]);
            }
        }
    }
}
