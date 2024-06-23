using TodoMauiClient.Pages;

namespace TodoMauiClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ManageToDoPage), typeof(ManageToDoPage));
        }
    }
}
