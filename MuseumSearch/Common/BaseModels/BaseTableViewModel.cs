using MuseumSearch.Data.Entities;

namespace MuseumSearch.Common.BaseModels
{
    public class BaseTableViewModel<T>
    {
        public int RecordsTotal { get; set; }
        public int RecordsFiltered { get; set; }
        public List<T> Data { get; set; }
    }
}
