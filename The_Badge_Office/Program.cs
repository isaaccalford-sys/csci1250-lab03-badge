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


//Printing answers
System.Console.WriteLine($"Name on badge: {fullNameUpperCase}");
System.Console.WriteLine($"Username: {userNameLowwerCase}");
System.Console.WriteLine($"Initials: {initalsUppercase}");
System.Console.WriteLine($"Letters in last name: {lettersInLastName}");
System.Console.WriteLine();

// Part 2: The Numbers
Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);


//Printing answers
System.Console.WriteLine($"Student ID: {studentId}");
System.Console.WriteLine($"Locker: {lockerNumber}");
System.Console.WriteLine();


//Part 3: The Walk 

//Dorm
System.Console.Write("What is the x Cordinate of your dorm? ");
double dormXValue = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is the y Cordinate of your dorm? ");
double dormYValue = Convert.ToDouble(Console.ReadLine());


//Classroom
System.Console.Write("What is the x Cordinate of your classroom? ");
double classroomXValue = Convert.ToDouble(Console.ReadLine());

System.Console.Write("What is the y Cordinate of your classroom? ");
double classroomYValue = Convert.ToDouble(Console.ReadLine());


//Student speed
System.Console.Write("What is your walking speed in feet per second? ");
double walkingSpeed = Convert.ToDouble(Console.ReadLine());


//Math for distance
double xTotalForSubtraction = classroomXValue - dormXValue;
double xTotalForPower = Math.Pow(xTotalForSubtraction, 2);


double yTotalForSubtraction = classroomYValue - dormYValue;
double yTotalForPower = Math.Pow(yTotalForSubtraction, 2);

double xAndYCombinedTotal= xTotalForPower + yTotalForPower;
double distance = Math.Sqrt(xAndYCombinedTotal);


//Math for walking speed
double walkingTimeInSeconds = distance / walkingSpeed;
double roundedWalkingTimeInSeconds = Math.Round(walkingTimeInSeconds, 0);

int minutes = (int)roundedWalkingTimeInSeconds / 60;
int seconds = (int)roundedWalkingTimeInSeconds % 60;


//Printing answers
System.Console.WriteLine();
System.Console.WriteLine($"Distance: {distance.ToString("F1")} feet");
System.Console.WriteLine($"Walk time: {minutes} minutes {seconds} seconds ");
System.Console.WriteLine();