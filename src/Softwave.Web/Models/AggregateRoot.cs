using System.Collections.Generic;

namespace Softwave.Web.Models
{
    public class AggregateRoot
    {
        public List<Datum> Data { get; set; }

        public static AggregateRoot DataSeed()
        {
            return new AggregateRoot()
            {
                Data = new List<Datum>()
                {
                    new Datum()
                    {
                        Year = 2017,
                        Circle1 = new Circle()
                        {
                            Value = 60,
                            MaxValue = 100
                        },
                        Circle2 = new Circle()
                        {
                            Value = 30,
                            MaxValue = 40
                        },
                        Categories = new List<Category>()
                        {
                            new Category()
                            {
                                Title ="cat1",
                                MaxValue = 10,
                                Value = 4
                            },
                            new Category()
                            {
                                Title ="cat2",
                                MaxValue = 10,
                                Value = 2
                            },
                            new Category()
                            {
                                Title ="cat3",
                                MaxValue = 11,
                                Value = 7
                            },
                            new Category()
                            {
                                Title ="cat4",
                                MaxValue = 10,
                                Value = 4
                            },
                            new Category()
                            {
                                Title ="cat5",
                                MaxValue = 10,
                                Value = 8
                            },
                            new Category()
                            {
                                Title ="cat6",
                                MaxValue = 10,
                                Value = 2
                            },
                            new Category()
                            {
                                Title ="cat7",
                                MaxValue = 10,
                                Value = 4
                            },
                            new Category()
                            {
                                Title ="cat8",
                                MaxValue = 10,
                                Value = 4
                            }
                        }
                    },
                    new Datum()
                    {
                        Year = 2018,
                        Circle1 = new Circle()
                        {
                            Value = 90,
                            MaxValue = 100
                        },
                        Circle2 = new Circle()
                        {
                            Value = 25,
                            MaxValue = 40
                        },
                        Categories = new List<Category>()
                        {
                            new Category()
                            {
                                Title ="cat1",
                                MaxValue = 10,
                                Value = 2
                            },
                            new Category()
                            {
                                Title ="cat2",
                                MaxValue = 10,
                                Value = 8
                            },
                            new Category()
                            {
                                Title ="cat3",
                                MaxValue = 12,
                                Value = 1
                            },
                            new Category()
                            {
                                Title ="cat4",
                                MaxValue = 10,
                                Value = 6
                            },
                            new Category()
                            {
                                Title ="cat5",
                                MaxValue = 10,
                                Value = 8
                            },
                            new Category()
                            {
                                Title ="cat6",
                                MaxValue = 10,
                                Value = 3
                            },
                            new Category()
                            {
                                Title ="cat7",
                                MaxValue = 10,
                                Value = 9
                            },
                            new Category()
                            {
                                Title ="cat8",
                                MaxValue = 10,
                                Value = 10
                            }
                        }
                    }
            }
            };
        }
        public class Datum
        {
            public int Year { get; set; }
            public Circle Circle1 { get; set; }
            public Circle Circle2 { get; set; }
            public List<Category> Categories { get; set; }
        }


        public abstract class Unit
        {
            public int Value { get; set; }
            public int MaxValue { get; set; }
        }

        public class Circle : Unit { }

        public class Category : Unit
        {
            public string Title { get; set; }
        }
    }
}
