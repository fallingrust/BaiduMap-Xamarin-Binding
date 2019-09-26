using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/JNIInitializer", DoNotGenerateAcw=true)]
	public partial class JNIInitializer : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/JNIInitializer", typeof (JNIInitializer));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected JNIInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/constructor[@name='JNIInitializer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JNIInitializer ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		public static unsafe global::Android.Content.Context CachedContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/method[@name='getCachedContext' and count(parameter)=0]"
			[Register ("getCachedContext", "()Landroid/content/Context;", "GetGetCachedContextHandler")]
			get {
				const string __id = "getCachedContext.()Landroid/content/Context;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='JNIInitializer']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.app.Application']]"
		[Register ("setContext", "(Landroid/app/Application;)V", "")]
		public static unsafe void SetContext (global::Android.App.Application p0)
		{
			const string __id = "setContext.(Landroid/app/Application;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
