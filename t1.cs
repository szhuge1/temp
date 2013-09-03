using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Panel1.Attributes.Add("style", "DISPLAY: none; POSITION: absolute");
            this.Panel2.Attributes.Add("style", "DISPLAY: none; POSITION: absolute");
        }

        protected void InitCaltulateTotalDays()
        {
            if ((txtStartDate.Text.Trim() == "") || (txtEndDate.Text.Trim() == ""))
            {
                return;
            }
            else
            {
                int result = calculateTotalDays();
                txtNoofDay.Text = result.ToString();
            }
        }

        protected int calculateTotalDays()
        {
            DateTime start = DateTime.ParseExact(txtStartDate.Text.Trim(), "dd-MM-yyyy", null);  //start of date
            DateTime end = DateTime.ParseExact(txtEndDate.Text.Trim(), "dd-MM-yyyy", null);    //end of date

            TimeSpan span = end - start; //total date
            int totalDays = (int)span.TotalDays + 1;
            int mon = 0;
            int tue = 0;
            int wed = 0;
            int thu = 0;
            int fri = 0;
            int sat = 0;
            int sun = 0;

            //if monday is checked
            if (chkM.Checked) mon = CountDays(DayOfWeek.Monday, start, end);
            //if tuesday is checked
            if (chkT.Checked) tue = CountDays(DayOfWeek.Tuesday, start, end);
            //if wednesday is checked
            if (chkW.Checked) wed = CountDays(DayOfWeek.Wednesday, start, end);
            //if thursday is checked
            if (chkTh.Checked) thu = CountDays(DayOfWeek.Thursday, start, end);
            //if friday is checked
            if (chkF.Checked) fri = CountDays(DayOfWeek.Friday, start, end);
            //if saturday is checked
            if (chkS.Checked) sat = CountDays(DayOfWeek.Saturday, start, end);
            //if sunday is checked
            if (chkSun.Checked) sun = CountDays(DayOfWeek.Sunday, start, end);

            int result = totalDays - mon - tue - wed - thu - fri - sat - sun;

            return result;
        }

        protected int CountDays(DayOfWeek day, DateTime start, DateTime end)
        {
            TimeSpan ts = end - start;                       // Total duration
            int count = (int)Math.Floor(ts.TotalDays / 7);   // Number of whole weeks
            int remainder = (int)(ts.TotalDays % 7);         // Number of remaining days
            int sinceLastDay = (int)(end.DayOfWeek - day);   // Number of days since last [day]
            if (sinceLastDay < 0) sinceLastDay += 7;         // Adjust for negative days since last [day]

            // If the days in excess of an even week are greater than or equal to the number days since the last [day], then count this one, too.
            if (remainder >= sinceLastDay) count++;

            return count;
        }

        protected void Check_ClickedM(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedT(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedW(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedTh(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedF(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedS(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void Check_ClickedSun(object sender, EventArgs e)
        {
            InitCaltulateTotalDays();
        }

        protected void btnPopup1_Click(object sender, EventArgs e)
        {
            this.Panel1.Attributes.Clear();
            this.Panel1.Attributes.Add("style"," POSITION: absolute");
        }

        protected void btnPopup2_Click(object sender, EventArgs e)
        {
            this.Panel2.Attributes.Clear();
            this.Panel2.Attributes.Add("style", " POSITION: absolute");
        }

        protected void startDateCal_SelectionChanged(object sender, EventArgs e)
        {
            this.txtStartDate.Text = startDateCal.SelectedDate.ToString("dd-MM-yyyy");
            this.Panel1.Attributes.Add("style", "DISPLAY: none; POSITION: absolute");
            InitCaltulateTotalDays();
        }

        protected void endDateCal_SelectionChanged(object sender, EventArgs e)
        {
            this.txtEndDate.Text = endDateCal.SelectedDate.ToString("dd-MM-yyyy");
            this.Panel2.Attributes.Add("style", "DISPLAY: none; POSITION: absolute");
            InitCaltulateTotalDays();
        }

    }
}
