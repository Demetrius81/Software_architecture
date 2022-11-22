using Microsoft.EntityFrameworkCore;
using ReportService.Models;

namespace ReportService.Services.Repository;

public class ReportRepositoryAsync : IRepositoryAsync<Report>
{
    private readonly BaseContext _context;
    private readonly ILogger<ReportRepositoryAsync> _logger;

    public ReportRepositoryAsync(BaseContext context, ILogger<ReportRepositoryAsync> logger)
    {
        this._context = context;
        this._logger = logger;
    }

    public async Task<int> AddAsync(Report item, CancellationToken cancel = default)
    {
        var result = await _context.Reports.AddAsync(item, cancel).ConfigureAwait(false);
        await _context.SaveChangesAsync(cancel);
        return result.Entity.Id;
    }

    public async Task<bool> DeleteAsync(Report item, CancellationToken cancel = default)
    {
        if(await _context.Reports.FirstOrDefaultAsync(i => i.Equals(item), cancel).ConfigureAwait(false) is null)
            return false;
        _context.Reports.Remove(item);
        await _context.SaveChangesAsync(cancel).ConfigureAwait(false);
        return true;
    }

    public async Task<IEnumerable<Report>> GetAllAsync(CancellationToken cancel = default)
    {
        return _context.Reports;
    }

    public async Task<Report?> GetByIdAsync(int id, CancellationToken cancel = default)
    {
        return await _context.Reports.FirstOrDefaultAsync(x => x.Id == id, cancel).ConfigureAwait(false);
    }

    public async Task<int> GetCountAsync(CancellationToken cancel = default)
    {
        return _context.Reports.Count();
    }

    public async Task<bool> UpdateAsync(Report item, CancellationToken cancel = default)
    {
        _context.Reports.Update(item);
        await _context.SaveChangesAsync(cancel).ConfigureAwait(false);
        return true;
    }
}
