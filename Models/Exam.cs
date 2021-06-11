using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace gs_api.Models
{
  public class Exam
  {
    public string Id;
    public string Name;
    [JsonConverter(typeof(StringEnumConverter))]
    public LicenseType LicenseType;
    public string Slug;
    public int AvailableQuestions;
    public string AspeqName;
    public ExamInfo AspeqExamInfo;
    public ExamInfo CurrentExamInfo;
    public List<ExamQuestion> Questions;
  }
}