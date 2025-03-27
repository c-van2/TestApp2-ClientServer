using Microsoft.AspNetCore.Mvc;
using TestApp2.Shared;

namespace TestApp2.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TeamCPDController : ControllerBase
{
    private readonly ILogger<TeamCPDController> _logger;

    public TeamCPDController(ILogger<TeamCPDController> logger)
    {
        _logger = logger;
    }

    [HttpGet("IAcpd")]
    public IEnumerable<IaCpdRecord> GetIaCpdRecords()
    {
        return new List<IaCpdRecord>
        {
            new IaCpdRecord { Name = "John Doe", FullName = "Johnathan Doe", TotalHours = 20, Compulsory = 5 },
            new IaCpdRecord { Name = "Jane Smith", FullName = "Jane Alexandra Smith", TotalHours = 25, Compulsory = 8 }
        };
    }

    [HttpGet("MPFAcpd")]
    public IEnumerable<MpfaCpdRecord> GetMpfaCpdRecords()
    {
        return new List<MpfaCpdRecord>
        {
            new MpfaCpdRecord { Name = "Alice Brown", FullName = "Alice B. Brown", TotalHours = 15, Core = 7.5 },
            new MpfaCpdRecord { Name = "Bob Green", FullName = "Robert Green", TotalHours = 18, Core = 9 }
        };
    }
}
