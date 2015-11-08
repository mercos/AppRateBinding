using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tjeannin.Apprate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']"
	[global::Android.Runtime.Register ("com/tjeannin/apprate/PrefsContract", DoNotGenerateAcw=true)]
	public partial class PrefsContract : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='PREF_APP_HAS_CRASHED']"
		[Register ("PREF_APP_HAS_CRASHED")]
		public const string PrefAppHasCrashed = (string) "pref_app_has_crashed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='PREF_DATE_FIRST_LAUNCH']"
		[Register ("PREF_DATE_FIRST_LAUNCH")]
		public const string PrefDateFirstLaunch = (string) "date_firstlaunch";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='PREF_DONT_SHOW_AGAIN']"
		[Register ("PREF_DONT_SHOW_AGAIN")]
		public const string PrefDontShowAgain = (string) "dont_show_again";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='PREF_DONT_SHOW_IF_CRASHED']"
		[Register ("PREF_DONT_SHOW_IF_CRASHED")]
		public const string PrefDontShowIfCrashed = (string) "pref_dont_show_if_crashed";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='PREF_LAUNCH_COUNT']"
		[Register ("PREF_LAUNCH_COUNT")]
		public const string PrefLaunchCount = (string) "launch_count";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/field[@name='SHARED_PREFS_NAME']"
		[Register ("SHARED_PREFS_NAME")]
		public const string SharedPrefsName = (string) "apprate_prefs";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tjeannin/apprate/PrefsContract", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PrefsContract); }
		}

		protected PrefsContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='PrefsContract']/constructor[@name='PrefsContract' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public PrefsContract () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PrefsContract)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

	}
}
