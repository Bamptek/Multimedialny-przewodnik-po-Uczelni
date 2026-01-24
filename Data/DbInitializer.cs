using Multimedialny_przewodnik_po_Uczelni.Models;

namespace Multimedialny_przewodnik_po_Uczelni.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var adminUser = new User
            {
                Username = "admin",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("admin"),
                Role = "Admin"
            };
            context.Users.Add(adminUser);
            context.SaveChanges();

            if (!context.Buildings.Any())
            {
                SeedDemoMap(context);
            }
        }

        private static void SeedDemoMap(AppDbContext context)
        {
            var b_1 = new Building { Name = "Budynek A", Code = "BA" };
            context.Buildings.Add(b_1);
            context.SaveChanges();

            var f_1 = new Floor { Name = "Parter", LevelNumber = 0, Building = b_1 };
            context.Floors.Add(f_1);
            var f_2 = new Floor { Name = "I Piętro", LevelNumber = 1, Building = b_1 };
            context.Floors.Add(f_2);
            context.SaveChanges();

            var n_1 = new LocationNode
            {
                X = 0,
                Y = 0,
                Floor = f_1,
                Type = NodeType.StartPoint,
                Description = "Wejście Główne",
                ImageUrl = "/images/wejscie_glowne.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_1);
            var n_9 = new LocationNode
            {
                X = 0,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Hol przy wejsciu",
                ImageUrl = "/images/hol.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_9);
            var n_10 = new LocationNode
            {
                X = 0,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Portiernia",
                ImageUrl = "/images/portiernia.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_10);
            var n_11 = new LocationNode
            {
                X = -1,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/kor4.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_11);
            var n_12 = new LocationNode
            {
                X = -1,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Stairs,
                Description = "Schody przy sekretariacie",
                ImageUrl = "/images/schody_sekretariat.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_12);
            var n_13 = new LocationNode
            {
                X = -1,
                Y = -3,
                Floor = f_2,
                Type = NodeType.Stairs,
                Description = "Schody przy sekretariacie",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_13);
            var n_14 = new LocationNode
            {
                X = -1,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Sekretariat",
                ImageUrl = "/images/sekretariat.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_14);
            var n_15 = new LocationNode
            {
                X = -2,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_15);
            var n_16 = new LocationNode
            {
                X = -2,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Pokoj nr 22",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_16);
            var n_17 = new LocationNode
            {
                X = -3,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/kor10.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_17);
            var n_18 = new LocationNode
            {
                X = -3,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Pokoj nr 22 (wejscie 2)",
                ImageUrl = "/images/p22.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_18);
            var n_19 = new LocationNode
            {
                X = -3,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Pokoj nr 2",
                ImageUrl = "/images/p2.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_19);
            var n_20 = new LocationNode
            {
                X = -4,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_20);
            var n_21 = new LocationNode
            {
                X = -5,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_21);
            var n_22 = new LocationNode
            {
                X = -5,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Pokoj nr 20",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_22);
            var n_23 = new LocationNode
            {
                X = -5,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Sala komputerowa A4",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_23);
            var n_24 = new LocationNode
            {
                X = -6,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_24);
            var n_25 = new LocationNode
            {
                X = -7,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_25);
            var n_26 = new LocationNode
            {
                X = -7,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Wneka, strefa relaksu",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_26);
            var n_27 = new LocationNode
            {
                X = -8,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_27);
            var n_28 = new LocationNode
            {
                X = -8,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Studium ksztalcenia na odleglosc, pokoj nr 16",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_28);
            var n_29 = new LocationNode
            {
                X = -8,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Elevator,
                Description = "Winda dla osob z niepelnosprawnosciami",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_29);
            var n_30 = new LocationNode
            {
                X = -9,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_30);
            var n_31 = new LocationNode
            {
                X = -10,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_31);
            var n_32 = new LocationNode
            {
                X = -10,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Pokoj nr 14",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_32);
            var n_33 = new LocationNode
            {
                X = -10,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Biuro promocji, pokoj nr 7",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_33);
            var n_34 = new LocationNode
            {
                X = -11,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_34);
            var n_35 = new LocationNode
            {
                X = -11,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Toaleta meska",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_35);
            var n_36 = new LocationNode
            {
                X = -11,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Sala nr 8A",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_36);
            var n_37 = new LocationNode
            {
                X = -12,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_37);
            var n_38 = new LocationNode
            {
                X = -13,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Korytarz",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_38);
            var n_39 = new LocationNode
            {
                X = -12,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Toaleta damska",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_39);
            var n_40 = new LocationNode
            {
                X = -13,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Toaleta dla osob z niepelnosprawnosciami",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_40);
            var n_41 = new LocationNode
            {
                X = -13,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Sala nr 9A",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Backward
            };
            context.Nodes.Add(n_41);
            var n_42 = new LocationNode
            {
                X = -14,
                Y = -2,
                Floor = f_1,
                Type = NodeType.Corridor,
                Description = "Wyjscie ewakuacyjne",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Left
            };
            context.Nodes.Add(n_42);
            var n_43 = new LocationNode
            {
                X = -14,
                Y = -3,
                Floor = f_1,
                Type = NodeType.Stairs,
                Description = "Schody przy toaletach",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_43);
            var n_45 = new LocationNode
            {
                X = -14,
                Y = -3,
                Floor = f_2,
                Type = NodeType.Stairs,
                Description = "Schody przy toaletach",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_45);
            var n_46 = new LocationNode
            {
                X = -8,
                Y = -1,
                Floor = f_2,
                Type = NodeType.Elevator,
                Description = "Winda dla osob z niepelnosprawnosciami",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_46);
            var n_47 = new LocationNode
            {
                X = 1,
                Y = -1,
                Floor = f_1,
                Type = NodeType.Room,
                Description = "Barek",
                ImageUrl = "/images/placeholder.jpg",
                AudioUrl = "",
                BaseOrientation = Direction.Forward
            };
            context.Nodes.Add(n_47);
            context.SaveChanges();

            context.Edges.Add(new Edge
            {
                FromNode = n_12,
                ToNode = n_13,
                Direction = Direction.Up,
                DistanceWeight = 10,
                IsStairs = true,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_13,
                ToNode = n_12,
                Direction = Direction.Down,
                DistanceWeight = 10,
                IsStairs = true,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_9,
                ToNode = n_1,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_9,
                ToNode = n_10,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_1,
                ToNode = n_9,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_10,
                ToNode = n_11,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_11,
                ToNode = n_12,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_11,
                ToNode = n_14,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_11,
                ToNode = n_10,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_14,
                ToNode = n_11,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_16,
                ToNode = n_15,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_15,
                ToNode = n_11,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_15,
                ToNode = n_16,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_11,
                ToNode = n_15,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_15,
                ToNode = n_17,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_17,
                ToNode = n_15,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_19,
                ToNode = n_17,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_17,
                ToNode = n_18,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_17,
                ToNode = n_19,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_18,
                ToNode = n_17,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_17,
                ToNode = n_20,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_20,
                ToNode = n_21,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_20,
                ToNode = n_17,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_21,
                ToNode = n_24,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_21,
                ToNode = n_22,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_21,
                ToNode = n_23,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_21,
                ToNode = n_20,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_22,
                ToNode = n_21,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_23,
                ToNode = n_21,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_24,
                ToNode = n_25,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_24,
                ToNode = n_21,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_25,
                ToNode = n_27,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_25,
                ToNode = n_24,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_26,
                ToNode = n_25,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_25,
                ToNode = n_26,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_27,
                ToNode = n_30,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_27,
                ToNode = n_25,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_27,
                ToNode = n_28,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_27,
                ToNode = n_29,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_30,
                ToNode = n_31,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_30,
                ToNode = n_27,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_31,
                ToNode = n_34,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_31,
                ToNode = n_32,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_31,
                ToNode = n_33,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_31,
                ToNode = n_30,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_33,
                ToNode = n_31,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_32,
                ToNode = n_31,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_34,
                ToNode = n_37,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_34,
                ToNode = n_35,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_34,
                ToNode = n_36,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_34,
                ToNode = n_31,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_36,
                ToNode = n_34,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_35,
                ToNode = n_34,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_37,
                ToNode = n_38,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_37,
                ToNode = n_39,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_37,
                ToNode = n_34,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_39,
                ToNode = n_37,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_38,
                ToNode = n_42,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_38,
                ToNode = n_40,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_38,
                ToNode = n_41,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_38,
                ToNode = n_37,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_42,
                ToNode = n_43,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_42,
                ToNode = n_38,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_41,
                ToNode = n_38,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_40,
                ToNode = n_38,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_29,
                ToNode = n_27,
                Direction = Direction.Forward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_28,
                ToNode = n_27,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_43,
                ToNode = n_42,
                Direction = Direction.Backward,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_43,
                ToNode = n_45,
                Direction = Direction.Up,
                DistanceWeight = 10,
                IsStairs = true,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_45,
                ToNode = n_43,
                Direction = Direction.Down,
                DistanceWeight = 10,
                IsStairs = true,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_29,
                ToNode = n_46,
                Direction = Direction.Up,
                DistanceWeight = 10,
                IsStairs = false,
                IsElevator = true
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_46,
                ToNode = n_29,
                Direction = Direction.Down,
                DistanceWeight = 10,
                IsStairs = false,
                IsElevator = true
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_47,
                ToNode = n_9,
                Direction = Direction.Left,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.Edges.Add(new Edge
            {
                FromNode = n_9,
                ToNode = n_47,
                Direction = Direction.Right,
                DistanceWeight = 5,
                IsStairs = false,
                IsElevator = false
            });
            context.SaveChanges();
        }

        private static void CreateBidirectionalEdge(AppDbContext context, LocationNode a, LocationNode b, Direction dirAtoB, Direction dirBtoA)
        {
            context.Edges.Add(new Edge { FromNodeId = a.Id, ToNodeId = b.Id, Direction = dirAtoB, DistanceWeight = 5 });
            context.Edges.Add(new Edge { FromNodeId = b.Id, ToNodeId = a.Id, Direction = dirBtoA, DistanceWeight = 5 });
        }
    }
}