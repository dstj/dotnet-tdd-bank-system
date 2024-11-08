using BankingSystem;

namespace BankSystem.Functional.Tests;

public class BankTestContext
{
	private Bank _bank;

	public void Given_that_a_bank_system_exists()
	{
		_bank = new Bank();
	}

	public void When_the_user_opens_a_savings_account_with_a_yearly_interest_rate_of_RATE(double rate)
	{
		var savingsBankAccount = new SavingsAccount(rate);
		_bank.OpenAccount(savingsBankAccount);
	}

	public void Then_the_balance_for_account_ACCOUNT_is_BALANCE(BankAccountType accountType, int balance)
	{
		var actual = _bank.GetBalance(accountType);
		actual.Should().Be(balance);
	}

	public void When_the_user_deposits_AMOUNT_in_the_account_ACCOUNT(int amount, BankAccountType accountType)
	{
		_bank.Deposit(accountType, amount);
	}
}
