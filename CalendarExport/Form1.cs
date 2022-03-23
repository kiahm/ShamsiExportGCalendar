using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarExport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var d = new SaveFileDialog()
            {
                DefaultExt = "CSV",
                Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*"
            };
            if (d.ShowDialog() == DialogResult.OK)
            {

                var year = decimal.ToInt32(mnYear.Value);
                var month = decimal.ToInt32(mnMonth.Value);
                var day = decimal.ToInt32(mnDay.Value);
                var time = dtTime.Value.ToString("HH:mm:ss tt");
                var repeat = decimal.ToInt32(mnRepeat.Value);
                
                using (var file = new StreamWriter(d.FileName))
                {
                    file.WriteLine("Subject, Start date, Start time");

                    var pc = new PersianCalendar();
                    var startDt = new DateTime(year, month, day, pc);

                    var pcs = new List<DateTime>();
                    var dts = new List<DateTime>();


                    for (var i = 0; i < repeat; i++)
                    {
                        startDt = new DateTime(year, month, day, pc);
                        
                        pcs.Add(startDt);
                        dts.Add(DateTime.Parse(startDt.ToString(CultureInfo.CreateSpecificCulture("en-US"))));
                        
                        month++;

                        if (month > 12)
                        {
                            year++;
                            month = 1;
                        }
                        
                        //file.WriteLine(startDt.ToString("d", CultureInfo.CreateSpecificCulture("fa-IR")) +", " + startDt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
                        file.WriteLine("{0}, {1}, {2}", txtTitle.Text, startDt.ToString("d", CultureInfo.CreateSpecificCulture("en-US")), time);

                    }



                    MessageBox.Show("File successfully writen", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
