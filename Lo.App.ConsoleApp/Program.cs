using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lo.Data.Repository.Repository;

namespace Lo.App.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "select count(1) from comment";

            var db = new RepositoryFactory().BaseRepository("Data Source=127.0.0.1;Initial Catalog=demo;User ID=sa;Password=luo123456;");
           var count= db.FindObject(sql);

            Console.WriteLine($"评论数量：{count}");
            Console.ReadKey();
        }
    }
}
