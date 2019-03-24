using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace TestMakerFree.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class AnswerViewModel
    {
        #region Properties 

        public int Id { get; set; }
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public string Notes { get; set; }

        [DefaultValue(0)] public int Type { get; set; }
        [DefaultValue(0)] public int Flags { get; set; }
        [DefaultValue(0)] public int Value { get; set; }
        [JsonIgnore] public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        #endregion

        #region Constructor 

        public AnswerViewModel()
        {
        }

        #endregion
    }
}