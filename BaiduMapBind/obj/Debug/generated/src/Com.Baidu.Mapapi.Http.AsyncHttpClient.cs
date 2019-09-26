using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/http/AsyncHttpClient", DoNotGenerateAcw=true)]
	public partial class AsyncHttpClient : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/http/AsyncHttpClient", typeof (AsyncHttpClient));
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

		protected AsyncHttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/constructor[@name='AsyncHttpClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AsyncHttpClient ()
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

		static Delegate cb_isAuthorized;
#pragma warning disable 0169
		static Delegate GetIsAuthorizedHandler ()
		{
			if (cb_isAuthorized == null)
				cb_isAuthorized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthorized);
			return cb_isAuthorized;
		}

		static bool n_IsAuthorized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorized;
		}
#pragma warning restore 0169

		protected virtual unsafe bool IsAuthorized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/method[@name='isAuthorized' and count(parameter)=0]"
			[Register ("isAuthorized", "()Z", "GetIsAuthorizedHandler")]
			get {
				const string __id = "isAuthorized.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_Handler ()
		{
			if (cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ == null)
				cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_);
			return cb_get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_;
		}

		static void n_Get_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Http.AsyncHttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.AsyncHttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Get (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='AsyncHttpClient']/method[@name='get' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.http.HttpClient.ProtoResultCallback']]"
		[Register ("get", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", "GetGet_Ljava_lang_String_Lcom_baidu_mapapi_http_HttpClient_ProtoResultCallback_Handler")]
		public virtual unsafe void Get (string p0, global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1)
		{
			const string __id = "get.(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
