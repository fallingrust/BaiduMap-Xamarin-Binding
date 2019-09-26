using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIMD5']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/util/JNIMD5", DoNotGenerateAcw=true)]
	public partial class JNIMD5 : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/util/JNIMD5", typeof (JNIMD5));
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

		protected JNIMD5 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string UrlNeedInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIMD5']/method[@name='getUrlNeedInfo' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIMD5']/method[@name='encodeUrlParamsValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIMD5']/method[@name='getSignMD5String' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
