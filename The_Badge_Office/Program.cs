/* 
* Name: Isaac Alford
* Course: CSCI-1250, Section 201
* Assignment: Lab 03, The Badge Office
* Date: October 3, 2026
* Discription:
*/

// Part 1: The Name

//Getting user's name
System.Console.Write("What is your full name? ");
string userInputFullName = Console.ReadLine()??"";

string fullNameTrimmed = userInputFullName.Trim();
string fullNameUpperCase = fullNameTrimmed.ToUpper();


//Breaking down name
int spacePosition = fullNameTrimmed.IndexOf(" ");
string firstName = fullNameTrimmed.Substring(0, spacePosition);
string lastName = fullNameTrimmed.Substring(spacePosition + 1);


//Making username
string userNameNoCase = firstName.Substring(0,1) + lastName;
string userNameLowwerCase = userNameNoCase.ToLower();


// Making Initals 
string initals = firstName.Substring(0,1)+ "." + lastName.Substring(0,1) + ".";
string initalsUppercase = initals.ToUpper();


// Making letters in last name 
int lettersInLastName = lastName.Length;


//printing answers
System.Console.WriteLine($"Name on badge: {fullNameUpperCase}");
System.Console.WriteLine($"Username: {userNameLowwerCase}");
System.Console.WriteLine($"Initials: {initalsUppercase}");
System.Console.WriteLine($"Letters in last name: {lettersInLastName}");
System.Console.WriteLine();

// Part 2: The Numbers
Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine($"Student ID: {studentId}");
System.Console.WriteLine($"Locker: {lockerNumber}");