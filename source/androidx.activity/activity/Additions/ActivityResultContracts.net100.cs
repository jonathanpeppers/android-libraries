using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

#if NET9_0_OR_GREATER

namespace AndroidX.Activity.Result.Contract
{
	public sealed partial class ActivityResultContracts
	{
		public sealed partial class OpenDocument
		{
			// public new global::Android.Content.Intent CreateIntent (global::Android.Content.Context context, string[] input)
			// {
			// 	Android.Runtime.JavaList<string> i = null;

			// 	return this.CreateIntent(context, i);
			// }

		}

		public sealed partial class OpenMultileDocuments
		{
			// public new global::Android.Content.Intent CreateIntent (global::Android.Content.Context context, string[] input)
			// {
			// 	Android.Runtime.JavaList<string> i = null;

			// 	return this.CreateIntent(context, i);
			// }

		}

		public sealed partial class RequestMultiplePermissions
		{
			// public new global::Android.Content.Intent CreateIntent (global::Android.Content.Context context, string[] input)
			// {
			// 	Android.Runtime.JavaList<string> i = null;

			// 	return this.CreateIntent(context, i);
			// }
		}
	}
}

#endif