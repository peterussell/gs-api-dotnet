using System.Collections.Generic;

namespace gs_api.Models
{
  public class ExamQuestion
  {
    public string Id;
    public string Text;
    public List<ExamAnswer> Answers;
    public string CorrectAnswerId;
    public string SelectedAnswerId;
    public List<string> AssetPaths;
  }
}