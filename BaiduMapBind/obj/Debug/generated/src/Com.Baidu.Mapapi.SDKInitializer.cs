using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/SDKInitializer", DoNotGenerateAcw=true)]
	public partial class SDKInitializer : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADCAST_ACTION_STRING_NETWORK_ERROR']"
		[Register ("SDK_BROADCAST_ACTION_STRING_NETWORK_ERROR")]
		public const string SdkBroadcastActionStringNetworkError = (string) "network error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_ERROR']"
		[Register ("SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_ERROR")]
		public const string SdkBroadtcastActionStringPermissionCheckError = (string) "permission check error";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_OK']"
		[Register ("SDK_BROADTCAST_ACTION_STRING_PERMISSION_CHECK_OK")]
		public const string SdkBroadtcastActionStringPermissionCheckOk = (string) "permission check ok";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_CODE']"
		[Register ("SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_CODE")]
		public const string SdkBroadtcastIntentExtraInfoKeyErrorCode = (string) "error_code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/field[@name='SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_MESSAGE']"
		[Register ("SDK_BROADTCAST_INTENT_EXTRA_INFO_KEY_ERROR_MESSAGE")]
		public const string SdkBroadtcastIntentExtraInfoKeyErrorMessage = (string) "error_message";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/SDKInitializer", typeof (SDKInitializer));
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

		protected SDKInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Baidu.Mapapi.CoordType CoordType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='getCoordType' and count(parameter)=0]"
			[Register ("getCoordType", "()Lcom/baidu/mapapi/CoordType;", "GetGetCoordTypeHandler")]
			get {
				const string __id = "getCoordType.()Lcom/baidu/mapapi/CoordType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.CoordType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='setCoordType' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.CoordType']]"
			[Register ("setCoordType", "(Lcom/baidu/mapapi/CoordType;)V", "GetSetCoordType_Lcom_baidu_mapapi_CoordType_Handler")]
			set {
				const string __id = "setCoordType.(Lcom/baidu/mapapi/CoordType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		public static unsafe bool HttpsEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='isHttpsEnable' and count(parameter)=0]"
			[Register ("isHttpsEnable", "()Z", "GetIsHttpsEnableHandler")]
			get {
				const string __id = "isHttpsEnable.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='setHttpsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHttpsEnable", "(Z)V", "GetSetHttpsEnable_ZHandler")]
			set {
				const string __id = "setHttpsEnable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initialize", "(Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0)
		{
			const string __id = "initialize.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='initialize' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Initialize (global::Android.Content.Context p0, bool p1, string p2, string p3)
		{
			const string __id = "initialize.(Landroid/content/Context;ZLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='SDKInitializer']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("initialize", "(Ljava/lang/String;Landroid/content/Context;)V", "")]
		public static unsafe void Initialize (string p0, global::Android.Content.Context p1)
		{
			const string __id = "initialize.(Ljava/lang/String;Landroid/content/Context;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
