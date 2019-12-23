using System;
using System.Windows;
using FontAwesome.WPF;
using MarkdownMonster;
using MarkdownMonster.AddIns;

namespace $safeprojectname$
{
    public class $safeprojectname$ : MarkdownMonster.AddIns.MarkdownMonsterAddin
    {


        /// <summary>
        /// Fired when the Addin is initially loaded. This is very early in
        /// the lifecycle and should only be used to create the addin name
        /// and UI options.
        /// </summary>
        /// <remarks>
        /// You do not have access to the Model or UI from this overload.
        /// </remarks>  
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();

            
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
        }

        /// <summary>
        /// Fired after the model has been loaded. If you need model access during loading
        /// this is the place to hook up your code.
        /// </summary>
        /// <param name="model">The Markdown Monster Application model</param>
        public override void OnModelLoaded(AppModel model) 
        { }


        /// <summary>
        /// Fired after the Markdown Monster UI becomes available
        /// for manipulation.
        ///
        /// If you add UI elements as part of your Addin, this is the
        /// place where you can hook them up.
        /// </summary>
        public override void OnWindowLoaded() 
        { }


        /// <summary>
        /// Fired when you click the addin button in the toolbar.
        /// </summary>
        /// <param name="sender"></param>
        public override void OnExecute(object sender)
        {
            MessageBox.Show("Hello from your $safeprojectname$ Addin", "$safeprojectname$ Addin",
                MessageBoxButton.OK, MessageBoxImage.Information);


            // *** Some things you can do:

            // // modify selected editor text
            //var text = GetSelection();
            //text = "<small>" + text + "</small>";
            //SetSelection(text);
            //RefreshPreview();

            // // open a new tab with a file
            //OpenTab(Path.Combine(mmApp.Configuration.CommonFolder, "$safeprojectname$.json"));

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
        public override void OnExecuteConfiguration(object sender)
        {
            MessageBox.Show("Configuration for our sample Addin",
                            "Markdown Addin Sample",
                            MessageBoxButton.OK, MessageBoxImage.Information);
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
