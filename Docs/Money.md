### Money

#### Add money

```cs
// Positive addition
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
Money sum = moneyA.Add(moneyB); // 2.6m

// Negative addition
Money negativeA = new("USD", -1.2m);
Money negativeB = new("USD", -1.4m);
Money negativeSum = negativeA.Add(negativeB); // -2.6m
```

#### Subtract money

```cs
// Positive subtraction
Money moneyA = new("USD", 1.2m);
Money moneyB = new("USD", 1.4m);
Money difference = moneyA.Subtract(moneyB); // -0.2m

// Negative subtraction
Money negativeA = new("USD", -1.2m);
Money negativeB = new("USD", -1.4m);
Money negativeDifference = negativeA.Subtract(negativeB); // 0.2m
```

#### Get decimal part of money as an integer

```cs
// Positive number
Money money = new("USD", 50.3m);
int decimalPart = money.DecimalNumberAsInteger; // 3

// Negative number
Money negativeMoney = new("USD", -50.3m);
int negativeDecimalPart = negativeMoney.DecimalNumberAsInteger; // -3
```
