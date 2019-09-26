using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map.Offline {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/offline/MKOLSearchRecord", DoNotGenerateAcw=true)]
	public partial class MKOLSearchRecord : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='childCities']"
		[Register ("childCities")]
		public global::System.Collections.IList ChildCities {
			get {
				const string __id = "childCities.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "childCities.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityID']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityName']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='cityType']"
		[Register ("cityType")]
		public int CityType {
			get {
				const string __id = "cityType.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "cityType.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='dataSize']"
		[Register ("dataSize")]
		public long DataSize {
			get {
				const string __id = "dataSize.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "dataSize.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/field[@name='size']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/offline/MKOLSearchRecord", typeof (MKOLSearchRecord));
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

		protected MKOLSearchRecord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map.offline']/class[@name='MKOLSearchRecord']/constructor[@name='MKOLSearchRecord' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MKOLSearchRecord ()
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
