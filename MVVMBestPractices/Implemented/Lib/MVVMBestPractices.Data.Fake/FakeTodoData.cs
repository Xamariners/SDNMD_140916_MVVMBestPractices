using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Enums;
using MVVMBestPractices.Shared.Models;

namespace MVVMBestPractices.Data.Fake
{
    /// <summary>
    ///     Holds the fake data
    /// </summary>
    public static class FakeToDoData
    {
        /// <summary>
        ///     Gets the fake data.
        /// </summary>
        /// <value>The data.</value>
        public static List<ToDoItem> FakeData
        {
            get
            {
                return new List<ToDoItem>()
                {

                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Read book for 15 minutes",
                        Details = "I want to start reading Gabriel Garcia Marquez",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Finish organizing craft cabinet",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-29),
                        Name = "Talk to Mom",
                        Details = "About new house",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-45),
                        Name = "Finish one load of laundry",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Fix desk",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-27),
                        Name = "Spend time as a family – picnic",
                        Details = "Maybe in the north of the town",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Collate receipts to update April’s budget",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Work on e-book",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-39),
                        Name = "Write two blog posts",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-29),
                        Name = "Make grocery list",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-17),
                        Name = "Wake up early",
                        Details =
                            "I am a big fan of waking at 5am and spending time working on myself before going to work.",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Exercise",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Rewrite goals",
                        Details = "About life",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Read motivational material",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Write a “To Do” List",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Check the News Headlines",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Write a blog about food",
                        Details = "Spicy food mainly",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Take time to look good",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-31),
                        Name = "Go to bed at a reasonable time",
                        Details = "Maximum at 1am",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-41),
                        Name = "Write a book about travelling in India",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-46),
                        Name = "Go to the gym 3 times a week",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-42),
                        Name = "Run a marathon",
                        Details = "First is in Madrid",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Travel to Colombia",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Cook for the children",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Buy a new guitar",
                        Details = "Get a Fender",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-32),
                        Name = "Buy a new car",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Get a new job",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-32),
                        Name = "Pay the electricity bills ",
                        Details = "200$",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-23),
                        Name = "Sell my house",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-41),
                        Name = "Rent an office",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Walk around the lake",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-14),
                        Name = "Visit my relatives in Scotland",
                        Details = "Summer time",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Buy Swiss chocolate",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-13),
                        Name = "Tidy my room",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-25),
                        Name = "Clean the fridge",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-25),
                        Name = "Repair the kitchen door",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Prepare my speech for my brother's weeding",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Travel to Sweden",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Prepare my Chinese exam",
                        Details = "Advanced level",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Study Portuguese",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-21),
                        Name = "Download new app for chatting",
                        Details = "WeChat",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Paint my house",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Plan the next two years of investment",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Plan to have children",
                        Details = "Maybe two, a boy and a girl",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Go to the waterpark with the family",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-27),
                        Name = "Go to New York on a business trip",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-47),
                        Name = "Attend to Jaime's party ",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-12),
                        Name = "Think carefully about moving abroad",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-43),
                        Name = "Getting a diploma in Business Administration",
                        Details = "I plan to go to study to Barcelona",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Get my nails done",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Visit Hawaii for a few days",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-14),
                        Name = "Buy candies for my niece",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Get a ticket for the next week of Bruno Mars",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-49),
                        Name = "Top up my subway card",
                        Details = "20$",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-28),
                        Name = "Sell my old phone",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Buy coffee",
                        Details = "Italian coffee",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-35),
                        Name = "Visit mom and dad",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-11),
                        Name = "Drink 2 litres of water a day",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Buy a keyboard",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-44),
                        Name = "Go to the Museum of Modern Art",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-10),
                        Name = "Find my friend house keys",
                        Details = "They should be somewhere in my room",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Set up a company in Luxembourg",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-30),
                        Name = "Fix TV antenna",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-34),
                        Name = "Go out with Mark next week",
                        Details = "Take him to the opera",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-40),
                        Name = "Record a video of myself surfing",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-16),
                        Name = "Learn how to make my own beer",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-37),
                        Name = "Go for a walk with Tracy",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-24),
                        Name = "Get healthy food for my cat",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-45),
                        Name = "Sell my camera",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-39),
                        Name = "Go for a picnic to the river",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Call to my Internet Provider",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-11),
                        Name = "Take the garbage out",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-48),
                        Name = "Find an USB cable for my phone",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-16),
                        Name = "Get a flight to Bahamas",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-26),
                        Name = "Leave the house in perfect conditions",
                        Details = "It as to be cleaned by the 15th of this month",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-18),
                        Name = "Find a boyfriend",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-46),
                        Name = "Feed my dog",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-22),
                        Name = "Eat as much pasta as I can",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Buy a ring to Mary",
                        Details = "A diamond one",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Get some fresh flowers",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Read a book in the park",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-36),
                        Name = "Listen to the latest Foo Fighters album",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-19),
                        Name = "Ride my bike to the office every morning",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-37),
                        Name = "Play my new brand videogame with friends",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-49),
                        Name = "Send an email to Charles",
                        Details = "I need to remember him I will go to the club on Sunday",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-42),
                        Name = "Get a pair of shoes",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-13),
                        Name = "Travel around Spain",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-15),
                        Name = "Arrange a football match at the office",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-50),
                        Name = "Play tennis with dad",
                        Details = "",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-40),
                        Name = "Go out to Eduard's bar",
                        Details = "",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Leave a good tip to the restaurant manager",
                        Details = "Around 10$",
                        ToDoStatus = ToDoStatus.Open
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-12),
                        Name = "Get some medicines for my back pain",
                        Details = "",
                        ToDoStatus = ToDoStatus.Closed
                    },
                    new ToDoItem
                    {

                        Created = DateTime.Now.AddDays(-33),
                        Name = "Visit my grandmother",
                        Details = "Some time around May",
                        ToDoStatus = ToDoStatus.InProgress
                    },
                };
            }
        }
    }
}