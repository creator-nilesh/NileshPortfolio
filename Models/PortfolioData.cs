namespace NileshPortfolio.Models;

// All portfolio content lives in this one file.
// To change text on the website, edit the values below - no need to touch the views.

public class Role
{
    public string Title { get; set; } = "";
    public string Period { get; set; } = "";
}

public class Project
{
    public string Name { get; set; } = "";
    public string Summary { get; set; } = "";
    public List<string> Highlights { get; set; } = new();
    public List<string> Technologies { get; set; } = new();
}

public static class PortfolioData
{
    public const string Name = "Nilesh Agrahari";
    public const string Headline = "Software Engineer | Pocket HRMS";
    public const string Location = "Mumbai, Maharashtra, India";
    public const string Email = "creator.nilesh@gmail.com";
    public const string LinkedIn = "https://www.linkedin.com/in/nilesh-agrahari-73b187234/";

    public const string AboutText =
        "Full Stack Developer with 3+ years of hands-on experience at Pocket HRMS, " +
        "specialising in .NET MVC. I build and maintain web applications and care about " +
        "clean code, problem solving and learning new things every day.";

    public static readonly List<string> WhyHireMe = new()
    {
        "3+ years of production experience in HR-tech with ASP.NET MVC",
        "Excellence in Execution Award - Pocket HRMS Annual Conference 2026",
        "Code Quality Champion - twice (2023 and Q3 2024-25)",
        "Built automated background jobs that save HR teams hours of manual work",
        "Quick learner who is comfortable integrating third-party libraries"
    };

    public static readonly List<string> Skills = new()
    {
        "C#", "ASP.NET MVC", "HTML", "CSS", "Bootstrap", "Hangfire", "Syncfusion", "GoRules"
    };

    public static readonly List<Role> Roles = new()
    {
        new Role { Title = "Software Engineer", Period = "Apr 2025 - Present" },
        new Role { Title = "Junior Software Developer", Period = "Dec 2022 - Apr 2025" }
    };

    public const string Company = "Pocket HRMS";
    public const string CompanyLocation = "Navi Mumbai, Maharashtra, India";

    public static readonly List<string> Awards = new()
    {
        "Excellence in Execution Award - Annual Conference 2026",
        "Code Quality Champion - Q3 2024-25 Rewards & Recognition",
        "Code Quality Champion - 2023"
    };

    public static readonly List<Project> Projects = new()
    {
        new Project
        {
            Name = "Pocket HRMS",
            Summary = "An HR-tech platform used by companies of all sizes, from a handful of " +
                      "employees to lakhs. I work on the Attendance and Leave modules.",
            Highlights = new List<string>
            {
                "Added many enhancements to the Attendance and Leave modules",
                "Integrated libraries such as GoRules (rule engine) and Syncfusion (UI components)",
                "Created automated Hangfire jobs: sending reports, time processing and leave credit",
                "Built reminder jobs that nudge managers to approve or reject leave and regularisation requests"
            },
            Technologies = new List<string>
            {
                "ASP.NET MVC", "C#", "Hangfire", "Syncfusion", "GoRules"
            }
        }
    };
}
