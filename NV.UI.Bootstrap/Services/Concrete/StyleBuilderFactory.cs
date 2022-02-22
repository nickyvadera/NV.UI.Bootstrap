using NV.UI.Bootstrap.Services.Abstract;

namespace NV.UI.Bootstrap.Services.Concrete
{
    public class StyleBuilderFactory : IStyleBuilderFactory
    {
        public IStyleBuilder Create()
        {
            return new StyleBuilder();
        }

        public IColumnStyleBuilder CreateForColumn()
        {
            return new ColumnStyleBuilder();
        }

        public IRowStyleBuilder CreateForRow()
        {
            return new RowStyleBuilder();
        }
    }
}
