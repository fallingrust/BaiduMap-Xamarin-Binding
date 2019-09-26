using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Android.Bbalbs.Common.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']"
	[global::Android.Runtime.Register ("com/baidu/android/bbalbs/common/util/CommonParam", DoNotGenerateAcw=true)]
	public partial class CommonParam : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/android/bbalbs/common/util/CommonParam", typeof (CommonParam));
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

		protected CommonParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']/constructor[@name='CommonParam' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommonParam ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.android.bbalbs.common.util']/class[@name='CommonParam']/method[@name='getCUID' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCUID", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCUID (global::Android.Content.Context p0)
		{
			const string __id = "getCUID.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
