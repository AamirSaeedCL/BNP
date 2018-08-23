using System.Collections.Generic;
using WebApi.Model;

namespace WebApi.ViewModel
{
    public class ExerciseViewModel
    {
        public List<Question> ExcerciseQuestions { get; set; }
        public List<RankTime> Ranks { get; set; }

    }
}
