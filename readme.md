# TDD Exercise - Banking System

## Objective & Rules of the Game

Learn Test Driven Development (TDD). No business logic code can be written is a prior test has not been written to force it. Always write the minimum amount of code that will make the test pass.

Thouroughly follow the "Red, Green, Refactor" steps. Git commit after each step.

## Context

Develop a simplistic banking system in TDD-style. The `Bank` system must include the following features:

1. Multiple account types (Savings, Credit Card)
2. Interest calculation for savings accounts
4. Credit limit management for credit cards
5. Transaction history logging
6. Atomic withdrawals and deposits functionalities

### Key Points to Consider

* Use inheritance and polymorphism to create a flexible account hierarchy
* Implement interfaces for ATM-like functionality
* Use dependency injection for services like interest rate providers
* Follow SOLID principles throughout the implementation
* Use design patterns like Factory Method for creating different account types

## Use Case

```
When the user opens a savings account with an interest rate of 2.5% / year
Then the balance is $0
When the user deposits 225$ in the savings account
Then the balance is $225
When the user deposits 20$ in the savings account
Then the balance is $245

When the user tries to withdraw $30 from the saving account
Then the balance is $215
When the user tries to withdraw $300 from the saving account
Then the sytem gives an error saying "Insufficient funds"

When the user opens a credit card account
Then the balance is $0
When the user withdraws $250 from the credit card account
Then the balance is -$250

When the user withdraws $200 from the credit card account
Then the sytem gives an error saying "Maximum credit limit reached"

When the user transfers $100 from the saving account to the credit card account
Then the balance of the savings account is $125
And the balance of the credit card account is -$150

When the user tries to make three concurrent transfer of $50 from the savings account to the credit card account
Then the balance of the checking account is $25
And the balance of the credit card account is -$50
And one transaction give an error

Given that a month passes
When checking the savings account balance
Then the balance is $25.05
```
