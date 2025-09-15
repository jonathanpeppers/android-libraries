using System.Reflection;
using System.Runtime.CompilerServices;
using Android.App;

[assembly: AssemblyMetadata ("BUILD_COMMIT",      "DEV")]
[assembly: AssemblyMetadata ("BUILD_NUMBER",    "DEBUG")]
[assembly: AssemblyMetadata ("BUILD_TIMESTAMP", "09/15/2025 09:50:59")]

#if !NETCOREAPP
[assembly: Android.LinkerSafe]
#endif

[assembly: AssemblyMetadata ("IsTrimmable", "True")]
