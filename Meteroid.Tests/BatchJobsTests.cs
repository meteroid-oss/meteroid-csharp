// this file is @generated
#pragma warning disable CS0612, CS0618 // the API may deprecate operations
using System.Threading.Tasks;
using Xunit;

namespace Meteroid.Tests;

public class BatchJobsTests
{
    [Fact]
    public async Task List()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"created_at\":\"2023-12-31T23:59:59.999-05:30\",\"created_by\":\"3fa85f64-5717-4562-b3fc-2c963f66afa6\",\"failed_items\":2147483647,\"id\":\"batch_job_id_67\",\"job_type\":\"SUBSCRIPTION_PLAN_MIGRATION\",\"processed_items\":-123456789,\"status\":\"CHUNKING\"}],\"pagination_meta\":{\"page\":-123456789,\"per_page\":-123456789,\"total_items\":-9007199254740993,\"total_pages\":123456789}}"
        );
        await mock.Client.BatchJobs.ListAsync();
        Assert.Equal(new[] { "GET /api/v1/batch-jobs" }, mock.Requests);
    }

    [Fact]
    public async Task Retrieve()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"created_at\":\"2024-03-15T10:30:45.123+02:00\",\"created_by\":\"00000000-0000-0000-0000-000000000000\",\"failed_items\":-2147483648,\"failure_count\":9007199254740993,\"has_error_csv\":false,\"has_output\":true,\"id\":\"batch_job_id_99\",\"job_type\":\"CUSTOMER_CSV_IMPORT\",\"processed_items\":-2147483648,\"status\":\"PROCESSING\"}"
        );
        await mock.Client.BatchJobs.RetrieveAsync("batch_job_id");
        Assert.Equal(new[] { "GET /api/v1/batch-jobs/batch_job_id" }, mock.Requests);
    }

    [Fact]
    public async Task ListFailures()
    {
        using var mock = new PerseidMock(
            200,
            "application/json",
            "{\"data\":[{\"chunk_id\":\"batch_job_chunk_id_9\",\"id\":\"00000000-0000-0000-0000-000000000000\",\"item_index\":2147483647,\"reason\":\"sample\"}],\"total_count\":9007199254740993}"
        );
        await mock.Client.BatchJobs.ListFailuresAsync("batch_job_id");
        Assert.Equal(new[] { "GET /api/v1/batch-jobs/batch_job_id/failures" }, mock.Requests);
    }
}
