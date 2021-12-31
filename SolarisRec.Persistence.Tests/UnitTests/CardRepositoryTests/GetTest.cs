using FluentAssertions;
using SolarisRec.Core.Card;
using SolarisRec.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Enum = SolarisRec.Core.Card.Enums;

namespace SolarisRec.Persistence.Tests.UnitTests.CardRepositoryTests
{
    public sealed class GetTest : CardRepositoryTestBase
    {
        const int EXISTING_ID = 1;
        const int NOT_EXISTING_ID = 2;

        [Fact]
        public async Task ExistingCardReturnsCard()
        {
            var expected = new Card()
            {
                Id = EXISTING_ID,
                Name = "Unit Test Card",
                Ability = "Unit Test Ability",
                ExpansionSerialNumber = "001",
                ExpansionName = "So it Begins",
                Type = (int)Enum.CardType.Agent,
                AttackValue = 1,
                HealthValue = 1,
                Unique = false,
                Factions = new List<string>() { "Earth" },
                Costs = new List<Cost>()
                { 
                    new Cost
                    { 
                        ResourceType = Enum.Resource.Earthian,
                        Quantity = 2
                    },
                    new Cost
                    { 
                        ResourceType = Enum.Resource.Any,
                        Quantity = 1
                    }
                },
                Talents =  new List<Talent>()
                { 
                    new Talent
                    {
                        TalentType = Enum.Talent.Green,
                        Quantity = 1
                    },
                    new Talent
                    {
                        TalentType = Enum.Talent.Black,
                        Quantity = 2
                    }
                }
            };

            using (var dbContext = CreateDbContext())
            {
                sut = new CardRepository(dbContext, persistenceModelMapper, domainModelMapper);

                var result = await sut.Get(EXISTING_ID);

                result.Should().BeEquivalentTo(expected);
            }
        }

        [Fact]
        public async Task NotExistingCardThrowsException()
        {
            using (var dbContext = CreateDbContext())
            {
                sut = new CardRepository(dbContext, persistenceModelMapper, domainModelMapper);

                Func<Task> act = async () => await sut.Get(NOT_EXISTING_ID);

                await act.Should()
                    .ThrowAsync<KeyNotFoundException>()
                    .WithMessage($"Card with Card Id {NOT_EXISTING_ID} does not exist.");
            }
        }

        internal override SolarisRecDbContext CreateDbContext()
        {
            var expansion = new PersistenceModel.Expansion
            {
                Id = (int)Enum.Expansion.SoItBegins,
                Name = "So it Begins"
            };

            var faction = new PersistenceModel.Faction
            {
                Id = (int)Enum.Faction.Earth,
                Name = "Earth"
            };

            var card = new PersistenceModel.Card
            {
                Id = EXISTING_ID,
                Name = "Unit Test Card",
                Ability = "Unit Test Ability",
                ExpansionSerialNumber = "001",
                Type = (int)Enum.CardType.Agent,
                AttackValue = 1,
                HealthValue = 1,
                Unique = false,
                ExpansionId = (int)Enum.Expansion.SoItBegins
            };

            var cardFaction = new PersistenceModel.JoiningTables.CardFaction
            {
                CardId = card.Id,
                FactionId = faction.Id
            };

            var earthResource = new PersistenceModel.Resource
            {
                Id = (int)Enum.Resource.Earthian,
                Name = "Earthian"
            };

            var anyResource = new PersistenceModel.Resource
            {
                Id = (int)Enum.Resource.Any,
                Name = "Any"
            };

            var earthCardResource = new PersistenceModel.JoiningTables.CardResource
            {
                CardId = card.Id,
                ResourceId = earthResource.Id,
                Quantity = 2
            };

            var anyCardResource = new PersistenceModel.JoiningTables.CardResource
            {
                CardId = card.Id,
                ResourceId = anyResource.Id,
                Quantity = 1
            };

            var greenTalent = new PersistenceModel.Talent
            {
                Id = (int)Enum.Talent.Green,
                Name = "Green"
            };

            var blackTalent = new PersistenceModel.Talent
            {
                Id = (int)Enum.Talent.Black,
                Name = "Black"
            };

            var greenCardTalent = new PersistenceModel.JoiningTables.CardTalent
            {
                CardId = card.Id,
                TalentId = greenTalent.Id,
                Quantity = 1
            };

            var blackCardTalent = new PersistenceModel.JoiningTables.CardTalent
            {
                CardId = card.Id,
                TalentId = blackTalent.Id,
                Quantity = 2
            };

            return new SolarisRecDbContextBuilder()
                .WithExpansion(expansion)
                .WithFaction(faction)
                .WithCard(card)
                .WithCardFaction(cardFaction)
                .WithResource(earthResource)
                .WithResource(anyResource)
                .WithCardResource(earthCardResource)
                .WithCardResource(anyCardResource)
                .WithTalent(greenTalent)
                .WithTalent(blackTalent)
                .WithCardTalent(greenCardTalent)
                .WithCardTalent(blackCardTalent)
                .Build();
        }
    }
}