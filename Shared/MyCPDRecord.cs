namespace TestApp2.Shared;

public class MyCpdRecord
{
    public string Column { get; set; }
    public double IaTotal { get; set; }
    public double IaComp { get; set; }
    public double MpfaTotal { get; set; }
    public double MpfaComp { get; set; }

    // // Required
    // public double RequiredIaTotal { get; set; }
    // public double RequiredIaComp { get; set; }
    // public double RequiredMpfaTotal { get; set; }
    // public double RequiredMpfaComp { get; set; }

    // // Earned
    // public double EarnedIaTotal { get; set; }
    // public double EarnedIaComp { get; set; }
    // public double EarnedMpfaTotal { get; set; }
    // public double EarnedMpfaComp { get; set; }

    // // Outstanding
    // public double OutstandingIaTotal { get; set; }
    // public double OutstandingIaComp { get; set; }
    // public double OutstandingMpfaTotal { get; set; }
    // public double OutstandingMpfaComp { get; set; }

}

public class MyCourseRecord
{
    public DateTime DateCompleted { get; set; }
    public string CourseCode { get; set; }
    public string Provider { get; set; }
    public string CourseTitle { get; set; }
    public double IaCpd { get; set; }
    public double IaCompulsory { get; set; }
    public double MpfaNonCore { get; set; }
    public double MpfaCore { get; set; }
}
