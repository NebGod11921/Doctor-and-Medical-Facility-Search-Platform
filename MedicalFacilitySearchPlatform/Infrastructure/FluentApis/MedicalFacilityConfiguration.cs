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
    public class MedicalFacilityConfiguration : IEntityTypeConfiguration<MedicalFacility>
    {
        public void Configure(EntityTypeBuilder<MedicalFacility> builder)
        {
            
        }
    }
}
