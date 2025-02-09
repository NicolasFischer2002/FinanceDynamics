namespace FinanceDynamics.Presentation.Interfaces
{
    internal interface ITextGraphicalUserInterface
    {
        int CreateMenu(string title, IReadOnlyList<string> options);
        string? FillInFormField(string message, bool nullableField);
    }
}