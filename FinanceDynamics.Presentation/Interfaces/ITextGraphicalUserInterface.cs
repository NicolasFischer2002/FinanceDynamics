namespace FinanceDynamics.Presentation.Interfaces
{
    internal interface ITextGraphicalUserInterface
    {
        int CreateMenu(string title, IReadOnlyList<string> options);
        string FillInTheRequiredFieldOnTheForm(string message);
        string? FillInTheNonMandatoryFieldOfTheForm(string message);
        string FillInTheConfidentialFieldOnTheForm(string message);
    }
}