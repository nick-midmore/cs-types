class NorthcodersStudent
{
    public bool IsDebugging { get; set; }
    public string Name { get; set; }
    public int YearsCoding { get; set; }
    public string CodingAffiliation { get; set; } = "Northcoders";

    public NorthcodersStudent()
    {

    }
    public void CheckIfDebugging()
    {
        if (IsDebugging)
        {
            Console.WriteLine("Defeating bugs in code...");
        }
        else
        {
            Console.WriteLine("Bugs defeated, happy coding!");
        }
    }
}