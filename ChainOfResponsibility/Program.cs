using ChainOfResponsibility;

var emailA = new Email("NigerianPrince@gmail.com", "Nigerian Prince needs help", "Some Text");
var spamDetectionSystem = new SpamDetectionSystem();
var isSpam = spamDetectionSystem.CheckSpam(emailA);
Console.WriteLine($"{emailA} is spam: {isSpam}");
Console.WriteLine("__________________________________");

var emailB = new Email("Spam@Spam.com", "Safe link to purchase", "Some Text");
isSpam = spamDetectionSystem.CheckSpam(emailB);
Console.WriteLine($"{emailB} is spam: {isSpam}");
Console.WriteLine("__________________________________");

var emailC = new Email("Someone@Someone.com", "Some Text", "Some Text");
isSpam = spamDetectionSystem.CheckSpam(emailC);
Console.WriteLine($"{emailC} is spam: {isSpam}");