using System.Linq;

namespace PeopleSearch.Models
{
    public class SeedData
    {
        public static void Initialize()
        {
            using (var personContext = new PersonContext())
            {
                if (personContext.People.Any())
                {
                    return;
                }

                personContext.AddRange(
                    new Person
                    {
                        Name = "Bill Gates",
                        Address = "2134 Gates Dr.\r\nMedina, WA 98039",
                        Age = 61,
                        Interests = "software,computers,philanthropy,bridge,tennis,golf",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/19/Bill_Gates_June_2015.jpg/220px-Bill_Gates_June_2015.jpg"
                    },

                    new Person
                    {
                        Name = "Bono",
                        Address = "4321 Bono Dr.\r\nDublin, Ireland",
                        Age = 56,
                        Interests = "music,sunglasses,philanthropy,harmonica",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Bono_2014.jpg/220px-Bono_2014.jpg"
                    },

                    new Person
                    {
                        Name = "Steve Wozniak",
                        Address = "2314 Woz Ave.\r\nSan Jose, CA 45675",
                        Age = 66,
                        Interests = "philanthropy,engineering,tetris",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Steve_Wozniak.jpg/220px-Steve_Wozniak.jpg"
                    },

                    new Person
                    {
                        Name = "Grace Hopper",
                        Address = "4123 Hooper Ln.\r\nNew York City, NY 95494",
                        Age = 85,
                        Interests = "COBOL,compilers,programming languages",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/ad/Commodore_Grace_M._Hopper%2C_USN_%28covered%29.jpg/220px-Commodore_Grace_M._Hopper%2C_USN_%28covered%29.jpg"
                    },

                    new Person
                    {
                        Name = "Barbara McClintock",
                        Address = "4132 McClintock Wy.\r\nHuntington, NY 82348",
                        Age = 90,
                        Interests = "botany,genetics,maize",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Barbara_McClintock_%281902-1992%29_shown_in_her_laboratory_in_1947.jpg/220px-Barbara_McClintock_%281902-1992%29_shown_in_her_laboratory_in_1947.jpg"
                    },

                    new Person
                    {
                        Name = "Maya Angelou",
                        Address = "4312 Angelou Ct.\r\nWinston-Salem, NC 32412",
                        Age = 86,
                        Interests = "poetry,writing,acting",
                        Picture = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b4/Angelou_at_Clinton_inauguration.jpg/220px-Angelou_at_Clinton_inauguration.jpg"
                    }
                );

                personContext.SaveChanges();
            }
        }
    }
}
