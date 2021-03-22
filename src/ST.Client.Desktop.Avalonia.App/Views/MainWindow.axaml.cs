using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Platform;
using System.ComponentModel;

namespace System.Application.UI.Views
{
    public class MainWindow : FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainWindow(IWindowImpl impl) : base(impl)
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif 
        }

        protected override void OnClosing(CancelEventArgs e)
        {
#if !UI_DEMO
            e.Cancel = true;
            Hide();
#endif
            base.OnClosed(e);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}