using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/TextureMapFragment", DoNotGenerateAcw=true)]
	public partial class TextureMapFragment : global::Android.App.Fragment {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/TextureMapFragment", typeof (TextureMapFragment));
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

		protected TextureMapFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/constructor[@name='TextureMapFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextureMapFragment ()
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

		static Delegate cb_getBaiduMap;
#pragma warning disable 0169
		static Delegate GetGetBaiduMapHandler ()
		{
			if (cb_getBaiduMap == null)
				cb_getBaiduMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaiduMap);
			return cb_getBaiduMap;
		}

		static IntPtr n_GetBaiduMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.TextureMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaiduMap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Map.BaiduMap BaiduMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='getBaiduMap' and count(parameter)=0]"
			[Register ("getBaiduMap", "()Lcom/baidu/mapapi/map/BaiduMap;", "GetGetBaiduMapHandler")]
			get {
				const string __id = "getBaiduMap.()Lcom/baidu/mapapi/map/BaiduMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapView;
#pragma warning disable 0169
		static Delegate GetGetMapViewHandler ()
		{
			if (cb_getMapView == null)
				cb_getMapView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapView);
			return cb_getMapView;
		}

		static IntPtr n_GetMapView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.TextureMapFragment __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Map.TextureMapView MapView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='getMapView' and count(parameter)=0]"
			[Register ("getMapView", "()Lcom/baidu/mapapi/map/TextureMapView;", "GetGetMapViewHandler")]
			get {
				const string __id = "getMapView.()Lcom/baidu/mapapi/map/TextureMapView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='newInstance' and count(parameter)=0]"
		[Register ("newInstance", "()Lcom/baidu/mapapi/map/TextureMapFragment;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.TextureMapFragment NewInstance ()
		{
			const string __id = "newInstance.()Lcom/baidu/mapapi/map/TextureMapFragment;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='TextureMapFragment']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register ("newInstance", "(Lcom/baidu/mapapi/map/BaiduMapOptions;)Lcom/baidu/mapapi/map/TextureMapFragment;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.TextureMapFragment NewInstance (global::Com.Baidu.Mapapi.Map.BaiduMapOptions p0)
		{
			const string __id = "newInstance.(Lcom/baidu/mapapi/map/BaiduMapOptions;)Lcom/baidu/mapapi/map/TextureMapFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TextureMapFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
