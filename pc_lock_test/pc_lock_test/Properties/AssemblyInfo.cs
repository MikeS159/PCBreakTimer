using System.Resources;
using System.Reflection;
using System;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("PC_Break_Timer")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Mike Simpson")]
[assembly: AssemblyProduct("PC Break Timer")]
[assembly: AssemblyCopyright("Copyright © Mike Simpson 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-GB")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9603153e-e44a-4198-83c6-82dac3b9b912")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.5.*")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("0.10.5.*")]
//[assembly: AssemblyFileVersion("1.5.*")]
#if DEBUG
[assembly: AssemblyInformationalVersion("0.10.5 DevBuild")]
#elif ALPHA
[assembly: AssemblyInformationalVersion("0.10.5 Alpha")]
#elif BETA
[assembly: AssemblyInformationalVersion("0.10.5 Beta")]
#else
[assembly: AssemblyInformationalVersion("0.10.5")]
#endif