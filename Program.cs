﻿using Packt.Shared;
// Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-GB");

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
var fruitNamed = bob.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

WriteLine($"");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

var (name2, dob2, fav2) = bob;
WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

WriteLine(bob.OptionalParameters());
WriteLine(bob.OptionalParameters("Jump!", 98.5));
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));
WriteLine(bob.OptionalParameters("Poke!", active: false));

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

int a = 10;
int b = 20;
int c = 30;

WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

int d = 10, e = 20;
WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet.");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}.");

WriteLine($"");

Person sam = new(){
  Name = "Sam",
  DateOfBirth = new(1969, 6, 25)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"{sam.Name}'s favorite ice-cream flavor is {sam.FavoriteIceCream}");

string color = "red";
try{
  sam.FavoritePrimaryColor = color;
  WriteLine($"{sam.Name}'s favorite primary color is {sam.FavoritePrimaryColor}");
} catch (Exception ex) {
  WriteLine(
    "Tried to set {0} to '{1}': {2}",
    nameof(sam.FavoritePrimaryColor), color, ex.Message
  );
}

sam.Children.Add(new() { Name = "Charlie", DateOfBirth = new(2010, 3, 18)});
sam.Children.Add(new() { Name = "Ella", DateOfBirth = new(2020, 12, 24)});

WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");

WriteLine($"Sam's child name {sam[1].Name} is {sam["Ella"].Age}");

// Book book = new(){
//   Isbn = "978-1803237800",
//   Title = "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"
// };

WriteLine($"");

Book book = new(isbn: "978-1803237800", title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals"){
  Author = "Mark J. Price",
  PageCount = 821
};

WriteLine(
  "{0}: {1} written by {2} has {3:N0} pages.",
  book.Isbn, book.Title, book.Author, book.PageCount
);

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };

lamech.Marry(adah);
// Person.Marry(zillah, lamech);
if(zillah + lamech){
  WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
}

WriteLine($"{ lamech.Name } is married to { lamech.Spouse?.Name ?? "nobody" }");
WriteLine($"{ adah.Name } is married to { adah.Spouse?.Name ?? "nobody" }");
WriteLine($"{ zillah.Name } is married to { zillah.Spouse?.Name ?? "nobody" }");

Person baby1 = lamech.ProcreateWith(adah);
baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");

Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

Person baby3 = lamech * adah;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
WriteLine($"{adah.Name} has {adah.Children.Count} children.");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");

for (int i = 0; i < lamech.Children.Count; i++){
  WriteLine(
    format: "{0}'s child #{1} is named \"{2}\"",
    arg0: lamech.Name,
    arg1: i,
    arg2: lamech[i].Name
  );
}


int number = -5;

try{
  Write($"{number}! is {Person.Factorial(number)}");
} catch (Exception ex) {
  WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}");  
}

WriteLine($"");

Passenger[] passengers = {
  new FirstClassPassenger { AirMiles = 1_419, Name = "Suman" },
  new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
  new BusinessClassPassenger { Name = "Janice" },
  new CoachClassPassenger { CarryOnKg = 25.7, Name = "Dave" },
  new CoachClassPassenger { CarryOnKg = 0, Name = "Amit" }
};

foreach(Passenger passenger in passengers){
  decimal flightCost = passenger switch{
    // FirstClassPassenger p when p.AirMiles > 3500  => 1500M,  C# 8 syntax
    // FirstClassPassenger p when p.AirMiles > 1500  => 1750M,
    // FirstClassPassenger _                         => 2000M,
    FirstClassPassenger p => p.AirMiles switch {
      > 35000 => 1500M,
      > 15000 => 1750M,
      _       => 2000M
    },
    BusinessClassPassenger _                      => 1000M,
    CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
    CoachClassPassenger _                         => 650M,
    _                                             => 800M
  };
  WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

WriteLine($"");

ImmutablePerson jeff = new(){
  FirstName = "Jeff",
  LastName = "Winger"
};

jeff.FirstName = "Geoff";