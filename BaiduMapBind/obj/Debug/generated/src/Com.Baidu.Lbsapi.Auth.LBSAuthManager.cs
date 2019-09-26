using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Lbsapi.Auth {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']"
	[global::Android.Runtime.Register ("com/baidu/lbsapi/auth/LBSAuthManager", DoNotGenerateAcw=true)]
	public partial class LBSAuthManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_AUTHENTICATE_SUCC']"
		[Register ("CODE_AUTHENTICATE_SUCC")]
		public const int CodeAuthenticateSucc = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_AUTHENTICATING']"
		[Register ("CODE_AUTHENTICATING")]
		public const int CodeAuthenticating = (int) 602;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_INNER_ERROR']"
		[Register ("CODE_INNER_ERROR")]
		public const int CodeInnerError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_KEY_NOT_EXIST']"
		[Register ("CODE_KEY_NOT_EXIST")]
		public const int CodeKeyNotExist = (int) 101;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_NETWORK_FAILED']"
		[Register ("CODE_NETWORK_FAILED")]
		public const int CodeNetworkFailed = (int) -11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_NETWORK_INVALID']"
		[Register ("CODE_NETWORK_INVALID")]
		public const int CodeNetworkInvalid = (int) -10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='CODE_UNAUTHENTICATE']"
		[Register ("CODE_UNAUTHENTICATE")]
		public const int CodeUnauthenticate = (int) 601;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/field[@name='VERSION']"
		[Register ("VERSION")]
		public const string Version = (string) "1.0.23";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/lbsapi/auth/LBSAuthManager", typeof (LBSAuthManager));
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

		protected LBSAuthManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getCUID;
#pragma warning disable 0169
		static Delegate GetGetCUIDHandler ()
		{
			if (cb_getCUID == null)
				cb_getCUID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCUID);
			return cb_getCUID;
		}

		static IntPtr n_GetCUID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CUID);
		}
#pragma warning restore 0169

		public virtual unsafe string CUID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getCUID' and count(parameter)=0]"
			[Register ("getCUID", "()Ljava/lang/String;", "GetGetCUIDHandler")]
			get {
				const string __id = "getCUID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKey;
#pragma warning disable 0169
		static Delegate GetGetKeyHandler ()
		{
			if (cb_getKey == null)
				cb_getKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKey);
			return cb_getKey;
		}

		static IntPtr n_GetKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key);
		}
#pragma warning restore 0169

		public virtual unsafe string Key {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getKey' and count(parameter)=0]"
			[Register ("getKey", "()Ljava/lang/String;", "GetGetKeyHandler")]
			get {
				const string __id = "getKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMCode;
#pragma warning disable 0169
		static Delegate GetGetMCodeHandler ()
		{
			if (cb_getMCode == null)
				cb_getMCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMCode);
			return cb_getMCode;
		}

		static IntPtr n_GetMCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MCode);
		}
#pragma warning restore 0169

		public virtual unsafe string MCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getMCode' and count(parameter)=0]"
			[Register ("getMCode", "()Ljava/lang/String;", "GetGetMCodeHandler")]
			get {
				const string __id = "getMCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_Handler ()
		{
			if (cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ == null)
				cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr, int>) n_Authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_);
			return cb_authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_;
		}

		static int n_Authenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Hashtable p2 = global::Java.Lang.Object.GetObject<global::Java.Util.Hashtable> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener p3 = (global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Authenticate (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='authenticate' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Hashtable&lt;java.lang.String, java.lang.String&gt;'] and parameter[4][@type='com.baidu.lbsapi.auth.LBSAuthManagerListener']]"
		[Register ("authenticate", "(ZLjava/lang/String;Ljava/util/Hashtable;Lcom/baidu/lbsapi/auth/LBSAuthManagerListener;)I", "GetAuthenticate_ZLjava_lang_String_Ljava_util_Hashtable_Lcom_baidu_lbsapi_auth_LBSAuthManagerListener_Handler")]
		public virtual unsafe int Authenticate (bool p0, string p1, global::Java.Util.Hashtable p2, global::Com.Baidu.Lbsapi.Auth.ILBSAuthManagerListener p3)
		{
			const string __id = "authenticate.(ZLjava/lang/String;Ljava/util/Hashtable;Lcom/baidu/lbsapi/auth/LBSAuthManagerListener;)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/baidu/lbsapi/auth/LBSAuthManager;", "")]
		public static unsafe global::Com.Baidu.Lbsapi.Auth.LBSAuthManager GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/baidu/lbsapi/auth/LBSAuthManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPublicKey_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetPublicKey_Landroid_content_Context_Handler ()
		{
			if (cb_getPublicKey_Landroid_content_Context_ == null)
				cb_getPublicKey_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPublicKey_Landroid_content_Context_);
			return cb_getPublicKey_Landroid_content_Context_;
		}

		static IntPtr n_GetPublicKey_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Lbsapi.Auth.LBSAuthManager __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Lbsapi.Auth.LBSAuthManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPublicKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.lbsapi.auth']/class[@name='LBSAuthManager']/method[@name='getPublicKey' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getPublicKey", "(Landroid/content/Context;)Ljava/lang/String;", "GetGetPublicKey_Landroid_content_Context_Handler")]
		public virtual unsafe string GetPublicKey (global::Android.Content.Context p0)
		{
			const string __id = "getPublicKey.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
