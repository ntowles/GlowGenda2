namespace GlowGenda2
{
    public partial class FormMain : Form
    {
        int m_service = 10;
        int m_TotalServices = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        private void GetBeautiful_Click(object sender, EventArgs e)
        {
            // Schedule beauty service for $10 
            // Every time someone schedule a service our total services should increase by service price.
            // Get Beautiful
            m_TotalServices = m_TotalServices + m_service;
            // Let's display the total services variable in the label
            TotalServices.Text = m_TotalServices.ToString();
        }
    }
}
