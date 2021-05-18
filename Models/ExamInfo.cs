using System.Collections.Generic;

namespace gs_api.Models
{
  public class ExamInfo
  {
    public int DurationMinutes;
    public int NumberOfQuestions;
    public List<AllowedMaterial> AllowedMaterials;
  }
}