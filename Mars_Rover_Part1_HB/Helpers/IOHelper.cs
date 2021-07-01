namespace Mars_Rover_Part1_HB.Helpers
{
    public static class IOHelper
    {
        public static string[] readFile(string inputFile)
        {
            return System.IO.File.ReadAllLines(inputFile);
        }
    }
}
