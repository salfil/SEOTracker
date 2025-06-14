using InfoTrackSEOTracker.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace SEOChecker.Services
{
    public class GoogleSearchService
    {
        public SearchResultModel PerformSearch(string searchTerm, string targetUrl)
        {
            var model = new SearchResultModel
            {
                SearchTerm = searchTerm,
                TargetUrl = targetUrl
            };

            string googleUrl = $"https://www.google.co.uk/search?num=100&q={Uri.EscapeDataString(searchTerm)}";
            string html = GetHtml(googleUrl);

            // Regex to extract result URLs
            var matches = Regex.Matches(html, @"<a href=""/url\?q=(.*?)&amp;");

            int position = 1;
            foreach (Match match in matches)
            {
                string url = match.Groups[1].Value;
                if (url.Contains(targetUrl, StringComparison.OrdinalIgnoreCase))
                {
                    model.Positions.Add(position);
                }
                position++;
                if (position > 100)
                    break;
            }

            return model;
        }

        private string GetHtml(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.UserAgent = "Mozilla/5.0"; 

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
