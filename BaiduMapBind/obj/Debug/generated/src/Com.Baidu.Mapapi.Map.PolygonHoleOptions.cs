using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonHoleOptions']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/PolygonHoleOptions", DoNotGenerateAcw=true)]
	public partial class PolygonHoleOptions : global::Com.Baidu.Mapapi.Map.HoleOptions {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/PolygonHoleOptions", typeof (PolygonHoleOptions));
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

		protected PolygonHoleOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonHoleOptions']/constructor[@name='PolygonHoleOptions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PolygonHoleOptions ()
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

		static Delegate cb_getHolePoints;
#pragma warning disable 0169
		static Delegate GetGetHolePointsHandler ()
		{
			if (cb_getHolePoints == null)
				cb_getHolePoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHolePoints);
			return cb_getHolePoints;
		}

		static IntPtr n_GetHolePoints (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.PolygonHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (__this.HolePoints);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> HolePoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonHoleOptions']/method[@name='getHolePoints' and count(parameter)=0]"
			[Register ("getHolePoints", "()Ljava/util/List;", "GetGetHolePointsHandler")]
			get {
				const string __id = "getHolePoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addPoints_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddPoints_Ljava_util_List_Handler ()
		{
			if (cb_addPoints_Ljava_util_List_ == null)
				cb_addPoints_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPoints_Ljava_util_List_);
			return cb_addPoints_Ljava_util_List_;
		}

		static IntPtr n_AddPoints_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.PolygonHoleOptions __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonHoleOptions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPoints (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='PolygonHoleOptions']/method[@name='addPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
		[Register ("addPoints", "(Ljava/util/List;)Lcom/baidu/mapapi/map/PolygonHoleOptions;", "GetAddPoints_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.PolygonHoleOptions AddPoints (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> p0)
		{
			const string __id = "addPoints.(Ljava/util/List;)Lcom/baidu/mapapi/map/PolygonHoleOptions;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.PolygonHoleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
