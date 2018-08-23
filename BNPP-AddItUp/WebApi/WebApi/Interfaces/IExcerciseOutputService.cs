using WebApi.Builders.Triggers;
using WebApi.ViewModel;

namespace WebApi.Interfaces
{
    public interface IExcerciseOutputService
    {
        ExerciseOutput ProcessMockDataOutput(ExerciseOutput output);
    }
}
