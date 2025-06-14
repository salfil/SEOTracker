namespace InfoTrackSEOTracker.Models
{
    public class SearchResultModel
    {
        public string SearchTerm { get; set; }
        public string TargetUrl { get; set; }
        public List<int> Positions { get; set; } = new List<int>();
    }
}
