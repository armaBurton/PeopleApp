using Packt.Shared;
Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-GB");

Person bob = new()
{
  Name = "Bob Smith",
  DateOfBirth = new DateTime(1965, 12, 22),
  FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia,
  BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon
  | WondersOfTheAncientWorld.MausoleumAtHalicarnassus
};

bob.Children.Add(new() { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });


Person alice = new(){
  Name = "Alice Jones",
  DateOfBirth = new(1998, 3, 7)
};

WriteLine("{0} was born on {1:dddd, d, MMMM, yyy}",
  arg0: bob.Name,
  arg1: bob.DateOfBirth
);

WriteLine(
  format: "{0}'s favorite wonder is {1}. Its integer is {2}",
  arg0: bob.Name,
  arg1: bob.FavoriteAncientWonder,
  arg2: (int)bob.FavoriteAncientWonder
  );

WriteLine("{0} was born on {1:dd MMM yy}",
  arg0: alice.Name,
  arg1: alice.DateOfBirth
);

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
WriteLine($"");
WriteLine($"{bob.Name} has {bob.Children.Count} children");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++){
  WriteLine($"> {bob.Children[childIndex].Name}");
}
WriteLine($"");
WriteLine($"{bob.Name} is a {Person.Species}");
WriteLine($"{bob.Name} was born on {bob.HomePlanet}");
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

WriteLine($"");


BankAccount.InterestRate = 0.012M;

BankAccount jonesAccount = new()
{
  AccountName = "Mrs. Jones",
  Balance = 2400
};
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: jonesAccount.AccountName,
  arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount gerrierAccount = new()
{
  AccountName = "Ms. Gerrier",
  Balance = 98
};
WriteLine(
  format: "{0} earned {1:C} interest.",
  arg0: gerrierAccount.AccountName,
  arg1: gerrierAccount.Balance * BankAccount.InterestRate
);

Person blankPerson = new();

WriteLine(
  format: "\n{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
  arg0: blankPerson.Name,
  arg1: blankPerson.HomePlanet,
  arg2: blankPerson.Instantiated
);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

WriteLine(
  format: "\n{0} of {1} was created at {2:hh:mm:ss} on {2:dddd}",
  arg0: gunny.Name,
  arg1: gunny.HomePlanet,
  arg2: gunny.Instantiated
);


