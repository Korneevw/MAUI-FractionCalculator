namespace MAUI_FractionCalculator;

public partial class MainPage : ContentPage
{
	public FractionOperation Operation { get; set; }
	public Fraction FractionA { get; set; } = new Fraction(1, 1);
	public Fraction FractionB { get; set; } = new Fraction(1, 1);
	public List<FractionOperation> Operations { get; private set; } = new List<FractionOperation>()
	{
		new Addition(),
		new Substraction(),
		new Multiplication(),
		new Division(),
	};
	public MainPage()
	{
        Operation = Operations[0];
        InitializeComponent();
        operatorPicker.BindingContext = this;
		fractionA.BindingContext = FractionA;
		fractionB.BindingContext = FractionB;
    }

	private void CalculateButtonClicked(object sender, EventArgs e)
	{
		Fraction result = FractionSimplifier.Simplify(Operation.Operate(FractionA, FractionB));
		resultNominatorEntry.Text = result.Numerator.ToString();
		resultDenominatorEntry.Text = result.Denominator.ToString();
	}
}
