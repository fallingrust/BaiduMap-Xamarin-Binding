using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']"
	[global::Android.Runtime.Register ("com/baidu/location/LocationClientOption", DoNotGenerateAcw=true)]
	public sealed partial class LocationClientOption : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='GpsFirst']"
		[Register ("GpsFirst")]
		public const int GpsFirst = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='GpsOnly']"
		[Register ("GpsOnly")]
		public const int GpsOnly = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_HIGHT']"
		[Register ("LOC_SENSITIVITY_HIGHT")]
		public const int LocSensitivityHight = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_LOW']"
		[Register ("LOC_SENSITIVITY_LOW")]
		public const int LocSensitivityLow = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='LOC_SENSITIVITY_MIDDLE']"
		[Register ("LOC_SENSITIVITY_MIDDLE")]
		public const int LocSensitivityMiddle = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='MIN_AUTO_NOTIFY_INTERVAL']"
		[Register ("MIN_AUTO_NOTIFY_INTERVAL")]
		public const int MinAutoNotifyInterval = (int) 10000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='MIN_SCAN_SPAN']"
		[Register ("MIN_SCAN_SPAN")]
		public const int MinScanSpan = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='NetWorkFirst']"
		[Register ("NetWorkFirst")]
		public const int NetWorkFirst = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='a']"
		[Register ("a")]
		protected global::Com.Baidu.Location.LocationClientOption.LocationMode A {
			get {
				const string __id = "a.Lcom/baidu/location/LocationClientOption$LocationMode;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Lcom/baidu/location/LocationClientOption$LocationMode;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='autoNotifyLocSensitivity']"
		[Register ("autoNotifyLocSensitivity")]
		public float AutoNotifyLocSensitivity {
			get {
				const string __id = "autoNotifyLocSensitivity.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "autoNotifyLocSensitivity.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='autoNotifyMaxInterval']"
		[Register ("autoNotifyMaxInterval")]
		public int AutoNotifyMaxInterval {
			get {
				const string __id = "autoNotifyMaxInterval.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "autoNotifyMaxInterval.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='disableLocCache']"
		[Register ("disableLocCache")]
		public bool DisableLocCache {
			get {
				const string __id = "disableLocCache.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "disableLocCache.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='enableSimulateGps']"
		[Register ("enableSimulateGps")]
		public bool EnableSimulateGps {
			get {
				const string __id = "enableSimulateGps.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "enableSimulateGps.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isIgnoreCacheException']"
		[Register ("isIgnoreCacheException")]
		public bool IsIgnoreCacheException {
			get {
				const string __id = "isIgnoreCacheException.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isIgnoreCacheException.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isIgnoreKillProcess']"
		[Register ("isIgnoreKillProcess")]
		public bool IsIgnoreKillProcess {
			get {
				const string __id = "isIgnoreKillProcess.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isIgnoreKillProcess.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAltitude']"
		[Register ("isNeedAltitude")]
		public bool IsNeedAltitude {
			get {
				const string __id = "isNeedAltitude.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedAltitude.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAptag']"
		[Register ("isNeedAptag")]
		public bool IsNeedAptag {
			get {
				const string __id = "isNeedAptag.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedAptag.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedAptagd']"
		[Register ("isNeedAptagd")]
		public bool IsNeedAptagd {
			get {
				const string __id = "isNeedAptagd.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedAptagd.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedNewVersionRgc']"
		[Register ("isNeedNewVersionRgc")]
		public bool IsNeedNewVersionRgc {
			get {
				const string __id = "isNeedNewVersionRgc.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedNewVersionRgc.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedPoiRegion']"
		[Register ("isNeedPoiRegion")]
		public bool IsNeedPoiRegion {
			get {
				const string __id = "isNeedPoiRegion.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedPoiRegion.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='isNeedRegular']"
		[Register ("isNeedRegular")]
		public bool IsNeedRegular {
			get {
				const string __id = "isNeedRegular.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isNeedRegular.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='location_change_notify']"
		[Register ("location_change_notify")]
		public bool LocationChangeNotify {
			get {
				const string __id = "location_change_notify.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "location_change_notify.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='mIsNeedDeviceDirect']"
		[Register ("mIsNeedDeviceDirect")]
		public bool MIsNeedDeviceDirect {
			get {
				const string __id = "mIsNeedDeviceDirect.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIsNeedDeviceDirect.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/field[@name='wifiCacheTimeOut']"
		[Register ("wifiCacheTimeOut")]
		public int WifiCacheTimeOut {
			get {
				const string __id = "wifiCacheTimeOut.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "wifiCacheTimeOut.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']"
		[global::Android.Runtime.Register ("com/baidu/location/LocationClientOption$BDLocationPurpose", DoNotGenerateAcw=true)]
		public sealed partial class BDLocationPurpose : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']/field[@name='SignIn']"
			[Register ("SignIn")]
			public static global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose SignIn {
				get {
					const string __id = "SignIn.Lcom/baidu/location/LocationClientOption$BDLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']/field[@name='Sport']"
			[Register ("Sport")]
			public static global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose Sport {
				get {
					const string __id = "Sport.Lcom/baidu/location/LocationClientOption$BDLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']/field[@name='Transport']"
			[Register ("Transport")]
			public static global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose Transport {
				get {
					const string __id = "Transport.Lcom/baidu/location/LocationClientOption$BDLocationPurpose;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/LocationClientOption$BDLocationPurpose", typeof (BDLocationPurpose));
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

			internal BDLocationPurpose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$BDLocationPurpose;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$BDLocationPurpose;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.BDLocationPurpose']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/location/LocationClientOption$BDLocationPurpose;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/location/LocationClientOption$BDLocationPurpose;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']"
		[global::Android.Runtime.Register ("com/baidu/location/LocationClientOption$LocationMode", DoNotGenerateAcw=true)]
		public sealed partial class LocationMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Battery_Saving']"
			[Register ("Battery_Saving")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode BatterySaving {
				get {
					const string __id = "Battery_Saving.Lcom/baidu/location/LocationClientOption$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Device_Sensors']"
			[Register ("Device_Sensors")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode DeviceSensors {
				get {
					const string __id = "Device_Sensors.Lcom/baidu/location/LocationClientOption$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/field[@name='Hight_Accuracy']"
			[Register ("Hight_Accuracy")]
			public static global::Com.Baidu.Location.LocationClientOption.LocationMode HightAccuracy {
				get {
					const string __id = "Hight_Accuracy.Lcom/baidu/location/LocationClientOption$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/LocationClientOption$LocationMode", typeof (LocationMode));
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

			internal LocationMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/location/LocationClientOption$LocationMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption.LocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/location/LocationClientOption$LocationMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Location.LocationClientOption.LocationMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Location.LocationClientOption.LocationMode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/LocationClientOption", typeof (LocationClientOption));
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

		internal LocationClientOption (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/constructor[@name='LocationClientOption' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LocationClientOption ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/constructor[@name='LocationClientOption' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
		[Register (".ctor", "(Lcom/baidu/location/LocationClientOption;)V", "")]
		public unsafe LocationClientOption (global::Com.Baidu.Location.LocationClientOption p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/location/LocationClientOption;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe string AddrType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAddrType' and count(parameter)=0]"
			[Register ("getAddrType", "()Ljava/lang/String;", "GetGetAddrTypeHandler")]
			get {
				const string __id = "getAddrType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setAddrType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddrType", "(Ljava/lang/String;)V", "GetSetAddrType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAddrType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe int AutoNotifyMinDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAutoNotifyMinDistance' and count(parameter)=0]"
			[Register ("getAutoNotifyMinDistance", "()I", "GetGetAutoNotifyMinDistanceHandler")]
			get {
				const string __id = "getAutoNotifyMinDistance.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int AutoNotifyMinTimeInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getAutoNotifyMinTimeInterval' and count(parameter)=0]"
			[Register ("getAutoNotifyMinTimeInterval", "()I", "GetGetAutoNotifyMinTimeIntervalHandler")]
			get {
				const string __id = "getAutoNotifyMinTimeInterval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string CoorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getCoorType' and count(parameter)=0]"
			[Register ("getCoorType", "()Ljava/lang/String;", "GetGetCoorTypeHandler")]
			get {
				const string __id = "getCoorType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setCoorType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCoorType", "(Ljava/lang/String;)V", "GetSetCoorType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCoorType.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe bool IsDisableCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isDisableCache' and count(parameter)=0]"
			[Register ("isDisableCache", "()Z", "GetIsDisableCacheHandler")]
			get {
				const string __id = "isDisableCache.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool LocationNotify {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isLocationNotify' and count(parameter)=0]"
			[Register ("isLocationNotify", "()Z", "GetIsLocationNotifyHandler")]
			get {
				const string __id = "isLocationNotify.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setLocationNotify' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLocationNotify", "(Z)V", "GetSetLocationNotify_ZHandler")]
			set {
				const string __id = "setLocationNotify.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool OpenGps {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='isOpenGps' and count(parameter)=0]"
			[Register ("isOpenGps", "()Z", "GetIsOpenGpsHandler")]
			get {
				const string __id = "isOpenGps.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenGps' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOpenGps", "(Z)V", "GetSetOpenGps_ZHandler")]
			set {
				const string __id = "setOpenGps.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int Priority {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getPriority' and count(parameter)=0]"
			[Register ("getPriority", "()I", "GetGetPriorityHandler")]
			get {
				const string __id = "getPriority.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setPriority' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPriority", "(I)V", "GetSetPriority_IHandler")]
			set {
				const string __id = "setPriority.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string ProdName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getProdName' and count(parameter)=0]"
			[Register ("getProdName", "()Ljava/lang/String;", "GetGetProdNameHandler")]
			get {
				const string __id = "getProdName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setProdName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProdName", "(Ljava/lang/String;)V", "GetSetProdName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProdName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe int ScanSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getScanSpan' and count(parameter)=0]"
			[Register ("getScanSpan", "()I", "GetGetScanSpanHandler")]
			get {
				const string __id = "getScanSpan.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setScanSpan' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScanSpan", "(I)V", "GetSetScanSpan_IHandler")]
			set {
				const string __id = "setScanSpan.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe string ServiceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getServiceName' and count(parameter)=0]"
			[Register ("getServiceName", "()Ljava/lang/String;", "GetGetServiceNameHandler")]
			get {
				const string __id = "getServiceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceName", "(Ljava/lang/String;)V", "GetSetServiceName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServiceName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe int TimeOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getTimeOut' and count(parameter)=0]"
			[Register ("getTimeOut", "()I", "GetGetTimeOutHandler")]
			get {
				const string __id = "getTimeOut.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeOut", "(I)V", "GetSetTimeOut_IHandler")]
			set {
				const string __id = "setTimeOut.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='SetIgnoreCacheException' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("SetIgnoreCacheException", "(Z)V", "")]
		public unsafe void SetIgnoreCacheException (bool p0)
		{
			const string __id = "SetIgnoreCacheException.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='disableCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("disableCache", "(Z)V", "")]
		public unsafe void DisableCache (bool p0)
		{
			const string __id = "disableCache.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='getLocationMode' and count(parameter)=0]"
		[Register ("getLocationMode", "()Lcom/baidu/location/LocationClientOption$LocationMode;", "")]
		public unsafe global::Com.Baidu.Location.LocationClientOption.LocationMode GetLocationMode ()
		{
			const string __id = "getLocationMode.()Lcom/baidu/location/LocationClientOption$LocationMode;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.LocationClientOption.LocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='optionEquals' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption']]"
		[Register ("optionEquals", "(Lcom/baidu/location/LocationClientOption;)Z", "")]
		public unsafe bool OptionEquals (global::Com.Baidu.Location.LocationClientOption p0)
		{
			const string __id = "optionEquals.(Lcom/baidu/location/LocationClientOption;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setEnableSimulateGps' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableSimulateGps", "(Z)V", "")]
		public unsafe void SetEnableSimulateGps (bool p0)
		{
			const string __id = "setEnableSimulateGps.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIgnoreKillProcess' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIgnoreKillProcess", "(Z)V", "")]
		public unsafe void SetIgnoreKillProcess (bool p0)
		{
			const string __id = "setIgnoreKillProcess.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedAddress", "(Z)V", "")]
		public unsafe void SetIsNeedAddress (bool p0)
		{
			const string __id = "setIsNeedAddress.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedAltitude' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedAltitude", "(Z)V", "")]
		public unsafe void SetIsNeedAltitude (bool p0)
		{
			const string __id = "setIsNeedAltitude.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedLocationDescribe' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedLocationDescribe", "(Z)V", "")]
		public unsafe void SetIsNeedLocationDescribe (bool p0)
		{
			const string __id = "setIsNeedLocationDescribe.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setIsNeedLocationPoiList' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsNeedLocationPoiList", "(Z)V", "")]
		public unsafe void SetIsNeedLocationPoiList (bool p0)
		{
			const string __id = "setIsNeedLocationPoiList.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setLocationMode' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption.LocationMode']]"
		[Register ("setLocationMode", "(Lcom/baidu/location/LocationClientOption$LocationMode;)V", "")]
		public unsafe void SetLocationMode (global::Com.Baidu.Location.LocationClientOption.LocationMode p0)
		{
			const string __id = "setLocationMode.(Lcom/baidu/location/LocationClientOption$LocationMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setLocationPurpose' and count(parameter)=1 and parameter[1][@type='com.baidu.location.LocationClientOption.BDLocationPurpose']]"
		[Register ("setLocationPurpose", "(Lcom/baidu/location/LocationClientOption$BDLocationPurpose;)V", "")]
		public unsafe void SetLocationPurpose (global::Com.Baidu.Location.LocationClientOption.BDLocationPurpose p0)
		{
			const string __id = "setLocationPurpose.(Lcom/baidu/location/LocationClientOption$BDLocationPurpose;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setNeedDeviceDirect' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedDeviceDirect", "(Z)V", "")]
		public unsafe void SetNeedDeviceDirect (bool p0)
		{
			const string __id = "setNeedDeviceDirect.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setNeedNewVersionRgc' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNeedNewVersionRgc", "(Z)V", "")]
		public unsafe void SetNeedNewVersionRgc (bool p0)
		{
			const string __id = "setNeedNewVersionRgc.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenAutoNotifyMode' and count(parameter)=0]"
		[Register ("setOpenAutoNotifyMode", "()V", "")]
		public unsafe void SetOpenAutoNotifyMode ()
		{
			const string __id = "setOpenAutoNotifyMode.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setOpenAutoNotifyMode' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setOpenAutoNotifyMode", "(III)V", "")]
		public unsafe void SetOpenAutoNotifyMode (int p0, int p1, int p2)
		{
			const string __id = "setOpenAutoNotifyMode.(III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setSema' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setSema", "(ZZZ)V", "")]
		public unsafe void SetSema (bool p0, bool p1, bool p2)
		{
			const string __id = "setSema.(ZZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='LocationClientOption']/method[@name='setWifiCacheTimeOut' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setWifiCacheTimeOut", "(I)V", "")]
		public unsafe void SetWifiCacheTimeOut (int p0)
		{
			const string __id = "setWifiCacheTimeOut.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
