namespace TestApp2.Shared;

public class MyCpdRecord
{
    public string Column { get; set; }
    public double IaTotal { get; set; }
    public double IaComp { get; set; }
    public double MpfaTotal { get; set; }
    public double MpfaComp { get; set; }
}

public class MyCourseRecord
{
    public DateTime? DateCompleted { get; set; }
    public string CourseCode { get; set; }
    public string Provider { get; set; }
    public string CourseTitle { get; set; }
    public double IaCpd { get; set; }
    public double IaCompulsory { get; set; }
    public double MpfaNonCore { get; set; }
    public double MpfaCore { get; set; }
}
