string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

Console.WriteLine($"First Order ID: {fraudulentOrderIDs[0]}");
Console.WriteLine($"second Order ID: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third Order ID: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
