using System.Threading.Tasks;
using LightBDD.Framework.Scenarios;
using LightBDD.NUnit3;

namespace BankSystem.Functional.Tests;

public class BankFeature : FeatureFixture
{
	[Scenario]
	[Test]
	public async Task TestBankSystem()
	{
		await Runner
				.WithContext<BankTestContext>()
				.AddSteps(
					c => c.Given_that_a_bank_system_exists()
					, c => c.When_the_user_opens_a_savings_account_with_a_yearly_interest_rate_of_RATE(2.5)
					, c => c.Then_the_balance_is_BALANCE(BankAccountType.Savings, 0)
					, c => c.When_the_user_deposits_AMOUNT_in_the_savings_account(225, BankAccountType.Savings)
					, c => c.Then_the_balance_is_BALANCE(BankAccountType.Savings, 225)
					, c => c.When_the_user_deposits_AMOUNT_in_the_savings_account(20, BankAccountType.Savings)
					, c => c.Then_the_balance_is_BALANCE(BankAccountType.Savings, 245)
				)
				.RunAsync();
	}
}
