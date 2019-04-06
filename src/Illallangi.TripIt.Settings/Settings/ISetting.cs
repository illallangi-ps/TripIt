namespace Illallangi.TripIt.Settings
{
    public interface ISetting
    {
        string ConsumerKey { get; set; }
        string ConsumerSecret { get; set; }
        string AuthorizeUrl { get; set; }
        string CallBackUrl { get; set; }
        string BaseUrl { get; set; }
        string AuthorizedKey { get; set; }
        string AuthorizedSecret { get; set; }
    }
}