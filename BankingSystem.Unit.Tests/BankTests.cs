using FluentAssertions;

namespace BankingSystem.Unit.Tests;

public class Tests
{
	private Bank _bank;

	[SetUp]
	public void SetUp()
	{
		_bank = new Bank();
	}

	[Test]
	public void CanCreateABank()
	{
		_bank.Should().NotBeNull();
	}
}
