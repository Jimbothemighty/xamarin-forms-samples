using System;
using Xamarin.Forms;

namespace FormsGallery.CodeExamples
{
    class TableViewMenuDemoPage : ContentPage
    {
        public TableViewMenuDemoPage()
        {
            Label header = new Label
            {
                Text = "TableView for a menu",
				FontSize = 30,
				FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Views for Presentation")
                    {
                        new TextCell
                        {
                            Text = "Label",
                            Command = new Command(async () => 
                                await Navigation.PushAsync(new LabelDemoPage()))
                        },

                        new TextCell
                        {
                            Text = "Image",
                            Command = new Command(async () => 
                                await Navigation.PushAsync(new ImageDemoPage()))
                        },

                        new TextCell
                        {
                            Text = "BoxView",
                            Command = new Command(async () => 
                                await Navigation.PushAsync(new BoxViewDemoPage()))
                        },

                        new TextCell
                        {
                            Text = "WebView",
                            Command = new Command(async () => 
                                await Navigation.PushAsync(new WebViewDemoPage()))
                        },
                    }
                },

                Margin = new Thickness(10, 0)
            };

            // Build the page.
            Title = "TableView Menu Demo";
            Content = new StackLayout
            {
                Children = 
                {
                    header,
                    tableView
                }
            };
        }
    }
}
