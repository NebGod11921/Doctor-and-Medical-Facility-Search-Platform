﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentApis
{
    public class GenericUserConfiguration : IEntityTypeConfiguration<GenericUser>
    {
        public void Configure(EntityTypeBuilder<GenericUser> builder)
        {

        }
    }
}
