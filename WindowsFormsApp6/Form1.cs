using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Classes;
using ORMi;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var helper = new WMIHelper("root\\CimV2");

            var processors = helper.Query<Win32_Processor>().ToList();
            var volumes = helper.Query<Win32_Volume>().ToList();
            var videoControllers = helper.Query<Win32_VideoController>().ToList();

            foreach (var processor in processors)
            {
                listBox1.Items.Add(Win32_Processor.ConvertArchitecture(processor.Architecture));
                listBox1.Items.Add(Win32_Processor.ConvertAvailability(processor.Availability));
                listBox1.Items.Add(Win32_Processor.ConvertCpuStatus(processor.CpuStatus));
                listBox1.Items.Add(CIM_Processor.ConvertFamily(processor.Family));
                listBox1.Items.Add(Win32_Processor.ConvertProcessorType(processor.ProcessorType));
                listBox1.Items.Add(processor.Status);
            }

            foreach (var volume in volumes)
            {
                listBox1.Items.Add(volume.Caption);
            }

            foreach (var videoController in videoControllers)
            {
                listBox1.Items.Add(videoController.Caption);
            }
        }
    }
}