using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/HeatMap", DoNotGenerateAcw=true)]
	public partial class HeatMap : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_GRADIENT']"
		[Register ("DEFAULT_GRADIENT")]
		public static global::Com.Baidu.Mapapi.Map.Gradient DefaultGradient {
			get {
				const string __id = "DEFAULT_GRADIENT.Lcom/baidu/mapapi/map/Gradient;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Gradient> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_OPACITY']"
		[Register ("DEFAULT_OPACITY")]
		public const double DefaultOpacity = (double) 0.6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/field[@name='DEFAULT_RADIUS']"
		[Register ("DEFAULT_RADIUS")]
		public const int DefaultRadius = (int) 12;
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/HeatMap$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/HeatMap$Builder", typeof (Builder));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/constructor[@name='HeatMap.Builder' and count(parameter)=0]"
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
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/baidu/mapapi/map/HeatMap;", "GetBuildHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap Build ()
			{
				const string __id = "build.()Lcom/baidu/mapapi/map/HeatMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_data_Ljava_util_Collection_;
#pragma warning disable 0169
			static Delegate GetData_Ljava_util_Collection_Handler ()
			{
				if (cb_data_Ljava_util_Collection_ == null)
					cb_data_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Data_Ljava_util_Collection_);
				return cb_data_Ljava_util_Collection_;
			}

			static IntPtr n_Data_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaCollection<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Data (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='data' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("data", "(Ljava/util/Collection;)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetData_Ljava_util_Collection_Handler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Data (global::System.Collections.Generic.ICollection<global::Com.Baidu.Mapapi.Model.LatLng> p0)
			{
				const string __id = "data.(Ljava/util/Collection;)Lcom/baidu/mapapi/map/HeatMap$Builder;";
				IntPtr native_p0 = global::Android.Runtime.JavaCollection<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_gradient_Lcom_baidu_mapapi_map_Gradient_;
#pragma warning disable 0169
			static Delegate GetGradient_Lcom_baidu_mapapi_map_Gradient_Handler ()
			{
				if (cb_gradient_Lcom_baidu_mapapi_map_Gradient_ == null)
					cb_gradient_Lcom_baidu_mapapi_map_Gradient_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Gradient_Lcom_baidu_mapapi_map_Gradient_);
				return cb_gradient_Lcom_baidu_mapapi_map_Gradient_;
			}

			static IntPtr n_Gradient_Lcom_baidu_mapapi_map_Gradient_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Gradient p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Gradient> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Gradient (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='gradient' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Gradient']]"
			[Register ("gradient", "(Lcom/baidu/mapapi/map/Gradient;)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetGradient_Lcom_baidu_mapapi_map_Gradient_Handler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Gradient (global::Com.Baidu.Mapapi.Map.Gradient p0)
			{
				const string __id = "gradient.(Lcom/baidu/mapapi/map/Gradient;)Lcom/baidu/mapapi/map/HeatMap$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_opacity_D;
#pragma warning disable 0169
			static Delegate GetOpacity_DHandler ()
			{
				if (cb_opacity_D == null)
					cb_opacity_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Opacity_D);
				return cb_opacity_D;
			}

			static IntPtr n_Opacity_D (IntPtr jnienv, IntPtr native__this, double p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Opacity (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='opacity' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("opacity", "(D)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetOpacity_DHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Opacity (double p0)
			{
				const string __id = "opacity.(D)Lcom/baidu/mapapi/map/HeatMap$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_radius_I;
#pragma warning disable 0169
			static Delegate GetRadius_IHandler ()
			{
				if (cb_radius_I == null)
					cb_radius_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Radius_I);
				return cb_radius_I;
			}

			static IntPtr n_Radius_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Baidu.Mapapi.Map.HeatMap.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Radius (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap.Builder']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("radius", "(I)Lcom/baidu/mapapi/map/HeatMap$Builder;", "GetRadius_IHandler")]
			public virtual unsafe global::Com.Baidu.Mapapi.Map.HeatMap.Builder Radius (int p0)
			{
				const string __id = "radius.(I)Lcom/baidu/mapapi/map/HeatMap$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/HeatMap", typeof (HeatMap));
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

		protected HeatMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_removeHeatMap;
#pragma warning disable 0169
		static Delegate GetRemoveHeatMapHandler ()
		{
			if (cb_removeHeatMap == null)
				cb_removeHeatMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveHeatMap);
			return cb_removeHeatMap;
		}

		static void n_RemoveHeatMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.HeatMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveHeatMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='HeatMap']/method[@name='removeHeatMap' and count(parameter)=0]"
		[Register ("removeHeatMap", "()V", "GetRemoveHeatMapHandler")]
		public virtual unsafe void RemoveHeatMap ()
		{
			const string __id = "removeHeatMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
