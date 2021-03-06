using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='AppMD5']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/util/AppMD5", DoNotGenerateAcw=true)]
	public partial class AppMD5 : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/util/AppMD5", typeof (AppMD5));
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

		protected AppMD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='AppMD5']/constructor[@name='AppMD5' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppMD5 ()
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

		public static unsafe string UrlNeedInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='AppMD5']/method[@name='getUrlNeedInfo' and count(parameter)=0]"
			[Register ("getUrlNeedInfo", "()Ljava/lang/String;", "GetGetUrlNeedInfoHandler")]
			get {
				const string __id = "getUrlNeedInfo.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='AppMD5']/method[@name='encodeUrlParamsValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeUrlParamsValue", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeUrlParamsValue (string p0)
		{
			const string __id = "encodeUrlParamsValue.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='AppMD5']/method[@name='getSignMD5String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSignMD5String", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetSignMD5String (string p0)
		{
			const string __id = "getSignMD5String.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
