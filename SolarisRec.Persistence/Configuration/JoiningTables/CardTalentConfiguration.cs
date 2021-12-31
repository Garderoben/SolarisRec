﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolarisRec.Persistence.PersistenceModel.JoiningTables;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Configuration.JoiningTables
{
    internal class CardTalentConfiguration : IEntityTypeConfiguration<CardTalent>
    {
        public void Configure(EntityTypeBuilder<CardTalent> builder)
        {
            builder.ToTable("CardTalents");

            builder.HasKey(ct => new { ct.CardId, ct.TalentId });

            builder.HasOne(ct => ct.Card)
                .WithMany(c => c.CardTalents)
                .HasForeignKey(ct => ct.CardId);

            builder.HasOne(ct => ct.Talent)
                .WithMany(t => t.CardTalents)
                .HasForeignKey(ct => ct.TalentId);

            builder.Property(ct => ct.Quantity)
                .IsRequired(true);

            Seed(builder);
        }

        private static void Seed(EntityTypeBuilder<CardTalent> builder)
        {
            builder.HasData
            (                
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Turncoat,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 1
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Diplomacy,
                    Quantity = 4
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Espionage,
                    Quantity = 4
                },
                new CardTalent
                {
                    CardId = (int)Enum.CardId.Redistribution,
                    TalentId = (int)Enum.Talent.Any,
                    Quantity = 5
                }
            );
        }
    }
}