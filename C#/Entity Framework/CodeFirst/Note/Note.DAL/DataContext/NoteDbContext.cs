using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Note.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.DAL.DataContext
{
    /*
     * NuGet Packages에서 아래 항목 설치
     * EntityFrameworkCore -> DbContext
     * EntityFrameworkCore.SqlServer -> UseSqlServer
     * EntityFrameworkCore.Tool -> CodeFirst를 위해(Add-Migration)
     * 
     * -> 프로젝트가 따로 존재하기 때문에 Startup Project에도 등록해줄 것
     */

    public class NoteDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public NoteDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Notice> Notices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ConnectionString은 보안상 AppSettings.json에 등록(ASP.NET Core 권장사항)
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DevDb"));
        }
    }
}
