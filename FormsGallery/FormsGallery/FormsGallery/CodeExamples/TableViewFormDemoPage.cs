using System;
using Xamarin.Forms;

namespace FormsGallery.CodeExamples
{
    class TableViewFormDemoPage : ContentPage
    {
        public TableViewFormDemoPage()
        {
            Label header = new Label
            {
                Text = "TableView for a form",
                FontSize = 30,
                FontAttributes = FontAttributes.Bold,
                HorizontalOptions = LayoutOptions.Center
            };

            TableView tableView = new TableView
            {
                Intent = TableIntent.Form,
                Root = new TableRoot("TableView Title")
                {
                    new TableSection("Table Section")
                    {
                        new TextCell
                        {
                            Text = "Text Cell",
                            Detail = "With Detail Text",
                        },
                        new ImageCell
                        {
                            // TODO: Fix this

                            // Some differences with loading images in initial release.
                            ImageSource = 
                            
                            // Device.RuntimePlatform == Device.iOS ? 
                            
                       //     ImageSource.FromUri(new Uri("http://xamarin.com/images/index/ide-xamarin-studio.png")) 
                       ImageSource.FromUri(new Uri("https://www.xamarin.com/content/images/pages/branding/assets/xamagon.png"))

                            ,
                            
                          //  :
                            //              Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("ide_xamarin_studio.png") : ImageSource.FromFile("Images/ide-xamarin-studio.png"),
                            Text = "Image Cell",
                            Detail = "With Detail Text",
                        },
                        new SwitchCell
                        {
                            Text = "Switch Cell"
                        },
                        new EntryCell
                        {
                            Label = "Entry Cell",
                            Placeholder = "Type text here"
                        },
                        new ViewCell
                        {
                            View = new Label
                            {
                                Text = "A View Cell can be anything you want!"
                            }
                        }
                    }
                },

                Margin = new Thickness(10, 0)
            };

            // Build the page.
            Title = "TableView Form Demo";
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
