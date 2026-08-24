using Shouldly;

namespace Kairos.Domain.Tests;

public class FocusIntentionTests
{
    [Fact]
    public void Create_with_valid_name_and_duration_succeeds()
    {
        var intention = FocusIntention.Create("Write report", TimeSpan.FromMinutes(30));

        intention.TaskName.ShouldBe("Write report");
        intention.PlannedDuration.ShouldBe(TimeSpan.FromMinutes(30));
    }

    [Fact]
    public void Create_with_blank_task_name_throws()
    {
        Should.Throw<ArgumentException>(() =>
            FocusIntention.Create("   ", TimeSpan.FromMinutes(30)));
    }

    [Fact]
    public void Create_with_zero_duration_throws()
    {
        Should.Throw<ArgumentException>(() =>
            FocusIntention.Create("Write report", TimeSpan.Zero));
    }

    [Fact]
    public void Create_with_negative_duration_throws()
    {
        Should.Throw<ArgumentException>(() =>
            FocusIntention.Create("Write report", TimeSpan.FromMinutes(-5)));
    }

    [Fact]
    public void Create_without_optional_fields_succeeds_with_sensible_defaults()
    {
        var intention = FocusIntention.Create("Write reports", TimeSpan.FromMinutes(30));

        intention.TaskContext.ShouldBeNull();
        intention.ExpectedApplications.ShouldBeEmpty();
    }

    [Fact]
    public void Create_with_expect_applications_retains_them()
    {
        var intention = FocusIntention.Create(
            "Write report",
            TimeSpan.FromMinutes(30),
            expectedApplications: new[] { "WINWORD.EXE", "notepad.exe" });

        intention.ExpectedApplications.ShouldBe(new[] { "WINWORD.EXE", "notepad.exe" });
    }
}
