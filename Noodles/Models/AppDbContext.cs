using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Noodles.Models;

public class AppDbContext: IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        Console.WriteLine("OnModelCreating");
        Console.WriteLine("Noodles have been added");
        
        modelBuilder.Entity<Noodle>().HasData
        (
            new Noodle { Id = 1, Name = "毛细", Price = 12, ShortDescription = "如发丝般细", LongDescription = "真的好细好细好细啊", ImageUrl="/images/毛细.png"},
            new Noodle { Id = 2, Name = "细", Price = 10, ShortDescription = "普通细", LongDescription = "还是挺细的", ImageUrl="/images/细.png"},
            new Noodle { Id = 3, Name = "三细", Price = 11, ShortDescription = "有点粗了", LongDescription = "比细的粗点，比二细细点", ImageUrl="/images/三细.png"},
            new Noodle { Id = 4, Name = "二细", Price = 10, ShortDescription = "粗了", LongDescription = "粗的才有嚼劲", ImageUrl="/images/二细.png"},
            new Noodle { Id = 5, Name = "二柱子", Price = 11, ShortDescription = "太粗了", LongDescription = "粗得快咬不动了", ImageUrl="/images/二柱子.png"},
            new Noodle { Id = 6, Name = "韭叶子", Price = 12, ShortDescription = "扁的", LongDescription = "韭猜叶一样宽", ImageUrl="/images/韭叶子.png"},
            new Noodle { Id = 7, Name = "薄宽", Price = 11, ShortDescription = "开始宽了", LongDescription = "比韭叶宽一点，比大宽窄一点", ImageUrl="/images/薄宽.png"},
            new Noodle { Id = 8, Name = "大宽", Price = 10, ShortDescription = "裤带面", LongDescription = "比嘴还宽了", ImageUrl="/images/大宽.png"},
            new Noodle { Id = 9, Name = "荞麦棱子", Price = 15, ShortDescription = "立方体的", LongDescription = "好像知道师傅怎么拉出来的", ImageUrl="/images/荞麦棱子.png"},
            new Noodle { Id = 10, Name = "一窝丝", Price = 15, ShortDescription = "这是啥", LongDescription = "我也没吃过", ImageUrl="/images/一窝丝.png"}
        );

        modelBuilder.Entity<Feedback>().HasData
        (
            new Feedback { Id = 1, Name = "阿莱克斯", Email = "noname@hotmail.com", Message = "真的好细好细好细啊", CreateDateUTC = DateTime.UtcNow},
            new Feedback { Id = 2, Name = "莱克斯", Email = "noname@hotmail.com", Message = "还是挺细的", CreateDateUTC = DateTime.UtcNow},
            new Feedback { Id = 3, Name = "克斯", Email = "noname@hotmail.com", Message = "比细的粗点，比二细细点", CreateDateUTC = DateTime.UtcNow},
            new Feedback { Id = 4, Name = "克斯", Email = "noname@hotmail.com", Message = "粗的才有嚼劲", CreateDateUTC = DateTime.UtcNow}
        );
    }

    public DbSet<Noodle> Noodles { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
}