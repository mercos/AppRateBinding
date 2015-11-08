using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Tjeannin.Apprate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='ExceptionHandler']"
	[global::Android.Runtime.Register ("com/tjeannin/apprate/ExceptionHandler", DoNotGenerateAcw=true)]
	public partial class ExceptionHandler : global::Java.Lang.Object, global::Java.Lang.Thread.IUncaughtExceptionHandler {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/tjeannin/apprate/ExceptionHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ExceptionHandler); }
		}

		protected ExceptionHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Thread_UncaughtExceptionHandler_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='ExceptionHandler']/constructor[@name='ExceptionHandler' and count(parameter)=2 and parameter[1][@type='java.lang.Thread.UncaughtExceptionHandler'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Ljava/lang/Thread$UncaughtExceptionHandler;Landroid/content/Context;)V", "")]
		public ExceptionHandler (global::Java.Lang.Thread.IUncaughtExceptionHandler p0, global::Android.Content.Context p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ExceptionHandler)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/Thread$UncaughtExceptionHandler;Landroid/content/Context;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/Thread$UncaughtExceptionHandler;Landroid/content/Context;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Ljava_lang_Thread_UncaughtExceptionHandler_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Ljava_lang_Thread_UncaughtExceptionHandler_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Thread$UncaughtExceptionHandler;Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Thread_UncaughtExceptionHandler_Landroid_content_Context_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_Thread_UncaughtExceptionHandler_Landroid_content_Context_, new JValue (p0), new JValue (p1));
		}

		static Delegate cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler ()
		{
			if (cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == null)
				cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_);
			return cb_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		}

		static void n_UncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tjeannin.Apprate.ExceptionHandler __this = global::Java.Lang.Object.GetObject<global::Com.Tjeannin.Apprate.ExceptionHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Thread p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.UncaughtException (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.tjeannin.apprate']/class[@name='ExceptionHandler']/method[@name='uncaughtException' and count(parameter)=2 and parameter[1][@type='java.lang.Thread'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V", "GetUncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_Handler")]
		public virtual void UncaughtException (global::Java.Lang.Thread p0, global::Java.Lang.Throwable p1)
		{
			if (id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "uncaughtException", "(Ljava/lang/Thread;Ljava/lang/Throwable;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, id_uncaughtException_Ljava_lang_Thread_Ljava_lang_Throwable_, new JValue (p0), new JValue (p1));
		}

	}
}
