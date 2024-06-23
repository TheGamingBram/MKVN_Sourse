using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace Pulsar_Pack_Creator
{

    partial class MainWindow : Window
    {
        public class Cup
        {
            public static readonly string[] defaultNames =
            {
                "Cup 0",
                "Cup 1",
                "Cup 2",
                "Cup 3",
                "Cup 4",
                "Cup 5",
                "Cup 6",
                "Cup 7",
                "Cup 8",
                "Cup 9",
                "Cup 10",
                "Cup 11",
                "Cup 12",
                "Cup 13",
                "Cup 14",
                "Cup 15",
                "Cup 16",
                "Cup 17",
                "Cup 18",
                "Cup 19",
                "Cup 20",
                "Cup 21",
                "Cup 22",
                "Cup 23",
                "Cup 24",
                "Cup 25",
                "Cup 26",
                "Cup 27",
                "Cup 28",
                "Cup 29",
                "Cup 30",
                "Cup 31",
                "Cup 32",
                "Cup 33",
                "Cup 34",
                "Cup 35",
                "Cup 36",
                "Cup 37",
                "Cup 38",
                "Cup 39",
                "Cup 40",
                "Cup 41",
                "Cup 42",
                "Cup 43",
                "Cup 44",
                "Cup 45",
                "Cup 46",
                "Cup 47",
                "Cup 48",
                "Cup 49",
                "Cup 50",
                "Cup 51",
                "Cup 52",
                "Cup 53",
                "Cup 54",
                "Cup 55",
                "Cup 56",
                "Cup 57",
                "Cup 58",
                "Cup 59",
                "Cup 60",
                "Cup 61",
                "Cup 62",
                "Cup 63",
                "Cup 64",
                "Cup 65",
                "Cup 66",
                "Cup 67",
                "Cup 68",
                "Cup 69",
                "Cup 70",
                "Cup 71",
                "Cup 72",
                "Cup 73",
                "Cup 74",
                "Cup 75",
                "Cup 76",
                "Cup 77",
                "Cup 78",
                "Cup 79",
                "Cup 80",
                "Cup 81",
                "Cup 82",
                "Cup 83",
                "Cup 84",
                "Cup 85",
                "Cup 86",
                "Cup 87",
                "Cup 88",
                "Cup 89",
                "Cup 90",
                "Cup 91",
                "Cup 92",
                "Cup 93",
                "Cup 94",
                "Cup 95",
                "Cup 96",
                "Cup 97",
                "Cup 98",
                "Cup 99",
                "Cup 100",
                "Cup 101",
                "Cup 102",
                "Cup 103",
                "Cup 104",
                "Cup 105",
                "Cup 106",
                "Cup 107",
                "Cup 108",
                "Cup 109",
                "Cup 110",
                "Cup 111",
                "Cup 112",
                "Cup 113",
                "Cup 114",
                "Cup 115",
                "Cup 116",
                "Cup 117",
                "Cup 118",
                "Cup 119",
                "Cup 120",
                "Cup 121",
                "Cup 122",
                "Cup 123",
                "Cup 124",
                "Cup 125",
                "Cup 126",
                "Cup 127",
                "Cup 128",
                "Cup 129",
                "Cup 130",
                "Cup 131",
                "Cup 132",
                "Cup 133",
                "Cup 134",
                "Cup 135",
                "Cup 136",
                "Cup 137",
                "Cup 138",
                "Cup 139",
                "Cup 140",
                "Cup 141",
                "Cup 142",
                "Cup 143",
                "Cup 144",
                "Cup 145",
                "Cup 146",
                "Cup 147",
                "Cup 148",
                "Cup 149",
                "Cup 150",
                "Cup 151",
                "Cup 152",
                "Cup 153",
                "Cup 154",
                "Cup 155",
                "Cup 156",
                "Cup 157",
                "Cup 158",
                "Cup 159",
                "Cup 160",
                "Cup 161",
                "Cup 162",
                "Cup 163",
                "Cup 164",
                "Cup 165",
                "Cup 166",
                "Cup 167",
                "Cup 168",
                "Cup 169",
                "Cup 170",
                "Cup 171",
                "Cup 172",
                "Cup 173",
                "Cup 174",
                "Cup 175",
                "Cup 176",
                "Cup 177",
                "Cup 178",
                "Cup 179",
                "Cup 180",
                "Cup 181",
                "Cup 182",
                "Cup 183",
                "Cup 184",
                "Cup 185",
                "Cup 186",
                "Cup 187",
                "Cup 188",
                "Cup 189",
                "Cup 190",
                "Cup 191",
                "Cup 192",
                "Cup 193",
                "Cup 194",
                "Cup 195",
                "Cup 196",
                "Cup 197",
                "Cup 198",
                "Cup 199",
                "Cup 200",
                "Cup 201",
                "Cup 202",
                "Cup 203",
                "Cup 204",
                "Cup 205",
                "Cup 206",
                "Cup 207",
                "Cup 208",
                "Cup 209",
                "Cup 210",
                "Cup 211",
                "Cup 212",
                "Cup 213",
                "Cup 214",
                "Cup 215",
                "Cup 216",
                "Cup 217",
                "Cup 218",
                "Cup 219",
                "Cup 220",
                "Cup 221",
                "Cup 222",
                "Cup 223",
                "Cup 224",
                "Cup 225",
                "Cup 226",
                "Cup 227",
                "Cup 228",
                "Cup 229",
                "Cup 230",
                "Cup 231",
                "Cup 232",
                "Cup 233",
                "Cup 234",
                "Cup 235",
                "Cup 236",
                "Cup 237",
                "Cup 238",
                "Cup 239",
                "Cup 240",
                "Cup 241",
                "Cup 242",
                "Cup 243",
                "Cup 244",
                "Cup 245",
                "Cup 246",
                "Cup 247",
                "Cup 248",
                "Cup 249",
                "Cup 250",
                "Cup 251",
                "Cup 252",
                "Cup 253",
                "Cup 254",
                "Cup 255",
                "Cup 256",
                "Cup 257",
                "Cup 258",
                "Cup 259",
                "Cup 260",
                "Cup 261",
                "Cup 262",
                "Cup 263",
                "Cup 264",
                "Cup 265",
                "Cup 266",
                "Cup 267",
                "Cup 268",
                "Cup 269",
                "Cup 270",
                "Cup 271",
                "Cup 272",
                "Cup 273",
                "Cup 274",
                "Cup 275",
                "Cup 276",
                "Cup 277",
                "Cup 278",
                "Cup 279",
                "Cup 280",
                "Cup 281",
                "Cup 282",
                "Cup 283",
                "Cup 284",
                "Cup 285",
                "Cup 286",
                "Cup 287",
                "Cup 288",
                "Cup 289",
                "Cup 290",
                "Cup 291",
                "Cup 292",
                "Cup 293",
                "Cup 294",
                "Cup 295",
                "Cup 296",
                "Cup 297",
                "Cup 298",
                "Cup 299",
                "Cup 300",
                "Cup 301",
                "Cup 302",
                "Cup 303",
                "Cup 304",
                "Cup 305",
                "Cup 306",
                "Cup 307",
                "Cup 308",
                "Cup 309",
                "Cup 310",
                "Cup 311",
                "Cup 312",
                "Cup 313",
                "Cup 314",
                "Cup 315",
                "Cup 316",
                "Cup 317",
                "Cup 318",
                "Cup 319",
                "Cup 320",
                "Cup 321",
                "Cup 322",
                "Cup 323",
                "Cup 324",
                "Cup 325",
                "Cup 326",
                "Cup 327",
                "Cup 328",
                "Cup 329",
                "Cup 330",
                "Cup 331",
                "Cup 332",
                "Cup 333",
                "Cup 334",
                "Cup 335",
                "Cup 336",
                "Cup 337",
                "Cup 338",
                "Cup 339",
                "Cup 340",
                "Cup 341",
                "Cup 342",
                "Cup 343",
                "Cup 344",
                "Cup 345",
                "Cup 346",
                "Cup 347",
                "Cup 348",
                "Cup 349",
                "Cup 350",
                "Cup 351",
                "Cup 352",
                "Cup 353",
                "Cup 354",
                "Cup 355",
                "Cup 356",
                "Cup 357",
                "Cup 358",
                "Cup 359",
                "Cup 360",
                "Cup 361",
                "Cup 362",
                "Cup 363",
                "Cup 364",
                "Cup 365",
                "Cup 366",
                "Cup 367",
                "Cup 368",
                "Cup 369",
                "Cup 370",
                "Cup 371",
                "Cup 372",
                "Cup 373",
                "Cup 374",
                "Cup 375",
                "Cup 376",
                "Cup 377",
                "Cup 378",
                "Cup 379",
                "Cup 380",
                "Cup 381",
                "Cup 382",
                "Cup 383",
                "Cup 384",
                "Cup 385",
                "Cup 386",
                "Cup 387",
                "Cup 388",
                "Cup 389",
                "Cup 390",
                "Cup 391",
                "Cup 392",
                "Cup 393",
                "Cup 394",
                "Cup 395",
                "Cup 396",
                "Cup 397",
                "Cup 398",
                "Cup 399",
                "Cup 400",
                "Cup 401",
                "Cup 402",
                "Cup 403",
                "Cup 404",
                "Cup 405",
                "Cup 406",
                "Cup 407",
                "Cup 408",
                "Cup 409",
                "Cup 410",
                "Cup 411",
                "Cup 412",
                "Cup 413",
                "Cup 414",
                "Cup 415",
                "Cup 416",
                "Cup 417",
                "Cup 418",
                "Cup 419",
                "Cup 420",
                "Cup 421",
                "Cup 422",
                "Cup 423",
                "Cup 424",
                "Cup 425",
                "Cup 426",
                "Cup 427",
                "Cup 428",
                "Cup 429",
                "Cup 430",
                "Cup 431",
                "Cup 432",
                "Cup 433",
                "Cup 434",
                "Cup 435",
                "Cup 436",
                "Cup 437",
                "Cup 438",
                "Cup 439",
                "Cup 440",
                "Cup 441",
                "Cup 442",
                "Cup 443",
                "Cup 444",
                "Cup 445",
                "Cup 446",
                "Cup 447",
                "Cup 448",
                "Cup 449",
                "Cup 450",
                "Cup 451",
                "Cup 452",
                "Cup 453",
                "Cup 454",
                "Cup 455",
                "Cup 456",
                "Cup 457",
                "Cup 458",
                "Cup 459",
                "Cup 460",
                "Cup 461",
                "Cup 462",
                "Cup 463",
                "Cup 464",
                "Cup 465",
                "Cup 466",
                "Cup 467",
                "Cup 468",
                "Cup 469",
                "Cup 470",
                "Cup 471",
                "Cup 472",
                "Cup 473",
                "Cup 474",
                "Cup 475",
                "Cup 476",
                "Cup 477",
                "Cup 478",
                "Cup 479",
                "Cup 480",
                "Cup 481",
                "Cup 482",
                "Cup 483",
                "Cup 484",
                "Cup 485",
                "Cup 486",
                "Cup 487",
                "Cup 488",
                "Cup 489",
                "Cup 490",
                "Cup 491",
                "Cup 492",
                "Cup 493",
                "Cup 494",
                "Cup 495",
                "Cup 496",
                "Cup 497",
                "Cup 498",
                "Cup 499",
                "Cup 500",
                "Cup 501",
                "Cup 502",
                "Cup 503",
                "Cup 504",
                "Cup 505",
                "Cup 506",
                "Cup 507",
                "Cup 508",
                "Cup 509",
                "Cup 510",
                "Cup 511",
                "Cup 512",
                "Cup 513",
                "Cup 514",
                "Cup 515",
                "Cup 516",
                "Cup 517",
                "Cup 518",
                "Cup 519",
                "Cup 520",
                "Cup 521",
                "Cup 522",
                "Cup 523",
                "Cup 524",
                "Cup 525",
                "Cup 526",
                "Cup 527",
                "Cup 528",
                "Cup 529",
                "Cup 530",
                "Cup 531",
                "Cup 532",
                "Cup 533",
                "Cup 534",
                "Cup 535",
                "Cup 536",
                "Cup 537",
                "Cup 538",
                "Cup 539",
                "Cup 540",
                "Cup 541",
                "Cup 542",
                "Cup 543",
                "Cup 544",
                "Cup 545",
                "Cup 546",
                "Cup 547",
                "Cup 548",
                "Cup 549",
                "Cup 550",
                "Cup 551",
                "Cup 552",
                "Cup 553",
                "Cup 554",
                "Cup 555",
                "Cup 556",
                "Cup 557",
                "Cup 558",
                "Cup 559",
                "Cup 560",
                "Cup 561",
                "Cup 562",
                "Cup 563",
                "Cup 564",
                "Cup 565",
                "Cup 566",
                "Cup 567",
                "Cup 568",
                "Cup 569",
                "Cup 570",
                "Cup 571",
                "Cup 572",
                "Cup 573",
                "Cup 574",
                "Cup 575",
                "Cup 576",
                "Cup 577",
                "Cup 578",
                "Cup 579",
                "Cup 580",
                "Cup 581",
                "Cup 582",
                "Cup 583",
                "Cup 584",
                "Cup 585",
                "Cup 586",
                "Cup 587",
                "Cup 588",
                "Cup 589",
                "Cup 590",
                "Cup 591",
                "Cup 592",
                "Cup 593",
                "Cup 594",
                "Cup 595",
                "Cup 596",
                "Cup 597",
                "Cup 598",
                "Cup 599",
                "Cup 600",
                "Cup 601",
                "Cup 602",
                "Cup 603",
                "Cup 604",
                "Cup 605",
                "Cup 606",
                "Cup 607",
                "Cup 608",
                "Cup 609",
                "Cup 610",
                "Cup 611",
                "Cup 612",
                "Cup 613",
                "Cup 614",
                "Cup 615",
                "Cup 616",
                "Cup 617",
                "Cup 618",
                "Cup 619",
                "Cup 620",
                "Cup 621",
                "Cup 622",
                "Cup 623",
                "Cup 624",
                "Cup 625",
                "Cup 626",
                "Cup 627",
                "Cup 628",
                "Cup 629",
                "Cup 630",
                "Cup 631",
                "Cup 632",
                "Cup 633",
                "Cup 634",
                "Cup 635",
                "Cup 636",
                "Cup 637",
                "Cup 638",
                "Cup 639",
                "Cup 640",
                "Cup 641",
                "Cup 642",
                "Cup 643",
                "Cup 644",
                "Cup 645",
                "Cup 646",
                "Cup 647",
                "Cup 648",
                "Cup 649",
                "Cup 650",
                "Cup 651",
                "Cup 652",
                "Cup 653",
                "Cup 654",
                "Cup 655",
                "Cup 656",
                "Cup 657",
                "Cup 658",
                "Cup 659",
                "Cup 660",
                "Cup 661",
                "Cup 662",
                "Cup 663",
                "Cup 664",
                "Cup 665",
                "Cup 666",
                "Cup 667",
                "Cup 668",
                "Cup 669",
                "Cup 670",
                "Cup 671",
                "Cup 672",
                "Cup 673",
                "Cup 674",
                "Cup 675",
                "Cup 676",
                "Cup 677",
                "Cup 678",
                "Cup 679",
                "Cup 680",
                "Cup 681",
                "Cup 682",
                "Cup 683",
                "Cup 684",
                "Cup 685",
                "Cup 686",
                "Cup 687",
                "Cup 688",
                "Cup 689",
                "Cup 690",
                "Cup 691",
                "Cup 692",
                "Cup 693",
                "Cup 694",
                "Cup 695",
                "Cup 696",
                "Cup 697",
                "Cup 698",
                "Cup 699",
                "Cup 700",
                "Cup 701",
                "Cup 702",
                "Cup 703",
                "Cup 704",
                "Cup 705",
                "Cup 706",
                "Cup 707",
                "Cup 708",
                "Cup 709",
                "Cup 710",
                "Cup 711",
                "Cup 712",
                "Cup 713",
                "Cup 714",
                "Cup 715",
                "Cup 716",
                "Cup 717",
                "Cup 718",
                "Cup 719",
                "Cup 720",
                "Cup 721",
                "Cup 722",
                "Cup 723",
                "Cup 724",
                "Cup 725",
                "Cup 726",
                "Cup 727",
                "Cup 728",
                "Cup 729",
                "Cup 730",
                "Cup 731",
                "Cup 732",
                "Cup 733",
                "Cup 734",
                "Cup 735",
                "Cup 736",
                "Cup 737",
                "Cup 738",
                "Cup 739",
                "Cup 740",
                "Cup 741",
                "Cup 742",
                "Cup 743",
                "Cup 744",
                "Cup 745",
                "Cup 746",
                "Cup 747",
                "Cup 748",
                "Cup 749",
                "Cup 750",
                "Cup 751",
                "Cup 752",
                "Cup 753",
                "Cup 754",
                "Cup 755",
                "Cup 756",
                "Cup 757",
                "Cup 758",
                "Cup 759",
                "Cup 760",
                "Cup 761",
                "Cup 762",
                "Cup 763",
                "Cup 764",
                "Cup 765",
                "Cup 766",
                "Cup 767",
                "Cup 768",
                "Cup 769",
                "Cup 770",
                "Cup 771",
                "Cup 772",
                "Cup 773",
                "Cup 774",
                "Cup 775",
                "Cup 776",
                "Cup 777",
                "Cup 778",
                "Cup 779",
                "Cup 780",
                "Cup 781",
                "Cup 782",
                "Cup 783",
                "Cup 784",
                "Cup 785",
                "Cup 786",
                "Cup 787",
                "Cup 788",
                "Cup 789",
                "Cup 790",
                "Cup 791",
                "Cup 792",
                "Cup 793",
                "Cup 794",
                "Cup 795",
                "Cup 796",
                "Cup 797",
                "Cup 798",
                "Cup 799",
                "Cup 800",
                "Cup 801",
                "Cup 802",
                "Cup 803",
                "Cup 804",
                "Cup 805",
                "Cup 806",
                "Cup 807",
                "Cup 808",
                "Cup 809",
                "Cup 810",
                "Cup 811",
                "Cup 812",
                "Cup 813",
                "Cup 814",
                "Cup 815",
                "Cup 816",
                "Cup 817",
                "Cup 818",
                "Cup 819",
                "Cup 820",
                "Cup 821",
                "Cup 822",
                "Cup 823",
                "Cup 824",
                "Cup 825",
                "Cup 826",
                "Cup 827",
                "Cup 828",
                "Cup 829",
                "Cup 830",
                "Cup 831",
                "Cup 832",
                "Cup 833",
                "Cup 834",
                "Cup 835",
                "Cup 836",
                "Cup 837",
                "Cup 838",
                "Cup 839",
                "Cup 840",
                "Cup 841",
                "Cup 842",
                "Cup 843",
                "Cup 844",
                "Cup 845",
                "Cup 846",
                "Cup 847",
                "Cup 848",
                "Cup 849",
                "Cup 850",
                "Cup 851",
                "Cup 852",
                "Cup 853",
                "Cup 854",
                "Cup 855",
                "Cup 856",
                "Cup 857",
                "Cup 858",
                "Cup 859",
                "Cup 860",
                "Cup 861",
                "Cup 862",
                "Cup 863",
                "Cup 864",
                "Cup 865",
                "Cup 866",
                "Cup 867",
                "Cup 868",
                "Cup 869",
                "Cup 870",
                "Cup 871",
                "Cup 872",
                "Cup 873",
                "Cup 874",
                "Cup 875",
                "Cup 876",
                "Cup 877",
                "Cup 878",
                "Cup 879",
                "Cup 880",
                "Cup 881",
                "Cup 882",
                "Cup 883",
                "Cup 884",
                "Cup 885",
                "Cup 886",
                "Cup 887",
                "Cup 888",
                "Cup 889",
                "Cup 890",
                "Cup 891",
                "Cup 892",
                "Cup 893",
                "Cup 894",
                "Cup 895",
                "Cup 896",
                "Cup 897",
                "Cup 898",
                "Cup 899",
                "Cup 900",
                "Cup 901",
                "Cup 902",
                "Cup 903",
                "Cup 904",
                "Cup 905",
                "Cup 906",
                "Cup 907",
                "Cup 908",
                "Cup 909",
                "Cup 910",
                "Cup 911",
                "Cup 912",
                "Cup 913",
                "Cup 914",
                "Cup 915",
                "Cup 916",
                "Cup 917",
                "Cup 918",
                "Cup 919",
                "Cup 920",
                "Cup 921",
                "Cup 922",
                "Cup 923",
                "Cup 924",
                "Cup 925",
                "Cup 926",
                "Cup 927",
                "Cup 928",
                "Cup 929",
                "Cup 930",
                "Cup 931",
                "Cup 932",
                "Cup 933",
                "Cup 934",
                "Cup 935",
                "Cup 936",
                "Cup 937",
                "Cup 938",
                "Cup 939",
                "Cup 940",
                "Cup 941",
                "Cup 942",
                "Cup 943",
                "Cup 944",
                "Cup 945",
                "Cup 946",
                "Cup 947",
                "Cup 948",
                "Cup 949",
                "Cup 950",
                "Cup 951",
                "Cup 952",
                "Cup 953",
                "Cup 954",
                "Cup 955",
                "Cup 956",
                "Cup 957",
                "Cup 958",
                "Cup 959",
                "Cup 960",
                "Cup 961",
                "Cup 962",
                "Cup 963",
                "Cup 964",
                "Cup 965",
                "Cup 966",
                "Cup 967",
                "Cup 968",
                "Cup 969",
                "Cup 970",
                "Cup 971",
                "Cup 972",
                "Cup 973",
                "Cup 974",
                "Cup 975",
                "Cup 976",
                "Cup 977",
                "Cup 978",
                "Cup 979",
                "Cup 980",
                "Cup 981",
                "Cup 982",
                "Cup 983",
                "Cup 984",
                "Cup 985",
                "Cup 986",
                "Cup 987",
                "Cup 988",
                "Cup 989",
                "Cup 990",
                "Cup 991",
                "Cup 992",
                "Cup 993",
                "Cup 994",
                "Cup 995",
                "Cup 996",
                "Cup 997",
                "Cup 998",
                "Cup 999"
            };

            public const int maxCupIcons = 1000;
            public Cup(uint idx)
            {
                this.idx = idx;
                slots = new byte[4] { 0x8, 0x8, 0x8, 0x8 };
                string defaultFile = "File";
                string defaultTrack = "Name";
                string defaultAuthor = "Author";
                string defaultVersion = "Version";
                string defaultGhost = "";
                musicSlots = new byte[4] { 0x8, 0x8, 0x8, 0x8 };
                fileNames = new string[4] { defaultFile, defaultFile, defaultFile, defaultFile };
                trackNames = new string[4] { defaultTrack, defaultTrack, defaultTrack, defaultTrack };
                authorNames = new string[4] { defaultAuthor, defaultAuthor, defaultAuthor, defaultAuthor };
                versionNames = new string[4] { defaultVersion, defaultVersion, defaultVersion, defaultVersion };
                expertFileNames = new string[4, 4] {{defaultGhost, defaultGhost, defaultGhost, defaultGhost},
                                                    {defaultGhost, defaultGhost, defaultGhost, defaultGhost},
                                                    {defaultGhost, defaultGhost, defaultGhost, defaultGhost},
                                                    {defaultGhost, defaultGhost, defaultGhost,defaultGhost} };
                if (idx < maxCupIcons)
                {
                    name = defaultNames[idx];
                    iconName = $"{name}.png";
                }
                else
                {
                    name = "";
                    iconName = "";
                }
            }

            public Cup(PulsarGame.Cup raw) : this(0)
            {
                List<Cup> cups = (GetWindow(App.Current.MainWindow) as MainWindow).cups;
                this.idx = (uint)cups.Count;

                for (int i = 0; i < 4; i++)
                {
                    PulsarGame.Track track = raw.tracks[i];
                    if (track.slot >= 0x20) slots[i] = 0x08; //remove battle slots from old config.pul
                    else slots[i] = track.slot;
                    musicSlots[i] = track.musicSlot;
                }

                if (idx < maxCupIcons)
                {
                    name = defaultNames[idx];
                    iconName = $"{name}.png";
                }
                else
                {
                    name = "";
                    iconName = "";
                }
            }
            public Cup(PulsarGame.CupV1 raw) : this(0)
            {
                List<Cup> cups = (GetWindow(App.Current.MainWindow) as MainWindow).cups;
                this.idx = (uint)cups.Count;

                for (int i = 0; i < 4; i++)
                {
                    PulsarGame.Track track = raw.tracks[i];
                    if (track.slot >= 0x20) slots[i] = 0x08; //remove battle slots from old config.pul
                    else slots[i] = track.slot;
                    musicSlots[i] = track.musicSlot;
                }

                if (idx < maxCupIcons)
                {
                    name = defaultNames[idx];
                    iconName = $"{name}.png";
                }
                else
                {
                    name = "";
                    iconName = "";
                }
            }

            public uint idx;
            //Data
            public byte[] slots;
            public byte[] musicSlots;
            public string[] fileNames;
            public string[] trackNames;
            public string[] authorNames;
            public string[] versionNames;
            public string[,] expertFileNames;
            public string iconName = "";
            public string name = "";
        }

        private void OnCupCountChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "" || box.Text == "0")
            {
                box.Text = "1";
                return;
            }
            ushort newCount = ushort.Parse(box.Text);
            if (newCount > 1000)
            {
                MsgWindow.Show("The maximum number of cups is 1000.");
                box.Text = $"{ctsCupCount}";
                return;
            }
            for (ushort ite = (ushort)cups.Count; ite < newCount; ite++)
            {
                cups.Add(new Cup(ite));
            }
            ctsCupCount = newCount;
        }
        private void OnGoToCupPasting(object sender, DataObjectPastingEventArgs e)
        {
            NumbersOnlyPasting(sender, e);
            if (!e.CommandCancelled)
            {
                String text = (String)e.DataObject.GetData(typeof(String));
                TextBox box = sender as TextBox;
                int dest = int.Parse(box.Text + text);
                if (dest > ctsCupCount) e.CancelCommand();
            }
        }

        private void OnGoToCupInput(object sender, TextCompositionEventArgs e)
        {
            NumbersOnlyBox(e.Text, e);
            if (!e.Handled)
            {
                TextBox box = sender as TextBox;
                int dest = int.Parse(box.Text + e.Text);
                if (dest > ctsCupCount) e.Handled = true;
            }
        }
        private void OnGoToCupChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text == "")
            {
                return;
            }
            short dest = short.Parse(box.Text);
            UpdateCurCup((short)(dest - 1 - curCup));
        }

        private void OnCupNameChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.IsKeyboardFocused)
            {
                /*
                if (curCup > 100)
                {
                    MsgWindow.Show("Only the first 100 cups have names and icons.");
                    box.Text = "";
                    return;
                }
                */
                if (box.Text == "" && curCup < Cup.maxCupIcons) box.Text = Cup.defaultNames[curCup];
                cups[curCup].name = box.Text;
            }
        }

        private void OnCupIconChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.IsKeyboardFocused)
            {
                /*
                if (curCup > 100)
                {
                    MsgWindow.Show("Only the first 100 cups have names and icons.");
                    box.Text = "";
                    return;
                }
                */
                if (box.Text == "" && curCup < Cup.maxCupIcons) box.Text = $"{Cup.defaultNames[curCup]}.png";
            }

        }
        private void OnCupIconLostKBFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.Text != cups[curCup].iconName && box.Text != "")
            {
                bool ret = DisplayImage(box.Text);
                if (ret) cups[curCup].iconName = box.Text;
            }
        }
        private void OnFilenameChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            int idx = Grid.GetRow(box);
            cups[curCup].fileNames[idx - firstTrackRow] = box.Text;
        }

        public static bool CheckTrackName(string name)
        {
            char[] invalid = Path.GetInvalidFileNameChars();
            invalid = invalid.Where(x => x != '\\' && x != ':').ToArray();
            return name.IndexOfAny(invalid) < 0;
        }
        private void OnTrackNameInput(object sender, TextCompositionEventArgs e)
        {
            string text = e.Text;
            if (!CheckTrackName(text))
            {
                MsgWindow.Show("Track names cannot contain any of <>\"/|?*");
                e.Handled = true;
            }
        }
        private void OnTrackNameChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            if (box.IsKeyboardFocused)
            {
                int idx = Grid.GetRow(box);
                cups[curCup].trackNames[idx - firstTrackRow] = box.Text;
                SetGhostLabelName(idx - firstTrackRow, box.Text);
            }

        }

        private void OnTrackNamePasting(object sender, DataObjectPastingEventArgs e)
        {
            String text = (String)e.DataObject.GetData(typeof(String));
            if(!CheckTrackName(text))
            {
                e.CancelCommand();     
                Dispatcher.BeginInvoke(new Action(() => MsgWindow.Show("Track names cannot contain any of <>\"/|?*")));        
            }
        }

        private void OnAuthorChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            int idx = Grid.GetRow(box);
            cups[curCup].authorNames[idx - firstTrackRow] = box.Text;
        }

        private void OnVersionChange(object sender, TextChangedEventArgs e)
        {
            TextBox box = sender as TextBox;
            int idx = Grid.GetRow(box);
            cups[curCup].versionNames[idx - firstTrackRow] = box.Text;
        }

        private void OnSlotChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            int idx = Grid.GetRow(box);
            cups[curCup].slots[idx - firstTrackRow] = PulsarGame.MarioKartWii.idxToCourseId[box.SelectedIndex];
        }

        private void OnMusicChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            int idx = Grid.GetRow(box);
            cups[curCup].musicSlots[idx - firstTrackRow] = PulsarGame.MarioKartWii.musicIdxToCourseId[box.SelectedIndex];
        }

        private void OnLeftArrowClick(object sender, RoutedEventArgs e)
        {
            UpdateCurCup(-1);
        }
        private void OnRightArrowClick(object sender, RoutedEventArgs e)
        {
            UpdateCurCup(1);
        }
        public void UpdateCurCup(Int16 direction)
        {
            curCup = (ushort)((curCup + ctsCupCount + direction) % ctsCupCount);
            if (curCup + 1 <= ctsCupCount)
            {
                Cup cup = cups[curCup];

                File1.Text = cup.fileNames[0];
                File2.Text = cup.fileNames[1];
                File3.Text = cup.fileNames[2];
                File4.Text = cup.fileNames[3];
                Name1.Text = cup.trackNames[0];
                Name2.Text = cup.trackNames[1];
                Name3.Text = cup.trackNames[2];
                Name4.Text = cup.trackNames[3];
                Author1.Text = cup.authorNames[0];
                Author2.Text = cup.authorNames[1];
                Author3.Text = cup.authorNames[2];
                Author4.Text = cup.authorNames[3];
                Version1.Text = cup.versionNames[0];
                Version2.Text = cup.versionNames[1];
                Version3.Text = cup.versionNames[2];
                Version4.Text = cup.versionNames[3];

                for (int row = 0; row < 4; row++)
                {
                    SetGhostLabelName(row, cup.trackNames[row]);
                    for (int col = 0; col < 4; col++)
                    {
                        SetExpertName(cup.expertFileNames[row, col], row, col);
                    }
                }

                Slot1.SelectedValue = PulsarGame.MarioKartWii.idxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.idxToCourseId, cup.slots[0])];
                Slot2.SelectedValue = PulsarGame.MarioKartWii.idxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.idxToCourseId, cup.slots[1])];
                Slot3.SelectedValue = PulsarGame.MarioKartWii.idxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.idxToCourseId, cup.slots[2])];
                Slot4.SelectedValue = PulsarGame.MarioKartWii.idxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.idxToCourseId, cup.slots[3])];
                Music1.SelectedValue = PulsarGame.MarioKartWii.musicIdxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.musicIdxToCourseId, cup.musicSlots[0])];
                Music2.SelectedValue = PulsarGame.MarioKartWii.musicIdxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.musicIdxToCourseId, cup.musicSlots[1])];
                Music3.SelectedValue = PulsarGame.MarioKartWii.musicIdxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.musicIdxToCourseId, cup.musicSlots[2])];
                Music4.SelectedValue = PulsarGame.MarioKartWii.musicIdxToAbbrev[Array.IndexOf(PulsarGame.MarioKartWii.musicIdxToCourseId, cup.musicSlots[3])];
                CupIdLabel.Text = $"Cup {curCup + 1}";
                CupName.Text = cup.name;
                CupIcon.Text = cup.iconName;
                DisplayImage(cup.iconName);
            }

        }

        public (string[], string[]) SortTracks() //tuple sorted, unsorted
        {
            string[] indexedArray = new string[ctsCupCount * 4];
            for (int idx = 0; idx < ctsCupCount; idx++)
            {
                Cup cup = cups[idx];
                for (int i = 0; i < 4; i++)
                {
                    indexedArray[cup.idx * 4 + i] = cup.trackNames[i] + cup.versionNames[i];
                }
            }
            string[] sortedArray = new string[ctsCupCount * 4];
            Array.Copy(indexedArray, sortedArray, indexedArray.Length);
            sortedArray = sortedArray.OrderBy(x => Regex.Replace(x, @"\\[mMxzuc]{.*?}", "")).ToArray();
            return (sortedArray, indexedArray);            
        }
        private void OnAlphabetizeClick(object sender, RoutedEventArgs e)
        {
            List<Cup> sortedCups = new List<Cup>(new Cup[cups.Count()]);
            for (ushort i = 0; i < cups.Count(); i++)
            {
                sortedCups[i] = new Cup(i);
                sortedCups[i].name = cups[i].name;
                sortedCups[i].iconName = cups[i].iconName;
            }

           
            (string[], string[]) trackNames = SortTracks();
            int cupIdx = 0;
            int trackIdx = 0;
            foreach (string s in trackNames.Item1)
            {
                int idx = Array.IndexOf(trackNames.Item2, s);
                int oldCupIdx = idx / 4;
                int oldTrackIdx = idx % 4;

                sortedCups[cupIdx].slots[trackIdx] = cups[oldCupIdx].slots[oldTrackIdx];
                sortedCups[cupIdx].musicSlots[trackIdx] = cups[oldCupIdx].musicSlots[oldTrackIdx];
                sortedCups[cupIdx].fileNames[trackIdx] = cups[oldCupIdx].fileNames[oldTrackIdx];
                sortedCups[cupIdx].trackNames[trackIdx] = cups[oldCupIdx].trackNames[oldTrackIdx];
                sortedCups[cupIdx].authorNames[trackIdx] = cups[oldCupIdx].authorNames[oldTrackIdx];
                sortedCups[cupIdx].versionNames[trackIdx] = cups[oldCupIdx].versionNames[oldTrackIdx];
                sortedCups[cupIdx].expertFileNames[trackIdx, 0] = cups[oldCupIdx].expertFileNames[oldTrackIdx, 0];
                sortedCups[cupIdx].expertFileNames[trackIdx, 1] = cups[oldCupIdx].expertFileNames[oldTrackIdx, 1];
                sortedCups[cupIdx].expertFileNames[trackIdx, 2] = cups[oldCupIdx].expertFileNames[oldTrackIdx, 2];
                sortedCups[cupIdx].expertFileNames[trackIdx, 3] = cups[oldCupIdx].expertFileNames[oldTrackIdx, 3];
                trackIdx++;
                if (trackIdx == 4)
                {
                    trackIdx = 0;
                    cupIdx++;
                }
            }
            cups = sortedCups;
            UpdateCurCup(0);
            UpdateMassImport();
            MsgWindow.Show("Tracks have been sorted alphabetically.");
        }
    }
}