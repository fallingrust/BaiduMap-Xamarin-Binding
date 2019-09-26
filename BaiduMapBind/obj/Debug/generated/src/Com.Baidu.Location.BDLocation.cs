using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']"
	[global::Android.Runtime.Register ("com/baidu/location/BDLocation", DoNotGenerateAcw=true)]
	public sealed partial class BDLocation : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_BD09LL_TO_GCJ02']"
		[Register ("BDLOCATION_BD09LL_TO_GCJ02")]
		public const string BdlocationBd09llToGcj02 = (string) "bd09ll2gcj";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_BD09_TO_GCJ02']"
		[Register ("BDLOCATION_BD09_TO_GCJ02")]
		public const string BdlocationBd09ToGcj02 = (string) "bd092gcj";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_GCJ02_TO_BD09']"
		[Register ("BDLOCATION_GCJ02_TO_BD09")]
		public const string BdlocationGcj02ToBd09 = (string) "bd09";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_GCJ02_TO_BD09LL']"
		[Register ("BDLOCATION_GCJ02_TO_BD09LL")]
		public const string BdlocationGcj02ToBd09ll = (string) "bd09ll";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='BDLOCATION_WGS84_TO_GCJ02']"
		[Register ("BDLOCATION_WGS84_TO_GCJ02")]
		public const string BdlocationWgs84ToGcj02 = (string) "gps2gcj";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_ACCURACY_BAD']"
		[Register ("GPS_ACCURACY_BAD")]
		public const int GpsAccuracyBad = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_ACCURACY_GOOD']"
		[Register ("GPS_ACCURACY_GOOD")]
		public const int GpsAccuracyGood = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_ACCURACY_MID']"
		[Register ("GPS_ACCURACY_MID")]
		public const int GpsAccuracyMid = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_ACCURACY_UNKNOWN']"
		[Register ("GPS_ACCURACY_UNKNOWN")]
		public const int GpsAccuracyUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_RECTIFY_INDOOR']"
		[Register ("GPS_RECTIFY_INDOOR")]
		public const int GpsRectifyIndoor = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_RECTIFY_NONE']"
		[Register ("GPS_RECTIFY_NONE")]
		public const int GpsRectifyNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='GPS_RECTIFY_OUTDOOR']"
		[Register ("GPS_RECTIFY_OUTDOOR")]
		public const int GpsRectifyOutdoor = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_NEARBY_SURPPORT_TRUE']"
		[Register ("INDOOR_LOCATION_NEARBY_SURPPORT_TRUE")]
		public const int IndoorLocationNearbySurpportTrue = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SOURCE_BLUETOOTH']"
		[Register ("INDOOR_LOCATION_SOURCE_BLUETOOTH")]
		public const int IndoorLocationSourceBluetooth = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SOURCE_MAGNETIC']"
		[Register ("INDOOR_LOCATION_SOURCE_MAGNETIC")]
		public const int IndoorLocationSourceMagnetic = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SOURCE_SMALLCELLSTATION']"
		[Register ("INDOOR_LOCATION_SOURCE_SMALLCELLSTATION")]
		public const int IndoorLocationSourceSmallcellstation = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SOURCE_UNKNOWN']"
		[Register ("INDOOR_LOCATION_SOURCE_UNKNOWN")]
		public const int IndoorLocationSourceUnknown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SOURCE_WIFI']"
		[Register ("INDOOR_LOCATION_SOURCE_WIFI")]
		public const int IndoorLocationSourceWifi = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SURPPORT_FALSE']"
		[Register ("INDOOR_LOCATION_SURPPORT_FALSE")]
		public const int IndoorLocationSurpportFalse = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_LOCATION_SURPPORT_TRUE']"
		[Register ("INDOOR_LOCATION_SURPPORT_TRUE")]
		public const int IndoorLocationSurpportTrue = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_NETWORK_STATE_HIGH']"
		[Register ("INDOOR_NETWORK_STATE_HIGH")]
		public const int IndoorNetworkStateHigh = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_NETWORK_STATE_LOW']"
		[Register ("INDOOR_NETWORK_STATE_LOW")]
		public const int IndoorNetworkStateLow = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='INDOOR_NETWORK_STATE_MIDDLE']"
		[Register ("INDOOR_NETWORK_STATE_MIDDLE")]
		public const int IndoorNetworkStateMiddle = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_IN_CN']"
		[Register ("LOCATION_WHERE_IN_CN")]
		public const int LocationWhereInCn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_OUT_CN']"
		[Register ("LOCATION_WHERE_OUT_CN")]
		public const int LocationWhereOutCn = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='LOCATION_WHERE_UNKNOW']"
		[Register ("LOCATION_WHERE_UNKNOW")]
		public const int LocationWhereUnknow = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_MOBILE']"
		[Register ("OPERATORS_TYPE_MOBILE")]
		public const int OperatorsTypeMobile = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_TELECOMU']"
		[Register ("OPERATORS_TYPE_TELECOMU")]
		public const int OperatorsTypeTelecomu = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_UNICOM']"
		[Register ("OPERATORS_TYPE_UNICOM")]
		public const int OperatorsTypeUnicom = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='OPERATORS_TYPE_UNKONW']"
		[Register ("OPERATORS_TYPE_UNKONW")]
		public const int OperatorsTypeUnkonw = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeCacheLocation']"
		[Register ("TypeCacheLocation")]
		public const int TypeCacheLocation = (int) 65;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeCriteriaException']"
		[Register ("TypeCriteriaException")]
		public const int TypeCriteriaException = (int) 62;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeGpsLocation']"
		[Register ("TypeGpsLocation")]
		public const int TypeGpsLocation = (int) 61;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNetWorkException']"
		[Register ("TypeNetWorkException")]
		public const int TypeNetWorkException = (int) 63;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNetWorkLocation']"
		[Register ("TypeNetWorkLocation")]
		public const int TypeNetWorkLocation = (int) 161;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeNone']"
		[Register ("TypeNone")]
		public const int TypeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocation']"
		[Register ("TypeOffLineLocation")]
		public const int TypeOffLineLocation = (int) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocationFail']"
		[Register ("TypeOffLineLocationFail")]
		public const int TypeOffLineLocationFail = (int) 67;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeOffLineLocationNetworkFail']"
		[Register ("TypeOffLineLocationNetworkFail")]
		public const int TypeOffLineLocationNetworkFail = (int) 68;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeServerCheckKeyError']"
		[Register ("TypeServerCheckKeyError")]
		public const int TypeServerCheckKeyError = (int) 505;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeServerDecryptError']"
		[Register ("TypeServerDecryptError")]
		public const int TypeServerDecryptError = (int) 162;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='TypeServerError']"
		[Register ("TypeServerError")]
		public const int TypeServerError = (int) 167;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='USER_INDDOR_TRUE']"
		[Register ("USER_INDDOR_TRUE")]
		public const int UserInddorTrue = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='USER_INDOOR_FALSE']"
		[Register ("USER_INDOOR_FALSE")]
		public const int UserIndoorFalse = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/field[@name='USER_INDOOR_UNKNOW']"
		[Register ("USER_INDOOR_UNKNOW")]
		public const int UserIndoorUnknow = (int) -1;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/BDLocation", typeof (BDLocation));
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

		internal BDLocation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BDLocation ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=1 and parameter[1][@type='com.baidu.location.BDLocation']]"
		[Register (".ctor", "(Lcom/baidu/location/BDLocation;)V", "")]
		public unsafe BDLocation (global::Com.Baidu.Location.BDLocation p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/location/BDLocation;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/constructor[@name='BDLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BDLocation (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public unsafe string AdCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAdCode' and count(parameter)=0]"
			[Register ("getAdCode", "()Ljava/lang/String;", "GetGetAdCodeHandler")]
			get {
				const string __id = "getAdCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string AddrStr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAddrStr' and count(parameter)=0]"
			[Register ("getAddrStr", "()Ljava/lang/String;", "GetGetAddrStrHandler")]
			get {
				const string __id = "getAddrStr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAddrStr' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAddrStr", "(Ljava/lang/String;)V", "GetSetAddrStr_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAddrStr.(Ljava/lang/String;)V";
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

		public unsafe global::Com.Baidu.Location.Address Address {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAddress' and count(parameter)=0]"
			[Register ("getAddress", "()Lcom/baidu/location/Address;", "GetGetAddressHandler")]
			get {
				const string __id = "getAddress.()Lcom/baidu/location/Address;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.Address> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe double Altitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getAltitude' and count(parameter)=0]"
			[Register ("getAltitude", "()D", "GetGetAltitudeHandler")]
			get {
				const string __id = "getAltitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAltitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setAltitude", "(D)V", "GetSetAltitude_DHandler")]
			set {
				const string __id = "setAltitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string BuildingID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getBuildingID' and count(parameter)=0]"
			[Register ("getBuildingID", "()Ljava/lang/String;", "GetGetBuildingIDHandler")]
			get {
				const string __id = "getBuildingID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setBuildingID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuildingID", "(Ljava/lang/String;)V", "GetSetBuildingID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBuildingID.(Ljava/lang/String;)V";
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

		public unsafe string BuildingName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getBuildingName' and count(parameter)=0]"
			[Register ("getBuildingName", "()Ljava/lang/String;", "GetGetBuildingNameHandler")]
			get {
				const string __id = "getBuildingName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setBuildingName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBuildingName", "(Ljava/lang/String;)V", "GetSetBuildingName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBuildingName.(Ljava/lang/String;)V";
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

		public unsafe string City {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCity' and count(parameter)=0]"
			[Register ("getCity", "()Ljava/lang/String;", "GetGetCityHandler")]
			get {
				const string __id = "getCity.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCityCode' and count(parameter)=0]"
			[Register ("getCityCode", "()Ljava/lang/String;", "GetGetCityCodeHandler")]
			get {
				const string __id = "getCityCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CoorType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCoorType' and count(parameter)=0]"
			[Register ("getCoorType", "()Ljava/lang/String;", "GetGetCoorTypeHandler")]
			get {
				const string __id = "getCoorType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setCoorType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		public unsafe string Country {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCountry' and count(parameter)=0]"
			[Register ("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")]
			get {
				const string __id = "getCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "GetGetCountryCodeHandler")]
			get {
				const string __id = "getCountryCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long DelayTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDelayTime' and count(parameter)=0]"
			[Register ("getDelayTime", "()J", "GetGetDelayTimeHandler")]
			get {
				const string __id = "getDelayTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setDelayTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDelayTime", "(J)V", "GetSetDelayTime_JHandler")]
			set {
				const string __id = "setDelayTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe float Derect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDerect' and count(parameter)=0]"
			[Register ("getDerect", "()F", "GetGetDerectHandler")]
			get {
				const string __id = "getDerect.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()F", "GetGetDirectionHandler")]
			get {
				const string __id = "getDirection.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDirection", "(F)V", "GetSetDirection_FHandler")]
			set {
				const string __id = "setDirection.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string District {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getDistrict' and count(parameter)=0]"
			[Register ("getDistrict", "()Ljava/lang/String;", "GetGetDistrictHandler")]
			get {
				const string __id = "getDistrict.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Floor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getFloor' and count(parameter)=0]"
			[Register ("getFloor", "()Ljava/lang/String;", "GetGetFloorHandler")]
			get {
				const string __id = "getFloor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setFloor' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFloor", "(Ljava/lang/String;)V", "GetSetFloor_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFloor.(Ljava/lang/String;)V";
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

		public unsafe int GpsAccuracyStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getGpsAccuracyStatus' and count(parameter)=0]"
			[Register ("getGpsAccuracyStatus", "()I", "GetGetGpsAccuracyStatusHandler")]
			get {
				const string __id = "getGpsAccuracyStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setGpsAccuracyStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGpsAccuracyStatus", "(I)V", "GetSetGpsAccuracyStatus_IHandler")]
			set {
				const string __id = "setGpsAccuracyStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int GpsCheckStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getGpsCheckStatus' and count(parameter)=0]"
			[Register ("getGpsCheckStatus", "()I", "GetGetGpsCheckStatusHandler")]
			get {
				const string __id = "getGpsCheckStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setGpsCheckStatus' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGpsCheckStatus", "(I)V", "GetSetGpsCheckStatus_IHandler")]
			set {
				const string __id = "setGpsCheckStatus.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool HasAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasAddr' and count(parameter)=0]"
			[Register ("hasAddr", "()Z", "GetHasAddrHandler")]
			get {
				const string __id = "hasAddr.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasAltitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasAltitude' and count(parameter)=0]"
			[Register ("hasAltitude", "()Z", "GetHasAltitudeHandler")]
			get {
				const string __id = "hasAltitude.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasRadius' and count(parameter)=0]"
			[Register ("hasRadius", "()Z", "GetHasRadiusHandler")]
			get {
				const string __id = "hasRadius.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasSateNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasSateNumber' and count(parameter)=0]"
			[Register ("hasSateNumber", "()Z", "GetHasSateNumberHandler")]
			get {
				const string __id = "hasSateNumber.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool HasSpeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='hasSpeed' and count(parameter)=0]"
			[Register ("hasSpeed", "()Z", "GetHasSpeedHandler")]
			get {
				const string __id = "hasSpeed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IndoorLocMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isIndoorLocMode' and count(parameter)=0]"
			[Register ("isIndoorLocMode", "()Z", "GetIsIndoorLocModeHandler")]
			get {
				const string __id = "isIndoorLocMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorLocMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIndoorLocMode", "(Z)V", "GetSetIndoorLocMode_ZHandler")]
			set {
				const string __id = "setIndoorLocMode.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int IndoorLocationSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorLocationSource' and count(parameter)=0]"
			[Register ("getIndoorLocationSource", "()I", "GetGetIndoorLocationSourceHandler")]
			get {
				const string __id = "getIndoorLocationSource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorLocationSource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndoorLocationSource", "(I)V", "GetSetIndoorLocationSource_IHandler")]
			set {
				const string __id = "setIndoorLocationSource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int IndoorLocationSurpport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorLocationSurpport' and count(parameter)=0]"
			[Register ("getIndoorLocationSurpport", "()I", "GetGetIndoorLocationSurpportHandler")]
			get {
				const string __id = "getIndoorLocationSurpport.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorLocationSurpport' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndoorLocationSurpport", "(I)V", "GetSetIndoorLocationSurpport_IHandler")]
			set {
				const string __id = "setIndoorLocationSurpport.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string IndoorLocationSurpportBuidlingID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorLocationSurpportBuidlingID' and count(parameter)=0]"
			[Register ("getIndoorLocationSurpportBuidlingID", "()Ljava/lang/String;", "GetGetIndoorLocationSurpportBuidlingIDHandler")]
			get {
				const string __id = "getIndoorLocationSurpportBuidlingID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string IndoorLocationSurpportBuidlingName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorLocationSurpportBuidlingName' and count(parameter)=0]"
			[Register ("getIndoorLocationSurpportBuidlingName", "()Ljava/lang/String;", "GetGetIndoorLocationSurpportBuidlingNameHandler")]
			get {
				const string __id = "getIndoorLocationSurpportBuidlingName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int IndoorNetworkState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorNetworkState' and count(parameter)=0]"
			[Register ("getIndoorNetworkState", "()I", "GetGetIndoorNetworkStateHandler")]
			get {
				const string __id = "getIndoorNetworkState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorNetworkState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIndoorNetworkState", "(I)V", "GetSetIndoorNetworkState_IHandler")]
			set {
				const string __id = "setIndoorNetworkState.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string IndoorSurpportPolygon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getIndoorSurpportPolygon' and count(parameter)=0]"
			[Register ("getIndoorSurpportPolygon", "()Ljava/lang/String;", "GetGetIndoorSurpportPolygonHandler")]
			get {
				const string __id = "getIndoorSurpportPolygon.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setIndoorSurpportPolygon' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIndoorSurpportPolygon", "(Ljava/lang/String;)V", "GetSetIndoorSurpportPolygon_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIndoorSurpportPolygon.(Ljava/lang/String;)V";
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

		public unsafe bool IsCellChangeFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isCellChangeFlag' and count(parameter)=0]"
			[Register ("isCellChangeFlag", "()Z", "GetIsCellChangeFlagHandler")]
			get {
				const string __id = "isCellChangeFlag.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsInIndoorPark {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isInIndoorPark' and count(parameter)=0]"
			[Register ("isInIndoorPark", "()Z", "GetIsInIndoorParkHandler")]
			get {
				const string __id = "isInIndoorPark.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsNrlAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isNrlAvailable' and count(parameter)=0]"
			[Register ("isNrlAvailable", "()Z", "GetIsNrlAvailableHandler")]
			get {
				const string __id = "isNrlAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLatitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLatitude", "(D)V", "GetSetLatitude_DHandler")]
			set {
				const string __id = "setLatitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int LocType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocType' and count(parameter)=0]"
			[Register ("getLocType", "()I", "GetGetLocTypeHandler")]
			get {
				const string __id = "getLocType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocType", "(I)V", "GetSetLocType_IHandler")]
			set {
				const string __id = "setLocType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string LocTypeDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocTypeDescription' and count(parameter)=0]"
			[Register ("getLocTypeDescription", "()Ljava/lang/String;", "GetGetLocTypeDescriptionHandler")]
			get {
				const string __id = "getLocTypeDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocTypeDescription' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocTypeDescription", "(Ljava/lang/String;)V", "GetSetLocTypeDescription_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocTypeDescription.(Ljava/lang/String;)V";
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

		public unsafe string LocationDescribe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocationDescribe' and count(parameter)=0]"
			[Register ("getLocationDescribe", "()Ljava/lang/String;", "GetGetLocationDescribeHandler")]
			get {
				const string __id = "getLocationDescribe.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocationDescribe' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocationDescribe", "(Ljava/lang/String;)V", "GetSetLocationDescribe_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocationDescribe.(Ljava/lang/String;)V";
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

		public unsafe string LocationID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocationID' and count(parameter)=0]"
			[Register ("getLocationID", "()Ljava/lang/String;", "GetGetLocationIDHandler")]
			get {
				const string __id = "getLocationID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocationID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLocationID", "(Ljava/lang/String;)V", "GetSetLocationID_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLocationID.(Ljava/lang/String;)V";
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

		public unsafe int LocationWhere {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLocationWhere' and count(parameter)=0]"
			[Register ("getLocationWhere", "()I", "GetGetLocationWhereHandler")]
			get {
				const string __id = "getLocationWhere.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLocationWhere' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLocationWhere", "(I)V", "GetSetLocationWhere_IHandler")]
			set {
				const string __id = "setLocationWhere.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setLongitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setLongitude", "(D)V", "GetSetLongitude_DHandler")]
			set {
				const string __id = "setLongitude.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string NetworkLocationType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getNetworkLocationType' and count(parameter)=0]"
			[Register ("getNetworkLocationType", "()Ljava/lang/String;", "GetGetNetworkLocationTypeHandler")]
			get {
				const string __id = "getNetworkLocationType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setNetworkLocationType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setNetworkLocationType", "(Ljava/lang/String;)V", "GetSetNetworkLocationType_Ljava_lang_String_Handler")]
			set {
				const string __id = "setNetworkLocationType.(Ljava/lang/String;)V";
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

		public unsafe double NrlLat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getNrlLat' and count(parameter)=0]"
			[Register ("getNrlLat", "()D", "GetGetNrlLatHandler")]
			get {
				const string __id = "getNrlLat.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double NrlLon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getNrlLon' and count(parameter)=0]"
			[Register ("getNrlLon", "()D", "GetGetNrlLonHandler")]
			get {
				const string __id = "getNrlLon.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string NrlResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getNrlResult' and count(parameter)=0]"
			[Register ("getNrlResult", "()Ljava/lang/String;", "GetGetNrlResultHandler")]
			get {
				const string __id = "getNrlResult.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Operators {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getOperators' and count(parameter)=0]"
			[Register ("getOperators", "()I", "GetGetOperatorsHandler")]
			get {
				const string __id = "getOperators.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setOperators' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setOperators", "(I)V", "GetSetOperators_IHandler")]
			set {
				const string __id = "setOperators.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Location.Poi> PoiList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getPoiList' and count(parameter)=0]"
			[Register ("getPoiList", "()Ljava/util/List;", "GetGetPoiListHandler")]
			get {
				const string __id = "getPoiList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Location.Poi>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setPoiList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.location.Poi&gt;']]"
			[Register ("setPoiList", "(Ljava/util/List;)V", "GetSetPoiList_Ljava_util_List_Handler")]
			set {
				const string __id = "setPoiList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Location.Poi>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::Com.Baidu.Location.PoiRegion PoiRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getPoiRegion' and count(parameter)=0]"
			[Register ("getPoiRegion", "()Lcom/baidu/location/PoiRegion;", "GetGetPoiRegionHandler")]
			get {
				const string __id = "getPoiRegion.()Lcom/baidu/location/PoiRegion;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Location.PoiRegion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setPoiRegion' and count(parameter)=1 and parameter[1][@type='com.baidu.location.PoiRegion']]"
			[Register ("setPoiRegion", "(Lcom/baidu/location/PoiRegion;)V", "GetSetPoiRegion_Lcom_baidu_location_PoiRegion_Handler")]
			set {
				const string __id = "setPoiRegion.(Lcom/baidu/location/PoiRegion;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string Province {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getProvince' and count(parameter)=0]"
			[Register ("getProvince", "()Ljava/lang/String;", "GetGetProvinceHandler")]
			get {
				const string __id = "getProvince.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
			set {
				const string __id = "setRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string RoadLocString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getRoadLocString' and count(parameter)=0]"
			[Register ("getRoadLocString", "()Ljava/lang/String;", "GetGetRoadLocStringHandler")]
			get {
				const string __id = "getRoadLocString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int SatelliteNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSatelliteNumber' and count(parameter)=0]"
			[Register ("getSatelliteNumber", "()I", "GetGetSatelliteNumberHandler")]
			get {
				const string __id = "getSatelliteNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setSatelliteNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSatelliteNumber", "(I)V", "GetSetSatelliteNumber_IHandler")]
			set {
				const string __id = "setSatelliteNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe string SemaAptag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSemaAptag' and count(parameter)=0]"
			[Register ("getSemaAptag", "()Ljava/lang/String;", "GetGetSemaAptagHandler")]
			get {
				const string __id = "getSemaAptag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe float Speed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getSpeed' and count(parameter)=0]"
			[Register ("getSpeed", "()F", "GetGetSpeedHandler")]
			get {
				const string __id = "getSpeed.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setSpeed' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpeed", "(F)V", "GetSetSpeed_FHandler")]
			set {
				const string __id = "setSpeed.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string Street {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getStreet' and count(parameter)=0]"
			[Register ("getStreet", "()Ljava/lang/String;", "GetGetStreetHandler")]
			get {
				const string __id = "getStreet.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string StreetNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getStreetNumber' and count(parameter)=0]"
			[Register ("getStreetNumber", "()Ljava/lang/String;", "GetGetStreetNumberHandler")]
			get {
				const string __id = "getStreetNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Time {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getTime' and count(parameter)=0]"
			[Register ("getTime", "()Ljava/lang/String;", "GetGetTimeHandler")]
			get {
				const string __id = "getTime.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTime", "(Ljava/lang/String;)V", "GetSetTime_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTime.(Ljava/lang/String;)V";
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

		public unsafe string Town {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getTown' and count(parameter)=0]"
			[Register ("getTown", "()Ljava/lang/String;", "GetGetTownHandler")]
			get {
				const string __id = "getTown.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int UserIndoorState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getUserIndoorState' and count(parameter)=0]"
			[Register ("getUserIndoorState", "()I", "GetGetUserIndoorStateHandler")]
			get {
				const string __id = "getUserIndoorState.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setUserIndoorState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setUserIndoorState", "(I)V", "GetSetUserIndoorState_IHandler")]
			set {
				const string __id = "setUserIndoorState.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string VdrJsonString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getVdrJsonString' and count(parameter)=0]"
			[Register ("getVdrJsonString", "()Ljava/lang/String;", "GetGetVdrJsonStringHandler")]
			get {
				const string __id = "getVdrJsonString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getExtraLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExtraLocation", "(Ljava/lang/String;)Landroid/location/Location;", "")]
		public unsafe global::Android.Locations.Location GetExtraLocation (string p0)
		{
			const string __id = "getExtraLocation.(Ljava/lang/String;)Landroid/location/Location;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Locations.Location> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getFusionLocInfo' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFusionLocInfo", "(Ljava/lang/String;)[D", "")]
		public unsafe double[] GetFusionLocInfo (string p0)
		{
			const string __id = "getFusionLocInfo.(Ljava/lang/String;)[D";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='getRetFields' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getRetFields", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string GetRetFields (string p0)
		{
			const string __id = "getRetFields.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='isParkAvailable' and count(parameter)=0]"
		[Register ("isParkAvailable", "()I", "")]
		public unsafe int IsParkAvailable ()
		{
			const string __id = "isParkAvailable.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setAddr' and count(parameter)=1 and parameter[1][@type='com.baidu.location.Address']]"
		[Register ("setAddr", "(Lcom/baidu/location/Address;)V", "")]
		public unsafe void SetAddr (global::Com.Baidu.Location.Address p0)
		{
			const string __id = "setAddr.(Lcom/baidu/location/Address;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setExtraLocation' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.location.Location']]"
		[Register ("setExtraLocation", "(Ljava/lang/String;Landroid/location/Location;)V", "")]
		public unsafe void SetExtraLocation (string p0, global::Android.Locations.Location p1)
		{
			const string __id = "setExtraLocation.(Ljava/lang/String;Landroid/location/Location;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setFusionLocInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='double[]']]"
		[Register ("setFusionLocInfo", "(Ljava/lang/String;[D)V", "")]
		public unsafe void SetFusionLocInfo (string p0, double[] p1)
		{
			const string __id = "setFusionLocInfo.(Ljava/lang/String;[D)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setNrlData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNrlData", "(Ljava/lang/String;)V", "")]
		public unsafe void SetNrlData (string p0)
		{
			const string __id = "setNrlData.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setParkAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setParkAvailable", "(I)V", "")]
		public unsafe void SetParkAvailable (int p0)
		{
			const string __id = "setParkAvailable.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setRetFields' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setRetFields", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void SetRetFields (string p0, string p1)
		{
			const string __id = "setRetFields.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setRoadLocString' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setRoadLocString", "(FF)V", "")]
		public unsafe void SetRoadLocString (float p0, float p1)
		{
			const string __id = "setRoadLocString.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='setVdrJsonValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setVdrJsonValue", "(Ljava/lang/String;)V", "")]
		public unsafe void SetVdrJsonValue (string p0)
		{
			const string __id = "setVdrJsonValue.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='BDLocation']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
