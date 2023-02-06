namespace UnitConverter
{
    public partial class Form1 : Form
    {
        private ConverterService _converterServices;
        public Form1()
        {
            _converterServices= new ConverterService();
            InitializeComponent();

            cmbType.DataSource = Enum.GetValues(typeof(TypeEnum));
            cmbType.DropDownStyle= ComboBoxStyle.DropDownList;  // estilo para que el combo no sea editable.
            lstFrom.DataSource = Enum.GetValues(typeof(MassEnum));
            lstTo.DataSource = Enum.GetValues(typeof(MassEnum));
        }

        //vamos a crear el filtro para que el combo, cambie según la opción elegida.
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAmunt.Text = string.Empty;
            txtConverted.Text = string.Empty;

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

            if(txtAmunt.Text.Length <= 0)
                return;

            if(lstFrom.SelectedItem == lstTo.SelectedItem)
            {
                txtConverted.Text = txtAmunt.Text;
            }

            if (string.IsNullOrEmpty(txtAmunt.Text))
                throw new Exception("debe ingresar un dato.");


           var type = (TypeEnum)cmbType.SelectedItem;
            double amount = double.Parse(txtAmunt.Text);
            double convertedAmount = 0;

            switch (type)
            {
                case TypeEnum.Mass:
                    var massFrom = (MassEnum)lstFrom.SelectedItem;
                    var massTo = (MassEnum)lstTo.SelectedItem;
                    convertedAmount = _converterServices.ConvertMassUnit(massFrom, massTo, amount);
                    break;
                case TypeEnum.Tempeture:
                    var tempFrom = (TemperatureEnum)lstFrom.SelectedItem;
                    var tempTo = (TemperatureEnum)lstTo.SelectedItem;
                    convertedAmount = _converterServices.ConvertTemperatureUnit(tempFrom, tempTo, amount);

                    break;
                case TypeEnum.Time:
                    var timeFrom = (TimeEnum)lstFrom.SelectedItem;
                    var timeTo = (TimeEnum)lstTo.SelectedItem;
                    convertedAmount = _converterServices.ConvertTimeUnit(timeFrom, timeTo, amount);


                    break;


            }

            txtConverted.Text = convertedAmount.ToString();
        }



        
        //evento keypress para el texto que recibe dato a convertir, que solo sea numérico y con decimales.
        private void txtAmunt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}