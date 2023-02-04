namespace UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbType.DataSource = Enum.GetValues(typeof(TypeEnum));
            cmbType.DropDownStyle= ComboBoxStyle.DropDownList;  // estilo para que el combo no sea editable.
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
        }

        //vamos a crear el filtro para que el combo, cambie según la opción elegida.
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //casteamos porque sabemos exactamente que tipo de objeto queremos.
            var type = (TypeEnum)cmbType.SelectedItem;

            switch (type)
            {
                case TypeEnum.Mass:
                    lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
                    break;
                case TypeEnum.Tempeture:
                    lstFrom.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TemperatureEnum));
                    break;
                case TypeEnum.Time:
                    lstFrom.DataSource = Enum.GetValues(typeof(TimeEnum));
                    lstTo.DataSource = Enum.GetValues(typeof(TimeEnum));
                    break;
                default:
                    break;
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

        }
    }
}