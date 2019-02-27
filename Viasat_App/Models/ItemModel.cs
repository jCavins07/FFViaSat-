using Xamarin.Forms;

namespace Viasat_App
{
    public class ItemModel
    {
        public string ItemTitle { get; set; }
        public string ItemSerial { get; set; }
        public string ItemDescription { get; set; }
        public int[] ItemComponentsIds { get; set; }
        public int[] ItemCommentsIds { get; set; }
    }
}