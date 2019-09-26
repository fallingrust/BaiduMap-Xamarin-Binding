using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationConfiguration", DoNotGenerateAcw=true)]
	public partial class MyLocationConfiguration : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='accuracyCircleFillColor']"
		[Register ("accuracyCircleFillColor")]
		public int AccuracyCircleFillColor {
			get {
				const string __id = "accuracyCircleFillColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "accuracyCircleFillColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='accuracyCircleStrokeColor']"
		[Register ("accuracyCircleStrokeColor")]
		public int AccuracyCircleStrokeColor {
			get {
				const string __id = "accuracyCircleStrokeColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "accuracyCircleStrokeColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='customMarker']"
		[Register ("customMarker")]
		public global::Com.Baidu.Mapapi.Map.BitmapDescriptor CustomMarker {
			get {
				const string __id = "customMarker.Lcom/baidu/mapapi/map/BitmapDescriptor;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "customMarker.Lcom/baidu/mapapi/map/BitmapDescriptor;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/field[@name='enableDirection']"
		[Register ("enableDirection")]
		public bool EnableDirection {
			get {
				const string __id = "enableDirection.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "enableDirection.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationConfiguration$LocationMode", DoNotGenerateAcw=true)]
		public sealed partial class LocationMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='COMPASS']"
			[Register ("COMPASS")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Compass {
				get {
					const string __id = "COMPASS.Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='FOLLOWING']"
			[Register ("FOLLOWING")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Following {
				get {
					const string __id = "FOLLOWING.Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode Normal {
				get {
					const string __id = "NORMAL.Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MyLocationConfiguration$LocationMode", typeof (LocationMode));
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration.LocationMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MyLocationConfiguration", typeof (MyLocationConfiguration));
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

		protected MyLocationConfiguration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/constructor[@name='MyLocationConfiguration' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration.LocationMode'] and parameter[2][@type='boolean'] and parameter[3][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V", "")]
		public unsafe MyLocationConfiguration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode p0, bool p1, global::Com.Baidu.Mapapi.Map.BitmapDescriptor p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationConfiguration']/constructor[@name='MyLocationConfiguration' and count(parameter)=5 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration.LocationMode'] and parameter[2][@type='boolean'] and parameter[3][@type='com.baidu.mapapi.map.BitmapDescriptor'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V", "")]
		public unsafe MyLocationConfiguration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration.LocationMode p0, bool p1, global::Com.Baidu.Mapapi.Map.BitmapDescriptor p2, int p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/mapapi/map/MyLocationConfiguration$LocationMode;ZLcom/baidu/mapapi/map/BitmapDescriptor;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
