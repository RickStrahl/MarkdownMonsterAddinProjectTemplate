using MarkdownMonster.AddIns;

namespace $safeprojectname$
{
    public class $safeprojectname$Configuration : BaseAddinConfiguration<$safeprojectname$Configuration>
    {
        public $safeprojectname$Configuration()
        {
            // uses this file for storing settings in `%appdata%\Markdown Monster`
            // to persist settings call `$safeprojectname$Configuration.Current.Write()`
            // at any time or when the addin is shut down
            ConfigurationFilename = "$safeprojectname$.json";
        }

        // Add properties for any configuration setting you want to persist and reload
        // you can access this object as 
        //     $safeprojectname$Configuration.Current.PropertyName
    }
}