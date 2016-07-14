using System;
using System.Collections.Generic;
using System.Text;

// Part One, Number One (1.1)
int Age = 20;
bool SkyIsBlue = true;
string myName = "Ali";
double LifeAnswer = 42.42;
decimal Laser = 8.2m;

//1.2

string Sentence(string myName, int Age)
{
    return $"My name is {myName} and I am {Age}";
}

//1.3
var print = Sentence(myName, Age);
Console.WriteLine(print);

//1.4

var friends =
    new[]
    {
        "Luke",
        "Scott",
        "David",
    };

//1.5

foreach (var name in friends) Console.WriteLine(name);

//2.1 + 2.2


public enum Gender
{
    Unknown,
    Male,
    Female
}

public class Customer
{
    public Customer(string name, Gender gender, string purchase)
    {
        Name = name;
        Gender = gender;
        Purchase = purchase;
    }


 
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public string Purchase { get; set; }


    //2.3
    public void SendingThankYou()
    {
        Console.WriteLine($"Hello {Name}, thank you for purchasing the {Purchase}. We hope you enjoy it!");
    }
 
    
    //2.4

    public void SendSaleNotice(DateTime saleDate)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale coming up on {saleDate:yyyy-MM-dd}");
    }


    public void SendSaleNotice(string purchase, DateTime saleDate)
    {
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale on {purchase} coming up on {saleDate:yyyy-MM-dd}");
    }
    //2.9

    public virtual void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Purchase}");
    }   
}

//2.5 

public sealed class InactiveCustomer
: Customer
{

//2.10

public enum InactiveReason
{
    Unknown,
    Irate,
    Moved,
    Uninterested
}

//2.6

public InactiveCustomer(string name, Gender gender, string purchase, int monthsInactive)
           : base(name, gender, purchase)
    {
        MonthsInactive = monthsInactive;
    }


    public int MonthsInactive { get; set; }

    //2.11

    public InactiveReason Reason { get; set; }


    //2.7

    public void InactivityMessage()
    {
        var message =
            new StringBuilder($"Thanks for shopping with us, {Name}. ")
                .Append($"We saw that you purchased a {Purchase} from us {MonthsInactive} months ago. ")
                .Append("We'd like to know if you'd like to take a look at some of our current deals.")
                .ToString();
        Console.WriteLine(message);
    }

    //2.12

    public override void PrintCustomerInfo()
    {
        Console.WriteLine($"{Name} - {Gender} - {Purchase} - {MonthsInactive} - {Reason}");
    }
}

//2.8

var A = new Customer("Ali", Gender.Male, "iPhone");
A.SendingThankYou();
A.SendSaleNotice(DateTime.Parse("2013-01-01"));
A.SendSaleNotice("Android", DateTime.Parse("2013-01-01"));
A.PrintCustomerInfo();


var inactiveCustomer =
    new InactiveCustomer("Jane", Gender.Female, "MacBook", 4)
    {
        Reason = InactiveCustomer.InactiveReason.Uninterested
    };
inactiveCustomer.SendingThankYou();
inactiveCustomer.InactivityMessage();
inactiveCustomer.PrintCustomerInfo();








