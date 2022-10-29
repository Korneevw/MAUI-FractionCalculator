namespace MAUI_FractionCalculator;

public partial class MainPage : ContentPage
{
	public Model Model = new Model();
	public bool IsToSimplifyResult { get; set; } = true;
	public bool IsResultAsImproperFraction { get; set; } = false;

	public MainPage()
	{
        Model.Operation = Model.Operations[0];
        InitializeComponent();
		fractionANegativeLabel.BindingContext = Model.FractionA;
		fractionA.BindingContext = Model.FractionA;
		fractionANegativeCB.BindingContext = Model.FractionA;

        operatorPicker.BindingContext = Model;

        fractionBNegativeLabel.BindingContext = Model.FractionB;
        fractionB.BindingContext = Model.FractionB;
        fractionBNegativeCB.BindingContext = Model.FractionB;

        simplifyCB.BindingContext = this;
        resultMixedCB.BindingContext = this;
    }

	private void CalculateButtonClicked(object sender, EventArgs e)
	{
        MixedFraction result = new MixedFraction(Model.Operation.Operate(Model.FractionA, Model.FractionB));

		if (IsToSimplifyResult)
		{
            result = FractionSimplifier.SimplifyMixed(result);
        }
		
		if (IsResultAsImproperFraction)
		{
			result = new MixedFraction(0, result.Numerator, result.Denominator);
		}

        fractionResult.BindingContext = result;
        resultNegativeLabel.BindingContext = result;
    }

	private void FractionANegativeCheckboxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		fractionANegativeLabel.Text = ((CheckBox)sender).IsChecked ? "-" : "+";
	}

	private void fractionBNegativeCB_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        fractionBNegativeLabel.Text = ((CheckBox)sender).IsChecked ? "-" : "+";
    }
}
