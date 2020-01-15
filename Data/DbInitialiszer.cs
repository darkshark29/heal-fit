using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using heal_fit.Models;

namespace heal_fit.Data
{
	public static class DbInitializer
	{
		public static void Initialize(IServiceProvider serviceProvider)
		{
			using (var context = new DatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DatabaseContext>>()))
            {
				if (!context.Account.Any())
				{
					Account[] accounts = new Account[]
					{
						new Account
						{
							Email = "Admin@Admin.fr",
							Pseudo = "Admin",
							Password = "Admin"
						},
						new Account
						{
							Email = "User@User.fr",
							Pseudo = "User",
							Password = "User"
						},
						new Account
						{
							Email = "test@test.fr",
							Pseudo = "test",
							Password = "test"
						},
						new Account
						{
							Email = "blabla@blabla.fr",
							Pseudo = "blabla",
							Password = "blabla"
						}
					};

					foreach (Account account in accounts)
					{
						context.Add(account);
					}

					context.SaveChanges();
				}

				if (!context.Profile.Any())
				{
					Profile[] profiles = new Profile[]
					{
						new Profile
						{
							FirstName = "Maxime",
							LastName = "Cardinal",
							Age = 26,
							AccountID = context.Account.Find(1).ID
						},
						new Profile
						{
							FirstName = "Thibaud",
							LastName = "Philippi",
							Age = 22,
							AccountID = context.Account.Find(2).ID
						},
						new Profile
						{
							FirstName = "John",
							LastName = "Johann Johnson",
							Age = 22,
							AccountID = context.Account.Find(2).ID
						},
						new Profile
						{
							FirstName = "Nathan",
							LastName = "Ropars",
							Age = 22,
							AccountID = context.Account.Find(3).ID
						}
					};

					foreach (Profile profile in profiles)
					{
						context.Add(profile);
					}

					context.SaveChanges();
				}

				if (!context.Plan.Any())
				{
					Plan[] plans = new Plan[]
					{
						new Plan
						{
							Name = "IMC",
							Type = Plan.PlanType.IMC,
							ProfileID = 1
						},
						new Plan
						{
							Name = "IMC 2",
							Type = Plan.PlanType.IMC,
							ProfileID = 1
						},
						new Plan
						{
							Name = "IMC",
							Type = Plan.PlanType.IMC,
							ProfileID = 2
						},
						new Plan
						{
							Name = "IMC",
							Type = Plan.PlanType.IMC,
							ProfileID = 3
						},
						new Plan
						{
							Name = "IMC",
							Type = Plan.PlanType.IMC,
							ProfileID = 4
						}
					};

					foreach (Plan plan in plans)
					{
						context.Add(plan);
					}
					context.SaveChanges();
				}

				if (!context.Trait.Any())
				{
					Trait[] traits = new Trait[]
					{
						new Trait()
						{
							Value = "50",
							Type = Trait.TraitType.POIDS,
							Date = new DateTime(2020, 01, 15),
							ProfileID = 1
						},
						new Trait()
						{
							Value = "150",
							Type = Trait.TraitType.POIDS,
							Date = new DateTime(2019, 01, 15),
							ProfileID = 2
						},
						new Trait()
						{
							Value = "90",
							Type = Trait.TraitType.POIDS,
							Date = new DateTime(2020, 01, 15),
							ProfileID = 2
						},
					};

					foreach (Trait trait in traits)
					{
						context.Add(trait);
					}

					context.SaveChanges();
				}
			}
		}
	}
}