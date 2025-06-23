using Microsoft.AspNetCore.Mvc;
using TestApp2.Shared;

namespace TestApp2.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class MyCPDController : ControllerBase
{
    private readonly ILogger<MyCPDController> _logger;

    public MyCPDController(ILogger<MyCPDController> logger)
    {
        _logger = logger;
    }

    [HttpGet("MYcpd")]
    public IEnumerable<MyCpdRecord> GetMyCpdRecords()
    {
        return new List<MyCpdRecord>
        {
            new MyCpdRecord { Column = "Required", IaTotal = 15.0, IaComp = 3.0, MpfaTotal = 15.0, MpfaComp = 4.0 },
            new MyCpdRecord { Column = "Earned", IaTotal = 25.0, IaComp = 1.0, MpfaTotal = 25.0, MpfaComp = 1.0 },
            new MyCpdRecord { Column = "Outstanding", IaTotal = 0.0, IaComp = 2.0, MpfaTotal = 0.0, MpfaComp = 3.0 },
        };
    }

    [HttpGet("MYCourse")]
    public IEnumerable<MyCourseRecord> GetMyCourseRecords()
    {
        return new List<MyCourseRecord>
        {
            new MyCourseRecord
            {
                DateCompleted = new DateTime(2023, 1, 15),
                CourseCode = "C001",
                Provider = "Provider A",
                CourseTitle = "Introduction to Investment Analysis",
                IaCpd = 2.0,
                IaCompulsory = 1.0,
                MpfaNonCore = 0.0,
                MpfaCore = 0.0
            },
            new MyCourseRecord
            {
                DateCompleted = new DateTime(2023, 2, 20),
                CourseCode = "C002",
                Provider = "Provider B",
                CourseTitle = "Advanced Financial Planning",
                IaCpd = 0.0,
                IaCompulsory = 0.0,
                MpfaNonCore = 1.5,
                MpfaCore = 1.0
            },
            new MyCourseRecord
            {
                DateCompleted = new DateTime(2023, 3, 10),
                CourseCode = "C003",
                Provider = "Provider A",
                CourseTitle = "Ethics in Finance",
                IaCpd = 1.0,
                IaCompulsory = 1.0,
                MpfaNonCore = 0.5,
                MpfaCore = 0.5
            }
        };
    }
}
