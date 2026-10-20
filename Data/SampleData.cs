namespace QAZAQ.Data;

using QAZAQ.Models;

/// <summary>
/// Static sample repository built from domain model classes featuring Kazakhstan tourism.
/// </summary>
public static class SampleData
{
    public static List<TouristSpot> Spots { get; } = new()
    {
        new TouristSpot
        {
            Id = 1,
            Name = "Kaindy Lake Submerged Forest",
            KazakhName = "Қайыңды көлі",
            Region = Region.AlmatyRegion,
            Category = SpotCategory.NaturalWonder,
            ShortDescription = "Mystical turquoise alpine lake with preserved 100-year-old Schrenk spruce trees rising out of crystal water.",
            FullDescription = "Formed after the catastrophic 1911 Kebin earthquake triggered a massive limestone landslide, Kaindy Lake is situated 2,000 meters above sea level in the Kungey Alatau range. The freezing water preserved the submerged needles and trunks of ancient spruce trees, creating an underwater forest world that enchants hikers and divers alike.",
            ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 95m,
            Rating = 4.9,
            ReviewCount = 384,
            BestSeason = "May to October",
            Highlights = new() { "Submerged spruce tree trunks", "Boat rides on turquoise waters", "Kolsai National Park trekking", "Stargazing in mountain yurts" },
            Difficulty = DifficultyLevel.Moderate,
            DurationDays = 2,
            AltitudeMeters = 2000,
            IsUnescoHeritage = false,
            IsPopular = true
        },
        new TouristSpot
        {
            Id = 2,
            Name = "Charyn Canyon & Valley of Castles",
            KazakhName = "Шарын шатқалы",
            Region = Region.AlmatyRegion,
            Category = SpotCategory.DesertCanyon,
            ShortDescription = "Dramatic 80-kilometer red sandstone gorge carved over 12 million years, often called Central Asia's Grand Canyon.",
            FullDescription = "Carved by the swift glacial Charyn River through millions of years of tectonic shifts and wind erosion, Charyn Canyon features striking sedimentary stone pillars that resemble castles, towers, and mythological creatures. The valley also shelters an ancient grove of rare Sogdian ash trees that survived the Ice Age.",
            ImageUrl = "https://images.unsplash.com/photo-1518457607834-6e8d80c183c5?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 80m,
            Rating = 4.8,
            ReviewCount = 512,
            BestSeason = "April to June, September to November",
            Highlights = new() { "Valley of Castles trail walk", "Sunset photography on the cliff rim", "Relic Sogdian Ash grove", "Charyn riverbank eco-camp" },
            Difficulty = DifficultyLevel.Easy,
            DurationDays = 1,
            AltitudeMeters = 1100,
            IsUnescoHeritage = false,
            IsPopular = true
        },
        new TouristSpot
        {
            Id = 3,
            Name = "Mausoleum of Khoja Ahmed Yasawi",
            KazakhName = "Қожа Ахмет Ясауи кесенесі",
            Region = Region.Turkistan,
            Category = SpotCategory.SilkRoadHeritage,
            ShortDescription = "Majestic 14th-century Timurid architectural masterpiece with towering turquoise domes and sacred Sufi history.",
            FullDescription = "Commissioned in 1389 by the conqueror Timur (Tamerlane) to replace a smaller 12th-century shrine of the famous Turkic Sufi master Khoja Ahmed Yasawi. The monument boasts one of the largest brick domes in Central Asia, Persian glazed ceramics, and the ceremonial bronze cauldron 'Tayqazan'.",
            ImageUrl = "https://images.unsplash.com/photo-1584551246679-0daf3d275d0f?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 110m,
            Rating = 4.9,
            ReviewCount = 420,
            BestSeason = "Year-round (Best: March to May)",
            Highlights = new() { "UNESCO World Heritage marvel", "The 2-tonne bronze Tayqazan cauldron", "Ancient underground Hilvet mosque", "Caravanserai cultural quarter" },
            Difficulty = DifficultyLevel.Easy,
            DurationDays = 2,
            AltitudeMeters = 220,
            IsUnescoHeritage = true,
            IsPopular = true
        },
        new TouristSpot
        {
            Id = 4,
            Name = "Bozzhira Tract & Ustyurt Plateau",
            KazakhName = "Бозжыра шатқалы",
            Region = Region.Mangystau,
            Category = SpotCategory.NaturalWonder,
            ShortDescription = "Otherworldly white chalk peaks and immense salt flats formed at the bottom of the prehistoric Tethys Ocean.",
            FullDescription = "Located in western Kazakhstan's remote Mangystau desert, Bozzhira resembles a Martian landscape with limestone needles rising over 250 meters. Travelers camp under the Milky Way and hunt for petrified prehistoric shark teeth and sea urchin fossils on cliffs that were ocean seabed millions of years ago.",
            ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 160m,
            Rating = 5.0,
            ReviewCount = 186,
            BestSeason = "April to May, September to October",
            Highlights = new() { "The Fangs of Bozzhira chalk towers", "Prehistoric shark teeth discovery", "4x4 desert safari expedition", "Stargazing under zero light pollution" },
            Difficulty = DifficultyLevel.Expedition,
            DurationDays = 3,
            AltitudeMeters = -20,
            IsUnescoHeritage = false,
            IsPopular = true
        },
        new TouristSpot
        {
            Id = 5,
            Name = "Big Almaty Lake & Trans-Ili Alatau",
            KazakhName = "Үлкен Алматы көлі",
            Region = Region.AlmatyRegion,
            Category = SpotCategory.MountainAlpine,
            ShortDescription = "Glacial reservoir cupped between 4,000-meter celestial peaks, reflecting azure blue and milky turquoise shades.",
            FullDescription = "A natural alpine reservoir nestled in the Ili-Alatau National Park just 15 kilometers south of Almaty city center. Surrounded by three towering peaks—Sovetov, Ozyorny, and Turist—the lake changes color throughout the day depending on light and glacial runoff.",
            ImageUrl = "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 75m,
            Rating = 4.7,
            ReviewCount = 630,
            BestSeason = "June to September",
            Highlights = new() { "Tian Shan Observatory visit", "Tien Shan alpine wildflower trails", "Panoramic Sovetov Peak backdrop", "Traditional Almaty apple orchards" },
            Difficulty = DifficultyLevel.Moderate,
            DurationDays = 1,
            AltitudeMeters = 2511,
            IsUnescoHeritage = false,
            IsPopular = true
        },
        new TouristSpot
        {
            Id = 6,
            Name = "Singing Dunes in Altyn-Emel",
            KazakhName = "Айғайқұм",
            Region = Region.AlmatyRegion,
            Category = SpotCategory.DesertCanyon,
            ShortDescription = "Rare 150-meter-tall sand dunes that hum and vibrate like a giant pipe organ when winds blow.",
            FullDescription = "Standing between two ridges of the Dzhungarian Alatau, the Singing Dunes produce an acoustic vibration that resonates like an airplane engine or church organ when dry sand shifts. Legend says Genghis Khan and his warriors are buried under the singing sands.",
            ImageUrl = "https://images.unsplash.com/photo-1509316975850-ff9c5deb0cd9?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 90m,
            Rating = 4.8,
            ReviewCount = 275,
            BestSeason = "May to October",
            Highlights = new() { "Acoustic sand dune climbing", "Rare Asiatic wild ass (Kulan) sighting", "Besshatyr Saka royal burial mounds", "Aktau chalk hills exploration" },
            Difficulty = DifficultyLevel.Moderate,
            DurationDays = 2,
            AltitudeMeters = 600,
            IsUnescoHeritage = false,
            IsPopular = false
        },
        new TouristSpot
        {
            Id = 7,
            Name = "Baiterek Tower & Nur-Alem Pavilion",
            KazakhName = "Бәйтерек монументі",
            Region = Region.AstanaCapital,
            Category = SpotCategory.ModernArchitecture,
            ShortDescription = "Futuristic 105-meter monument symbolizing the Kazakh mythical Tree of Life and the golden egg of the Samruk bird.",
            FullDescription = "Designed by Sir Norman Foster's team, Baiterek is the national emblem of independent Kazakhstan in the heart of Astana. The 97-meter-high observation deck houses the golden handprint of the nation's founders, offering sweeping views of the futuristic steppe capital and the Nur-Alem sphere.",
            ImageUrl = "https://images.unsplash.com/photo-1486406146926-c627a92ad1ab?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 60m,
            Rating = 4.6,
            ReviewCount = 740,
            BestSeason = "Year-round",
            Highlights = new() { "Samruk golden sphere observation deck", "Khan Shatyr transparent tent mall", "Nur-Alem future energy museum", "Ishim river sunset promenade" },
            Difficulty = DifficultyLevel.Easy,
            DurationDays = 1,
            AltitudeMeters = 347,
            IsUnescoHeritage = false,
            IsPopular = false
        },
        new TouristSpot
        {
            Id = 8,
            Name = "Katon-Karagay & Belukha Alpine Valley",
            KazakhName = "Қатонқарағай",
            Region = Region.EastKazakhstan,
            Category = SpotCategory.MountainAlpine,
            ShortDescription = "The pristine Altai mountain frontier with dense cedar taiga, maral deer farms, and Mt. Belukha glaciers.",
            FullDescription = "Katon-Karagay National Park is Kazakhstan's largest national park, where the Siberian taiga meets the Central Asian steppes. Known for its medicinal herbal honey, velvet deer antler wellness springs, and legendary mystical gateway of Shambhala beneath Mount Belukha (4,506 m).",
            ImageUrl = "https://images.unsplash.com/photo-1544735716-392fe2489ffa?auto=format&fit=crop&w=1200&q=80",
            BasePriceUsd = 140m,
            Rating = 4.9,
            ReviewCount = 210,
            BestSeason = "June to September",
            Highlights = new() { "Mount Belukha glacier views", "Wild Altai organic honey tasting", "Thermal radon mineral baths", "Rakhmanov Springs alpine retreat" },
            Difficulty = DifficultyLevel.Challenging,
            DurationDays = 3,
            AltitudeMeters = 1750,
            IsUnescoHeritage = true,
            IsPopular = false
        }
    };

    public static List<CulturalHeritage> CulturalItems { get; } = new()
    {
        new CulturalHeritage
        {
            Id = 1,
            Title = "The Nomad Yurt (Kiiz Üy)",
            KazakhName = "Киіз үй",
            Category = "Architecture & Cosmology",
            Description = "The portable felt home of the steppe nomads, engineered for swift assembly and extreme weather. The crown wheel (Shanyrak) is an ancient celestial emblem featured on Kazakhstan's coat of arms.",
            CulturalSignificance = "Symbol of family continuity, cosmic harmony, and ancestral hearth.",
            ImageUrl = "https://images.unsplash.com/photo-1533240332313-0db49b459ad6?auto=format&fit=crop&w=1200&q=80"
        },
        new CulturalHeritage
        {
            Id = 2,
            Title = "Dastarkhan & Sacred Hospitality",
            KazakhName = "Дастарқан",
            Category = "Culinary & Customs",
            Description = "An ornate low feast table overflowing with freshly baked Baursak breads, Beshbarmak (the national boiled meat and noodle dish), horse meat delicacies (Kazy), and nourishing fermented mare's milk (Kumis).",
            CulturalSignificance = "Steppe code of honor: an arriving guest is treated as a blessing from the skies.",
            ImageUrl = "https://images.unsplash.com/photo-1578632767115-351597cf2477?auto=format&fit=crop&w=1200&q=80"
        },
        new CulturalHeritage
        {
            Id = 3,
            Title = "Berkutchi & Golden Eagle Falconry",
            KazakhName = "Бүркітшілік",
            Category = "Living UNESCO Heritage",
            Description = "A 4,000-year-old equestrian hunting tradition where master hunters bond with magnificent female golden eagles to hunt across the snowy steppe.",
            CulturalSignificance = "Sacred partnership between steppe falconer, horse, and the majestic eagle.",
            ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?auto=format&fit=crop&w=1200&q=80"
        },
        new CulturalHeritage
        {
            Id = 4,
            Title = "The Dombra & Kui Music",
            KazakhName = "Домбыра мен күй",
            Category = "Acoustic Heritage",
            Description = "The two-stringed long-necked lute that expresses the soul of the steppes. Master musicians play 'kui'—rapid rhythmic narratives evoking galloping horses and mountain winds.",
            CulturalSignificance = "Included on the UNESCO Representative List of the Intangible Cultural Heritage.",
            ImageUrl = "https://images.unsplash.com/photo-1518457607834-6e8d80c183c5?auto=format&fit=crop&w=1200&q=80"
        }
    };

    public static List<TouristReview> Reviews { get; } = new()
    {
        new TouristReview
        {
            Id = 1,
            AuthorName = "Elena Rostova",
            Country = "Switzerland",
            DestinationName = "Kaindy Lake Submerged Forest",
            Rating = 5,
            TravelMonth = "September 2025",
            Title = "Surreal underwater forest unlike anything in the Alps",
            Comment = "I have hiked throughout Switzerland and Patagonia, but Kaindy Lake left me speechless. The crystal turquoise clarity with century-old pine needles preserved submerged in the water felt like a mythical fantasy. Our local guide Yerlan arranged an incredible yurt overnight in Saty with steaming hot baursaks.",
            ImageUrl = "https://images.unsplash.com/photo-1506744038136-46273834b3fb?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 42,
            IsVerifiedGuest = true
        },
        new TouristReview
        {
            Id = 2,
            AuthorName = "Marcus Vance",
            Country = "United Kingdom",
            DestinationName = "Charyn Canyon & Valley of Castles",
            Rating = 5,
            TravelMonth = "October 2025",
            Title = "Sunset over the Valley of Castles is unforgettable",
            Comment = "The scale of Charyn Canyon is breathtaking. We walked the 3km Valley of Castles down to the glacial river. Zero crowds compared to Arizona, completely peaceful, and the red rock formations glow like molten gold during sunset. A 10/10 must-see in Kazakhstan.",
            ImageUrl = "https://images.unsplash.com/photo-1518457607834-6e8d80c183c5?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 38,
            IsVerifiedGuest = true
        },
        new TouristReview
        {
            Id = 3,
            AuthorName = "Kenji Takahashi",
            Country = "Japan",
            DestinationName = "Mausoleum of Khoja Ahmed Yasawi",
            Rating = 5,
            TravelMonth = "May 2025",
            Title = "Pure Silk Road magic and architectural genius",
            Comment = "Turkistan was the spiritual highlight of my Central Asia trip. The turquoise ceramic mosaic tiles and the monumental 2-tonne bronze Tayqazan cauldron inside the dome showcase Timurid artistry at its peak. The local people were extraordinarily hospitable.",
            ImageUrl = "https://images.unsplash.com/photo-1584551246679-0daf3d275d0f?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 29,
            IsVerifiedGuest = true
        },
        new TouristReview
        {
            Id = 4,
            AuthorName = "Chloe Martin",
            Country = "France",
            DestinationName = "Bozzhira Tract & Ustyurt Plateau",
            Rating = 5,
            TravelMonth = "May 2025",
            Title = "Camping on the seabed of the ancient Tethys Ocean",
            Comment = "Bozzhira in Mangystau feels like landing on another planet. We spent three days in offroad 4x4s, camped under the brightest Milky Way I have ever witnessed, and found prehistoric shark teeth on white chalk cliffs. It is genuine, untamed wilderness.",
            ImageUrl = "https://images.unsplash.com/photo-1507525428034-b723cf961d3e?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 51,
            IsVerifiedGuest = true
        },
        new TouristReview
        {
            Id = 5,
            AuthorName = "David Miller",
            Country = "Canada",
            DestinationName = "Big Almaty Lake",
            Rating = 4,
            TravelMonth = "July 2025",
            Title = "Incredible celestial alpine reservoir near Almaty",
            Comment = "Only a short scenic drive from the leafy avenues of Almaty. The water color shifts between emerald and baby blue depending on the sunlight. Highly recommend visiting the Tian Shan Observatory nearby for stargazing.",
            ImageUrl = "https://images.unsplash.com/photo-1464822759023-fed622ff2c3b?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 19,
            IsVerifiedGuest = true
        },
        new TouristReview
        {
            Id = 6,
            AuthorName = "Sophie Lindqvist",
            Country = "Sweden",
            DestinationName = "Singing Dunes in Altyn-Emel",
            Rating = 5,
            TravelMonth = "August 2025",
            Title = "The sand actually vibrates and sings like an organ!",
            Comment = "We slid down the 150m dune ridge and the low-frequency acoustic hum was astonishing. We also spotted wild Asiatic Kulan galloping across the steppe. Truly a bucket list encounter in Altyn-Emel.",
            ImageUrl = "https://images.unsplash.com/photo-1509316975850-ff9c5deb0cd9?auto=format&fit=crop&w=600&q=80",
            HelpfulVotes = 34,
            IsVerifiedGuest = true
        }
    };
}
