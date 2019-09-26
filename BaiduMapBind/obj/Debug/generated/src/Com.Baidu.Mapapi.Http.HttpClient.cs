using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Http {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient", DoNotGenerateAcw=true)]
	public partial class HttpClient : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/field[@name='isHttpsEnable']"
		[Register ("isHttpsEnable")]
		public static bool IsHttpsEnable {
			get {
				const string __id = "isHttpsEnable.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "isHttpsEnable.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$HttpStateError", DoNotGenerateAcw=true)]
		public sealed partial class HttpStateError : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='INNER_ERROR']"
			[Register ("INNER_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError InnerError {
				get {
					const string __id = "INNER_ERROR.Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='NETWORK_ERROR']"
			[Register ("NETWORK_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError NetworkError {
				get {
					const string __id = "NETWORK_ERROR.Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='NO_ERROR']"
			[Register ("NO_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError NoError {
				get {
					const string __id = "NO_ERROR.Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='REQUEST_ERROR']"
			[Register ("REQUEST_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError RequestError {
				get {
					const string __id = "REQUEST_ERROR.Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/field[@name='SERVER_ERROR']"
			[Register ("SERVER_ERROR")]
			public static global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError ServerError {
				get {
					const string __id = "SERVER_ERROR.Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/http/HttpClient$HttpStateError", typeof (HttpStateError));
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

			internal HttpStateError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/http/HttpClient$HttpStateError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.HttpStateError']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/http/HttpClient$HttpStateError;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/http/HttpClient$HttpStateError;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", DoNotGenerateAcw=true)]
		public abstract partial class ProtoResultCallback : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", typeof (ProtoResultCallback));
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

			protected ProtoResultCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/constructor[@name='HttpClient.ProtoResultCallback' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe ProtoResultCallback ()
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

			static Delegate cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_;
#pragma warning disable 0169
			static Delegate GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler ()
			{
				if (cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ == null)
					cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_);
				return cb_onFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_;
			}

			static void n_OnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnFailed (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.http.HttpClient.HttpStateError']]"
			[Register ("onFailed", "(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V", "GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler")]
			public abstract void OnFailed (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0);

			static Delegate cb_onSuccess_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnSuccess_Ljava_lang_String_Handler ()
			{
				if (cb_onSuccess_Ljava_lang_String_ == null)
					cb_onSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSuccess_Ljava_lang_String_);
				return cb_onSuccess_Ljava_lang_String_;
			}

			static void n_OnSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
			public abstract void OnSuccess (string p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", DoNotGenerateAcw=true)]
		internal partial class ProtoResultCallbackInvoker : ProtoResultCallback {

			public ProtoResultCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/http/HttpClient$ProtoResultCallback", typeof (ProtoResultCallbackInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onFailed' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.http.HttpClient.HttpStateError']]"
			[Register ("onFailed", "(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V", "GetOnFailed_Lcom_baidu_mapapi_http_HttpClient_HttpStateError_Handler")]
			public override unsafe void OnFailed (global::Com.Baidu.Mapapi.Http.HttpClient.HttpStateError p0)
			{
				const string __id = "onFailed.(Lcom/baidu/mapapi/http/HttpClient$HttpStateError;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient.ProtoResultCallback']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onSuccess", "(Ljava/lang/String;)V", "GetOnSuccess_Ljava_lang_String_Handler")]
			public override unsafe void OnSuccess (string p0)
			{
				const string __id = "onSuccess.(Ljava/lang/String;)V";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/http/HttpClient", typeof (HttpClient));
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

		protected HttpClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/constructor[@name='HttpClient' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.baidu.mapapi.http.HttpClient.ProtoResultCallback']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V", "")]
		public unsafe HttpClient (string p0, global::Com.Baidu.Mapapi.Http.HttpClient.ProtoResultCallback p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/baidu/mapapi/http/HttpClient$ProtoResultCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static unsafe string AuthToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='getAuthToken' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='getPhoneInfo' and count(parameter)=0]"
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

		static Delegate cb_checkNetwork;
#pragma warning disable 0169
		static Delegate GetCheckNetworkHandler ()
		{
			if (cb_checkNetwork == null)
				cb_checkNetwork = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckNetwork);
			return cb_checkNetwork;
		}

		static bool n_CheckNetwork (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckNetwork ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='checkNetwork' and count(parameter)=0]"
		[Register ("checkNetwork", "()Z", "GetCheckNetworkHandler")]
		protected virtual unsafe bool CheckNetwork ()
		{
			const string __id = "checkNetwork.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_request_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRequest_Ljava_lang_String_Handler ()
		{
			if (cb_request_Ljava_lang_String_ == null)
				cb_request_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Request_Ljava_lang_String_);
			return cb_request_Ljava_lang_String_;
		}

		static void n_Request_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Request (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='request' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("request", "(Ljava/lang/String;)V", "GetRequest_Ljava_lang_String_Handler")]
		protected virtual unsafe void Request (string p0)
		{
			const string __id = "request.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setMaxTimeOut_I;
#pragma warning disable 0169
		static Delegate GetSetMaxTimeOut_IHandler ()
		{
			if (cb_setMaxTimeOut_I == null)
				cb_setMaxTimeOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxTimeOut_I);
			return cb_setMaxTimeOut_I;
		}

		static void n_SetMaxTimeOut_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxTimeOut (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='setMaxTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxTimeOut", "(I)V", "GetSetMaxTimeOut_IHandler")]
		public virtual unsafe void SetMaxTimeOut (int p0)
		{
			const string __id = "setMaxTimeOut.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setReadTimeOut_I;
#pragma warning disable 0169
		static Delegate GetSetReadTimeOut_IHandler ()
		{
			if (cb_setReadTimeOut_I == null)
				cb_setReadTimeOut_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetReadTimeOut_I);
			return cb_setReadTimeOut_I;
		}

		static void n_SetReadTimeOut_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Http.HttpClient __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Http.HttpClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetReadTimeOut (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.http']/class[@name='HttpClient']/method[@name='setReadTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setReadTimeOut", "(I)V", "GetSetReadTimeOut_IHandler")]
		public virtual unsafe void SetReadTimeOut (int p0)
		{
			const string __id = "setReadTimeOut.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
