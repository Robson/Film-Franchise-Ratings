//--------------------------------------------------------------//
// Program.cs
//
// Written by Robson
// <https://robson.plus>
//
// See the GitHub repository for licensing information.
// <https://github.com/Robson/Film-Franchise-Ratings>
//--------------------------------------------------------------//

namespace GetImdbFilmFranchiseData
{
    using System;
    using System.Collections.Generic;    
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    internal class Program
    {
        private const string Filename = "data.js";

        private static readonly WebClient Client = new WebClient();       

        internal static void Main()
        {
            File.WriteAllText(Filename, "var data = [" + Environment.NewLine, Encoding.Unicode);

            foreach (var franchise in Franchises.GetAllFranchises())
            {
                GetSeriesData(franchise.Key, franchise.Value);
            }

            File.AppendAllText(Filename, "];", Encoding.Unicode);
        }

        private static void GetSeriesData(string name, List<string> ids)
        {
            Console.WriteLine(name); // show progress
            var series = new Series
            {
                Name = name,
                Wikipedia = ids.First(),
                Films = new List<Series.Film>()
            };

            foreach (var id in ids.Skip(1))
            {
                var bytes = Client.DownloadData("https://www.imdb.com/title/" + id);
                var html = Encoding.UTF8.GetString(bytes).Replace("\n", string.Empty);
                var film = GetFilmData(html, id);
                series.Films.Add(film);                
                Console.WriteLine('\t' + film.Name); // show progress
            }

            File.AppendAllText(Filename, JsonConvert.SerializeObject(series, Formatting.Indented) + ",\n", Encoding.Unicode);
        }

        private static Series.Film GetFilmData(string html, string id)
        {
            return new Series.Film()
            {
                Id = id,
                Year = int.Parse(Regex.Match(html, "(\\d{4})\\) - IMDb</title>").Groups[1].Value),
                Name = Regex.Match(html, "<h1[^>]*>([^<]+)").Groups[1].Value.Replace("&nbsp;", " ").Trim(),
                Rating = decimal.Parse(Regex.Match(html, "aggregateRating.*,\"ratingValue\":([\\d\\.]+)\\}").Groups[1].Value),
                Votes = int.Parse(Regex.Match(html, ",\"ratingCount\":(\\d+),").Groups[1].Value.Replace(",", string.Empty)),
                Metascore = Regex.Match(html, "{\"metascore\":{\"score\":([\\d+]+),\"").Groups[1].Value,
                Poster = Regex.Match(html, "<img alt=\"[^\"]+\" class=\"ipc-image\" loading=\"eager\" src=\"([^\"]+)\"").Groups[1].Value,
            };
        }

        private class Series
        {
            public string Name { get; set; }

            public string Wikipedia { get; set; }

            public List<Film> Films { get; set; }

            internal class Film
            {
                public int Year { get; set; }

                public string Id { get; set; }

                public string Name { get; set; }

                public decimal Rating { get; set; }

                public int Votes { get; set; }

                public string Metascore { get; set; }

                public string Poster { get; set; }
            }
        }
    }    
}