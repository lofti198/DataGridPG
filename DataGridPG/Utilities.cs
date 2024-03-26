using System;
using System.Data;
using System.Threading.Tasks;

namespace DataGridPG
{
    public static class Utilities
    {
        public static async Task<DataTable> GenerateDataTableWithNRowsAsync(int N)
        {
            return await Task.Run(() => GenerateDataTableWithNRows(N));

        }
        public static DataTable GenerateDataTableWithNRows(int N)
        {
            // Create a new DataTable object
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Beruf", typeof(string));

            // Add N rows to the DataTable
            for (int i = 1; i <= N; i++)
            {
                // Each row can have default or sequential values. Here we use sequential for demonstration.
                dataTable.Rows.Add(i, $"Name {i}", $"Beruf {i}");
            } 

            return dataTable;
        }

    }
}
