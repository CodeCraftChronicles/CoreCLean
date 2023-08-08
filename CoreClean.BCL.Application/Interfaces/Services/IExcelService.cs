using CoreClean.BCL.Shared.Interfaces;

using System.Data;

namespace CoreClean.BCL.Application.Interfaces.Services;

public interface IExcelService
{
    Task<string> ExportAsync<TData>(IEnumerable<TData> data
        , Dictionary<string, Func<TData, object>> mappers
        , string sheetName = "Sheet1");

    Task<IResult<IEnumerable<TEntity>>> ImportAsync<TEntity>(Stream data
        , Dictionary<string, Func<DataRow, TEntity, object>> mappers
        , string sheetName = "Sheet1");
}