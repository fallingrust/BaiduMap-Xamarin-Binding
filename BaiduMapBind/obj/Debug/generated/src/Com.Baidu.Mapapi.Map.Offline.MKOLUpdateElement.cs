using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOLUpdateElement", DoNotGenerateAcw=true)]
	public partial class MKOLUpdateElement : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='DOWNLOADING']"
		[Register ("DOWNLOADING")]
		public const int Downloading = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='FINISHED']"
		[Register ("FINISHED")]
		public const int Finished = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='SUSPENDED']"
		[Register ("SUSPENDED")]
		public const int Suspended = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='UNDEFINED']"
		[Register ("UNDEFINED")]
		public const int Undefined = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='WAITING']"
		[Register ("WAITING")]
		public const int Waiting = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='cityID']"
		[Register ("cityID")]
		public int CityID {
			get {
				const string __id = "cityID.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cityID.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='cityName']"
		[Register ("cityName")]
		public string CityName {
			get {
				const string __id = "cityName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cityName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSFormatError']"
		[Register ("eOLDSFormatError")]
		public const int EOLDSFormatError = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSIOError']"
		[Register ("eOLDSIOError")]
		public const int EOLDSIOError = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSInstalling']"
		[Register ("eOLDSInstalling")]
		public const int EOLDSInstalling = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSMd5Error']"
		[Register ("eOLDSMd5Error")]
		public const int EOLDSMd5Error = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSNetError']"
		[Register ("eOLDSNetError")]
		public const int EOLDSNetError = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='eOLDSWifiError']"
		[Register ("eOLDSWifiError")]
		public const int EOLDSWifiError = (int) 8;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='geoPt']"
		[Register ("geoPt")]
		public global::Com.Baidu.Mapapi.Model.LatLng GeoPt {
			get {
				const string __id = "geoPt.Lcom/baidu/mapapi/model/LatLng;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "geoPt.Lcom/baidu/mapapi/model/LatLng;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='level']"
		[Register ("level")]
		public int Level {
			get {
				const string __id = "level.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "level.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='ratio']"
		[Register ("ratio")]
		public int Ratio {
			get {
				const string __id = "ratio.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ratio.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='serversize']"
		[Register ("serversize")]
		public int Serversize {
			get {
				const string __id = "serversize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "serversize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='size']"
		[Register ("size")]
		public int Size {
			get {
				const string __id = "size.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "size.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='status']"
		[Register ("status")]
		public int Status {
			get {
				const string __id = "status.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "status.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/field[@name='update']"
		[Register ("update")]
		public bool Update {
			get {
				const string __id = "update.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "update.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/offline/MKOLUpdateElement", typeof (MKOLUpdateElement));
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

		protected MKOLUpdateElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLUpdateElement']/constructor[@name='MKOLUpdateElement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKOLUpdateElement ()
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

	}
}
