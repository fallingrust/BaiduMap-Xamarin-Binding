using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SyncSysInfo']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/util/SyncSysInfo", DoNotGenerateAcw=true)]
	public partial class SyncSysInfo : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/util/SyncSysInfo", typeof (SyncSysInfo));
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

		protected SyncSysInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SyncSysInfo']/constructor[@name='SyncSysInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SyncSysInfo ()
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

		public static unsafe string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SyncSysInfo']/method[@name='getAuthToken' and count(parameter)=0]"
			[Register ("getAuthToken", "()Ljava/lang/String;", "GetGetAuthTokenHandler")]
			get {
				const string __id = "getAuthToken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string PhoneInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SyncSysInfo']/method[@name='getPhoneInfo' and count(parameter)=0]"
			[Register ("getPhoneInfo", "()Ljava/lang/String;", "GetGetPhoneInfoHandler")]
			get {
				const string __id = "getPhoneInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
