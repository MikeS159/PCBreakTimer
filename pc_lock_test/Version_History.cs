using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCBreakTimer
{
    static class Version_History
    {
        static Dictionary<string, string> programVersionHistory = new Dictionary<string, string>();
        
        static Version_History()
        {
            programVersionHistory.Add("0.8.2 - 04/02/2016:", "Reduced background CPU usage \n-Minor bug fixes");
            programVersionHistory.Add("0.8.1 - 02/09/2015:", "Fixed bug where multiple pop-up boxes would appear after closing settings page \n-Ensured that debug tools will only appear in debug builds");
            programVersionHistory.Add("0.8.0 - 01/09/2015:", "Added additional user settings to give better control over times and warnings");
            programVersionHistory.Add("0.7.7 - 26/08/2015:", "Bug fix where several message boxes would be created when locking");
            programVersionHistory.Add("0.7.5 - 21/08/2015:", "Various bug fixes - see Bug Tracker");
            programVersionHistory.Add("0.7.4 - 19/08/2015:", "Various bug fixes - see Bug Tracker");
            programVersionHistory.Add("0.7.3 - 03/08/2015:", "Fixed bug where switching user wouldn't trigger timers");
            programVersionHistory.Add("0.7.2 - 31/07/2015:", "Then fixed that bug fix");
            programVersionHistory.Add("0.7.1 - 30/07/2015:", "Fixed bug in last bug fix");
            programVersionHistory.Add("0.7.0 - 30/07/2015:", "Fixed bug where program would record time at desk when it starts while computer locked");
            programVersionHistory.Add("0.6.3 - 01/05/2015:", "Added settings file and entry location in settings window");
            programVersionHistory.Add("0.6.2 - 26/05/2015:", "Rounded percentage value \n-Added settings menu (no user input avalible yet");
            programVersionHistory.Add("0.6.1 - 26/05/2015:", "Added percentage counter \n-Made about section easier to read");
            programVersionHistory.Add("0.5.3 - 22/05/2015:", "Added in program version history");
            programVersionHistory.Add("0.5.2 - 22/05/2015:", "Fixed size issue where system would not return from minimized state \n-Added confirmation dialog when closing program");
            programVersionHistory.Add("0.5.1 - 22/05/2015:", "Added total timer and menu bar for controls");
            programVersionHistory.Add("0.4.1 - 22/05/2015:", "Fixed warning timer, total time goes red when value is > working day");
            programVersionHistory.Add("0.4.0 - 22/05/2015:", "Created system tray icon for access when minamized");
            programVersionHistory.Add("0.3.0 - 22/05/2015:", "Added timer to show when last break was taken and warning to take break");
            programVersionHistory.Add("0.2.0 - 22/05/2015:", "Timers update ever second rather than when PC is locked/unlocked");
            programVersionHistory.Add("0.1.0 - 22/05/2015:", "Created timers for at desk and away");
        }

        public static string returnString()
        {
            string s = "";
            foreach(KeyValuePair<string, string> pair in programVersionHistory)
            {
                s = s + pair.Key + "\n-" + pair.Value + "\n\n";
            }
            return s;
        }

    }
}
