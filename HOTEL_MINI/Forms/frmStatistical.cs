using HOTEL_MINI.BLL;
using HOTEL_MINI.Forms;
using HOTEL_MINI.Forms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MINI.Forms
{
    public partial class frmStatistical : Form
    {
        private readonly UcRevenue _ucRevenue;
        private readonly UcRoomStatiscal _ucRoomStatistical;
        public frmStatistical()
        {
            InitializeComponent();
            _ucRevenue = new UcRevenue() { Dock = DockStyle.Fill };
            tabRevenue.Controls.Add(_ucRevenue);

            _ucRoomStatistical = new UcRoomStatiscal() { Dock = DockStyle.Fill };
            tabRoom.Controls.Add(_ucRoomStatistical);

        }
    }
}
