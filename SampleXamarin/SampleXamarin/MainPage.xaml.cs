using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public List<string> Governorate { get; set; }
        public MainPage()
        {
            InitializeComponent();
            Governorate = new List<string>
            {
                "أريانة",
                "باجة",
                "بنزرت",
                "قابس",
                "قفصة",
                "جندوبة",
                "القيروان",
                "القصرين",
                "قبلي",
                "الكاف",
                "المهدية",
                "منوبة",
                "مدنين",
                "المنستير",
                "نابل",
                "صفاقس",
                "سيدي بوزيد",
                "سليانة",
                "سوسة",
                "تطاوين",
                "توزر",
                "تونس",
                "زغوان"
            };

            governorate.BindingContext = this;
            governorate.ItemsLayout = new ListItemsLayout(ItemsLayoutOrientation.Vertical); // Vertical is default
        }
    }
}
