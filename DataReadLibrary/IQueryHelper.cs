namespace DataReadLibrary
{
    public interface IQueryHelper
    {
        string StudentFacultyRead { get; }

        string? GetProviderFromConfiguration();
    }
}