using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTierProject.CORE.Mapping
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : CoreEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).HasColumnName("ID");
            builder.Property(x => x.Status).IsRequired(true);//Boş bırakılamaz.
            builder.Property(x => x.CreatedComputerName).HasColumnName("CreatedComputerName").IsRequired(false);//boş geçilebilir
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate").IsRequired(false);//boş geçilebilir
            builder.Property(x => x.CreatedADUserName).HasColumnName("CreatedADUserName").IsRequired(false);//boş geçilebilir
            builder.Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsRequired(false);//boş geçilebilir
            builder.Property(x => x.CreatedIP).HasColumnName("CreatedIP").IsRequired(false);//boş geçilebilir

        
            builder.Property(x => x.ModifiedComputerName).HasColumnName("ModeifiedComputerName").IsRequired(false);
            builder.Property(x => x.ModifiedDate).HasColumnName("ModeifiedDate").IsRequired(false);
            builder.Property(x => x.ModifiedADUserName).HasColumnName("ModeifiedADUserName").IsRequired(false);
            builder.Property(x => x.ModifiedBy).HasColumnName("ModeifiedBy").IsRequired(false);
            builder.Property(x => x.ModifiedIP).HasColumnName("ModeifiedIP").IsRequired(false);
        }
    }
}
