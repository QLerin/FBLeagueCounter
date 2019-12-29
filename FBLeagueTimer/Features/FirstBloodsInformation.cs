namespace FBLeagueTimer.Features
{
    public class FirstBloodsInformation
    {
        public FirstBloodsInformation()
        {

        }

        public FirstBloodsInformation(int counts, string logging)
        {
            Counts = counts;
            Logging = logging;
        }

        public int Counts { set; get; }
        public string Logging { set; get; }
    }
}
