using MarkdownMonster.AddIns;

namespace $safeprojectname$
{
    public class $safeprojectname$Configuration : BaseAddinConfiguration<$safeprojectname$Configuration>
    {

        // Configuration data stored in the mmApp.Configuration.CommonFolder (%appdata%\Markdown Monster by default)
        protected override string ConfigurationFilePath { get; set; } = "$safeprojectname$.json";


        // Add properties for any configuration data you want to persist and reload
        // you can access this object as 
        //
        //      $safeprojectname$Configuration.Current.PropertyName

    }
}