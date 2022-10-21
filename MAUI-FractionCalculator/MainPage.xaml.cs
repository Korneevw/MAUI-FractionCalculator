namespace MAUI_FractionCalculator;

public partial class MainPage : ContentPage
{
	public Model Model = new Model();
	public bool IsSimplifyResult { get; set; } = true;
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
    }

	private void CalculateButtonClicked(object sender, EventArgs e)
	{
		Fraction result = Model.Operation.Operate(Model.FractionA, Model.FractionB);
		if (IsSimplifyResult)
			result = FractionSimplifier.Simplify(result);
		resultNominatorEntry.Text = Math.Abs(result.Numerator).ToString();
		resultDenominatorEntry.Text = Math.Abs(result.Denominator).ToString();
		resultNegativeLabel.Text = result.IsNegative ? "+" : "-";
    }
	private void SimplifyResultCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		IsSimplifyResult = simplifyCB.IsChecked;
	}

	private void FractionANegativeCheckboxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		fractionANegativeLabel.Text = ((CheckBox)sender).IsChecked ? "+" : "-";
	}

	private void fractionBNegativeCB_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        fractionBNegativeLabel.Text = ((CheckBox)sender).IsChecked ? "+" : "-";
    }
}
