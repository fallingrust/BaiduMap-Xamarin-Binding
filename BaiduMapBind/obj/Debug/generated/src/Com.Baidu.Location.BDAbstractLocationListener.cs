using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']"
	[global::Android.Runtime.Register ("com/baidu/location/BDAbstractLocationListener", DoNotGenerateAcw=true)]
	public abstract partial class BDAbstractLocationListener : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/BDAbstractLocationListener", typeof (BDAbstractLocationListener));
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

		protected BDAbstractLocationListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']/constructor[@name='BDAbstractLocationListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDAbstractLocationListener ()
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

		static Delegate cb_onConnectHotSpotMessage_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOnConnectHotSpotMessage_Ljava_lang_String_IHandler ()
		{
			if (cb_onConnectHotSpotMessage_Ljava_lang_String_I == null)
				cb_onConnectHotSpotMessage_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnConnectHotSpotMessage_Ljava_lang_String_I);
			return cb_onConnectHotSpotMessage_Ljava_lang_String_I;
		}

		static void n_OnConnectHotSpotMessage_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Location.BDAbstractLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDAbstractLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConnectHotSpotMessage (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']/method[@name='onConnectHotSpotMessage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("onConnectHotSpotMessage", "(Ljava/lang/String;I)V", "GetOnConnectHotSpotMessage_Ljava_lang_String_IHandler")]
		public virtual unsafe void OnConnectHotSpotMessage (string p0, int p1)
		{
			const string __id = "onConnectHotSpotMessage.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_onLocDiagnosticMessage_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnLocDiagnosticMessage_IILjava_lang_String_Handler ()
		{
			if (cb_onLocDiagnosticMessage_IILjava_lang_String_ == null)
				cb_onLocDiagnosticMessage_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnLocDiagnosticMessage_IILjava_lang_String_);
			return cb_onLocDiagnosticMessage_IILjava_lang_String_;
		}

		static void n_OnLocDiagnosticMessage_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Baidu.Location.BDAbstractLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDAbstractLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnLocDiagnosticMessage (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']/method[@name='onLocDiagnosticMessage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("onLocDiagnosticMessage", "(IILjava/lang/String;)V", "GetOnLocDiagnosticMessage_IILjava_lang_String_Handler")]
		public virtual unsafe void OnLocDiagnosticMessage (int p0, int p1, string p2)
		{
			const string __id = "onLocDiagnosticMessage.(IILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
#pragma warning disable 0169
		static Delegate GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler ()
		{
			if (cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ == null)
				cb_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnReceiveLocation_Lcom_baidu_location_BDLocation_);
			return cb_onReceiveLocation_Lcom_baidu_location_BDLocation_;
		}

		static void n_OnReceiveLocation_Lcom_baidu_location_BDLocation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Location.BDAbstractLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDAbstractLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveLocation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler")]
		public abstract void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0);

	}

	[global::Android.Runtime.Register ("com/baidu/location/BDAbstractLocationListener", DoNotGenerateAcw=true)]
	internal partial class BDAbstractLocationListenerInvoker : BDAbstractLocationListener {

		public BDAbstractLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/location/BDAbstractLocationListener", typeof (BDAbstractLocationListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDAbstractLocationListener']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler")]
		public override unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			const string __id = "onReceiveLocation.(Lcom/baidu/location/BDLocation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
