using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationData", DoNotGenerateAcw=true)]
	public partial class MyLocationData : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='accuracy']"
		[Register ("accuracy")]
		public float Accuracy {
			get {
				const string __id = "accuracy.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "accuracy.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='direction']"
		[Register ("direction")]
		public float Direction {
			get {
				const string __id = "direction.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "direction.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='latitude']"
		[Register ("latitude")]
		public double Latitude {
			get {
				const string __id = "latitude.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "latitude.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='longitude']"
		[Register ("longitude")]
		public double Longitude {
			get {
				const string __id = "longitude.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "longitude.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='satellitesNum']"
		[Register ("satellitesNum")]
		public int SatellitesNum {
			get {
				const string __id = "satellitesNum.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "satellitesNum.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData']/field[@name='speed']"
		[Register ("speed")]
		public float Speed {
			get {
				const string __id = "speed.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "speed.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MyLocationData$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MyLocationData$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/constructor[@name='MyLocationData.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_accuracy_F;
#pragma warning disable 0169
			static Delegate GetAccuracy_FHandler ()
			{
				if (cb_accuracy_F == null)
					cb_accuracy_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Accuracy_F);
				return cb_accuracy_F;
			}

			static IntPtr n_Accuracy_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Accuracy (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='accuracy' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("accuracy", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetAccuracy_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Accuracy (float p0)
			{
				const string __id = "accuracy.(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/MyLocationData;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData Build ()
			{
				const string __id = "build.()Lcom/baidu/mapapi/map/MyLocationData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_direction_F;
#pragma warning disable 0169
			static Delegate GetDirection_FHandler ()
			{
				if (cb_direction_F == null)
					cb_direction_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Direction_F);
				return cb_direction_F;
			}

			static IntPtr n_Direction_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Direction (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='direction' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("direction", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetDirection_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Direction (float p0)
			{
				const string __id = "direction.(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_latitude_D;
#pragma warning disable 0169
			static Delegate GetLatitude_DHandler ()
			{
				if (cb_latitude_D == null)
					cb_latitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Latitude_D);
				return cb_latitude_D;
			}

			static IntPtr n_Latitude_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Latitude (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='latitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("latitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetLatitude_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Latitude (double p0)
			{
				const string __id = "latitude.(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_longitude_D;
#pragma warning disable 0169
			static Delegate GetLongitude_DHandler ()
			{
				if (cb_longitude_D == null)
					cb_longitude_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Longitude_D);
				return cb_longitude_D;
			}

			static IntPtr n_Longitude_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Longitude (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='longitude' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("longitude", "(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetLongitude_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Longitude (double p0)
			{
				const string __id = "longitude.(D)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_satellitesNum_I;
#pragma warning disable 0169
			static Delegate GetSatellitesNum_IHandler ()
			{
				if (cb_satellitesNum_I == null)
					cb_satellitesNum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SatellitesNum_I);
				return cb_satellitesNum_I;
			}

			static IntPtr n_SatellitesNum_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SatellitesNum (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='satellitesNum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("satellitesNum", "(I)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetSatellitesNum_IHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder SatellitesNum (int p0)
			{
				const string __id = "satellitesNum.(I)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_speed_F;
#pragma warning disable 0169
			static Delegate GetSpeed_FHandler ()
			{
				if (cb_speed_F == null)
					cb_speed_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_Speed_F);
				return cb_speed_F;
			}

			static IntPtr n_Speed_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::Com.Baidu.Mapapi.Map.MyLocationData.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Speed (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MyLocationData.Builder']/method[@name='speed' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("speed", "(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;", "GetSpeed_FHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.MyLocationData.Builder Speed (float p0)
			{
				const string __id = "speed.(F)Lcom/baidu/mapapi/map/MyLocationData$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MyLocationData", typeof (MyLocationData));
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

		protected MyLocationData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
