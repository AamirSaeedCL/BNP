namespace WebApi.Model
{
    public class Question
    {
        public string ExcerciseQuestion { get; set; }
        public string Answer { get; set; }
        public bool isLocked { get; set; }
        public EnumRank Ranking { get; set; }

    }
}
