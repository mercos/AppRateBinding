using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tjeannin.Apprate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']"
	[global::Android.Runtime.Register ("com/tjeannin/apprate/AppRate", DoNotGenerateAcw=true)]
	public partial class AppRate : global::Java.Lang.Object, global::Android.Content.IDialogInterfaceOnCancelListener, global::Android.Content.IDialogInterfaceOnClickListener {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tjeannin/apprate/AppRate", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppRate); }
		}

		protected AppRate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_app_Activity_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/constructor[@name='AppRate' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register (".ctor", "(Landroid/app/Activity;)V", "")]
		public AppRate (global::Android.App.Activity p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (AppRate)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/app/Activity;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/app/Activity;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
				id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_app_Activity_, new JValue (p0));
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_init);
		}

		static Delegate cb_onCancel_Landroid_content_DialogInterface_;
#pragma warning disable 0169
		static Delegate GetOnCancel_Landroid_content_DialogInterface_Handler ()
		{
			if (cb_onCancel_Landroid_content_DialogInterface_ == null)
				cb_onCancel_Landroid_content_DialogInterface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCancel_Landroid_content_DialogInterface_);
			return cb_onCancel_Landroid_content_DialogInterface_;
		}

		static void n_OnCancel_Landroid_content_DialogInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterface p0 = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCancel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCancel_Landroid_content_DialogInterface_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='onCancel' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface']]"
		[Register ("onCancel", "(Landroid/content/DialogInterface;)V", "GetOnCancel_Landroid_content_DialogInterface_Handler")]
		public virtual void OnCancel (global::Android.Content.IDialogInterface p0)
		{
			if (id_onCancel_Landroid_content_DialogInterface_ == IntPtr.Zero)
				id_onCancel_Landroid_content_DialogInterface_ = JNIEnv.GetMethodID (class_ref, "onCancel", "(Landroid/content/DialogInterface;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onCancel_Landroid_content_DialogInterface_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onCancel_Landroid_content_DialogInterface_, new JValue (p0));
		}

		static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_I == null)
				cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnClick_Landroid_content_DialogInterface_I);
			return cb_onClick_Landroid_content_DialogInterface_I;
		}

		static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterface p0 = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onClick_Landroid_content_DialogInterface_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
		public virtual void OnClick (global::Android.Content.IDialogInterface p0, int p1)
		{
			if (id_onClick_Landroid_content_DialogInterface_I == IntPtr.Zero)
				id_onClick_Landroid_content_DialogInterface_I = JNIEnv.GetMethodID (class_ref, "onClick", "(Landroid/content/DialogInterface;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onClick_Landroid_content_DialogInterface_I, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_onClick_Landroid_content_DialogInterface_I, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_reset_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='reset' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("reset", "(Landroid/content/Context;)V", "")]
		public static void Reset (global::Android.Content.Context p0)
		{
			if (id_reset_Landroid_content_Context_ == IntPtr.Zero)
				id_reset_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "reset", "(Landroid/content/Context;)V");
			JNIEnv.CallStaticVoidMethod  (class_ref, id_reset_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_setCustomDialog_Landroid_app_AlertDialog_Builder_;
#pragma warning disable 0169
		static Delegate GetSetCustomDialog_Landroid_app_AlertDialog_Builder_Handler ()
		{
			if (cb_setCustomDialog_Landroid_app_AlertDialog_Builder_ == null)
				cb_setCustomDialog_Landroid_app_AlertDialog_Builder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomDialog_Landroid_app_AlertDialog_Builder_);
			return cb_setCustomDialog_Landroid_app_AlertDialog_Builder_;
		}

		static IntPtr n_SetCustomDialog_Landroid_app_AlertDialog_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.AlertDialog.Builder p0 = global::Java.Lang.Object.GetObject<global::Android.App.AlertDialog.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomDialog (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomDialog_Landroid_app_AlertDialog_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='setCustomDialog' and count(parameter)=1 and parameter[1][@type='android.app.AlertDialog.Builder']]"
		[Register ("setCustomDialog", "(Landroid/app/AlertDialog$Builder;)Lcom/tjeannin/apprate/AppRate;", "GetSetCustomDialog_Landroid_app_AlertDialog_Builder_Handler")]
		public virtual global::Com.Tjeannin.Apprate.AppRate SetCustomDialog (global::Android.App.AlertDialog.Builder p0)
		{
			if (id_setCustomDialog_Landroid_app_AlertDialog_Builder_ == IntPtr.Zero)
				id_setCustomDialog_Landroid_app_AlertDialog_Builder_ = JNIEnv.GetMethodID (class_ref, "setCustomDialog", "(Landroid/app/AlertDialog$Builder;)Lcom/tjeannin/apprate/AppRate;");

			global::Com.Tjeannin.Apprate.AppRate __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallObjectMethod  (Handle, id_setCustomDialog_Landroid_app_AlertDialog_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setCustomDialog_Landroid_app_AlertDialog_Builder_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setMinDaysUntilPrompt_J;
#pragma warning disable 0169
		static Delegate GetSetMinDaysUntilPrompt_JHandler ()
		{
			if (cb_setMinDaysUntilPrompt_J == null)
				cb_setMinDaysUntilPrompt_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetMinDaysUntilPrompt_J);
			return cb_setMinDaysUntilPrompt_J;
		}

		static IntPtr n_SetMinDaysUntilPrompt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMinDaysUntilPrompt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMinDaysUntilPrompt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='setMinDaysUntilPrompt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMinDaysUntilPrompt", "(J)Lcom/tjeannin/apprate/AppRate;", "GetSetMinDaysUntilPrompt_JHandler")]
		public virtual global::Com.Tjeannin.Apprate.AppRate SetMinDaysUntilPrompt (long p0)
		{
			if (id_setMinDaysUntilPrompt_J == IntPtr.Zero)
				id_setMinDaysUntilPrompt_J = JNIEnv.GetMethodID (class_ref, "setMinDaysUntilPrompt", "(J)Lcom/tjeannin/apprate/AppRate;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallObjectMethod  (Handle, id_setMinDaysUntilPrompt_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setMinDaysUntilPrompt_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setMinLaunchesUntilPrompt_J;
#pragma warning disable 0169
		static Delegate GetSetMinLaunchesUntilPrompt_JHandler ()
		{
			if (cb_setMinLaunchesUntilPrompt_J == null)
				cb_setMinLaunchesUntilPrompt_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetMinLaunchesUntilPrompt_J);
			return cb_setMinLaunchesUntilPrompt_J;
		}

		static IntPtr n_SetMinLaunchesUntilPrompt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMinLaunchesUntilPrompt (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setMinLaunchesUntilPrompt_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='setMinLaunchesUntilPrompt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMinLaunchesUntilPrompt", "(J)Lcom/tjeannin/apprate/AppRate;", "GetSetMinLaunchesUntilPrompt_JHandler")]
		public virtual global::Com.Tjeannin.Apprate.AppRate SetMinLaunchesUntilPrompt (long p0)
		{
			if (id_setMinLaunchesUntilPrompt_J == IntPtr.Zero)
				id_setMinLaunchesUntilPrompt_J = JNIEnv.GetMethodID (class_ref, "setMinLaunchesUntilPrompt", "(J)Lcom/tjeannin/apprate/AppRate;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallObjectMethod  (Handle, id_setMinLaunchesUntilPrompt_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setMinLaunchesUntilPrompt_J, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnClickListener_Landroid_content_DialogInterface_OnClickListener_Handler ()
		{
			if (cb_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_ == null)
				cb_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOnClickListener_Landroid_content_DialogInterface_OnClickListener_);
			return cb_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_;
		}

		static IntPtr n_SetOnClickListener_Landroid_content_DialogInterface_OnClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IDialogInterfaceOnClickListener p0 = (global::Android.Content.IDialogInterfaceOnClickListener)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterfaceOnClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOnClickListener (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='setOnClickListener' and count(parameter)=1 and parameter[1][@type='android.content.DialogInterface.OnClickListener']]"
		[Register ("setOnClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/tjeannin/apprate/AppRate;", "GetSetOnClickListener_Landroid_content_DialogInterface_OnClickListener_Handler")]
		public virtual global::Com.Tjeannin.Apprate.AppRate SetOnClickListener (global::Android.Content.IDialogInterfaceOnClickListener p0)
		{
			if (id_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_ == IntPtr.Zero)
				id_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_ = JNIEnv.GetMethodID (class_ref, "setOnClickListener", "(Landroid/content/DialogInterface$OnClickListener;)Lcom/tjeannin/apprate/AppRate;");

			global::Com.Tjeannin.Apprate.AppRate __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallObjectMethod  (Handle, id_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setOnClickListener_Landroid_content_DialogInterface_OnClickListener_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setShowIfAppHasCrashed_Z;
#pragma warning disable 0169
		static Delegate GetSetShowIfAppHasCrashed_ZHandler ()
		{
			if (cb_setShowIfAppHasCrashed_Z == null)
				cb_setShowIfAppHasCrashed_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetShowIfAppHasCrashed_Z);
			return cb_setShowIfAppHasCrashed_Z;
		}

		static IntPtr n_SetShowIfAppHasCrashed_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tjeannin.Apprate.AppRate __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShowIfAppHasCrashed (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setShowIfAppHasCrashed_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='AppRate']/method[@name='setShowIfAppHasCrashed' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShowIfAppHasCrashed", "(Z)Lcom/tjeannin/apprate/AppRate;", "GetSetShowIfAppHasCrashed_ZHandler")]
		public virtual global::Com.Tjeannin.Apprate.AppRate SetShowIfAppHasCrashed (bool p0)
		{
			if (id_setShowIfAppHasCrashed_Z == IntPtr.Zero)
				id_setShowIfAppHasCrashed_Z = JNIEnv.GetMethodID (class_ref, "setShowIfAppHasCrashed", "(Z)Lcom/tjeannin/apprate/AppRate;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallObjectMethod  (Handle, id_setShowIfAppHasCrashed_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.AppRate> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, id_setShowIfAppHasCrashed_Z, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
