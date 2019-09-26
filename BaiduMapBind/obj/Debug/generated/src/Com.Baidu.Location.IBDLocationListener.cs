using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.location']/interface[@name='BDLocationListener']"
	[Register ("com/baidu/location/BDLocationListener", "", "Com.Baidu.Location.IBDLocationListenerInvoker")]
	public partial interface IBDLocationListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/interface[@name='BDLocationListener']/method[@name='onReceiveLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register ("onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V", "GetOnReceiveLocation_Lcom_baidu_location_BDLocation_Handler:Com.Baidu.Location.IBDLocationListenerInvoker, BaiduMapBind")]
		void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0);

	}

	[global::Android.Runtime.Register ("com/baidu/location/BDLocationListener", DoNotGenerateAcw=true)]
	internal class IBDLocationListenerInvoker : global::Java.Lang.Object, IBDLocationListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/location/BDLocationListener", typeof (IBDLocationListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IBDLocationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBDLocationListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.baidu.location.BDLocationListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBDLocationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Baidu.Location.IBDLocationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.IBDLocationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnReceiveLocation (p0);
		}
#pragma warning restore 0169

		IntPtr id_onReceiveLocation_Lcom_baidu_location_BDLocation_;
		public unsafe void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			if (id_onReceiveLocation_Lcom_baidu_location_BDLocation_ == IntPtr.Zero)
				id_onReceiveLocation_Lcom_baidu_location_BDLocation_ = JNIEnv.GetMethodID (class_ref, "onReceiveLocation", "(Lcom/baidu/location/BDLocation;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceiveLocation_Lcom_baidu_location_BDLocation_, __args);
		}

	}

	// event args for com.baidu.location.BDLocationListener.onReceiveLocation
	public partial class BDLocationEventArgs : global::System.EventArgs {

		public BDLocationEventArgs (global::Com.Baidu.Location.BDLocation p0)
		{
			this.p0 = p0;
		}

		global::Com.Baidu.Location.BDLocation p0;
		public global::Com.Baidu.Location.BDLocation P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/baidu/location/BDLocationListenerImplementor")]
	internal sealed partial class IBDLocationListenerImplementor : global::Java.Lang.Object, IBDLocationListener {

		object sender;

		public IBDLocationListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/location/BDLocationListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BDLocationEventArgs> Handler;
#pragma warning restore 0649

		public void OnReceiveLocation (global::Com.Baidu.Location.BDLocation p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new BDLocationEventArgs (p0));
		}

		internal static bool __IsEmpty (IBDLocationListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
