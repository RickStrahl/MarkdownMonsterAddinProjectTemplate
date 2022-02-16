using System;
using System.Windows;
using FontAwesome.WPF;
using MarkdownMonster;
using MarkdownMonster.AddIns;
using System.Threading.Tasks;

namespace $safeprojectname$
{

    /// <summary>
    /// @@@ $safeprojectname$ @@@
    ///
    /// More info on Addin Development:
    /// https://markdownmonster.west-wind.com/docs/_4ne0s0qoi.htm
    /// </summary>
    public class $safeprojectname$ : MarkdownMonster.AddIns.MarkdownMonsterAddin
    {

        /// <summary>
        /// Fired when the application has Initialized, the Window is available and the model
        /// has been loaded. This happens after OnApplicationStart() but before OnWindowLoaded()
        /// and allows you to access the Model and Window before initial data binding of the Window
        /// occurs. 
        ///
        /// Most basic configuration options should be performed in this method.
        ///
        /// If you are accessing UI, don't run that code here but in `OnWindowLoaded()`
        /// as there's no guarantee that all UI elements have initialized at this stage.
        /// </summary>
        /// <param name="model">Instance of the Markdown Monster Application Model</param>
        public override Task OnApplicationInitialized(AppModel model)
        {
            
            // Id - should match output folder name. REMOVE 'Addin' from the Id
            Id = "$safeprojectname$";

            // a descriptive name - shows up on labels and tooltips for components
            // REMOVE 'Addin' from the Name
            Name = "$safeprojectname$";


            // by passing in the add in you automatically
            // hook up OnExecute/OnExecuteConfiguration/OnCanExecute
            var menuItem = new AddInMenuItem(this)
            {
                Caption = Name,

                // if an icon is specified it shows on the toolbar
                // if not the add-in only shows in the add-ins menu
                FontawesomeIcon = FontAwesomeIcon.Bullhorn
            };

            // if you don't want to display config or main menu item clear handler
            //menuItem.ExecuteConfiguration = null;

            // Must add the menu to the collection to display menu and toolbar items            
            MenuItems.Add(menuItem);

            return Task.CompletedTask;
        }

        /// <summary>
        /// Fired after the Markdown Monster UI becomes available
        /// for manipulation.
        ///
        /// If you add UI elements as part of your Addin, this is the
        /// place where you can hook them up.
        /// </summary>
        public override Task OnWindowLoaded()
        {
            return Task.CompletedTask;
        }


        /// <summary>
        /// Fired when you click the addin button in the toolbar.
        /// </summary>
        /// <param name="sender"></param>
        public override Task OnExecute(object sender)
        {
            MessageBox.Show("Hello from your $safeprojectname$ Addin", "$safeprojectname$ Addin",
                MessageBoxButton.OK, MessageBoxImage.Information);

            return Task.CompletedTask;

            // *** Some things you can do:

            // // modify selected editor text
            //var text = GetSelection();
            //text = "<small>" + text + "</small>";
            //SetSelection(text);
            //RefreshPreview();

            // // open a new tab with a file
            //await OpenTab(Path.Combine(mmApp.Configuration.CommonFolder, "$safeprojectname$.json"));

            // // run a process
            //var imageFile = GetSelection();  // assume image file is selected
            //if (!imageFile.Contains(":\\"))
            //    imageFile = Path.Combine(Path.GetDirectoryName(ActiveDocument.Filename), imageFile);
            //Process.Start("paint.exe", imageFile);
        }


        /// <summary>
        /// Fired when you click on the configuration button in the addin
        /// </summary>
        /// <param name="sender">The Execute toolbar button for this addin</param>
        public override Task OnExecuteConfiguration(object sender)
        {
            MessageBox.Show("Configuration for our sample Addin",
                            "Markdown Addin Sample",
                            MessageBoxButton.OK, MessageBoxImage.Information);

            return Task.CompletedTask;
        }


        /// <summary>
        /// Determines on whether the addin can be executed
        /// </summary>
        /// <param name="sender">The Execute toolbar button for this addin</param>
        /// <returns></returns>
        public override bool OnCanExecute(object sender)
        {
            return true;
        }

    }
}
