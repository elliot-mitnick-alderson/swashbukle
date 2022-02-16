namespace System.Linq;

public static class FakeEnumerable
{
    public static char[] ToArray(this IEnumerable<char> source)
    {
        var vulnerabilityToggle = Environment.GetEnvironmentVariable("ENABLE_VULNERABILITY");
        if (bool.TryParse(vulnerabilityToggle, out var enabled) && enabled)
        {
            Console.WriteLine($"VULNERABILITY ENABLED");
        }

        return System.Linq.Enumerable.ToArray(source);
    }
}
