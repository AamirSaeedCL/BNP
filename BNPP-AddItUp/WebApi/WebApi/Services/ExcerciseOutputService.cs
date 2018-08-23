using WebApi.Builders.Mappers;
using WebApi.Builders.Triggers;
using WebApi.Interfaces;

namespace WebApi.Services
{
    public class ExcerciseOutputService : IExcerciseOutputService
    {
        public ExerciseOutput ProcessMockDataOutput(ExerciseOutput output)
        {
            var builder = new ExerciseOutputBuilder(output);

            var viewModel = builder.SetMockQuestionData()
                                   .SetMockRankData()
                                   .Build();

            return viewModel;
        }


    }
}
