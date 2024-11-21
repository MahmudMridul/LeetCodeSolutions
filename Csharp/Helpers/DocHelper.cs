
namespace Csharp.Helpers
{
    public class DocHelper
    {
        public void GetAllEasyProblems()
        {
            string folderPath = @"D:\Codes\LeetCodeSolutions\Csharp\Easy";
            string output = "names.txt";

            try
            {
                string[] files = Directory.GetFiles(folderPath);
                int index = files[0].IndexOf("Csharp");
                for (int i = 0; i < files.Length; ++i)
                {
                    string filePath = files[i].Substring(index);
                    string mdString = GetListAndLinkStringForMd(filePath, i);
                    files[i] = mdString;
                }
                File.WriteAllLines(output, files);
                Console.WriteLine($"File list written to '{output}' successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public string GetListAndLinkStringForMd(string filePath, int n)
        {
            string fileNameWithExtension = filePath.Substring( filePath.IndexOf("LC") );
            string fileName = fileNameWithExtension.Split('.')[0];
            string problemNo = fileName.Split('_')[1];
            string mdString = $"{n + 1}. [LC {problemNo}]({filePath})";
            mdString = mdString.Replace('\\', '/');
            return mdString;
        }
    }
}
