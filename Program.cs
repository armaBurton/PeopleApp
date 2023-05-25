﻿using Packt.Shared;

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