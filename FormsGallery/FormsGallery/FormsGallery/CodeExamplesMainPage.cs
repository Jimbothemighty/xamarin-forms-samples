using System;
using Xamarin.Forms;

namespace FormsGallery
{
    public class CodeExamplesMainPage : ContentPage
    {
        public CodeExamplesMainPage()
        {
            // Define command for the items in the TableView.
            Command<Type> navigateCommand = 
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);
                });

            Content = new TableView
            {
                Intent = TableIntent.Menu,
                Root = new TableRoot
                {
                    new TableSection("Views for Presentation")
                    {
                        new TextCell
                        {
                            Text = "Label",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.LabelDemoPage)
                        },

                        new TextCell
                        {
                            Text = "Image",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ImageDemoPage)
                        },

                        new TextCell
                        {
                            Text = "BoxView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.BoxViewDemoPage)
                        },

                        new TextCell
                        {
                            Text = "WebView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.WebViewDemoPage)
                        },

                        new TextCell
                        {
                            Text = "OpenGLView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.OpenGLViewDemoPage)
                        },

                        new TextCell
                        {
                            Text = "Map",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.MapDemoPage)
                        }
                    }, 

                    new TableSection("Views that Initiate Commands")
                    {
                        new TextCell
                        {
                            Text = "Button",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ButtonDemoPage)
                        },

                        new TextCell
                        {
                            Text = "SearchBar",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.SearchBarDemoPage)
                        }
                    },

                    new TableSection("Views for Common Data Types")
                    {
                        new TextCell
                        {
                            Text = "Slider (double)",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.SliderDemoPage)
                        },

                        new TextCell
                        {
                            Text = "Stepper (double)",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.StepperDemoPage)
                        },

                        new TextCell
                        {
                            Text = "Switch (bool)",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.SwitchDemoPage)
                        },

                        new TextCell
                        {
                            Text = "DatePicker",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.DatePickerDemoPage)
                        },

                        new TextCell
                        {
                            Text = "TimePicker",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.TimePickerDemoPage)
                        }
                    },

                    new TableSection("Views for Editing Text")
                    {
                        new TextCell
                        {
                            Text = "Entry (single line)",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.EntryDemoPage)
                        },

                        new TextCell
                        {
                            Text = "Editor (multiple lines)",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.EditorDemoPage)
                        }
                    },

                    new TableSection("Views to Indicate Activity")
                    {
                        new TextCell
                        {
                            Text = "ActivityIndicator",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ActivityIndicatorDemoPage)
                        },

                        new TextCell
                        {
                            Text = "ProgressBar",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ProgressBarDemoPage)
                        }
                    },

                    new TableSection("Views that Display Collections")
                    {
                        new TextCell
                        {
                            Text = "Picker",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.PickerDemoPage)
                        },

                        new TextCell
                        {
                            Text = "ListView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ListViewDemoPage)
                        },

                        new TextCell
                        {
                            Text = "TableView for a menu",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.TableViewMenuDemoPage) 
                        },

                        new TextCell
                        {
                            Text = "TableView for a form",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.TableViewFormDemoPage)
                        }
                    },

                    new TableSection("Cells")
                    {
                        new TextCell
                        {
                            Text = "TextCell",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.TextCellDemoPage)
                        },

                        new TextCell
                        {
                            Text = "ImageCell",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ImageCellDemoPage)
                        },

                        new TextCell
                        {
                            Text = "SwitchCell",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.SwitchCellDemoPage)
                        },

                        new TextCell
                        {
                            Text = "EntryCell",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.EntryCellDemoPage)
                        }
                    },

                    new TableSection("Layouts with Single Content")
                    {
                        new TextCell
                        {
                            Text = "ContentView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ContentViewDemoPage)
                        },
                        new TextCell
                        {
                            Text = "Frame",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.FrameDemoPage)
                        },
                        new TextCell
                        {
                            Text = "ScrollView",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ScrollViewDemoPage)
                        }
                    },

                    new TableSection("Layouts with Multiple Children")
                    {
                        new TextCell
                        {
                            Text = "StackLayout",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.StackLayoutDemoPage)
                        },
                        new TextCell
                        {
                            Text = "AbsoluteLayout",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.AbsoluteLayoutDemoPage)
                        },
                        new TextCell
                        {
                            Text = "Grid",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.GridDemoPage)
                        },
                        new TextCell
                        {
                            Text = "RelativeLayout",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.RelativeLayoutDemoPage)
                        }
                    },

                    new TableSection("Pages")
                    {
                        new TextCell
                        {
                            Text = "ContentPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.ContentPageDemoPage) 
                        },
                        new TextCell
                        {
                            Text = "NavigationPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.NavigationPageDemoPage) 
                        },
                        new TextCell
                        {
                            Text = "MasterDetailPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.MasterDetailPageDemoPage)
                        },
                        new TextCell
                        {
                            Text = "TabbedPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.TabbedPageDemoPage)
                        },
                        new TextCell
                        {
                            Text = "CarouselPage",
                            Command = navigateCommand,
                            CommandParameter = typeof(CodeExamples.CarouselPageDemoPage)
                        }
                    }
                }
            };
        }
    }
}



