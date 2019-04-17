using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpoMarkAnalizerProject
{
    public partial class JournalPanel : Component
    {
        public JournalPanel()
        {
            InitializeComponent();
        }

        public JournalPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
