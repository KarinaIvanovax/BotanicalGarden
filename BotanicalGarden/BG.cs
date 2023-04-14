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
            DialogResult result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Завершение работы", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BG_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Название", typeof(string));
            dt.Columns.Add("Окрас", typeof(string));
            dt.Columns.Add("Произрастает", typeof(string));

            dt.Rows.Add("Вульфения каринтская", "вечнозеленая", "Альпы, Албания");
            dt.Rows.Add("Дармера щитовидная", "розовато-белые бутоны", "на западе США");
            dt.Rows.Add("Кентрантус красный", "малиновые, светло-розовые оттенки", " Южная Европа, Средиземноморье, Северо-Западная Африка, Юго-Западная Азия");

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