using MuseumSearch.Common.BaseModels;
using MuseumSearch.Data.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MuseumSearch.ViewModels
{
    public class PaintingsTableViewModel:BaseTableViewModel<Painting>
    {
        [DisplayName("Име")]
        public string Name { get; set; }
        [DisplayName("Автор")]
        public string Author { get; set; }
    }
}
