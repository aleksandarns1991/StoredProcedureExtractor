using StoredProcedureExtractor.Models;
using System.Diagnostics;

namespace StoredProcedureExtractor.DataAccess
{
    public class FileWriter
    {
        public static int WriteToFile(IEnumerable<StoredProcedure> procedures, string dirPath)
        {
            var isDirCreated = CreateDirectory(dirPath);

            if (!isDirCreated)
            {
                return 0;
            }

            int count = 0;

            foreach (var procedure in procedures)
            {
                var filePath = Path.Combine(dirPath, procedure.ProcedureName + ".txt");

                try
                {
                    using var writer = new StreamWriter(filePath, true);
                    writer.WriteLine(procedure.SourceCode);
                    writer.Close();

                    count++;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Writing to file error: {ex.Message}");
                    continue;
                }
            }

            return count; 
        }

        private static bool CreateDirectory(string dirPath)
        {
            try
            {
                Directory.CreateDirectory(dirPath);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Directory create error: {ex.Message}");
                return false;
            }
        }
    }
}
