namespace Kairos.Desktop.Common;

internal static class ExpectedApplicationsParser
{
    public static IReadOnlyList<string> Parse(string? input)
    {
        return (input ?? string.Empty)
            .Split(',')
            .Select(app => app.Trim())
            .Where(app => app.Length > 0)
            .ToList();
    }
}
