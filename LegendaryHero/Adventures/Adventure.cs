namespace LegendaryHero.Adventures
{
    public class Adventure
    {
        public string GUID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CompletionXPReward { get; set; }

        public int CompletionGoldReward { get; set; }

        public int MinLvl { get; set; }
        public int MaxLvl { get; set; }

        public Adventure()
        {

        }

       
    }
}
