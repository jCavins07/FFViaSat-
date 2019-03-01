using Xamarin.Forms;

namespace Viasat_App
{
    public class ItemModel
    {
        public string ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public int ItemRevision { get; set; }
        public string ItemPartType { get; set; }
        public int[] ItemComponentsIds { get; set; }
        public int[] ItemCommentsIds { get; set; }
    }
}