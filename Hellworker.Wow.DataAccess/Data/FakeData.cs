using Dai.Entities.Implementation;
using System.Collections.ObjectModel;

namespace Hellworker.Wow.DataAccess.Data;

public static class FakeData
{
    public static IEnumerable<Item> Items = new List<Item>
    {
        new Item
        {
            Name = "sword",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/sword.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Weapon
        },
        new Item
        {
            Name = "Chestplate",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/chestplate.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Chestplate
        },
        new Item
        {
            Name = "Helm",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/helm.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Helm
        },
        new Item
        {
            Name = "Amulet",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/amulet.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Amulet
        },
        new Item
        {
            Name = "Belt",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/belt.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Belt
        },
        new Item
        {
            Name = "Boots",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/boots.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Boots
        },
        new Item
        {
            Name = "Bracers",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/bracers.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Bracers
        },
        new Item
        {
            Name = "Gloves",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/gloves.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Gloves
        },
        new Item
        {
            Name = "Pants",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/pants.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Pants
        },
        new Item
        {
            Name = "Ring of str.",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/ring_01.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.RingLeft
        },
        new Item
        {
            Name = "Ring of str. ||",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/ring_02.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.RingRight
        },
        new Item
        {
            Name = "Shield",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/shield.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.OffHand
        },
        new Item
        {
            Name = "Shoulder",
            Damage = 100,
            Defense = 100,
            Health = 100,
            ItemLevel = 1,
            Image = "/Images/Items/shoulder.png",
            Rarity = ItemRarity.Common,
            Type = ItemType.Shoulders
        }
    };

    public static IEnumerable<Bag> Bags = new List<Bag>
    {
        new Bag
        {
            Size = 50,
            Items = new ObservableCollection<Item>(Items)
        }
    };

    public static IEnumerable<Inventory> Inventories = new List<Inventory>
    {
        new Inventory
        {
            Helm = Items.FirstOrDefault(x=>x.Type == ItemType.Helm),
            Shoulders = Items.FirstOrDefault(x=>x.Type == ItemType.Shoulders),
            Gloves = Items.FirstOrDefault(x=>x.Type == ItemType.Gloves),
            Pants = Items.FirstOrDefault(x=>x.Type == ItemType.Pants),
            Boots = Items.FirstOrDefault(x=>x.Type == ItemType.Boots),
            Belt = Items.FirstOrDefault(x=>x.Type == ItemType.Belt),
            Bracers = Items.FirstOrDefault(x=>x.Type == ItemType.Bracers),
            Amulet = Items.FirstOrDefault(x=>x.Type == ItemType.Amulet),
            RingLeft = Items.FirstOrDefault(x=>x.Type == ItemType.RingRight),
            RingRight = Items.FirstOrDefault(x=>x.Type == ItemType.RingLeft),
            OffHand = Items.FirstOrDefault(x=>x.Type == ItemType.OffHand),
            //Chestplate = Items.FirstOrDefault(x=>x.Type == ItemType.Chestplate),
            Weapon = Items.FirstOrDefault(x=>x.Type == ItemType.Weapon)
        }
    };

    public static IEnumerable<Player> Players = new List<Player>
    {
        new Player
        {
            Level = 1,
            Name = "3Hock",
            Damage = 30,
            Defense = 30,
            Health = 30,
            Inventory = Inventories.FirstOrDefault(),
            Bag = Bags.FirstOrDefault()
        },
        new Player
        {
            Level = 13,
            Name = "4Hock",
            Damage = 200,
            Defense = 300,
            Health = 240,
            Inventory = new Inventory(),
            Bag = Bags.FirstOrDefault()
        },
        new Player
        {
            Level = 47,
            Name = "4Hock",
            Damage = 820,
            Defense = 900,
            Health = 840,
            Inventory = new Inventory(),
            Bag = Bags.FirstOrDefault()
        },
        new Player
        {
            Level = 31,
            Name = "4Hock",
            Damage = 2300,
            Defense = 2100,
            Health = 2400,
            Inventory = new Inventory(),
            Bag = Bags.FirstOrDefault()
        }
        ,
        new Player
        {
            Level = 61,
            Name = "5Hock",
            Damage = 5300,
            Defense = 6100,
            Health = 5400,
            Inventory = new Inventory(),
            Bag = Bags.FirstOrDefault()
        }
    };

    public static IEnumerable<Enemy> Enemies = new List<Enemy>
    {
        new Enemy
        {
            Damage = 10,
            Defense = 10,
            Health = 40,
            Level = 1,
            NeedToKill = 10,
            Name = "Wolf",
            Image = "/Images/LairEnemies/wolf.jpg",
            ImageHead = "/Images/LairEnemies/wolfhead.png"
        },
        new Enemy
        {
            Damage = 30,
            Defense = 24,
            Health = 110,
            Level = 4,
            NeedToKill = 10,
            Name = "Wolf",
            Image = "/Images/LairEnemies/wolf.jpg",
            ImageHead = "/Images/LairEnemies/wolfhead.png"
        },
        new Enemy
        {
            Damage = 70,
            Defense = 60,
            Health = 350,
            Level = 7,
            NeedToKill = 10,
            Name = "Wolf",
            Image = "/Images/LairEnemies/wolf.jpg",
            ImageHead = "/Images/LairEnemies/wolfhead.png"
        },
        new Enemy
        {
            Damage = 110,
            Defense = 80,
            Health = 720,
            Level = 10,
            NeedToKill = 1,
            Name = "Were Wolf",
            Image = "/Images/LairEnemies/werewolf.jpg",
            ImageHead = "/Images/LairEnemies/werewolfhead.png"
        },
        new Enemy
        {
            Damage = 90,
            Defense = 90,
            Health = 840,
            Level = 13,
            NeedToKill = 10,
            Name = "Ork",
            Image = "/Images/LairEnemies/ork.jpg",
            ImageHead = "/Images/LairEnemies/orkhead.png"
        },
        new Enemy
        {
            Damage = 120,
            Defense = 110,
            Health = 1110,
            Level = 14,
            NeedToKill = 10,
            Name = "Ork",
            Image = "/Images/LairEnemies/ork.jpg",
            ImageHead = "/Images/LairEnemies/orkhead.png"
        },
        new Enemy
        {
            Damage = 170,
            Defense = 160,
            Health = 1350,
            Level = 17,
            NeedToKill = 10,
            Name = "Ork",
            Image = "/Images/LairEnemies/ork.jpg",
            ImageHead = "/Images/LairEnemies/orkhead.png"
        },
        new Enemy
        {
            Damage = 210,
            Defense = 280,
            Health = 2720,
            Level = 20,
            NeedToKill = 1,
            Name = "Ogre",
            Image = "/Images/LairEnemies/ogre.jpg",
            ImageHead = "/Images/LairEnemies/ogrehead.png",
        }
    };

    public static IEnumerable<Location> Locations => new List<Location>
    {
        new Location
        {
            Background = "/Images/Background/elwynforest.jpg",
            Enemies = Enemies.Where(x => x.Name == "Wolf" || x.Name == "Were Wolf").ToList(),
            Name = "Elwyn Forest",
            Theme = "//sound//",
        },
        new Location
        {
            Background = "/Images/Background/westfall.jpg",
            Enemies = Enemies.Where(x => x.Name == "Ork" || x.Name == "Ogre").ToList(),
            Name = "Westfall",
            Theme = "//sound//",
        }
    };

    public static IEnumerable<WayPoint> WayPoints => new List<WayPoint>
    {
        new WayPoint
        {
            Location = Locations.First(x=>x.Name == "Elwyn Forest")
        },
        new WayPoint
        {
            Location = Locations.First(x=>x.Name == "Westfall")
        }
    };
}