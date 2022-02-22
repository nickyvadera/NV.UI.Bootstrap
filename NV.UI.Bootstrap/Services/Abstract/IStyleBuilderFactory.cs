namespace NV.UI.Bootstrap.Services.Abstract
{
    public interface IStyleBuilderFactory
    {
        IStyleBuilder Create();

        IRowStyleBuilder CreateForRow();

        IColumnStyleBuilder CreateForColumn();
    }
}
