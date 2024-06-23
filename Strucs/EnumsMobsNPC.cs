﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class EnumsMobsNPC
{

    public enum MonsterType
    {
        Skeleton = 0,
        Returned = 1,
        BoneWarrior = 2,
        BurningDead = 3,
        Horror = 4,
        Zombie = 5,
        HungryDead = 6,
        Ghoul = 7,
        DrownedCarcass = 8,
        PlagueBearer = 9,
        Afflicted = 10,
        Tainted = 11,
        Misshapen = 12,
        Disfigured = 13,
        Damned = 14,
        FoulCrow = 15,
        BloodHawk = 16,
        BlackRaptor = 17,
        CloudStalker = 18,
        Fallen = 19,
        Carver = 20,
        Devilkin = 21,
        DarkOne = 22,
        WarpedFallen = 23,
        Brute = 24,
        Yeti = 25,
        Crusher = 26,
        WailingBeast = 27,
        GargantuanBeast = 28,
        SandRaider = 29,
        Marauder = 30,
        Invader = 31,
        Infidel = 32,
        Assailant = 33,
        gorgon1 = 34,
        gorgon2 = 35,
        gorgon3 = 36,
        gorgon4 = 37,
        Ghost = 38,
        Wraith = 39,
        Specter = 40,
        Apparition = 41,
        DarkShape = 42,
        DarkHunter = 43,
        VileHunter = 44,
        DarkStalker = 45,
        BlackRogue = 46,
        FleshHunter = 47,
        DuneBeast = 48,
        RockDweller = 49,
        JungleHunter = 50,
        DoomApe = 51,
        TempleGuard = 52,
        MoonClan = 53,
        NightClan = 54,
        BloodClan = 55,
        HellClan = 56,
        DeathClan = 57,
        FallenShaman = 58,
        CarverShaman = 59,
        DevilkinShaman = 60,
        DarkShaman = 61,
        BaalSubject1 = 62,
        QuillRat = 63,
        SpikeFiend = 64,
        ThornBeast = 65,
        RazorSpine = 66,
        JungleUrchin = 67,
        SandMaggot = 68,
        RockWorm = 69,
        Devourer = 70,
        GiantLamprey = 71,
        WorldKiller = 72,
        TombViper = 73,
        ClawViper = 74,
        Salamander = 75,
        PitViper = 76,
        SerpentMagus = 77,
        SandLeaper = 78,
        CaveLeaper = 79,
        TombCreeper = 80,
        TreeLurker = 81,
        RazorPitDemon = 82,
        Huntress = 83,
        SaberCat = 84,
        NightTiger = 85,
        HellCat = 86,
        Itchies = 87,
        BlackLocusts = 88,
        PlagueBugs = 89,
        HellSwarm = 90,
        DungSoldier = 91,
        SandWarrior = 92,
        Scarab = 93,
        SteelWeevil = 94,
        AlbinoRoach = 95,
        DriedCorpse = 96,
        Decayed = 97,
        Embalmed = 98,
        PreservedDead = 99,
        Cadaver = 100,
        HollowOne = 101,
        Guardian = 102,
        Unraveler = 103,
        HoradrimAncient = 104,
        BaalSubject2 = 105,
        chaoshorde1 = 106,
        chaoshorde2 = 107,
        chaoshorde3 = 108,
        chaoshorde4 = 109,
        CarrionBird = 110,
        UndeadScavenger = 111,
        HellBuzzard = 112,
        WingedNightmare = 113,
        Sucker = 114,
        Feeder = 115,
        BloodHook = 116,
        BloodWing = 117,
        Gloam = 118,
        SwampGhost = 119,
        BurningSoul = 120,
        BlackSoul = 121,
        Arach = 122,
        SandFisher = 123,
        PoisonSpinner = 124,
        FlameSpider = 125,
        SpiderMagus = 126,
        ThornedHulk = 127,
        BrambleHulk = 128,
        Thrasher = 129,
        Spikefist = 130,
        GhoulLord = 131,
        NightLord = 132,
        DarkLord = 133,
        BloodLord = 134,
        Banished = 135,
        DesertWing = 136,
        Fiend = 137,
        Gloombat = 138,
        BloodDiver = 139,
        DarkFamiliar = 140,
        RatMan = 141,
        Fetish = 142,
        Flayer = 143,
        SoulKiller = 144,
        StygianDoll = 145,
        DeckardCain = 146,
        Gheed = 147,
        Akara = 148,
        chicken = 149,
        //Kashya = 150,
        rat = 151,
        rogue1 = 152,
        hellmeteor = 153,
        Charsi = 154,
        Warriv = 155,
        Andariel = 156,
        bird1 = 157,
        bird2 = 158,
        bat = 159,
        DarkRanger = 160,
        VileArcher = 161,
        DarkArcher = 162,
        BlackArcher = 163,
        FleshArcher = 164,
        DarkSpearwoman = 165,
        VileLancer = 166,
        DarkLancer = 167,
        BlackLancer = 168,
        FleshLancer = 169,
        SkeletonArcher = 170,
        ReturnedArcher = 171,
        BoneArcher = 172,
        BurningDeadArcher = 173,
        HorrorArcher = 174,
        Warriv2 = 175,
        Atma = 176,
        Drognan = 177,
        Fara = 178,
        cow = 179,
        SandMaggotYoung = 180,
        RockWormYoung = 181,
        DevourerYoung = 182,
        GiantLampreyYoung = 183,
        WorldKillerYoung = 184,
        camel = 185,
        Blunderbore = 186,
        Gorbelly = 187,
        Mauler = 188,
        Urdar = 189,
        SandMaggotEgg = 190,
        RockWormEgg = 191,
        DevourerEgg = 192,
        GiantLampreyEgg = 193,
        WorldKillerEgg = 194,
        act2male = 195,
        act2female = 196,
        act2child = 197,
        Greiz = 198,
        Elzix = 199,
        Geglash = 200,
        Jerhyn = 201,
        Lysander = 202,
        act2guard1 = 203,
        act2vendor1 = 204,
        act2vendor2 = 205,
        FoulCrowNest = 206,
        BloodHawkNest = 207,
        BlackVultureNest = 208,
        CloudStalkerNest = 209,
        Meshif = 210,
        Duriel = 211,
        UndeadRatMan = 212,
        UndeadFetish = 213,
        UndeadFlayer = 214,
        UndeadSoulKiller = 215,
        UndeadStygianDoll = 216,
        darkguard1 = 217,
        darkguard2 = 218,
        darkguard3 = 219,
        darkguard4 = 220,
        darkguard5 = 221,
        bloodmage1 = 222,
        bloodmage2 = 223,
        bloodmage3 = 224,
        bloodmage4 = 225,
        bloodmage5 = 226,
        Maggot = 227,
        MummyGenerator = 228,
        Radament = 229,
        firebeast = 230,
        iceglobe = 231,
        lightningbeast = 232,
        poisonorb = 233,
        FlyingScimitar = 234,
        Zakarumite = 235,
        Faithful = 236,
        Zealot = 237,
        Sexton = 238,
        Cantor = 239,
        Heirophant = 240,
        Heirophant2 = 241,
        Mephisto = 242,
        Diablo = 243,
        DeckardCain2 = 244,
        DeckardCain3 = 245,
        DeckardCain4 = 246,
        SwampDweller = 247,
        BogCreature = 248,
        SlimePrince = 249,
        Summoner = 250,
        tyrael = 251,
        Asheara = 252,
        Hratli = 253,
        Alkor = 254,
        Ormus = 255,
        Izual = 256,
        Halbu = 257,
        WaterWatcherLimb = 258,
        RiverStalkerLimb = 259,
        StygianWatcherLimb = 260,
        WaterWatcherHead = 261,
        RiverStalkerHead = 262,
        StygianWatcherHead = 263,
        meshif = 264,
        DeckardCain5 = 265,
        navi = 266,
        Bloodraven = 267,
        bug = 268,
        scorpion = 269,
        RogueScout = 270,
        roguehire = 271,
        rogue3 = 272,
        GargoyleTrap = 273,
        ReturnedMage = 274,
        BoneMage = 275,
        BurningDeadMage = 276,
        HorrorMage = 277,
        RatManShaman = 278,
        FetishShaman = 279,
        FlayerShaman = 280,
        SoulKillerShaman = 281,
        StygianDollShaman = 282,
        larva = 283,
        SandMaggotQueen = 284,
        RockWormQueen = 285,
        DevourerQueen = 286,
        GiantLampreyQueen = 287,
        WorldKillerQueen = 288,
        ClayGolem = 289,
        BloodGolem = 290,
        IronGolem = 291,
        FireGolem = 292,
        familiar = 293,
        act3male = 294,
        NightMarauder = 295,
        act3female = 296,
        Natalya = 297,
        FleshSpawner = 298,
        StygianHag = 299,
        Grotesque = 300,
        FleshBeast = 301,
        StygianDog = 302,
        GrotesqueWyrm = 303,
        Groper = 304,
        Strangler = 305,
        StormCaster = 306,
        Corpulent = 307,
        CorpseSpitter = 308,
        MawFiend = 309,
        DoomKnight = 310,
        AbyssKnight = 311,
        OblivionKnight = 312,
        QuillBear = 313,
        SpikeGiant = 314,
        ThornBrute = 315,
        RazorBeast = 316,
        GiantUrchin = 317,
        snake = 318,
        parrot = 319,
        fish = 320,
        evilhole1 = 321,
        evilhole2 = 322,
        evilhole3 = 323,
        evilhole4 = 324,
        evilhole5 = 325,
        atrap = 326,
        atrap2 = 327,
        atrap3 = 328,
        atrap4 = 329,
        atrap5 = 330,
        Kaelan = 331,
        invisospawner = 332,
        Diabloclone = 333,
        SuckerNest = 334,
        FeederNest = 335,
        BloodHookNest = 336,
        BloodWingNest = 337,
        Guard = 338, //OR DeadCorpse
        minispider = 339,
        boneprison1 = 340,
        boneprison2 = 341,
        boneprison3 = 342,
        boneprison4 = 343,
        bonewall = 344,
        CouncilMember = 345,
        CouncilMember2 = 346,
        CouncilMember3 = 347,
        Turret = 348,
        Turret2 = 349,
        Turret3 = 350,
        Hydra = 351,
        Hydra2 = 352,
        Hydra3 = 353,
        atrap6 = 354,
        seventombs = 355,
        Dopplezon = 356,
        Valkyrie = 357,
        act2guard3 = 358,
        IronWolf = 359,
        Balrog = 360,
        PitLord = 361,
        VenomLord = 362,
        NecroSkeleton = 363,
        NecroMage = 364,
        Griswold = 365,
        compellingorb = 366,
        Tyrael = 367,
        youngdiablo = 368,
        atrap7 = 369,
        spiritmummy = 370,
        LightningSpire = 371,
        FireTower = 372,
        Slinger = 373,
        SpearCat = 374,
        NightSlinger = 375,
        HellSlinger = 376,
        act2guard4 = 377,
        act2guard5 = 378,
        ReturnedMage2 = 379,
        BoneMage2 = 380,
        BaalColdMage = 381,
        HorrorMage2 = 382,
        ReturnedMage3 = 383,
        BoneMage3 = 384,
        BurningDeadMage2 = 385,
        HorrorMage3 = 386,
        ReturnedMage4 = 387,
        BoneMage4 = 388,
        BurningDeadMage3 = 389,
        HorrorMage4 = 390,
        HellBovine = 391,
        window1 = 392,
        window2 = 393,
        SpearCat2 = 394,
        NightSlinger2 = 395,
        RatMan2 = 396,
        Fetish2 = 397,
        Flayer2 = 398,
        SoulKiller2 = 399,
        StygianDoll2 = 400,
        mephistospirit = 401,
        TheSmith = 402,
        TrappedSoul = 403,
        TrappedSoul2 = 404,
        Jamella = 405,
        Izual2 = 406,
        RatMan3 = 407,
        Malachai = 408,
        TheFeatureCreep = 409,
        WakeofDestruction = 410,
        ChargedBoltSentry = 411,
        LightningSentry = 412,
        BladeCreeper = 413,
        InvisPet = 414,
        InfernoSentry = 415,
        DeathSentry = 416,
        ShadowWarrior = 417,
        ShadowMaster = 418,
        DruidHawk = 419,
        DruidSpiritWolf = 420,
        DruidFenris = 421,
        SpiritofBarbs = 422,
        HeartofWolverine = 423,
        OakSage = 424,
        DruidPlaguePoppy = 425,
        DruidCycleofLife = 426,
        VineCreature = 427,
        DruidBear = 428,
        Eagle = 429,
        Wolf = 430,
        Bear = 431,
        BarricadeDoor = 432,
        BarricadeDoor2 = 433,
        PrisonDoor = 434,
        BarricadeTower = 435,
        RotWalker = 436,
        ReanimatedHorde = 437,
        ProwlingDead = 438,
        UnholyCorpse = 439,
        DefiledWarrior = 440,
        SiegeBeast = 441,
        CrushBiest = 442,
        BloodBringer = 443,
        GoreBearer = 444,
        DeamonSteed = 445,
        SnowYeti1 = 446,
        SnowYeti2 = 447,
        SnowYeti3 = 448,
        SnowYeti4 = 449,
        WolfRider1 = 450,
        WolfRider2 = 451,
        WolfRider3 = 452,
        Eldritch = 453,
        Slayerexp = 454,
        IceBoar = 455,
        FireBoar = 456,
        HellSpawn = 457,
        IceSpawn = 458,
        GreaterHellSpawn = 459,
        GreaterIceSpawn = 460,
        FanaticMinion = 461,
        BerserkSlayer = 462,
        ConsumedIceBoar = 463,
        ConsumedFireBoar = 464,
        FrenziedHellSpawn = 465,
        FrenziedIceSpawn = 466,
        InsaneHellSpawn = 467,
        InsaneIceSpawn = 468,
        Succubusexp = 469,
        VileTemptress = 470,
        StygianHarlot = 471,
        HellTemptress = 472,
        BloodTemptress = 473,
        Dominus = 474,
        VileWitch = 475,
        StygianFury = 476,
        BloodWitch = 477,
        HellWitch = 478,
        Shenk = 479,
        Lasher = 480,
        OverLord = 481,
        BloodBoss = 482,
        HellWhip = 483,
        MinionSpawner = 484,
        MinionSlayerSpawner = 485,
        MinionIce_fireBoarSpawner = 486,
        MinionIce_fireBoarSpawner2 = 487,
        Minionice_hellSpawnSpawner = 488,
        MinionIce_fireBoarSpawner3 = 489,
        MinionIce_fireBoarSpawner4 = 490,
        Minionice_hellSpawnSpawner2 = 491,
        Imp1 = 492,
        Imp2 = 493,
        Imp3 = 494,
        Imp4 = 495,
        Imp5 = 496,
        CatapultS = 497,
        CatapultE = 498,
        CatapultSiege = 499,
        CatapultW = 500,
        FrozenHorror1 = 501,
        FrozenHorror2 = 502,
        FrozenHorror3 = 503,
        FrozenHorror4 = 504,
        FrozenHorror5 = 505,
        BloodLord1 = 506,
        BloodLord2 = 507,
        BloodLord3 = 508,
        BloodLord4 = 509,
        BloodLord5 = 510,
        Larzuk = 511,
        Anya = 512,
        Malah = 513,
        NihlathakTown = 514,
        QualKehk = 515,
        CatapultSpotterS = 516,
        CatapultSpotterE = 517,
        CatapultSpotterSiege = 518,
        CatapultSpotterW = 519,
        DeckardCain6 = 520,
        tyrael3 = 521,
        Act5Combatant = 522,
        Act5Combatant2 = 523,
        BarricadeWallRight = 524,
        BarricadeWallLeft = 525,
        Nihlathak = 526,
        Anya2 = 527,
        Evilhut = 528,
        DeathMauler1 = 529,
        DeathMauler2 = 530,
        DeathMauler3 = 531,
        DeathMauler4 = 532,
        DeathMauler5 = 533,
        POW = 534,
        Act5Townguard = 535,
        Act5Townguard2 = 536,
        AncientStatue1 = 537,
        AncientStatue2 = 538,
        AncientStatue3 = 539,
        AncientBarbarian1 = 540,
        AncientBarbarian2 = 541,
        AncientBarbarian3 = 542,
        BaalThrone = 543,
        Baal = 544,
        BaalTaunt = 545,
        PutridDefiler1 = 546,
        PutridDefiler2 = 547,
        PutridDefiler3 = 548,
        PutridDefiler4 = 549,
        PutridDefiler5 = 550,
        PainWorm1 = 551,
        PainWorm2 = 552,
        PainWorm3 = 553,
        PainWorm4 = 554,
        PainWorm5 = 555,
        Bunny = 556,
        BaalSubject3 = 557,
        BaalSubject4 = 558,
        BaalCrabtoStairs = 559,
        Act5Hireling1hs = 560,
        Act5Hireling2hs = 561,
        BaalTentacle = 562,
        BaalTentacle2 = 563,
        BaalTentacle3 = 564,
        BaalTentacle4 = 565,
        BaalTentacle5 = 566,
        InjuredBarbarian1 = 567,
        InjuredBarbarian2 = 568,
        InjuredBarbarian3 = 569,
        Baalclone = 570,
        BaalSubject5 = 571,
        BaalsMinion2 = 572,
        BaalsMinion3 = 573,
        WorldstoneEffect = 574,
        BurningDeadArcher2 = 575,
        BoneArcher2 = 576,
        BurningDeadArcher3 = 577,
        ReturnedArcher2 = 578,
        HorrorArcher2 = 579,
        Afflicted2 = 580,
        Tainted2 = 581,
        Misshapen2 = 582,
        Disfigured2 = 583,
        Damned2 = 584,
        MoonClan2 = 585,
        NightClan2 = 586,
        HellClan2 = 587,
        BloodClan2 = 588,
        DeathClan2 = 589,
        FoulCrow2 = 590,
        BloodHawk2 = 591,
        BlackRaptor2 = 592,
        CloudStalker2 = 593,
        ClawViper2 = 594,
        PitViper2 = 595,
        Salamander2 = 596,
        TombViper2 = 597,
        SerpentMagus2 = 598,
        Marauder2 = 599,
        Infidel2 = 600,
        SandRaider2 = 601,
        Invader2 = 602,
        Assailant2 = 603,
        DeathMauler12 = 604,
        QuillRat2 = 605,
        SpikeFiend2 = 606,
        RazorSpine2 = 607,
        CarrionBird2 = 608,
        ThornedHulk2 = 609,
        Slinger2 = 610,
        Slinger3 = 611,
        Slinger4 = 612,
        VileArcher2 = 613,
        DarkArcher2 = 614,
        VileLancer2 = 615,
        DarkLancer2 = 616,
        BlackLancer2 = 617,
        Blunderbore2 = 618,
        Mauler2 = 619,
        ReturnedMage5 = 620,
        BurningDeadMage4 = 621,
        ReturnedMage6 = 622,
        HorrorMage5 = 623,
        BoneMage5 = 624,
        HorrorMage6 = 625,
        HorrorMage7 = 626,
        Huntress2 = 627,
        SaberCat2 = 628,
        CaveLeaper2 = 629,
        TombCreeper2 = 630,
        Ghost2 = 631,
        Wraith2 = 632,
        Specter2 = 633,
        Succubusexp2 = 634,
        HellTemptress2 = 635,
        Dominus2 = 636,
        HellWitch2 = 637,
        VileWitch2 = 638,
        Gloam2 = 639,
        BlackSoul2 = 640,
        BurningSoul2 = 641,
        Carver2 = 642,
        Devilkin2 = 643,
        DarkOne2 = 644,
        CarverShaman2 = 645,
        DevilkinShaman2 = 646,
        DarkShaman2 = 647,
        BoneWarrior2 = 648,
        Returned2 = 649,
        Gloombat2 = 650,
        Fiend2 = 651,
        BloodLord6 = 652,
        BloodLord7 = 653,
        Scarab2 = 654,
        SteelWeevil2 = 655,
        Flayer3 = 656,
        StygianDoll3 = 657,
        SoulKiller3 = 658,
        Flayer4 = 659,
        StygianDoll4 = 660,
        SoulKiller4 = 661,
        FlayerShaman2 = 662,
        StygianDollShaman2 = 663,
        SoulKillerShaman2 = 664,
        TempleGuard2 = 665,
        TempleGuard3 = 666,
        Guardian2 = 667,
        Unraveler2 = 668,
        HoradrimAncient2 = 669,
        HoradrimAncient3 = 670,
        Zealot2 = 671,
        Zealot3 = 672,
        Heirophant3 = 673,
        Heirophant4 = 674,
        Grotesque2 = 675,
        FleshSpawner2 = 676,
        GrotesqueWyrm2 = 677,
        FleshBeast2 = 678,
        WorldKiller2 = 679,
        WorldKillerYoung2 = 680,
        WorldKillerEgg2 = 681,
        Slayerexp2 = 682,
        HellSpawn2 = 683,
        GreaterHellSpawn2 = 684,
        Arach2 = 685,
        Balrog2 = 686,
        PitLord2 = 687,
        Imp6 = 688,
        Imp7 = 689,
        UndeadStygianDoll2 = 690,
        UndeadSoulKiller2 = 691,
        Strangler2 = 692,
        StormCaster2 = 693,
        MawFiend2 = 694,
        BloodLord8 = 695,
        GhoulLord2 = 696,
        DarkLord2 = 697,
        UnholyCorpse2 = 698,
        DoomKnight2 = 699,
        DoomKnight3 = 700,
        OblivionKnight2 = 701,
        BaalThrone2 = 702,
        Cadaver2 = 703,
        UberMephisto = 704,
        UberDiablo = 705,
        UberIzual = 706,
        UberLilith = 707,
        UberDuriel = 708,
        UberBaalCrab = 709,
        Evilhut2 = 710,
        evilhole12 = 711,
        PitLord3 = 712,
        OblivionKnight4 = 713,
        Imp8 = 714,
        HellSwarm2 = 715,
        WorldKiller3 = 716,
        Arach3 = 717,
        SteelWeevil3 = 718,
        HellTemptress3 = 719,
        VileWitch3 = 720,
        FleshHunter2 = 721,
        DarkArcher3 = 722,
        BlackLancer3 = 723,
        HellWhip2 = 724,
        Returned3 = 725,
        HorrorArcher3 = 726,
        BurningDeadMage5 = 727,
        HorrorMage8 = 728,
        BoneMage6 = 729,
        HorrorMage9 = 730,
        DarkLord3 = 731,
        Specter3 = 732,
        BurningSoul3 = 733,
        Bishibosh = 734,
        Bonebreak = 735,
        Coldcrow = 736,
        Rakanishu = 737,
        TreeheadWoodFist = 738,
        Griswold2 = 739,
        PitspawnFouldog = 740,
        TheCountess = 741,
        FlamespiketheCrawler = 742,
        Boneash = 743,
        Radament2 = 744,
        CubeNPC = 745,
        Fangskin = 746,
        Beetleburst = 747,
        Leatherarm = 748,
        ColdwormtheBurrower = 749,
        FireEye = 750,
        DarkElder = 751,
        AncientKaatheSoulless = 752,
        TheSummoner = 753,
        TheSmith2 = 754,
        WebMagetheBurning = 755,
        WitchDoctorEndugu = 756,
        Stormtree = 757,
        SarinatheBattlemaid = 758,
        IcehawkRiftwing = 759,
        IsmailVilehand = 760,
        GelebFlamefinger = 761,
        BremmSparkfist = 762,
        ToorcIcefist = 763,
        WyandVoidfinger = 764,
        MafferDragonhand = 765,
        WingedDeath = 766,
        TheTormentor = 767,
        Taintbreeder = 768,
        RiftwraththeCannibal = 769,
        InfectorofSouls = 770,
        LordDeSeis = 771,
        GrandVizierofChaos = 772,
        TheCowKing = 773,
        Corpsefire = 774,
        TheFeatureCreep2 = 775,
        Shenk2 = 776,
        Talic = 777,
        Madawc = 778,
        Korlic = 779,
        AxeDweller = 780,
        BonesawBreaker = 781,
        DacFarren = 782,
        MegaflowRectifer = 783,
        EyebackUnleashed = 784,
        ThreashSocket = 785,
        Pindleskin = 786,
        SnapchipShatter = 787,
        AnodizedElite = 788,
        VinvearMolech = 789,
        SharpToothSayer = 790,
        MagmaTorquer = 791,
        BlazeRipper = 792,
        Frozenstein = 793,
        Nihlathak2 = 794,
        ColenzothAnnihilator = 795,
        AchmeltheCursed = 796,
        BartuctheBloody = 797,
        VentartheUnholy = 798,
        ListertheTormentor = 799,
        Unknown = 800,
        Unknown2 = 801,
        Unknown3 = 802,
        Nihlathak3 = 803,
    }




    public enum MobsNPC
    {
        Skeleton,
        Returned,
        BoneWarrior,
        BurningDead,
        Horror,
        Zombie,
        HungryDead,
        Ghoul,
        DrownedCarcass,
        PlagueBearer,
        Afflicted,
        Tainted,
        Misshapen,
        Disfigured,
        Damned,
        FoulCrow,
        BloodHawk,
        BlackRaptor,
        CloudStalker,
        Fallen,
        Carver,
        Devilkin,
        DarkOne,
        WarpedFallen,
        Brute,
        Yeti,
        Crusher,
        WailingBeast,
        GargantuanBeast,
        SandRaer,
        Marauder,
        Invader,
        Infel,
        Assailant,
        Gorgon,
        Gorgon2,
        Gorgon3,
        Gorgon4,
        Ghost,
        Wraith,
        Specter,
        Apparition,
        DarkShape,
        DarkHunter,
        VileHunter,
        DarkStalker,
        BlackRogue,
        FleshHunter,
        DuneBeast,
        RockDweller,
        JungleHunter,
        DoomApe,
        TempleGuard,
        MoonClan,
        NightClan,
        BloodClan,
        HellClan,
        DeathClan,
        FallenShaman,
        CarverShaman,
        DevilkinShaman,
        DarkShaman,
        WarpedShaman,
        QuillRat,
        SpikeFiend,
        ThornBeast,
        RazorSpine,
        JungleUrchin,
        SandMaggot,
        RockWorm,
        Devourer,
        GiantLamprey,
        WorldKiller,
        TombViper,
        ClawViper,
        Salamander,
        PitViper,
        SerpentMagus,
        SandLeaper,
        CaveLeaper,
        TombCreeper,
        TreeLurker,
        RazorPitDemon,
        Huntress,
        SaberCat,
        NightTiger,
        HellCat,
        Itchies,
        BlackLocusts,
        PlagueBugs,
        HellSwarm,
        DungSoldier,
        SandWarrior,
        Scarab,
        SteelWeevil,
        AlbinoRoach,
        DriedCorpse,
        Decayed,
        Embalmed,
        PreservedDead,
        Cadaver,
        HollowOne,
        Guardian,
        Unraveler,
        HoradrimAncient,
        BaalSubjectMummy,
        ChaosHorde,
        ChaosHorde2,
        ChaosHorde3,
        ChaosHorde4,
        CarrionBird,
        UndeadScavenger,
        HellBuzzard,
        WingedNightmare,
        Sucker,
        Feeder,
        BloodHook,
        BloodWing,
        Gloam,
        SwampGhost,
        BurningSoul,
        BlackSoul,
        Arach,
        SandFisher,
        PoisonSpinner,
        FlameSper,
        SperMagus,
        ThornedHulk,
        BrambleHulk,
        Thrasher,
        Spikefist,
        GhoulLord,
        NightLord,
        DarkLord,
        BloodLord,
        Banished,
        DesertWing,
        Fiend,
        Gloombat,
        BloodDiver,
        DarkFamiliar,
        RatMan,
        Fetish,
        Flayer,
        SoulKiller,
        StygianDoll,
        DeckardCain,
        Gheed,
        Akara,
        Chicken,
        //Kashya,
        Rogue,
        HellMeteor,
        Charsi,
        Warriv,
        Andariel,
        Bird,
        Bird2,
        Bat,
        DarkRanger,
        VileArcher,
        DarkArcher,
        BlackArcher,
        FleshArcher,
        DarkSpearwoman,
        VileLancer,
        DarkLancer,
        BlackLancer,
        FleshLancer,
        SkeletonArcher,
        ReturnedArcher,
        BoneArcher,
        BurningDeadArcher,
        HorrorArcher,
        Warriv2,
        Atma,
        Drognan,
        Fara,
        Cow,
        SandMaggotYoung,
        RockWormYoung,
        DevourerYoung,
        GiantLampreyYoung,
        WorldKillerYoung,
        Camel,
        Blunderbore,
        Gorbelly,
        Mauler,
        Urdar,
        SandMaggotEgg,
        RockWormEgg,
        DevourerEgg,
        GiantLampreyEgg,
        WorldKillerEgg,
        Act2Male,
        Act2Female,
        Act2Child,
        Greiz,
        Elzix,
        Geglash,
        Jerhyn,
        Lysander,
        Act2Guard,
        Act2Vendor,
        Act2Vendor2,
        FoulCrowNest,
        BloodHawkNest,
        BlackVultureNest,
        CloudStalkerNest,
        Meshif,
        Duriel,
        UndeadRatMan,
        UndeadFetish,
        UndeadFlayer,
        UndeadSoulKiller,
        UndeadStygianDoll,
        DarkGuard,
        DarkGuard2,
        DarkGuard3,
        DarkGuard4,
        DarkGuard5,
        BloodMage,
        BloodMage2,
        BloodMage3,
        BloodMage4,
        BloodMage5,
        Maggot,
        MummyGenerator,
        Radament,
        FireBeast,
        IceGlobe,
        LightningBeast,
        PoisonOrb,
        FlyingScimitar,
        Zakarumite,
        Faithful,
        Zealot,
        Sexton,
        Cantor,
        Heirophant,
        Heirophant2,
        Mephisto,
        Diablo,
        SwampDweller,
        BogCreature,
        SlimePrince,
        Summoner,
        Tyrael,
        Asheara,
        Hratli,
        Alkor,
        Ormus,
        Izual,
        Halbu,
        WaterWatcherLimb,
        RiverStalkerLimb,
        StygianWatcherLimb,
        WaterWatcherHead,
        RiverStalkerHead,
        StygianWatcherHead,
        Meshif2,
        DeckardCain5,
        Navi,
        BloodRaven,
        Bug,
        Scorpion,
        RogueScout,
        Rogue2,
        Rogue3,
        GargoyleTrap,
        ReturnedMage,
        BoneMage,
        BurningDeadMage,
        HorrorMage,
        RatManShaman,
        FetishShaman,
        FlayerShaman,
        SoulKillerShaman,
        StygianDollShaman,
        Larva,
        SandMaggotQueen,
        RockWormQueen,
        DevourerQueen,
        GiantLampreyQueen,
        WorldKillerQueen,
        ClayGolem,
        BloodGolem,
        IronGolem,
        FireGolem,
        Familiar,
        Act3Male,
        NightMarauder,
        Act3Female,
        Natalya,
        FleshSpawner,
        StygianHag,
        Grotesque,
        FleshBeast,
        StygianDog,
        GrotesqueWyrm,
        Groper,
        Strangler,
        StormCaster,
        Corpulent,
        CorpseSpitter,
        MawFiend,
        DoomKnight,
        AbyssKnight,
        OblivionKnight,
        QuillBear,
        SpikeGiant,
        ThornBrute,
        RazorBeast,
        GiantUrchin,
        Snake,
        Parrot,
        Fish,
        EvilHole,
        EvilHole2,
        EvilHole3,
        EvilHole4,
        EvilHole5,
        FireboltTrap,
        HorzMissileTrap,
        VertMissileTrap,
        PoisonCloudTrap,
        LightningTrap,
        Kaelan,
        InvisoSpawner,
        DiabloClone,
        SuckerNest,
        FeederNest,
        BloodHookNest,
        BloodWingNest,
        Guard,
        MiniSper,
        BonePrison,
        BonePrison2,
        BonePrison3,
        BonePrison4,
        BoneWall,
        CouncilMember,
        CouncilMember2,
        CouncilMember3,
        Turret,
        Turret2,
        Turret3,
        Hydra,
        Hydra2,
        Hydra3,
        MeleeTrap,
        SevenTombs,
        Decoy,
        Valkyrie,
        Act2Guard3,
        IronWolf,
        Balrog,
        PitLord,
        VenomLord,
        NecroSkeleton,
        NecroMage,
        Griswold,
        CompellingOrbNpc,
        Tyrael2,
        DarkWanderer,
        NovaTrap,
        SpiritMummy,
        LightningSpire,
        FireTower,
        Slinger,
        SpearCat,
        NightSlinger,
        HellSlinger,
        Act2Guard4,
        Act2Guard5,
        ReturnedMage2,
        BoneMage2,
        BaalColdMage,
        HorrorMage2,
        ReturnedMage3,
        BoneMage3,
        BurningDeadMage2,
        HorrorMage3,
        ReturnedMage4,
        BoneMage4,
        BurningDeadMage3,
        HorrorMage4,
        HellBovine,
        Window,
        Window2,
        SpearCat2,
        NightSlinger2,
        RatMan2,
        Fetish2,
        Flayer2,
        SoulKiller2,
        StygianDoll2,
        MephistoSpirit,
        TheSmith,
        TrappedSoul,
        TrappedSoul2,
        Jamella,
        Izual2,
        RatMan3,
        Malachai,
        Hephasto,
        WakeOfDestruction,
        ChargedBoltSentry,
        LightningSentry,
        BladeCreeper,
        InvisiblePet,
        InfernoSentry,
        DeathSentry,
        ShadowWarrior,
        ShadowMaster,
        DruHawk,
        DruSpiritWolf,
        DruFenris,
        SpiritOfBarbs,
        HeartOfWolverine,
        OakSage,
        DruPlaguePoppy,
        DruCycleOfLife,
        VineCreature,
        DruBear,
        Eagle,
        Wolf,
        Bear,
        BarricadeDoor,
        BarricadeDoor2,
        PrisonDoor,
        BarricadeTower,
        RotWalker,
        ReanimatedHorde,
        ProwlingDead,
        UnholyCorpse,
        DefiledWarrior,
        SiegeBeast,
        CrushBiest,
        BloodBringer,
        GoreBearer,
        DeamonSteed,
        SnowYeti,
        SnowYeti2,
        SnowYeti3,
        SnowYeti4,
        WolfRer,
        WolfRer2,
        WolfRer3,
        MinionExp,
        SlayerExp,
        IceBoar,
        FireBoar,
        HellSpawn,
        IceSpawn,
        GreaterHellSpawn,
        GreaterIceSpawn,
        FanaticMinion,
        BerserkSlayer,
        ConsumedIceBoar,
        ConsumedFireBoar,
        FrenziedHellSpawn,
        FrenziedIceSpawn,
        InsaneHellSpawn,
        InsaneIceSpawn,
        SuccubusExp2,
        VileTemptress,
        StygianHarlot,
        HellTemptress2,
        BloodTemptress,
        Dominus,
        VileWitch2,
        StygianFury,
        BloodWitch,
        HellWitch,
        OverSeer,
        Lasher,
        OverLord,
        BloodBoss,
        HellWhip2,
        MinionSpawner,
        MinionSlayerSpawner,
        MinionBoarSpawner,
        MinionBoarSpawner2,
        MinionSpawnSpawner,
        MinionBoarSpawner3,
        MinionBoarSpawner4,
        MinionSpawnSpawner2,
        Imp,
        Imp2,
        Imp3,
        Imp4,
        Imp5,
        CatapultS,
        CatapultE,
        CatapultSiege,
        CatapultW,
        FrozenHorror,
        FrozenHorror2,
        FrozenHorror3,
        FrozenHorror4,
        FrozenHorror5,
        BloodLord2,
        BloodLord3,
        BloodLord4,
        BloodLord5,
        BloodLord6,
        Larzuk,
        Anya,
        Malah,
        NihlathakTown,
        QualKehk,
        CatapultSpotterS,
        CatapultSpotterE,
        CatapultSpotterSiegeName,
        CatapultSpotterW,
        DeckardCain6,
        Tyrael3,
        Act5Combatant,
        Act5Combatant2,
        BarricadeWallRight,
        BarricadeWallLeft,
        Nihlathak,
        Anya2,
        EvilHut,
        DeathMauler,
        DeathMauler2,
        DeathMauler3,
        DeathMauler4,
        DeathMauler5,
        POW,
        Act5Townguard,
        Act5Townguard2,
        AncientStatue,
        AncientStatueNpc2,
        AncientStatueNpc3,
        AncientBarbarian,
        AncientBarbarian2,
        AncientBarbarian3,
        BaalThrone,
        BaalCrab,
        BaalTaunt,
        PutrDefiler,
        PutrDefiler2,
        PutrDefiler3,
        PutrDefiler4,
        PutrDefiler5,
        PainWorm,
        PainWorm2,
        PainWorm3,
        PainWorm4,
        PainWorm5,
        Bunny,
        CouncilMemberBall,
        VenomLord2,
        BaalCrabToStairs,
        Act5Hireling1Hand,
        Act5Hireling2Hand,
        BaalTentacle,
        BaalTentacle2,
        BaalTentacle3,
        BaalTentacle4,
        BaalTentacle5,
        InjuredBarbarian,
        InjuredBarbarian2,
        InjuredBarbarian3,
        BaalCrabClone,
        BaalsMinion,
        BaalsMinion2,
        BaalsMinion3,
        WorldstoneEffect,
        BurningDeadArcher2,
        BoneArcher2,
        BurningDeadArcher3,
        ReturnedArcher2,
        HorrorArcher2,
        Afflicted2,
        Tainted2,
        Misshapen2,
        Disfigured2,
        Damned2,
        MoonClan2,
        NightClan2,
        HellClan2,
        BloodClan2,
        DeathClan2,
        FoulCrow2,
        BloodHawk2,
        BlackRaptor2,
        CloudStalker2,
        ClawViper2,
        PitViper2,
        Salamander2,
        TombViper2,
        SerpentMagus2,
        Marauder2,
        Infel2,
        SandRaer2,
        Invader2,
        Assailant2,
        DeathMauler6,
        QuillRat2,
        SpikeFiend2,
        RazorSpine2,
        CarrionBird2,
        ThornedHulk2,
        Slinger2,
        Slinger3,
        Slinger4,
        VileArcher2,
        DarkArcher2,
        VileLancer2,
        DarkLancer2,
        BlackLancer2,
        Blunderbore2,
        Mauler2,
        ReturnedMage5,
        BurningDeadMage4,
        ReturnedMage6,
        HorrorMage5,
        BoneMage5,
        HorrorMage6,
        HorrorMage7,
        Huntress2,
        SaberCat2,
        CaveLeaper2,
        TombCreeper2,
        Ghost2,
        Wraith2,
        Specter2,
        SuccubusExp3,
        HellTemptress3,
        Dominus2,
        HellWitch2,
        VileWitch3,
        Gloam2,
        BlackSoul2,
        BurningSoul2,
        Carver2,
        Devilkin2,
        DarkOne2,
        CarverShaman2,
        DevilkinShaman2,
        DarkShaman2,
        BoneWarrior2,
        Returned2,
        Gloombat2,
        Fiend2,
        BloodLord7,
        BloodLord8,
        Scarab2,
        SteelWeevil2,
        Flayer3,
        StygianDoll3,
        SoulKiller3,
        Flayer4,
        StygianDoll4,
        SoulKiller4,
        FlayerShaman2,
        StygianDollShaman2,
        SoulKillerShaman2,
        TempleGuard2,
        TempleGuard3,
        Guardian2,
        Unraveler2,
        HoradrimAncient2,
        HoradrimAncient3,
        Zealot2,
        Zealot3,
        Heirophant3,
        Heirophant4,
        Grotesque2,
        FleshSpawner2,
        GrotesqueWyrm2,
        FleshBeast2,
        WorldKiller2,
        WorldKillerYoung2,
        WorldKillerEgg2,
        SlayerExp2,
        HellSpawn2,
        GreaterHellSpawn2,
        Arach2,
        Balrog2,
        PitLord2,
        Imp6,
        Imp7,
        UndeadStygianDoll2,
        UndeadSoulKiller2,
        Strangler2,
        StormCaster2,
        MawFiend2,
        BloodLord9,
        GhoulLord2,
        DarkLord2,
        UnholyCorpse2,
        DoomKnight2,
        DoomKnight3,
        OblivionKnight2,
        OblivionKnight3,
        Cadaver2,
        UberMephisto,
        UberDiablo,
        UberIzual,
        Lilith,
        UberDuriel,
        UberBaal,
        EvilHut2,
        DemonHole,
        PitLord3,
        OblivionKnight4,
        Imp8,
        HellSwarm2,
        WorldKiller3,
        Arach3,
        SteelWeevil3,
        HellTemptress4,
        VileWitch4,
        FleshHunter2,
        DarkArcher3,
        BlackLancer3,
        HellWhip3,
        Returned3,
        HorrorArcher3,
        BurningDeadMage5,
        HorrorMage8,
        BoneMage6,
        HorrorMage9,
        DarkLord3,
        Specter3,
        BurningSoul3,
        Bishibosh,
        Bonebreak,
        Coldcrow,
        Rakanishu,
        TreeheadWoodFist,
        Griswold2,
        PitspawnFouldog,
        TheCountess,
        FlamespiketheCrawler,
        Boneash,
        Radament2,
        CubeNPC,
        Fangskin,
        Beetleburst,
        Leatherarm,
        ColdwormtheBurrower,
        FireEye,
        DarkElder,
        AncientKaatheSoulless,
        TheSummoner,
        TheSmith2,
        WebMagetheBurning,
        WitchDoctorEndugu,
        Stormtree,
        SarinatheBattlemaid,
        IcehawkRiftwing,
        IsmailVilehand,
        GelebFlamefinger,
        BremmSparkfist,
        ToorcIcefist,
        WyandVoidfinger,
        MafferDragonhand,
        WingedDeath,
        TheTormentor,
        Taintbreeder,
        RiftwraththeCannibal,
        InfectorofSouls,
        LordDeSeis,
        GrandVizierofChaos,
        TheCowKing,
        Corpsefire,
        TheFeatureCreep2,
        Shenk2,
        Talic,
        Madawc,
        Korlic,
        AxeDweller,
        BonesawBreaker,
        DacFarren,
        MegaflowRectifer,
        EyebackUnleashed,
        ThreashSocket,
        Pindleskin,
        SnapchipShatter,
        AnodizedElite,
        VinvearMolech,
        SharpToothSayer,
        MagmaTorquer,
        BlazeRipper,
        Frozenstein,
        Nihlathak2,
        ColenzothAnnihilator,
        AchmeltheCursed,
        BartuctheBloody,
        VentartheUnholy,
        ListertheTormentor
    }
}
