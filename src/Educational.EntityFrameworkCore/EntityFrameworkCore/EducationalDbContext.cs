﻿using Educational.Organization;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Educational.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class EducationalDbContext :
    AbpDbContext<EducationalDbContext>
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity

    #endregion

    public EducationalDbContext(DbContextOptions<EducationalDbContext> options)
        : base(options)
    {

    }
    /// <summary>
    /// 数据集
    /// </summary>
    public DbSet<OrganizationModel> OrganizationModels { get; set; }
    public DbSet<OrganizationLevel> OrganizationLevels { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(EducationalConsts.DbTablePrefix + "YourEntities", EducationalConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});
        //部门机构管理
        builder.Entity<OrganizationModel>(b =>
        {
            b.ToTable(EducationalConsts.DbTablePrefix + "OrganizationModels", EducationalConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            // ... 其它字段同理，添加 .HasComment("xxx") ...
        });
        //部门机构级别管理
        builder.Entity<OrganizationLevel>(b =>
        {
            b.ToTable(EducationalConsts.DbTablePrefix + "OrganizationLevel", EducationalConsts.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Id).IsRequired().HasMaxLength(128);
            // ... 其它字段同理，添加 .HasComment("xxx") ...
        });
    }
}
