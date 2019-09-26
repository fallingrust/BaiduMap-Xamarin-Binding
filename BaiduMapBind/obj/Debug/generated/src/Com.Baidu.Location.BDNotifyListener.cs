using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']"
	[global::Android.Runtime.Register ("com/baidu/location/BDNotifyListener", DoNotGenerateAcw=true)]
	public abstract partial class BDNotifyListener : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='Notified']"
		[Register ("Notified")]
		public int Notified {
			get {
				const string __id = "Notified.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "Notified.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='differDistance']"
		[Register ("differDistance")]
		public float DifferDistance {
			get {
				const string __id = "differDistance.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "differDistance.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='isAdded']"
		[Register ("isAdded")]
		public bool IsAdded {
			get {
				const string __id = "isAdded.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isAdded.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mCoorType']"
		[Register ("mCoorType")]
		public string MCoorType {
			get {
				const string __id = "mCoorType.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCoorType.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLatitude']"
		[Register ("mLatitude")]
		public double MLatitude {
			get {
				const string __id = "mLatitude.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLatitude.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLatitudeC']"
		[Register ("mLatitudeC")]
		public double MLatitudeC {
			get {
				const string __id = "mLatitudeC.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLatitudeC.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLongitude']"
		[Register ("mLongitude")]
		public double MLongitude {
			get {
				const string __id = "mLongitude.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLongitude.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mLongitudeC']"
		[Register ("mLongitudeC")]
		public double MLongitudeC {
			get {
				const string __id = "mLongitudeC.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLongitudeC.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/field[@name='mRadius']"
		[Register ("mRadius")]
		public float MRadius {
			get {
				const string __id = "mRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/BDNotifyListener", typeof (BDNotifyListener));
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

		protected BDNotifyListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/constructor[@name='BDNotifyListener' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDNotifyListener ()
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

		static Delegate cb_SetNotifyLocation_DDFLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNotifyLocation_DDFLjava_lang_String_Handler ()
		{
			if (cb_SetNotifyLocation_DDFLjava_lang_String_ == null)
				cb_SetNotifyLocation_DDFLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double, double, float, IntPtr>) n_SetNotifyLocation_DDFLjava_lang_String_);
			return cb_SetNotifyLocation_DDFLjava_lang_String_;
		}

		static void n_SetNotifyLocation_DDFLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, double p0, double p1, float p2, IntPtr native_p3)
		{
			global::Com.Baidu.Location.BDNotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetNotifyLocation (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/method[@name='SetNotifyLocation' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.String']]"
		[Register ("SetNotifyLocation", "(DDFLjava/lang/String;)V", "GetSetNotifyLocation_DDFLjava_lang_String_Handler")]
		public virtual unsafe void SetNotifyLocation (double p0, double p1, float p2, string p3)
		{
			const string __id = "SetNotifyLocation.(DDFLjava/lang/String;)V";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static Delegate cb_onNotify_Lcom_baidu_location_BDLocation_F;
#pragma warning disable 0169
		static Delegate GetOnNotify_Lcom_baidu_location_BDLocation_FHandler ()
		{
			if (cb_onNotify_Lcom_baidu_location_BDLocation_F == null)
				cb_onNotify_Lcom_baidu_location_BDLocation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_OnNotify_Lcom_baidu_location_BDLocation_F);
			return cb_onNotify_Lcom_baidu_location_BDLocation_F;
		}

		static void n_OnNotify_Lcom_baidu_location_BDLocation_F (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
		{
			global::Com.Baidu.Location.BDNotifyListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDNotifyListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Location.BDLocation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.BDLocation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnNotify (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDNotifyListener']/method[@name='onNotify' and count(parameter)=2 and parameter[1][@type='com.baidu.location.BDLocation'] and parameter[2][@type='float']]"
		[Register ("onNotify", "(Lcom/baidu/location/BDLocation;F)V", "GetOnNotify_Lcom_baidu_location_BDLocation_FHandler")]
		public virtual unsafe void OnNotify (global::Com.Baidu.Location.BDLocation p0, float p1)
		{
			const string __id = "onNotify.(Lcom/baidu/location/BDLocation;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/baidu/location/BDNotifyListener", DoNotGenerateAcw=true)]
	internal partial class BDNotifyListenerInvoker : BDNotifyListener {

		public BDNotifyListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/location/BDNotifyListener", typeof (BDNotifyListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
