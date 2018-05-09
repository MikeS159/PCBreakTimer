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
            programVersionHistory.Add("0.10.9 - 20/12/2017:", "Fixed issue #1 & #2 on GitHub.");
            programVersionHistory.Add("0.10.8 - 20/12/2017:", "Fixed bug preventing version history from opening (duplicate version number)");
            programVersionHistory.Add("0.10.7 - 27/11/2017:", "Reverted scaling fix from last build, was caused by Windows display scaling");
            programVersionHistory.Add("0.10.6 - 27/11/2017:", "Fixed scaling issue on new laptop");
            programVersionHistory.Add("0.10.5 - 07/06/2017:", "Implemted proper fix to keep awake using the Win32 interaction timer and code from mouse jiggler");
            programVersionHistory.Add("0.10.4 - 09/05/2017:", "Forgot to remove test code which added 4 days to date calculation program");
            programVersionHistory.Add("0.10.3 - 08/05/2017:", "Changed method of preventing computer from sleeping to the orignal verion in 0.10.0 \n-Couldn't not reproduce ");
            programVersionHistory.Add("0.10.2 - 14/02/2017:", "Change method of keeping screen unlocked to a 1 pixel mouse nudge in the y direction (back and forth) as old method was not working");
            programVersionHistory.Add("0.10.1 - 08/02/2017:", "Now allows screen off when the PC is locked and will resume keeping unlocked (if the user option is enabled) when unlocked again \n-Bug fix where text was incorrectly displayed on some message box windows and take a break message had the wrong tray icon");
            programVersionHistory.Add("0.10.0 - 07/02/2017:", "Added user option to stop the computer locking or the screen going to sleep");
            programVersionHistory.Add("0.9.3 - 20/01/2017:", "Fixed formatting issue with time left until home where each number would be negative, causing rounding problems for hours. One minus sign is now used \n-Changed icon to reduce .exe size");
            programVersionHistory.Add("0.9.2 - 23/12/2016:", "Flexible Message Box implemented so all items in version history can be read \n-Added licence info and attributes into program menu");
            programVersionHistory.Add("0.9.1 - 22/12/2016:", "Added new icon to be more distinctive");
            programVersionHistory.Add("0.9.0 - 21/12/2016:", "Working patterns can now be entered to allow different lengths of day and lunch to be accounted for \n-Fixed bug where the start time wasn't being displayed until form loaded \n-Fixed window size bug, program now resizes to account for debug tools in debug mode");
            programVersionHistory.Add("0.8.0 - 28/10/2016:", "Time to go home now displayed on the form \n-Application now auto updates from H drive");
            programVersionHistory.Add("0.7.9 - 26/10/2016:", "Fixed bug where hours would sometime be rounded up, giving incorrect time");
            programVersionHistory.Add("0.7.8 - 24/10/2016:", "Added time left until home counter \n- Fixed bug where incorrect start time was shown");
            programVersionHistory.Add("0.7.7 - 14/04/2016:", "Dates and time now display correctly based on location");
            programVersionHistory.Add("0.7.6 - 01/04/2016:", "Retroactivly edited version history for consistency \n-Fixed bug where user settings wouldn't be updated properly after upgrade \n-Fixed bug where times over 24 hours would only display upto 24 hours");
            programVersionHistory.Add("0.7.5 - 28/03/2016:", "Fixed bug where timers would not always update when the program is mazimised");
            programVersionHistory.Add("0.7.4 - 22/03/2016:", "Fixed start time issue when program startes minamized \n-Fixed issue with program starting with incorrect size");
            programVersionHistory.Add("0.7.3 - 04/03/2016:", "Program settings now persist between version upgrades \n-Program starts minimized properly when setting is selected");
            programVersionHistory.Add("0.7.2 - 04/02/2016:", "Reduced background CPU usage \n-Minor bug fixes");
            programVersionHistory.Add("0.7.1 - 02/09/2015:", "Fixed bug where multiple pop-up boxes would appear after closing settings page \n-Ensured that debug tools will only appear in debug builds");
            programVersionHistory.Add("0.7.0 - 01/09/2015:", "Added additional user settings to give better control over times and warnings");
            programVersionHistory.Add("0.6.9 - 26/08/2015:", "Bug fix where several message boxes would be created when locking");
            programVersionHistory.Add("0.6.8 - 21/08/2015:", "Various bug fixes");
            programVersionHistory.Add("0.6.7 - 19/08/2015:", "Various bug fixes");
            programVersionHistory.Add("0.6.6 - 03/08/2015:", "Fixed bug where switching user wouldn't trigger timers");
            programVersionHistory.Add("0.6.5 - 31/07/2015:", "Then fixed that bug fix");
            programVersionHistory.Add("0.6.4 - 30/07/2015:", "Fixed bug in last bug fix");
            programVersionHistory.Add("0.6.3 - 30/07/2015:", "Fixed bug where program would record time at desk when it starts while computer locked");
            programVersionHistory.Add("0.6.2 - 01/05/2015:", "Added settings file and entry location in settings window");
            programVersionHistory.Add("0.6.1 - 26/05/2015:", "Rounded percentage value \n-Added settings menu (no user input avalible yet");
            programVersionHistory.Add("0.6.0 - 26/05/2015:", "Added percentage counter \n-Made about section easier to read");
            programVersionHistory.Add("0.5.2 - 22/05/2015:", "Added in program version history");
            programVersionHistory.Add("0.5.1 - 22/05/2015:", "Fixed size issue where system would not return from minimized state \n-Added confirmation dialog when closing program");
            programVersionHistory.Add("0.5.0 - 22/05/2015:", "Added total timer and menu bar for controls");
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
