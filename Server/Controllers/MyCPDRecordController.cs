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

    public IEnumerable<MyCourseRecord> GetMyCourseRecords()
    {
        return new List<MyCpdRecord>
        {
            new MyCpdRecord { Column = "Required", IaTotal = 15.0, IaComp = 3.0, MpfaTotal = 15.0, MpfaComp = 4.0 },
            new MyCpdRecord { Column = "Earned", IaTotal = 25.0, IaComp = 1.0, MpfaTotal = 25.0, MpfaComp = 1.0 },
            new MyCpdRecord { Column = "Outstanding", IaTotal = 0.0, IaComp = 2.0, MpfaTotal = 0.0, MpfaComp = 3.0 },
        };
    }
}
