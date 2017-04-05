using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Sticky.Hub
{

    partial class HubPage : global::Windows.UI.Xaml.Controls.Page
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Hub NewsHub;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 14.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView ZoomedOutList;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 14.0.0.0")]
        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", " 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;

            global::System.Uri resourceLocator = new global::System.Uri("ms-appx:///ControlPages/HubPage.xaml");
            global::Windows.UI.Xaml.Application.LoadComponent(this, resourceLocator, global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
        }

    }

    /// An empty page that can be used on its own or navigated to within a Frame.

    public sealed partial class HubPage : Page
    {
        public void Hub()
        {
            this.InitializeComponent();
            Loaded += HubPage_Loaded;
        }

        void HubPage_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> sections = new List<string>();

            foreach (HubSection section in NewsHub.Sections)
            {
                if (section.Header != null)
                {
                    sections.Add(section.Header.ToString());
                }
            }

            ZoomedOutList.ItemsSource = sections;

        }
        void Hub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            switch (e.Section.Name)
            {
                case "Teams":
                   Frame.Navigate(typeof(Teams));
                    break;
                case "Projects":
                    Frame.Navigate(typeof(Projects));
                    break;
            }
        }
    }
}
