using Microsoft.EntityFrameworkCore;

namespace ForUI.Models
{
    public class FirstContext :DbContext
    {

        public FirstContext(DbContextOptions<FirstContext> options): base(options)
        {

        }
        public  DbSet<FirstModel>FirstModels{ get; set; } = null!;
    }
}
