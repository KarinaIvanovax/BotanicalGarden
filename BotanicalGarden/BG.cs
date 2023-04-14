using System.Collections;
using System.Data;

namespace BotanicalGarden
{
    public partial class BG : Form
    {
        public BG()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�� ������������� ������ ������� ���������?", "���������� ������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BG_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("��������", typeof(string));
            dt.Columns.Add("�����", typeof(string));
            dt.Columns.Add("������������", typeof(string));

            dt.Rows.Add("��������� ����������", "������������", "�����, �������");
            dt.Rows.Add("������� ����������", "��������-����� ������", "�� ������ ���");
            dt.Rows.Add("���������� �������", "���������, ������-������� �������", " ����� ������, ���������������, ������-�������� ������, ���-�������� ����");

            ITable.DataSource = dt;
        }
        public class Description
        {
            public string name;
            public string colour;
            public string from;

            public Description(string _name, string _colour, string _from)
            {
                this.name = _name;
                this.colour = _colour;
                this.from = _from;

            }

        }
        List<Description> descriptions = new List<Description>();

        private void ITable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}