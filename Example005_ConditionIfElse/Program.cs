Console.Write("What is your name? : ");
string username = Console.ReadLine();
if (username.ToLower() == "evgeny"){
    Console.WriteLine("Good Job Evgeny!");
} else {
    Console.Write("Bad Job ");
    Console.WriteLine(username);
}