using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.Builders.Triggers
{
    public class ExerciseOutput
    {
        public List<Question> ExcerciseQuestions { get; set; }
        public List<RankTime> Ranks { get; set; }
    }

}
