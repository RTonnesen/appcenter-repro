# appcenter-repro
Reproduce error where appcenter.start doesn't work for iOS xamarin app.


# steps

- Open solution in Visual Studio 2022
- Edit App.xaml.cs and assign a valid AppCenter key.
- Build the iOS project
- Start debugging the iOS project
- Inspect the Debug output from Visual Studio.



# Output 

Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Mono.Security.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Core.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Numerics.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Net.Http.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Drawing.Common.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Xamarin.iOS.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Xml.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Xamarin.Forms.Platform.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Xamarin.Forms.Core.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.ServiceModel.Internals.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Runtime.Serialization.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Xamarin.Forms.Platform.iOS.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Microsoft.AppCenter.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Microsoft.AppCenter.Analytics.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Microsoft.AppCenter.Crashes.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/Xamarin.Forms.Xaml.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/appcenter_start_repro.dll
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/appcenter_start_repro.iOS.exe
Thread started:  #2
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/netstandard.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Transactions.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Data.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Data.DataSetExtensions.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.IO.Compression.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.IO.Compression.FileSystem.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.ComponentModel.Composition.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Web.Services.dll [External]
Loaded assembly: /private/var/containers/Bundle/Application/A8B615E6-54C3-48F1-B196-8D0C27C2B878/appcenter_start_repro.iOS.app/System.Xml.Linq.dll [External]
Resolved pending breakpoint for 'appcenter_start_repro.iOS.Application.Main(System.String[])' to D:\github\appcenter-repro\src\appcenter_start_repro\appcenter_start_repro.iOS\Main.cs:14 [0x00000].
Loaded assembly: data-0x13bfd8000 [External]
2023-05-01 10:10:28.774 appcenter_start_repro.iOS[2535:2579026] warning: Symbol file LoadedFromMemory is not a mono symbol file

Loaded assembly: data-0x13bfec000 [External]
Loaded assembly: data-0x13d900000 [External]
Loaded assembly: data-0x13d950000 [External]
Loaded assembly: data-0x13d960000 [External]
Resolved pending breakpoint for 'Xamarin.HotReload.HotReloadAgent.BreakpointSendToIde(System.String)' to D:\a\_work\1\s\HotReload\Source\Xamarin.HotReload.Agent\HotReloadAgent.cs:423 [0x00000].
Resolved pending breakpoint for 'Xamarin.HotReload.HotReloadAgent.BreakpointCheckpoint()' to D:\a\_work\1\s\HotReload\Source\Xamarin.HotReload.Agent\HotReloadAgent.cs:418 [0x00000].
2023-05-01 10:10:29.594 appcenter_start_repro.iOS[2535:2579026] 1 ##############

2023-05-01 10:10:29.625 appcenter_start_repro.iOS[2535:2579026] [AppCenter] ERROR: +[MSACDBStorage executeSelectionQuery:inOpenedDatabase:result:withValues:]_block_invoke/409 Query failed with error: 5
	database is locked
2023-05-01 10:10:29.625 appcenter_start_repro.iOS[2535:2579026] [AppCenter] ERROR: +[MSACDBStorage executeQuery:inOpenedDatabase:withValues:usingBlock:]/362 Failed to finalize SQLite statement, result=5
	database is locked

2023-05-01 10:10:29.625 appcenter_start_repro.iOS[2535:2579107] [AppCenter] ERROR: +[MSACDBStorage executeNonSelectionQuery:inOpenedDatabase:withValues:]_block_invoke/338 Could not execute the statement, result=5
	database is locked
2023-05-01 10:10:29.625 appcenter_start_repro.iOS[2535:2579107] [AppCenter] ERROR: +[MSACDBStorage executeQuery:inOpenedDatabase:withValues:usingBlock:]/362 Failed to finalize SQLite statement, result=5
	database is locked
2023-05-01 10:10:29.625 appcenter_start_repro.iOS[2535:2579026] 2 ##############

Thread started:  #3
Thread started:  #4
Thread started:  #5
Thread started:  #6





