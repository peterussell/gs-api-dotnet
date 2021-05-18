using System.Collections.Generic;

namespace gs_api.Models
{
  public class Exam
  {
    public string Id;
    public string Name;
    public LicenseType LicenseType;
    public string Slug;
    public int AvailableQuestions;
    public string AspeqName;
    public ExamInfo AspeqExamInfo;
    public ExamInfo CurrentExamInfo;
    public List<ExamQuestion> Questions;
  }
}