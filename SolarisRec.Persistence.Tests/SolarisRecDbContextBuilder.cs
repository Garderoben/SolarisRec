using System;

namespace SolarisRec.Persistence.Tests
{
    internal class SolarisRecDbContextBuilder
    {
        private readonly SolarisRecDbContext context;

        internal SolarisRecDbContextBuilder() : this(Guid.NewGuid().ToString())
        {
        }

        internal SolarisRecDbContextBuilder(string dbName)
        {
            context = new InMemorySolarisRecDbContext(dbName);
        }

        public SolarisRecDbContextBuilder WithAccount(PersistenceModel.Account account)
        {
            context.Accounts.Add(account);

            return this;
        }

        public SolarisRecDbContextBuilder WithExpansion(PersistenceModel.Expansion expansion)
        {
            context.Expansions.Add(expansion);

            return this;
        }

        public SolarisRecDbContextBuilder WithFaction(PersistenceModel.Faction faction)
        {
            context.Factions.Add(faction);

            return this;
        }

        public SolarisRecDbContextBuilder WithCardFaction(PersistenceModel.JoiningTables.CardFaction cardFaction)
        {
            context.CardFactions.Add(cardFaction);

            return this;
        }

        public SolarisRecDbContextBuilder WithResource(PersistenceModel.Resource resource)
        {
            context.Resources.Add(resource);

            return this;
        }

        public SolarisRecDbContextBuilder WithCardResource(PersistenceModel.JoiningTables.CardResource cardResource)
        {
            context.CardResources.Add(cardResource);

            return this;
        }

        public SolarisRecDbContextBuilder WithTalent(PersistenceModel.Talent talent)
        {
            context.Talents.Add(talent);

            return this;
        }

        public SolarisRecDbContextBuilder WithCardTalent(PersistenceModel.JoiningTables.CardTalent cardTalent)
        {
            context.CardTalents.Add(cardTalent);

            return this;
        }

        public SolarisRecDbContextBuilder WithCard(PersistenceModel.Card card)
        {
            context.Cards.Add(card);

            return this;
        }

        public SolarisRecDbContext Build()
        {
            context.SaveChanges();
            return context;
        }
    }
}