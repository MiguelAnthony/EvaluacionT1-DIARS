using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace EvaluacionT1_DIARS.Models.Map
{
    public class AccountMap
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("PersonaRegistro");
            builder.HasKey(o => o.id);
        }
    }
}
