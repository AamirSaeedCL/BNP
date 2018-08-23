using System.Collections.Generic;
using WebApi.Builders.Triggers;
using WebApi.Model;

namespace WebApi.Builders.Mappers
{
    public class ExerciseOutputBuilder : IExerciseOutputBuilder
    {
        private readonly ExerciseOutput _output;
        public ExerciseOutputBuilder(ExerciseOutput output)
        {
            _output = output;
        }

        public ExerciseOutput Build()
        {
            return _output;
        }
        public ExerciseOutputBuilder SetMockQuestionData()
        {
            _output.ExcerciseQuestions = new List<Question>
             {
               new Question()
                 {
                     ExcerciseQuestion = "1+2",
                     Answer ="3",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                new Question()
                 {
                     ExcerciseQuestion = "2+3",
                     Answer ="5",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "4+3",
                     Answer ="7",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "3+3",
                     Answer ="6",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "4+2",
                     Answer ="6",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "6+3",
                     Answer ="9",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "1+3",
                     Answer ="4",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "1+4",
                     Answer ="5",
                     isLocked=false,
                     Ranking = EnumRank.Beginner
                 },
                   new Question()
                 {
                     ExcerciseQuestion = "10+15",
                     Answer ="25",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                   new Question()
                 {
                     ExcerciseQuestion = "11+16",
                     Answer ="27",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                   new Question()
                 {
                     ExcerciseQuestion = "12+15",
                     Answer ="27",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                   new Question()
                 {
                     ExcerciseQuestion = "13+18",
                     Answer ="31",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                   new Question()
                 {
                     ExcerciseQuestion = "15+15",
                     Answer ="30",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "16+15",
                     Answer ="31",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "16+16",
                     Answer ="32",
                     isLocked=false,
                     Ranking = EnumRank.Talented
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "100+100",
                     Answer ="200",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "200+200",
                     Answer ="400",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "200+300",
                     Answer ="500",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                  new Question()
                 {
                     ExcerciseQuestion = "250+250",
                     Answer ="500",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "350+450",
                     Answer ="800",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "150+100",
                     Answer ="250",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "350+100",
                     Answer ="450",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 },
                 new Question()
                 {
                     ExcerciseQuestion = "100+120",
                     Answer ="220",
                     isLocked=false,
                     Ranking = EnumRank.Intermediate
                 }
        };

            return this;
        }



        public ExerciseOutputBuilder SetMockRankData()
        {
            _output.Ranks = new List<RankTime>
             {
               new RankTime()
               {
                   Ranking = EnumRank.Beginner,
                   TimeInSecond = 60
               },
               new RankTime()
               {
                   Ranking = EnumRank.Talented,
                   TimeInSecond = 59
               },
               new RankTime()
               {
                   Ranking = EnumRank.Intermediate,
                   TimeInSecond = 58
               },
               new RankTime()
               {
                   Ranking = EnumRank.Advanced,
                   TimeInSecond = 57
               },
               new RankTime()
               {
                   Ranking = EnumRank.Expert,
                   TimeInSecond = 56
               }
            };
            return this;
        }
    }
}