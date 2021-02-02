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
                { "A Nightmare on Elm Street", new List<string>() { "tt0087800", "tt0089686", "tt0093629", "tt0095742", "tt0097981", "tt0101917", "tt0111686", "tt0329101", "tt1179056" } },
                { "Ace Ventura", new List<string>() { "tt0109040", "tt0112281", "tt0844029" } },
                { "Alien", new List<string>() { "tt0078748", "tt0090605", "tt0103644", "tt0118583", "tt1446714", "tt2316204" } },
                { "American Pie", new List<string>() { "tt0163651", "tt0252866", "tt0328828", "tt0436058", "tt0808146", "tt0974959", "tt1407050", "tt1605630", "tt11771594" } },
                { "Back to the Future", new List<string>() { "tt0088763", "tt0096874", "tt0099088" } },
                { "Bill & Ted", new List<string>() { "tt0096928", "tt0101452", "tt1086064" } },
                { "Blair Witch", new List<string>() { "tt0185937", "tt0229260", "tt1540011" } },
                { "Bourne", new List<string>() { "tt0258463", "tt0372183", "tt0440963", "tt1194173", "tt4196776" } },
                { "Cars", new List<string>() { "tt0317219", "tt1216475", "tt3606752" } },
                { "Dark Knight", new List<string>() { "tt0372784", "tt0468569", "tt1345836" } },
                { "Despicable Me", new List<string>() { "tt1323594", "tt1690953", "tt2293640", "tt3469046" } },
                { "Die Hard", new List<string>() { "tt0095016", "tt0099423", "tt0112864", "tt0337978", "tt1606378" } },
                { "Dollars", new List<string>() { "tt0058461", "tt0060196", "tt0059578" } },
                { "Exorcist", new List<string>() { "tt0070047", "tt0076009", "tt0099528", "tt0204313", "tt0449086" } },
                { "Fast and the Furious", new List<string>() { "tt0232500", "tt0322259", "tt0463985", "tt1013752", "tt1596343", "tt1905041", "tt2820852", "tt4630562" } },
                { "Final Destination", new List<string>() { "tt0195714", "tt0309593", "tt0414982", "tt1144884", "tt1622979" } },
                { "Friday the 13th", new List<string>() { "tt0080761", "tt0082418", "tt0083972", "tt0087298", "tt0089173", "tt0091080", "tt0095179", "tt0097388", "tt0107254", "tt0211443", "tt0329101", "tt0758746" } },
                { "Godfather", new List<string>() { "tt0068646", "tt0071562", "tt0099674" } },
                { "Halloween", new List<string>() { "tt0077651", "tt0082495", "tt0085636", "tt0095271", "tt0097474", "tt0113253", "tt0120694", "tt0220506", "tt0373883", "tt1311067", "tt1502407" } },
                { "Hangover", new List<string>() { "tt1119646", "tt01411697", "tt1951261" } },
                { "Hannibal Lecter", new List<string>() { "tt0091474", "tt0102926", "tt0212985", "tt0289765", "tt0367959" } },
                { "Harry Potter", new List<string>() { "tt0241527", "tt0295297", "tt0304141", "tt0330373", "tt0373889", "tt0417741", "tt0926084", "tt1201607" } },
                { "Home Alone", new List<string>() { "tt0099785", "tt0104431", "tt0119303", "tt0329200", "tt2308733" } },
                { "Hunger Games", new List<string>() { "tt1392170", "tt1951264", "tt1951265", "tt1951266" } },
                { "I Know What You Did Last Summer", new List<string>() { "tt0119345", "tt0130018", "tt0469111" } },
                { "Ice Age", new List<string>() { "tt0268380", "tt0438097", "tt1080016", "tt1667889", "tt3416828" } },
                { "Indiana Jones", new List<string>() { "tt0082971", "tt0087469", "tt0097576", "tt0367882" } },
                { "James Bond", new List<string>() { "tt0055928", "tt0057076", "tt0058150", "tt0059800", "tt0061452", "tt0062512", "tt0064757", "tt0066995", "tt0070328", "tt0071807", "tt0076752", "tt0079574", "tt0082398", "tt0086034", "tt0086006", "tt0090264", "tt0093428", "tt0097742", "tt0113189", "tt0120347", "tt0143145", "tt0246460", "tt0381061", "tt0830515", "tt1074638", "tt2379713" } },
                { "Jaws", new List<string>() { "tt0073195", "tt0077766", "tt0085750", "tt0093300" } },
                { "John Wick", new List<string>() { "tt2911666", "tt4425200", "tt6146586" } },
                { "Johnny English", new List<string>() { "tt0274166", "tt1634122", "tt6921996" } },
                { "Jurassic Park", new List<string>() { "tt0107290", "tt0119567", "tt0163025", "tt0369610", "tt4881806" } },
                { "Leprechaun", new List<string>() { "tt0107387", "tt0110329", "tt0113636", "tt0116861", "tt0209095", "tt0339294", "tt2345613", "tt8155182" } },
                { "Mad Max", new List<string>() { "tt0079501", "tt0082694", "tt0089530", "tt1392190" } },
                { "Marvel Cinematic Universe", new List<string>() { "tt0371746", "tt0800080", "tt1228705", "tt0800369", "tt0458339", "tt0848228", "tt1300854", "tt1981115", "tt1843866", "tt2015381", "tt2395427", "tt0478970", "tt3498820", "tt1211837", "tt3896198", "tt2250912", "tt3501632", "tt1825683", "tt4154756", "tt5095030", "tt4154664", "tt4154796", "tt6320628" } },
                { "Matrix", new List<string>() { "tt00133093", "tt00234215", "tt0242653" } },
                { "Men in Black", new List<string>() { "tt0119654", "tt00120912", "tt1409024", "tt2283336" } },
                { "Middle Earth", new List<string>() { "tt0120737", "tt0167261", "tt0167260", "tt0903624", "tt1170358", "tt2310332" } },
                { "Mission Impossible", new List<string>() { "tt0117060", "tt0120755", "tt0317919", "tt1229238", "tt2381249", "tt4912910" } },
                { "Naked Gun", new List<string>() { "tt0095705", "tt0102510", "tt0110622" } },
                { "Night of the Living Dead", new List<string>() { "tt0063350", "tt0077402", "tt0088993", "tt0418819", "tt0848557", "tt1134854" } },
                { "Ocean's", new List<string>() { "tt0054135", "tt0240772", "tt0349903", "tt0496806", "tt5164214" } },
                { "Pirates of the Caribbean", new List<string>() { "tt0325980", "tt0383574", "tt0449088", "tt1298650", "tt1790809" } },
                { "Planet of the Apes", new List<string>() { "tt0063442", "tt0065462", "tt0067065", "tt0068408", "tt0069768", "tt0133152", "tt1318514", "tt2103281", "tt3450958" } },
                { "Police Academy", new List<string>() { "tt0087928", "tt0089822", "tt0091777", "tt0093756", "tt0095882", "tt0098105", "tt0110857" } },
                { "Rambo", new List<string>() { "tt0083944", "tt0089880", "tt0095956", "tt0462499", "tt1206885" } },
                { "Resident Evil", new List<string>() { "tt0120804", "tt0318627", "tt0432021", "tt1220634", "tt1855325", "tt2592614" } },
                { "Rocky", new List<string>() { "tt0075148", "tt0079817", "tt0084602", "tt0089927", "tt0100507", "tt0479143", "tt3076658", "tt6343314" } },
                { "Saw", new List<string>() { "tt0387564", "tt0432348", "tt0489270", "tt0890870", "tt1132626", "tt1233227", "tt1477076", "tt3348730" } },
                { "Scary Movie", new List<string>() { "tt0175142", "tt0257106", "tt0306047", "tt0362120", "tt0795461" } },
                { "Scream", new List<string>() { "tt0117571", "tt0120082", "tt0134084", "tt1262416" } },
                { "Shrek", new List<string>() { "tt0126029", "tt0298148", "tt0413267", "tt0892791" } },
                { "Spider-Man", new List<string>() { "tt0145487", "tt0316654", "tt0413300", "tt0948470", "tt1872181", "tt2250912", "tt4633694", "tt6320628" } },
                { "Star Trek", new List<string>() { "tt0079945", "tt0084726", "tt0088170", "tt0092007", "tt0098382", "tt0102975", "tt0111280", "tt0117731", "tt0120844", "tt0253754", "tt0796366", "tt1408101", "tt2660888" } },
                { "Star Wars", new List<string>() { "tt0076759", "tt0080684", "tt0086190", "tt0120915", "tt0121765", "tt0121766", "tt2488496", "tt2527336" } },
                { "Taken", new List<string>() { "tt0936501", "tt1397280", "tt2446042" } },
                { "Terminator", new List<string>() { "tt0088247", "tt0103064", "tt0181852", "tt0438488", "tt1340138" } },
                { "Texas Chainsaw Massacre", new List<string>() { "tt0072271", "tt0092076", "tt0099994", "tt0110978", "tt0324216", "tt0420294", "tt1572315", "tt2620590" } },
                { "Toy Story", new List<string>() { "tt0114709", "tt0120363", "tt0435761", "tt1979376" } },
                { "Transformers", new List<string>() { "tt0418279", "tt1055369", "tt1399103", "tt2109248", "tt3371366", "tt4701182" } },
                { "Twilight", new List<string>() { "tt1099212", "tt1259571", "tt1325004", "tt1324999", "tt1673434" } },
                { "X-Men", new List<string>() { "tt0120903", "tt0290334", "tt0376994", "tt0458525", "tt1270798", "tt1430132", "tt1877832", "tt1431045", "tt3385516", "tt3315342", "tt5463162", "tt6565702" } }
            };
        }
    }
}