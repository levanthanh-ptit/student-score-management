using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DX_Student_Score_Management
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        ConnectionData connectionData;
        public FormMain(ConnectionData connectionData)
        {
            InitializeComponent();
            this.connectionData = connectionData;
        }
    }
}
