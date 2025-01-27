//--------------------------------------------------------------//
// Franchises.cs
//
// Written by Robson
// <https://robson.plus>
//
// See the GitHub repository for licensing information.
// <https://github.com/Robson/Film-Franchise-Ratings>
//--------------------------------------------------------------//

namespace GetImdbFilmFranchiseData
{
    using System.Collections.Generic;

    internal static class Franchises
    {
        internal static Dictionary<string, List<string>> GetAllFranchises()
        {
            return new Dictionary<string, List<string>>()
            {
                { "A Nightmare on Elm Street", new List<string>() { "https://en.wikipedia.org/wiki/A_Nightmare_on_Elm_Street_(franchise)#Films", "tt0087800", "tt0089686", "tt0093629", "tt0095742", "tt0097981", "tt0101917", "tt0111686", "tt0329101", "tt1179056" } },
                { "Ace Ventura", new List<string>() { "https://en.wikipedia.org/wiki/Ace_Ventura_(franchise)#Films", "tt0109040", "tt0112281", "tt0844029" } },
                { "Alien", new List<string>() { "https://en.wikipedia.org/wiki/Alien_(franchise)#Films", "tt0078748", "tt0090605", "tt0103644", "tt0118583", "tt1446714", "tt2316204", "tt18412256" } },
                { "Alvin and the Chipmunks", new List<string>() { "https://en.wikipedia.org/wiki/Alvin_and_the_Chipmunks_in_film#Films", "tt0092752", "tt0207957", "tt0252227", "tt0842012", "tt0952640", "tt1231580", "tt1615918", "tt2974918" } },
                { "American Pie", new List<string>() { "https://en.wikipedia.org/wiki/American_Pie_(film_series)", "tt0163651", "tt0252866", "tt0328828", "tt0436058", "tt0808146", "tt0974959", "tt1407050", "tt1605630", "tt11771594" } },
                { "Austin Powers", new List<string>() { "https://en.wikipedia.org/wiki/Austin_Powers#Films", "tt0118655", "tt0145660", "tt0295178" } },
                { "Back to the Future", new List<string>() { "https://en.wikipedia.org/wiki/Back_to_the_Future_(franchise)#Films", "tt0088763", "tt0096874", "tt0099088" } },
                { "Bill & Ted", new List<string>() { "https://en.wikipedia.org/wiki/Bill_%26_Ted#Films", "tt0096928", "tt0101452", "tt1086064" } },
                { "Blade", new List<string>() { "https://en.wikipedia.org/wiki/Blade_(franchise)#Films", "tt0120611", "tt0187738", "tt0359013" } },
                { "Blair Witch", new List<string>() { "https://en.wikipedia.org/wiki/Blair_Witch#Films", "tt0185937", "tt0229260", "tt1540011" } },
                { "Bourne", new List<string>() { "https://en.wikipedia.org/wiki/Bourne_(franchise)#Films", "tt0258463", "tt0372183", "tt0440963", "tt1194173", "tt4196776" } },
                { "Bridget Jones", new List<string>() { "https://en.wikipedia.org/wiki/Bridget_Jones_(film_series)#Films", "tt0243155", "tt0317198", "tt1473832" } },
                { "Carry On", new List<string>() { "https://en.wikipedia.org/wiki/Carry_On_series_on_screen_and_stage#Filmography", "tt0051453", "tt0051452", "tt0052676", "tt0053699", "tt0054727", "tt0055831", "tt0056912", "tt0057919", "tt0057920", "tt0057918", "tt0059014", "tt0060214", "tt0060330", "tt0061680", "tt0061450", "tt0062782", "tt0064133", "tt0064132", "tt0065525", "tt0065524", "tt0066894", "tt0066895", "tt0068339", "tt0069847", "tt0069848", "tt0071281", "tt0072764", "tt0074286", "tt0076814", "tt0077300", "tt0103927" } },
                { "Cars", new List<string>() { "https://en.wikipedia.org/wiki/Cars_(franchise)#Cars_film_series", "tt0317219", "tt1216475", "tt3606752" } },
                { "Conjuring", new List<string>() { "https://en.wikipedia.org/wiki/The_Conjuring_Universe#Films", "tt1457767", "tt3322940", "tt3065204", "tt5140878", "tt5814060", "tt8350360", "tt7069210", "tt10160976" } },
                { "Dark Knight", new List<string>() { "https://en.wikipedia.org/wiki/Batman_in_film#The_Dark_Knight_trilogy_(2005%E2%80%932012)", "tt0372784", "tt0468569", "tt1345836" } },
                { "Despicable Me", new List<string>() { "https://en.wikipedia.org/wiki/Despicable_Me#Main_series", "tt1323594", "tt1690953", "tt2293640", "tt3469046", "tt5113044", "tt7510222" } },
                { "Die Hard", new List<string>() { "https://en.wikipedia.org/wiki/Die_Hard_(film_series)#Films", "tt0095016", "tt0099423", "tt0112864", "tt0337978", "tt1606378" } },
                { "Dollars", new List<string>() { "https://en.wikipedia.org/wiki/Dollars_Trilogy#Films", "tt0058461", "tt0060196", "tt0059578" } },
                { "Exorcist", new List<string>() { "https://en.wikipedia.org/wiki/The_Exorcist_(franchise)#Films", "tt0070047", "tt0076009", "tt0099528", "tt0204313", "tt0449086", "tt12921446" } },
                { "Fast & Furious", new List<string>() { "https://en.wikipedia.org/wiki/Fast_%26_Furious#Films", "tt0232500", "tt0322259", "tt0463985", "tt1013752", "tt1596343", "tt1905041", "tt2820852", "tt4630562", "tt5433138", "tt5433140" } },
                { "Fantastic Beasts", new List<string>() { "https://en.wikipedia.org/wiki/Fantastic_Beasts_(film_series)#Films", "tt3183660", "tt4123430", "tt4123432" } },
                { "Final Destination", new List<string>() { "https://en.wikipedia.org/wiki/Final_Destination#Films", "tt0195714", "tt0309593", "tt0414982", "tt1144884", "tt1622979" } },
                { "Friday the 13th", new List<string>() { "https://en.wikipedia.org/wiki/Friday_the_13th_(franchise)#Films", "tt0080761", "tt0082418", "tt0083972", "tt0087298", "tt0089173", "tt0091080", "tt0095179", "tt0097388", "tt0107254", "tt0211443", "tt0329101", "tt0758746" } },
                { "Godfather", new List<string>() { "https://en.wikipedia.org/wiki/The_Godfather_(film_series)#Film_series", "tt0068646", "tt0071562", "tt0099674" } },
                { "Halloween", new List<string>() { "https://en.wikipedia.org/wiki/Halloween_(franchise)#Films", "tt0077651", "tt0082495", "tt0085636", "tt0095271", "tt0097474", "tt0113253", "tt0120694", "tt0220506", "tt0373883", "tt1311067", "tt1502407", "tt10665338", "tt10665342" } },
                { "Hangover", new List<string>() { "https://en.wikipedia.org/wiki/The_Hangover_(film_series)#Films", "tt1119646", "tt1411697", "tt1951261" } },
                { "Hannibal Lecter", new List<string>() { "https://en.wikipedia.org/wiki/Hannibal_Lecter_(franchise)#Films", "tt0091474", "tt0102926", "tt0212985", "tt0289765", "tt0367959" } },
                { "Harry Potter", new List<string>() { "https://en.wikipedia.org/wiki/Harry_Potter_(film_series)#Films", "tt0241527", "tt0295297", "tt0304141", "tt0330373", "tt0373889", "tt0417741", "tt0926084", "tt1201607" } },
                { "Home Alone", new List<string>() { "https://en.wikipedia.org/wiki/Home_Alone_(franchise)#Films", "tt0099785", "tt0104431", "tt0119303", "tt0329200", "tt2308733", "tt11012066" } },
                { "How to Train Your Dragon", new List<string>() { "https://en.wikipedia.org/wiki/How_to_Train_Your_Dragon#Films", "tt0892769", "tt1646971", "tt2386490" } },
                { "Hunger Games", new List<string>() { "https://en.wikipedia.org/wiki/The_Hunger_Games_(film_series)#Films", "tt1392170", "tt1951264", "tt1951265", "tt1951266", "tt10545296" } },
                { "I Know What You Did Last Summer", new List<string>() { "https://en.wikipedia.org/wiki/I_Know_What_You_Did_Last_Summer_(franchise)#Films", "tt0119345", "tt0130018", "tt0469111" } },
                { "Ice Age", new List<string>() { "https://en.wikipedia.org/wiki/Ice_Age_(franchise)#Films", "tt0268380", "tt0438097", "tt1080016", "tt1667889", "tt3416828", "tt13634480" } },
                { "Indiana Jones", new List<string>() { "https://en.wikipedia.org/wiki/Indiana_Jones#Films", "tt0082971", "tt0087469", "tt0097576", "tt0367882", "tt1462764" } },
                { "Invisible Man", new List<string>() { "https://en.wikipedia.org/wiki/The_Invisible_Man_(film_series)#Films", "tt0024184", "tt0032635", "tt0032637", "tt0034902", "tt0036959", "tt0043255" } },
                { "Jackass", new List<string>() { "https://en.wikipedia.org/wiki/Jackass_(franchise)#Films", "tt0322802", "tt0493430", "tt1116184", "tt11466222" } },
                { "James Bond", new List<string>() { "https://en.wikipedia.org/wiki/List_of_James_Bond_films", "tt0055928", "tt0057076", "tt0058150", "tt0059800", "tt0061452", "tt0062512", "tt0064757", "tt0066995", "tt0070328", "tt0071807", "tt0076752", "tt0079574", "tt0082398", "tt0086034", "tt0086006", "tt0090264", "tt0093428", "tt0097742", "tt0113189", "tt0120347", "tt0143145", "tt0246460", "tt0381061", "tt0830515", "tt1074638", "tt2379713", "tt2382320" } },
                { "Jaws", new List<string>() { "https://en.wikipedia.org/wiki/Jaws_(franchise)#Films", "tt0073195", "tt0077766", "tt0085750", "tt0093300" } },
                { "John Wick", new List<string>() { "https://en.wikipedia.org/wiki/John_Wick#Films", "tt2911666", "tt4425200", "tt6146586", "tt10366206" } },
                { "Johnny English", new List<string>() { "https://en.wikipedia.org/wiki/Johnny_English_(franchise)#Films", "tt0274166", "tt1634122", "tt6921996" } },
                { "Jumanji", new List<string>() { "https://en.wikipedia.org/wiki/Jumanji_(franchise)#Films", "tt0113497", "tt0406375", "tt2283362", "tt7975244" } },
                { "Jurassic Park", new List<string>() { "https://en.wikipedia.org/wiki/Jurassic_Park#Films", "tt0107290", "tt0119567", "tt0163025", "tt0369610", "tt4881806" } },
                { "King Kong", new List<string>() { "https://en.wikipedia.org/wiki/King_Kong_(franchise)#Filmography", "tt0024216", "tt0024593", "tt0056142", "tt0061868", "tt0074751", "tt0091344", "tt0158780", "tt0360717", "tt3731562", "tt5034838", "tt14539740" } },
                { "Kung Fu Panda", new List<string>() { "https://en.wikipedia.org/wiki/Kung_Fu_Panda#Films", "tt0441773", "tt1302011", "tt2267968", "tt21692408" } },
                { "LEGO", new List<string>() { "https://en.wikipedia.org/wiki/The_Lego_Movie_(franchise)#Films", "tt1490017", "tt4116284", "tt3014284", "tt3513498" } },
                { "Leprechaun", new List<string>() { "https://en.wikipedia.org/wiki/Leprechaun_(film_series)#Films", "tt0107387", "tt0110329", "tt0113636", "tt0116861", "tt0209095", "tt0339294", "tt2345613", "tt8155182" } },
                { "Mad Max", new List<string>() { "https://en.wikipedia.org/wiki/Mad_Max#Films", "tt0079501", "tt0082694", "tt0089530", "tt1392190", "tt12037194" } },
                { "Madagascar", new List<string>() { "https://en.wikipedia.org/wiki/Madagascar_(franchise)#Films", "tt0351283", "tt0479952", "tt1277953" } },
                { "Marvel Cinematic Universe", new List<string>() { "https://en.wikipedia.org/wiki/List_of_Marvel_Cinematic_Universe_films#Films", "tt0371746", "tt0800080", "tt1228705", "tt0800369", "tt0458339", "tt0848228", "tt1300854", "tt1981115", "tt1843866", "tt2015381", "tt2395427", "tt0478970", "tt3498820", "tt1211837", "tt3896198", "tt2250912", "tt3501632", "tt1825683", "tt4154756", "tt5095030", "tt4154664", "tt4154796", "tt6320628", "tt3480822", "tt9376612", "tt9032400", "tt10872600", "tt9419884", "tt10648342", "tt9114286", "tt10954600", "tt6791350", "tt10676048", "tt6263850" } },
                { "Matrix", new List<string>() { "https://en.wikipedia.org/wiki/The_Matrix_(franchise)#Films", "tt0133093", "tt0234215", "tt0242653", "tt10838180" } },
                { "Meet the Parents", new List<string>() { "https://en.wikipedia.org/wiki/Meet_the_Parents_(film_series)#Films", "tt0212338", "tt0290002", "tt0970866" } },
                { "Men in Black", new List<string>() { "https://en.wikipedia.org/wiki/Men_in_Black_(film_series)#Films", "tt0119654", "tt0120912", "tt1409024", "tt2283336" } },
                { "Middle Earth", new List<string>() { "https://en.wikipedia.org/wiki/Middle-earth_in_film#Warner_Bros.", "tt0120737", "tt0167261", "tt0167260", "tt0903624", "tt1170358", "tt2310332" } },
                { "Mission Impossible", new List<string>() { "https://en.wikipedia.org/wiki/Mission:_Impossible_(film_series)#Films", "tt0117060", "tt0120755", "tt0317919", "tt1229238", "tt2381249", "tt4912910", "tt9603212" } },
                { "Mummy", new List<string>() { "https://en.wikipedia.org/wiki/The_Mummy_(franchise)#Feature_films", "tt0023245", "tt0032818", "tt0035096", "tt0037099", "tt0037098", "tt0047795", "tt0053085", "tt0057986", "tt0062006", "tt0068290", "tt0120616", "tt0209163", "tt0859163", "tt2345759" } },
                { "Naked Gun", new List<string>() { "https://en.wikipedia.org/wiki/The_Naked_Gun_(franchise)#Film", "tt0095705", "tt0102510", "tt0110622" } },
                { "Night at the Museum", new List<string>() { "https://en.wikipedia.org/wiki/Night_at_the_Museum_(franchise)#Films", "tt0477347", "tt1078912", "tt2692250", "tt13623880" } },
                { "Night of the Living Dead", new List<string>() { "https://en.wikipedia.org/wiki/Night_of_the_Living_Dead_(film_series)#Films", "tt0063350", "tt0077402", "tt0088993", "tt0418819", "tt0848557", "tt1134854" } },
                { "Ocean's", new List<string>() { "https://en.wikipedia.org/wiki/Ocean's_(film_series)", "tt0054135", "tt0240772", "tt0349903", "tt0496806", "tt5164214" } },
                { "Pirates of the Caribbean", new List<string>() { "https://en.wikipedia.org/wiki/Pirates_of_the_Caribbean_(film_series)#Films", "tt0325980", "tt0383574", "tt0449088", "tt1298650", "tt1790809" } },
                { "Planet of the Apes", new List<string>() { "https://en.wikipedia.org/wiki/Planet_of_the_Apes#Original_film_series", "tt0063442", "tt0065462", "tt0067065", "tt0068408", "tt0069768", "tt0133152", "tt1318514", "tt2103281", "tt3450958", "tt11389872" } },
                { "Police Academy", new List<string>() { "https://en.wikipedia.org/wiki/Police_Academy_(franchise)#Films", "tt0087928", "tt0089822", "tt0091777", "tt0093756", "tt0095882", "tt0098105", "tt0110857" } },
                { "Rambo", new List<string>() { "https://en.wikipedia.org/wiki/Rambo_(franchise)#Films", "tt0083944", "tt0089880", "tt0095956", "tt0462499", "tt1206885" } },
                { "Resident Evil", new List<string>() { "https://en.wikipedia.org/wiki/Resident_Evil_(film_series)#Films", "tt0120804", "tt0318627", "tt0432021", "tt1220634", "tt1855325", "tt2592614", "tt6920084" } },
                { "Rocky", new List<string>() { "https://en.wikipedia.org/wiki/Rocky_(franchise)#Films", "tt0075148", "tt0079817", "tt0084602", "tt0089927", "tt0100507", "tt0479143", "tt3076658", "tt6343314", "tt11145118" } },
                { "Saw", new List<string>() { "https://en.wikipedia.org/wiki/Saw_(franchise)#Films", "tt0387564", "tt0432348", "tt0489270", "tt0890870", "tt1132626", "tt1233227", "tt1477076", "tt3348730", "tt10342730", "tt21807222" } },
                { "Scary Movie", new List<string>() { "https://en.wikipedia.org/wiki/Scary_Movie_(film_series)#Films", "tt0175142", "tt0257106", "tt0306047", "tt0362120", "tt0795461" } },
                { "Scorpion King", new List<string>() { "https://en.wikipedia.org/wiki/The_Scorpion_King_(film_series)#Films", "tt0277296", "tt1104123", "tt1781896", "tt3086386", "tt7338690" } },
                { "Scream", new List<string>() { "https://en.wikipedia.org/wiki/Scream_(franchise)#Films", "tt0117571", "tt0120082", "tt0134084", "tt1262416", "tt11245972", "tt17663992" } },
                { "Shrek", new List<string>() { "https://en.wikipedia.org/wiki/Shrek_(franchise)#Films", "tt0126029", "tt0298148", "tt0413267", "tt0892791" } },
                { "Spider-Man", new List<string>() { "https://en.wikipedia.org/wiki/Spider-Man_in_film", "tt0145487", "tt0316654", "tt0413300", "tt0948470", "tt1872181", "tt2250912", "tt4633694", "tt6320628", "tt10872600", "tt9362722" } },
                { "Star Trek", new List<string>() { "https://en.wikipedia.org/wiki/List_of_Star_Trek_films", "tt0079945", "tt0084726", "tt0088170", "tt0092007", "tt0098382", "tt0102975", "tt0111280", "tt0117731", "tt0120844", "tt0253754", "tt0796366", "tt1408101", "tt2660888", "tt9603060" } },
                { "Star Wars", new List<string>() { "https://en.wikipedia.org/wiki/List_of_Star_Wars_films", "tt0076759", "tt0080684", "tt0086190", "tt0120915", "tt0121765", "tt0121766", "tt2488496", "tt2527336", "tt2527338" } },
                { "Taken", new List<string>() { "https://en.wikipedia.org/wiki/Taken_(franchise)#Films", "tt0936501", "tt1397280", "tt2446042" } },
                { "Teenage Mutant Ninja Turtles", new List<string>() { "https://en.wikipedia.org/wiki/Teenage_Mutant_Ninja_Turtles_in_film", "tt0100758", "tt0103060", "tt0108308", "tt0453556", "tt1291150", "tt3949660", "tt8589698" } },
                { "Terminator", new List<string>() { "https://en.wikipedia.org/wiki/Terminator_(franchise)#Films", "tt0088247", "tt0103064", "tt0181852", "tt0438488", "tt1340138", "tt6450804" } },
                { "Texas Chainsaw Massacre", new List<string>() { "https://en.wikipedia.org/wiki/The_Texas_Chainsaw_Massacre_(franchise)#Films", "tt0072271", "tt0092076", "tt0099994", "tt0110978", "tt0324216", "tt0420294", "tt1572315", "tt2620590", "tt11755740" } },
                { "Three Colours", new List<string>() { "https://en.wikipedia.org/wiki/Three_Colours_trilogy", "tt0108394", "tt0111507", "tt0111495" } },
                { "Toy Story", new List<string>() { "https://en.wikipedia.org/wiki/Toy_Story_(franchise)#Main_films", "tt0114709", "tt0120363", "tt0435761", "tt1979376" } },
                { "Transformers", new List<string>() { "https://en.wikipedia.org/wiki/Transformers_(film_series)#Films", "tt0418279", "tt1055369", "tt1399103", "tt2109248", "tt3371366", "tt4701182", "tt5090568" } },
                { "Tremors", new List<string>() { "https://en.wikipedia.org/wiki/Tremors_(franchise)#Films", "tt0100814", "tt0114720", "tt0259685", "tt0334541", "tt4180514", "tt6086082", "tt8322060" } },
                { "Twilight", new List<string>() { "https://en.wikipedia.org/wiki/The_Twilight_Saga_(film_series)#Films", "tt1099212", "tt1259571", "tt1325004", "tt1324999", "tt1673434" } },
                { "X-Men", new List<string>() { "https://en.wikipedia.org/wiki/X-Men_(film_series)#Films", "tt0120903", "tt0290334", "tt0376994", "tt0458525", "tt1270798", "tt1430132", "tt1877832", "tt1431045", "tt3385516", "tt3315342", "tt5463162", "tt6565702", "tt4682266" } }
            };
        }
    }
}
