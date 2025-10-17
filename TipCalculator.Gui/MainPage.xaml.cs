namespace TipCalculator.Gui
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            LIMPIAR();
        }

        private void ButtonCALCULAR(object sender, EventArgs e)
        {

            decimal importedelcosumo = Convert.ToDecimal(IMPORTEDELCONSUMOENTRY.Text);
            decimal numerodepersonas = Convert.ToDecimal(NUMERODEPERSONASENTRY.Text);
            decimal porcentajedepropina = Convert.ToDecimal(PORCENTAJEDEPROPINA.Text);

            decimal propinaTotal = CalcularImporteDePropinaTotal(importedelcosumo, porcentajedepropina);
            decimal propinaPorPersona = CalcularPropinaPorPersona(propinaTotal, numerodepersonas);
            decimal importeTotal = CalcularImporteTotal(importedelcosumo, propinaTotal);
            decimal importeTotalPorPersona = CalcularImporteTotalPorPersona(importeTotal, numerodepersonas);


            IMPORTEPROPINATOTALLABEL.Text = $"{propinaTotal:C}";
            PROPINAPORPERSONALABEL.Text = $"{propinaPorPersona:C}";
            IMPORTETOLALABEL.Text = $"{importeTotal:C}";
            IMPORTETOTALPORPERSONALABEL.Text = $"{importeTotalPorPersona:C}";


        }
        decimal CalcularImporteDePropinaTotal(decimal importeConsumo, decimal porcentajePropina)
        {
            return (porcentajePropina / 100) * importeConsumo;
        }

        decimal CalcularPropinaPorPersona(decimal propinaTotal, decimal numeroPersonas)
        {
            return propinaTotal / numeroPersonas;
        }

        decimal CalcularImporteTotal(decimal importeConsumo, decimal propinaTotal)
        {
            return importeConsumo + propinaTotal;
        }

        decimal CalcularImporteTotalPorPersona(decimal importeTotal, decimal numeroPersonas)
        {
            return importeTotal / numeroPersonas;
        }




        void LIMPIAR()
        {
            IMPORTEPROPINATOTALLABEL.Text = string.Empty;
            PROPINAPORPERSONALABEL.Text = string.Empty;
            IMPORTETOLALABEL.Text = string.Empty;
            IMPORTETOTALPORPERSONALABEL.Text= string.Empty;

            IMPORTEDELCONSUMOENTRY.Text= string.Empty;
            NUMERODEPERSONASENTRY.Text = string.Empty;
            PORCENTAJEDEPROPINA.Text = string.Empty;

        }
        private void ButtonLIMPIAR(object sender, EventArgs e)
        {


            LIMPIAR();


        }
    }

}
