// See https://aka.ms/new-console-template for more information

using OOPS.Abstraction;
using OOPS.Encapsulation;
using OOPS.Inheritance;

Console.WriteLine("Hello, World!");
//ENCAPSULATION DEMO

//Here, anyone can create the instance of the class and access & modify the public fields
//Because they're not protected/encapsulated but off-guard.
NonEncapsulation nonEncap = new NonEncapsulation();
nonEncap.Age = 30;
nonEncap.Name = "Steve";

// Here, fields are not accessible directly, but to access them, we need to access the properties
Encapsulation encap = new Encapsulation();
encap.Age = 30;
encap.Name = "Steve";

//ABSTRACTION DEMO
// All 4 methods are called in specific order one-by-one
// If any order changes, email will not be sent.
// User has overhead of sending emails, the just want to send an email, don't want to call all 4 methods 
NonAbstraction emailServiceNonAbstracted = new NonAbstraction();
emailServiceNonAbstracted.Connect();
emailServiceNonAbstracted.Authenticate("username", "password");
emailServiceNonAbstracted.SendMessage("sagar@gmail.com", "This is test message");
emailServiceNonAbstracted.Disconnect();

//AbstractedEmail service
AbstractionEmailService emailService = new AbstractionEmailService();
emailService.SendEmail("Steve@gmail.com", "This is test message","Test body");  
// Here, I do not want to bother about how to connect and authenticate
// All I want to do is to send an email, that is it.



//Inheritance Demo
Vehicle car = new Car();
Vehicle bike = new Bike();

Car car2 = (Car)new Vehicle(); // run-time error
Bike bike2 = (Bike)new Vehicle(); // run-time error

car2.StartCar();
bike2.StartBike();