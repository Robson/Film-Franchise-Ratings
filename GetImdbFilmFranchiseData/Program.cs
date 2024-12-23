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
    using System.Net.Http;
    using System.Reflection.Metadata;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using Newtonsoft.Json;
    using static System.Net.WebRequestMethods;

    internal class Program
    {
        private const string Filename = "data.js";

        private static readonly WebClient Client = new WebClient();       

        internal static void Main()
        {
            System.IO.File.WriteAllText(Filename, "var data = [" + Environment.NewLine, Encoding.Unicode);

            foreach (var franchise in Franchises.GetAllFranchises())
            {
                GetSeriesData(franchise.Key, franchise.Value);
            }

            System.IO.File.AppendAllText(Filename, "];", Encoding.Unicode);
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
                bool success;
                do
                {
                    success = false;
                    try
                    {
                        var bytes = Client.DownloadData("https://www.imdb.com/title/" + id);
                        var html = Encoding.UTF8.GetString(bytes).Replace("\n", string.Empty);
                        var film = GetFilmData(html, id);
                        if (film.Name.Length == 0)
                        {
                            throw new ArgumentException("Could not find the film name.");
                        }
                        series.Films.Add(film);
                        Console.WriteLine('\t' + film.Name.PadRight(60) + film.Year + ' ' + string.Format("{0:0.0}", film.Rating) + ' ' + film.Metascore); // show progress
                        success = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\t!Error with " + id + "! Will retry in 1 minute. [" + ex.Message + "]");
                        Thread.Sleep(60000);
                    }
                } while (!success);
            }

            System.IO.File.AppendAllText(Filename, JsonConvert.SerializeObject(series, Formatting.Indented) + ",\n", Encoding.Unicode);
        }

        private static Series.Film GetFilmData(string html, string id)
        {
            // <title>&quot;The Wonderful World of Disney&quot; Home Alone 4: Taking Back the House (TV Episode 2002) - IMDb</title>
            var nom = Regex.Match(html, "<title>([^<]+)( \\([a-zA-Z ]*\\d{4})\\) - IMDb</title>").Groups[1].Value.Replace("&nbsp;", " ").Replace("&#x27;", "'").Trim();

            var data = new Series.Film()
            {
                Id = id,
                Year = int.Parse(Regex.Match(html, "(\\d{4})\\) - IMDb</title>").Groups[1].Value),
                Name = nom,
                Rating = decimal.Parse(Regex.Match(html, "aggregateRating.*,\"ratingValue\":([\\d\\.]+)\\}").Groups[1].Value),
                Votes = int.Parse(Regex.Match(html, ",\"ratingCount\":(\\d+),").Groups[1].Value.Replace(",", string.Empty)),
                Metascore = Regex.Match(html, "{\"metascore\":{\"score\":([\\d+]+),\"").Groups[1].Value,
                Poster = Regex.Match(html, "<img alt=\"[^\"]+\" class=\"ipc-image\" loading=\"eager\" src=\"([^\"]+)\"").Groups[1].Value,
            };

            var bytesLetterboxd = Client.DownloadData("https://letterboxd.com/imdb/" + id);
            var htmlLetterboxd = Encoding.UTF8.GetString(bytesLetterboxd).Replace("\n", string.Empty);
            if (Regex.Match(htmlLetterboxd, @"""([\d\.]+) out of 5").Success)
            {
                data.Letterboxd = decimal.Parse(Regex.Match(htmlLetterboxd, @"""([\d\.]+) out of 5").Groups[1].Value);
            }

            return data;
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

                public decimal Letterboxd { get; set; }

                public string Poster { get; set; }
            }
        }
    }    
}