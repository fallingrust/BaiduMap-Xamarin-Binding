using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/CircleHoleOptions", DoNotGenerateAcw=true)]
	public partial class CircleHoleOptions : global::Com.Baidu.Mapapi.Map.HoleOptions {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/CircleHoleOptions", typeof (CircleHoleOptions));
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

		protected CircleHoleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']/constructor[@name='CircleHoleOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CircleHoleOptions ()
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

		static Delegate cb_getHoleCenter;
#pragma warning disable 0169
		static Delegate GetGetHoleCenterHandler ()
		{
			if (cb_getHoleCenter == null)
				cb_getHoleCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHoleCenter);
			return cb_getHoleCenter;
		}

		static IntPtr n_GetHoleCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.CircleHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HoleCenter);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng HoleCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']/method[@name='getHoleCenter' and count(parameter)=0]"
			[Register ("getHoleCenter", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetHoleCenterHandler")]
			get {
				const string __id = "getHoleCenter.()Lcom/baidu/mapapi/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHoleRadius;
#pragma warning disable 0169
		static Delegate GetGetHoleRadiusHandler ()
		{
			if (cb_getHoleRadius == null)
				cb_getHoleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHoleRadius);
			return cb_getHoleRadius;
		}

		static int n_GetHoleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.CircleHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HoleRadius;
		}
#pragma warning restore 0169

		public virtual unsafe int HoleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']/method[@name='getHoleRadius' and count(parameter)=0]"
			[Register ("getHoleRadius", "()I", "GetGetHoleRadiusHandler")]
			get {
				const string __id = "getHoleRadius.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_center_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetCenter_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_center_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_center_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Center_Lcom_baidu_mapapi_model_LatLng_);
			return cb_center_Lcom_baidu_mapapi_model_LatLng_;
		}

		static IntPtr n_Center_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.CircleHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Center (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']/method[@name='center' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("center", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/CircleHoleOptions;", "GetCenter_Lcom_baidu_mapapi_model_LatLng_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.CircleHoleOptions Center (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "center.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/CircleHoleOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Baidu.Mapapi.Map.CircleHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Radius (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='CircleHoleOptions']/method[@name='radius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("radius", "(I)Lcom/baidu/mapapi/map/CircleHoleOptions;", "GetRadius_IHandler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.CircleHoleOptions Radius (int p0)
		{
			const string __id = "radius.(I)Lcom/baidu/mapapi/map/CircleHoleOptions;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.CircleHoleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
