using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap", DoNotGenerateAcw=true)]
	public partial class BaiduMap : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_NONE']"
		[Register ("MAP_TYPE_NONE")]
		public const int MapTypeNone = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_NORMAL']"
		[Register ("MAP_TYPE_NORMAL")]
		public const int MapTypeNormal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='MAP_TYPE_SATELLITE']"
		[Register ("MAP_TYPE_SATELLITE")]
		public const int MapTypeSatellite = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/field[@name='mapStatusReason']"
		[Register ("mapStatusReason")]
		public static int MapStatusReason {
			get {
				const string __id = "mapStatusReason.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "mapStatusReason.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnBaseIndoorMapListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnBaseIndoorMapListenerInvoker")]
		public partial interface IOnBaseIndoorMapListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnBaseIndoorMapListener']/method[@name='onBaseIndoorMapMode' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='com.baidu.mapapi.map.MapBaseIndoorMapInfo']]"
			[Register ("onBaseIndoorMapMode", "(ZLcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V", "GetOnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnBaseIndoorMapListenerInvoker, BaiduMapBind")]
			void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener", DoNotGenerateAcw=true)]
		internal class IOnBaseIndoorMapListenerInvoker : global::Java.Lang.Object, IOnBaseIndoorMapListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener", typeof (IOnBaseIndoorMapListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnBaseIndoorMapListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnBaseIndoorMapListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnBaseIndoorMapListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
#pragma warning disable 0169
			static Delegate GetOnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_Handler ()
			{
				if (cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ == null)
					cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, IntPtr>) n_OnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_);
				return cb_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
			}

			static void n_OnBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnBaseIndoorMapMode (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_;
			public unsafe void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				if (id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ == IntPtr.Zero)
					id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_ = JNIEnv.GetMethodID (class_ref, "onBaseIndoorMapMode", "(ZLcom/baidu/mapapi/map/MapBaseIndoorMapInfo;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBaseIndoorMapMode_ZLcom_baidu_mapapi_map_MapBaseIndoorMapInfo_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener.onBaseIndoorMapMode
		public partial class BaseIndoorMapEventArgs : global::System.EventArgs {

			public BaseIndoorMapEventArgs (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}

			global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1;
			public global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnBaseIndoorMapListenerImplementor")]
		internal sealed partial class IOnBaseIndoorMapListenerImplementor : global::Java.Lang.Object, IOnBaseIndoorMapListener {

			object sender;

			public IOnBaseIndoorMapListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnBaseIndoorMapListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<BaseIndoorMapEventArgs> Handler;
#pragma warning restore 0649

			public void OnBaseIndoorMapMode (bool p0, global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo p1)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new BaseIndoorMapEventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnBaseIndoorMapListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker")]
		public partial interface IOnMapClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, BaiduMapBind")]
			void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapClickListener']/method[@name='onMapPoiClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapPoi']]"
			[Register ("onMapPoiClick", "(Lcom/baidu/mapapi/map/MapPoi;)V", "GetOnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapClickListenerInvoker, BaiduMapBind")]
			void OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapClickListenerInvoker : global::Java.Lang.Object, IOnMapClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapClickListener", typeof (IOnMapClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

			static Delegate cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
#pragma warning disable 0169
			static Delegate GetOnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_Handler ()
			{
				if (cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ == null)
					cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_);
				return cb_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
			}

			static void n_OnMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapPoi p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapPoi> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapPoiClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_;
			public unsafe void OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				if (id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ == IntPtr.Zero)
					id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_ = JNIEnv.GetMethodID (class_ref, "onMapPoiClick", "(Lcom/baidu/mapapi/map/MapPoi;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapPoiClick_Lcom_baidu_mapapi_map_MapPoi_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapClickListener.onMapClick
		public partial class MapClickEventArgs : global::System.EventArgs {

			public MapClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapClickListener.onMapPoiClick
		public partial class MapPoiClickEventArgs : global::System.EventArgs {

			public MapPoiClickEventArgs (global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapPoi p0;
			public global::Com.Baidu.Mapapi.Map.MapPoi P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapClickListenerImplementor")]
		internal sealed partial class IOnMapClickListenerImplementor : global::Java.Lang.Object, IOnMapClickListener {

			object sender;

			public IOnMapClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapClickEventArgs> OnMapClickHandler;
#pragma warning restore 0649

			public void OnMapClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = OnMapClickHandler;
				if (__h != null)
					__h (sender, new MapClickEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapPoiClickEventArgs> OnMapPoiClickHandler;
#pragma warning restore 0649

			public void OnMapPoiClick (global::Com.Baidu.Mapapi.Map.MapPoi p0)
			{
				var __h = OnMapPoiClickHandler;
				if (__h != null)
					__h (sender, new MapPoiClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapClickListenerImplementor value)
			{
				return value.OnMapClickHandler == null && value.OnMapPoiClickHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDoubleClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDoubleClickListenerInvoker")]
		public partial interface IOnMapDoubleClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDoubleClickListener']/method[@name='onMapDoubleClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapDoubleClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDoubleClickListenerInvoker, BaiduMapBind")]
			void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapDoubleClickListenerInvoker : global::Java.Lang.Object, IOnMapDoubleClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener", typeof (IOnMapDoubleClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapDoubleClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapDoubleClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapDoubleClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDoubleClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapDoubleClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDoubleClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener.onMapDoubleClick
		public partial class MapDoubleClickEventArgs : global::System.EventArgs {

			public MapDoubleClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapDoubleClickListenerImplementor")]
		internal sealed partial class IOnMapDoubleClickListenerImplementor : global::Java.Lang.Object, IOnMapDoubleClickListener {

			object sender;

			public IOnMapDoubleClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapDoubleClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapDoubleClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapDoubleClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapDoubleClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapDoubleClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker")]
		public partial interface IOnMapDrawFrameCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']/method[@name='onMapDrawFrame' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapDrawFrame", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker, BaiduMapBind")]
			void OnMapDrawFrame (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapDrawFrameCallback']/method[@name='onMapDrawFrame' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='com.baidu.mapapi.map.MapStatus']]"
[Obsolete (@"deprecated")]
			[Register ("onMapDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapDrawFrameCallbackInvoker, BaiduMapBind")]
			void OnMapDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Com.Baidu.Mapapi.Map.MapStatus p1);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback", DoNotGenerateAcw=true)]
		internal class IOnMapDrawFrameCallbackInvoker : global::Java.Lang.Object, IOnMapDrawFrameCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback", typeof (IOnMapDrawFrameCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapDrawFrameCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapDrawFrameCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapDrawFrameCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapDrawFrameCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDrawFrame (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapDrawFrame (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapDrawFrame", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDrawFrame_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Javax.Microedition.Khronos.Opengles.IGL10 p0 = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnMapDrawFrame (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 p0, global::Com.Baidu.Mapapi.Map.MapStatus p1)
			{
				if (id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLoadedCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLoadedCallbackInvoker")]
		public partial interface IOnMapLoadedCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLoadedCallback']/method[@name='onMapLoaded' and count(parameter)=0]"
			[Register ("onMapLoaded", "()V", "GetOnMapLoadedHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLoadedCallbackInvoker, BaiduMapBind")]
			void OnMapLoaded ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback", DoNotGenerateAcw=true)]
		internal class IOnMapLoadedCallbackInvoker : global::Java.Lang.Object, IOnMapLoadedCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback", typeof (IOnMapLoadedCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapLoadedCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLoadedCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapLoadedCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLoadedCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLoaded;
#pragma warning disable 0169
			static Delegate GetOnMapLoadedHandler ()
			{
				if (cb_onMapLoaded == null)
					cb_onMapLoaded = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapLoaded);
				return cb_onMapLoaded;
			}

			static void n_OnMapLoaded (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLoaded ();
			}
#pragma warning restore 0169

			IntPtr id_onMapLoaded;
			public unsafe void OnMapLoaded ()
			{
				if (id_onMapLoaded == IntPtr.Zero)
					id_onMapLoaded = JNIEnv.GetMethodID (class_ref, "onMapLoaded", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLoaded);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLongClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLongClickListenerInvoker")]
		public partial interface IOnMapLongClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapLongClickListener']/method[@name='onMapLongClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("onMapLongClick", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetOnMapLongClick_Lcom_baidu_mapapi_model_LatLng_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapLongClickListenerInvoker, BaiduMapBind")]
			void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener", DoNotGenerateAcw=true)]
		internal class IOnMapLongClickListenerInvoker : global::Java.Lang.Object, IOnMapLongClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapLongClickListener", typeof (IOnMapLongClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapLongClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapLongClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapLongClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetOnMapLongClick_Lcom_baidu_mapapi_model_LatLng_Handler ()
			{
				if (cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ == null)
					cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapLongClick_Lcom_baidu_mapapi_model_LatLng_);
				return cb_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
			}

			static void n_OnMapLongClick_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapLongClick (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_;
			public unsafe void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				if (id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ == IntPtr.Zero)
					id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapLongClick", "(Lcom/baidu/mapapi/model/LatLng;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapLongClick_Lcom_baidu_mapapi_model_LatLng_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener.onMapLongClick
		public partial class MapLongClickEventArgs : global::System.EventArgs {

			public MapLongClickEventArgs (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Model.LatLng p0;
			public global::Com.Baidu.Mapapi.Model.LatLng P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapLongClickListenerImplementor")]
		internal sealed partial class IOnMapLongClickListenerImplementor : global::Java.Lang.Object, IOnMapLongClickListener {

			object sender;

			public IOnMapLongClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapLongClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapLongClickEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapLongClick (global::Com.Baidu.Mapapi.Model.LatLng p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapLongClickEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapLongClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderCallbackInvoker")]
		public partial interface IOnMapRenderCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderCallback']/method[@name='onMapRenderFinished' and count(parameter)=0]"
			[Register ("onMapRenderFinished", "()V", "GetOnMapRenderFinishedHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderCallbackInvoker, BaiduMapBind")]
			void OnMapRenderFinished ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback", DoNotGenerateAcw=true)]
		internal class IOnMapRenderCallbackInvoker : global::Java.Lang.Object, IOnMapRenderCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapRenderCallback", typeof (IOnMapRenderCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapRenderCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapRenderCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapRenderCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapRenderCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapRenderFinished;
#pragma warning disable 0169
			static Delegate GetOnMapRenderFinishedHandler ()
			{
				if (cb_onMapRenderFinished == null)
					cb_onMapRenderFinished = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMapRenderFinished);
				return cb_onMapRenderFinished;
			}

			static void n_OnMapRenderFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapRenderFinished ();
			}
#pragma warning restore 0169

			IntPtr id_onMapRenderFinished;
			public unsafe void OnMapRenderFinished ()
			{
				if (id_onMapRenderFinished == IntPtr.Zero)
					id_onMapRenderFinished = JNIEnv.GetMethodID (class_ref, "onMapRenderFinished", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapRenderFinished);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderValidDataListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderValidDataListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderValidDataListenerInvoker")]
		public partial interface IOnMapRenderValidDataListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapRenderValidDataListener']/method[@name='onMapRenderValidData' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
			[Register ("onMapRenderValidData", "(ZILjava/lang/String;)V", "GetOnMapRenderValidData_ZILjava_lang_String_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapRenderValidDataListenerInvoker, BaiduMapBind")]
			void OnMapRenderValidData (bool p0, int p1, string p2);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapRenderValidDataListener", DoNotGenerateAcw=true)]
		internal class IOnMapRenderValidDataListenerInvoker : global::Java.Lang.Object, IOnMapRenderValidDataListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapRenderValidDataListener", typeof (IOnMapRenderValidDataListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapRenderValidDataListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapRenderValidDataListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapRenderValidDataListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapRenderValidDataListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapRenderValidData_ZILjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnMapRenderValidData_ZILjava_lang_String_Handler ()
			{
				if (cb_onMapRenderValidData_ZILjava_lang_String_ == null)
					cb_onMapRenderValidData_ZILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, IntPtr>) n_OnMapRenderValidData_ZILjava_lang_String_);
				return cb_onMapRenderValidData_ZILjava_lang_String_;
			}

			static void n_OnMapRenderValidData_ZILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, int p1, IntPtr native_p2)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnMapRenderValidData (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onMapRenderValidData_ZILjava_lang_String_;
			public unsafe void OnMapRenderValidData (bool p0, int p1, string p2)
			{
				if (id_onMapRenderValidData_ZILjava_lang_String_ == IntPtr.Zero)
					id_onMapRenderValidData_ZILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onMapRenderValidData", "(ZILjava/lang/String;)V");
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapRenderValidData_ZILjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p2);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapRenderValidDataListener.onMapRenderValidData
		public partial class MapRenderValidDataEventArgs : global::System.EventArgs {

			public MapRenderValidDataEventArgs (bool p0, int p1, string p2)
			{
				this.p0 = p0;
				this.p1 = p1;
				this.p2 = p2;
			}

			bool p0;
			public bool P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}

			string p2;
			public string P2 {
				get { return p2; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapRenderValidDataListenerImplementor")]
		internal sealed partial class IOnMapRenderValidDataListenerImplementor : global::Java.Lang.Object, IOnMapRenderValidDataListener {

			object sender;

			public IOnMapRenderValidDataListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapRenderValidDataListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapRenderValidDataEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapRenderValidData (bool p0, int p1, string p2)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapRenderValidDataEventArgs (p0, p1, p2));
			}

			internal static bool __IsEmpty (IOnMapRenderValidDataListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", DoNotGenerateAcw=true)]
		public abstract class OnMapStatusChangeListener : Java.Lang.Object {

			internal OnMapStatusChangeListener ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/field[@name='REASON_API_ANIMATION']"
			[Register ("REASON_API_ANIMATION")]
			public const int ReasonApiAnimation = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/field[@name='REASON_DEVELOPER_ANIMATION']"
			[Register ("REASON_DEVELOPER_ANIMATION")]
			public const int ReasonDeveloperAnimation = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/field[@name='REASON_GESTURE']"
			[Register ("REASON_GESTURE")]
			public const int ReasonGesture = (int) 1;
		}

		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'OnMapStatusChangeListener' type. This type will be removed in a future release.")]
		public abstract class OnMapStatusChangeListenerConsts : OnMapStatusChangeListener {

			private OnMapStatusChangeListenerConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker")]
		public partial interface IOnMapStatusChangeListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChange' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChange", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, BaiduMapBind")]
			void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChangeFinish' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChangeFinish", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, BaiduMapBind")]
			void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChangeStart' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
			[Register ("onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;)V", "GetOnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, BaiduMapBind")]
			void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapStatusChangeListener']/method[@name='onMapStatusChangeStart' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapStatus'] and parameter[2][@type='int']]"
			[Register ("onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;I)V", "GetOnMapStatusChangeStart2_Lcom_baidu_mapapi_map_MapStatus_IHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapStatusChangeListenerInvoker, BaiduMapBind")]
			void OnMapStatusChangeStart2 (global::Com.Baidu.Mapapi.Map.MapStatus p0, int p1);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", DoNotGenerateAcw=true)]
		internal class IOnMapStatusChangeListenerInvoker : global::Java.Lang.Object, IOnMapStatusChangeListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener", typeof (IOnMapStatusChangeListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapStatusChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapStatusChangeListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapStatusChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChange (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChange", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChange_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeFinish (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeFinish", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeFinish_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_Handler ()
			{
				if (cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ == null)
					cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_);
				return cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
			}

			static void n_OnMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_;
			public unsafe void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				if (id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ == IntPtr.Zero)
					id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_ = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_, __args);
			}

			static Delegate cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeStart2_Lcom_baidu_mapapi_map_MapStatus_IHandler ()
			{
				if (cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I == null)
					cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnMapStatusChangeStart2_Lcom_baidu_mapapi_map_MapStatus_I);
				return cb_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I;
			}

			static void n_OnMapStatusChangeStart2_Lcom_baidu_mapapi_map_MapStatus_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.MapStatus p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeStart2 (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I;
			public unsafe void OnMapStatusChangeStart2 (global::Com.Baidu.Mapapi.Map.MapStatus p0, int p1)
			{
				if (id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I == IntPtr.Zero)
					id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeStart", "(Lcom/baidu/mapapi/map/MapStatus;I)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeStart_Lcom_baidu_mapapi_map_MapStatus_I, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener.onMapStatusChange
		public partial class MapStatusChangeEventArgs : global::System.EventArgs {

			public MapStatusChangeEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener.onMapStatusChangeFinish
		public partial class MapStatusChangeFinishEventArgs : global::System.EventArgs {

			public MapStatusChangeFinishEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener.onMapStatusChangeStart
		public partial class MapStatusChangeStartEventArgs : global::System.EventArgs {

			public MapStatusChangeStartEventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener.onMapStatusChangeStart
		public partial class MapStatusChangeStart2EventArgs : global::System.EventArgs {

			public MapStatusChangeStart2EventArgs (global::Com.Baidu.Mapapi.Map.MapStatus p0, int p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			global::Com.Baidu.Mapapi.Map.MapStatus p0;
			public global::Com.Baidu.Mapapi.Map.MapStatus P0 {
				get { return p0; }
			}

			int p1;
			public int P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapStatusChangeListenerImplementor")]
		internal sealed partial class IOnMapStatusChangeListenerImplementor : global::Java.Lang.Object, IOnMapStatusChangeListener {

			object sender;

			public IOnMapStatusChangeListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapStatusChangeListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapStatusChangeEventArgs> OnMapStatusChangeHandler;
#pragma warning restore 0649

			public void OnMapStatusChange (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapStatusChangeFinishEventArgs> OnMapStatusChangeFinishHandler;
#pragma warning restore 0649

			public void OnMapStatusChangeFinish (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeFinishHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeFinishEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapStatusChangeStartEventArgs> OnMapStatusChangeStartHandler;
#pragma warning restore 0649

			public void OnMapStatusChangeStart (global::Com.Baidu.Mapapi.Map.MapStatus p0)
			{
				var __h = OnMapStatusChangeStartHandler;
				if (__h != null)
					__h (sender, new MapStatusChangeStartEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MapStatusChangeStart2EventArgs> OnMapStatusChangeStart2Handler;
#pragma warning restore 0649

			public void OnMapStatusChangeStart2 (global::Com.Baidu.Mapapi.Map.MapStatus p0, int p1)
			{
				var __h = OnMapStatusChangeStart2Handler;
				if (__h != null)
					__h (sender, new MapStatusChangeStart2EventArgs (p0, p1));
			}

			internal static bool __IsEmpty (IOnMapStatusChangeListenerImplementor value)
			{
				return value.OnMapStatusChangeHandler == null && value.OnMapStatusChangeFinishHandler == null && value.OnMapStatusChangeStartHandler == null && value.OnMapStatusChangeStart2Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapTouchListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMapTouchListenerInvoker")]
		public partial interface IOnMapTouchListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMapTouchListener']/method[@name='onTouch' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/MotionEvent;)V", "GetOnTouch_Landroid_view_MotionEvent_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMapTouchListenerInvoker, BaiduMapBind")]
			void OnTouch (global::Android.Views.MotionEvent p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener", DoNotGenerateAcw=true)]
		internal class IOnMapTouchListenerInvoker : global::Java.Lang.Object, IOnMapTouchListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMapTouchListener", typeof (IOnMapTouchListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMapTouchListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMapTouchListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMapTouchListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMapTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onTouch_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnTouch_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_MotionEvent_;
			}

			static void n_OnTouch_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnTouch (p0);
			}
#pragma warning restore 0169

			IntPtr id_onTouch_Landroid_view_MotionEvent_;
			public unsafe void OnTouch (global::Android.Views.MotionEvent p0)
			{
				if (id_onTouch_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/MotionEvent;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_MotionEvent_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMapTouchListener.onTouch
		public partial class MapTouchEventArgs : global::System.EventArgs {

			public MapTouchEventArgs (global::Android.Views.MotionEvent p0)
			{
				this.p0 = p0;
			}

			global::Android.Views.MotionEvent p0;
			public global::Android.Views.MotionEvent P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMapTouchListenerImplementor")]
		internal sealed partial class IOnMapTouchListenerImplementor : global::Java.Lang.Object, IOnMapTouchListener {

			object sender;

			public IOnMapTouchListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMapTouchListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MapTouchEventArgs> Handler;
#pragma warning restore 0649

			public void OnTouch (global::Android.Views.MotionEvent p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new MapTouchEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMapTouchListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerClickListenerInvoker")]
		public partial interface IOnMarkerClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerClickListener']/method[@name='onMarkerClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z", "GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerClickListenerInvoker, BaiduMapBind")]
			bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerClickListenerInvoker : global::Java.Lang.Object, IOnMarkerClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMarkerClickListener", typeof (IOnMarkerClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMarkerClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerClick_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
			}

			static bool n_OnMarkerClick_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnMarkerClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_;
			public unsafe bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerClick", "(Lcom/baidu/mapapi/map/Marker;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerClick_Lcom_baidu_mapapi_map_Marker_, __args);
				return __ret;
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener.onMarkerClick
		public partial class MarkerClickEventArgs : global::System.EventArgs {

			public MarkerClickEventArgs (bool handled, global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerClickListenerImplementor")]
		internal sealed partial class IOnMarkerClickListenerImplementor : global::Java.Lang.Object, IOnMarkerClickListener {

			object sender;

			public IOnMarkerClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMarkerClick (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MarkerClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMarkerClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker")]
		public partial interface IOnMarkerDragListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDrag' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDrag", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDrag_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, BaiduMapBind")]
			void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDragEnd' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDragEnd", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, BaiduMapBind")]
			void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMarkerDragListener']/method[@name='onMarkerDragStart' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Marker']]"
			[Register ("onMarkerDragStart", "(Lcom/baidu/mapapi/map/Marker;)V", "GetOnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMarkerDragListenerInvoker, BaiduMapBind")]
			void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener", DoNotGenerateAcw=true)]
		internal class IOnMarkerDragListenerInvoker : global::Java.Lang.Object, IOnMarkerDragListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMarkerDragListener", typeof (IOnMarkerDragListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMarkerDragListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMarkerDragListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMarkerDragListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDrag_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDrag_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDrag_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDrag (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDrag", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDrag_Lcom_baidu_mapapi_map_Marker_, __args);
			}

			static Delegate cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragEnd (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragEnd", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragEnd_Lcom_baidu_mapapi_map_Marker_, __args);
			}

			static Delegate cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
#pragma warning disable 0169
			static Delegate GetOnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_Handler ()
			{
				if (cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ == null)
					cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_);
				return cb_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
			}

			static void n_OnMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Marker p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnMarkerDragStart (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_;
			public unsafe void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				if (id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ == IntPtr.Zero)
					id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_ = JNIEnv.GetMethodID (class_ref, "onMarkerDragStart", "(Lcom/baidu/mapapi/map/Marker;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarkerDragStart_Lcom_baidu_mapapi_map_Marker_, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener.onMarkerDrag
		public partial class MarkerDragEventArgs : global::System.EventArgs {

			public MarkerDragEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener.onMarkerDragEnd
		public partial class MarkerDragEndEventArgs : global::System.EventArgs {

			public MarkerDragEndEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener.onMarkerDragStart
		public partial class MarkerDragStartEventArgs : global::System.EventArgs {

			public MarkerDragStartEventArgs (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				this.p0 = p0;
			}

			global::Com.Baidu.Mapapi.Map.Marker p0;
			public global::Com.Baidu.Mapapi.Map.Marker P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerDragListenerImplementor")]
		internal sealed partial class IOnMarkerDragListenerImplementor : global::Java.Lang.Object, IOnMarkerDragListener {

			object sender;

			public IOnMarkerDragListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMarkerDragListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MarkerDragEventArgs> OnMarkerDragHandler;
#pragma warning restore 0649

			public void OnMarkerDrag (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragHandler;
				if (__h != null)
					__h (sender, new MarkerDragEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragEndEventArgs> OnMarkerDragEndHandler;
#pragma warning restore 0649

			public void OnMarkerDragEnd (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragEndHandler;
				if (__h != null)
					__h (sender, new MarkerDragEndEventArgs (p0));
			}
#pragma warning disable 0649
			public EventHandler<MarkerDragStartEventArgs> OnMarkerDragStartHandler;
#pragma warning restore 0649

			public void OnMarkerDragStart (global::Com.Baidu.Mapapi.Map.Marker p0)
			{
				var __h = OnMarkerDragStartHandler;
				if (__h != null)
					__h (sender, new MarkerDragStartEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnMarkerDragListenerImplementor value)
			{
				return value.OnMarkerDragHandler == null && value.OnMarkerDragEndHandler == null && value.OnMarkerDragStartHandler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMyLocationClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnMyLocationClickListenerInvoker")]
		public partial interface IOnMyLocationClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnMyLocationClickListener']/method[@name='onMyLocationClick' and count(parameter)=0]"
			[Register ("onMyLocationClick", "()Z", "GetOnMyLocationClickHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnMyLocationClickListenerInvoker, BaiduMapBind")]
			bool OnMyLocationClick ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener", DoNotGenerateAcw=true)]
		internal class IOnMyLocationClickListenerInvoker : global::Java.Lang.Object, IOnMyLocationClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener", typeof (IOnMyLocationClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnMyLocationClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnMyLocationClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnMyLocationClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMyLocationClick;
#pragma warning disable 0169
			static Delegate GetOnMyLocationClickHandler ()
			{
				if (cb_onMyLocationClick == null)
					cb_onMyLocationClick = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnMyLocationClick);
				return cb_onMyLocationClick;
			}

			static bool n_OnMyLocationClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.OnMyLocationClick ();
			}
#pragma warning restore 0169

			IntPtr id_onMyLocationClick;
			public unsafe bool OnMyLocationClick ()
			{
				if (id_onMyLocationClick == IntPtr.Zero)
					id_onMyLocationClick = JNIEnv.GetMethodID (class_ref, "onMyLocationClick", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onMyLocationClick);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener.onMyLocationClick
		public partial class MyLocationClickEventArgs : global::System.EventArgs {

			public MyLocationClickEventArgs (bool handled)
			{
				this.handled = handled;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnMyLocationClickListenerImplementor")]
		internal sealed partial class IOnMyLocationClickListenerImplementor : global::Java.Lang.Object, IOnMyLocationClickListener {

			object sender;

			public IOnMyLocationClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnMyLocationClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<MyLocationClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnMyLocationClick ()
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new MyLocationClickEventArgs (true);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnMyLocationClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnPolylineClickListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnPolylineClickListenerInvoker")]
		public partial interface IOnPolylineClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnPolylineClickListener']/method[@name='onPolylineClick' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Polyline']]"
			[Register ("onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z", "GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler:Com.Baidu.Mapapi.Map.BaiduMap/IOnPolylineClickListenerInvoker, BaiduMapBind")]
			bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener", DoNotGenerateAcw=true)]
		internal class IOnPolylineClickListenerInvoker : global::Java.Lang.Object, IOnPolylineClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnPolylineClickListener", typeof (IOnPolylineClickListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnPolylineClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPolylineClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPolylineClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
#pragma warning disable 0169
			static Delegate GetOnPolylineClick_Lcom_baidu_mapapi_map_Polyline_Handler ()
			{
				if (cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == null)
					cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_);
				return cb_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
			}

			static bool n_OnPolylineClick_Lcom_baidu_mapapi_map_Polyline_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Baidu.Mapapi.Map.Polyline p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Polyline> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPolylineClick (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_;
			public unsafe bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				if (id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ == IntPtr.Zero)
					id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_ = JNIEnv.GetMethodID (class_ref, "onPolylineClick", "(Lcom/baidu/mapapi/map/Polyline;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPolylineClick_Lcom_baidu_mapapi_map_Polyline_, __args);
				return __ret;
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener.onPolylineClick
		public partial class PolylineClickEventArgs : global::System.EventArgs {

			public PolylineClickEventArgs (bool handled, global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				this.handled = handled;
				this.p0 = p0;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			global::Com.Baidu.Mapapi.Map.Polyline p0;
			public global::Com.Baidu.Mapapi.Map.Polyline P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnPolylineClickListenerImplementor")]
		internal sealed partial class IOnPolylineClickListenerImplementor : global::Java.Lang.Object, IOnPolylineClickListener {

			object sender;

			public IOnPolylineClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnPolylineClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PolylineClickEventArgs> Handler;
#pragma warning restore 0649

			public bool OnPolylineClick (global::Com.Baidu.Mapapi.Map.Polyline p0)
			{
				var __h = Handler;
				if (__h == null)
					return false;
				var __e = new PolylineClickEventArgs (true, p0);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnPolylineClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnSynchronizationListener']"
		[Register ("com/baidu/mapapi/map/BaiduMap$OnSynchronizationListener", "", "Com.Baidu.Mapapi.Map.BaiduMap/IOnSynchronizationListenerInvoker")]
		public partial interface IOnSynchronizationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.OnSynchronizationListener']/method[@name='onMapStatusChangeReason' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onMapStatusChangeReason", "(I)V", "GetOnMapStatusChangeReason_IHandler:Com.Baidu.Mapapi.Map.BaiduMap/IOnSynchronizationListenerInvoker, BaiduMapBind")]
			void OnMapStatusChangeReason (int p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$OnSynchronizationListener", DoNotGenerateAcw=true)]
		internal class IOnSynchronizationListenerInvoker : global::Java.Lang.Object, IOnSynchronizationListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$OnSynchronizationListener", typeof (IOnSynchronizationListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnSynchronizationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnSynchronizationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.OnSynchronizationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnSynchronizationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMapStatusChangeReason_I;
#pragma warning disable 0169
			static Delegate GetOnMapStatusChangeReason_IHandler ()
			{
				if (cb_onMapStatusChangeReason_I == null)
					cb_onMapStatusChangeReason_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_OnMapStatusChangeReason_I);
				return cb_onMapStatusChangeReason_I;
			}

			static void n_OnMapStatusChangeReason_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMapStatusChangeReason (p0);
			}
#pragma warning restore 0169

			IntPtr id_onMapStatusChangeReason_I;
			public unsafe void OnMapStatusChangeReason (int p0)
			{
				if (id_onMapStatusChangeReason_I == IntPtr.Zero)
					id_onMapStatusChangeReason_I = JNIEnv.GetMethodID (class_ref, "onMapStatusChangeReason", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapStatusChangeReason_I, __args);
			}

		}

		// event args for com.baidu.mapapi.map.BaiduMap.OnSynchronizationListener.onMapStatusChangeReason
		public partial class SynchronizationEventArgs : global::System.EventArgs {

			public SynchronizationEventArgs (int p0)
			{
				this.p0 = p0;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/BaiduMap_OnSynchronizationListenerImplementor")]
		internal sealed partial class IOnSynchronizationListenerImplementor : global::Java.Lang.Object, IOnSynchronizationListener {

			object sender;

			public IOnSynchronizationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/BaiduMap_OnSynchronizationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<SynchronizationEventArgs> Handler;
#pragma warning restore 0649

			public void OnMapStatusChangeReason (int p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new SynchronizationEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnSynchronizationListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.SnapshotReadyCallback']"
		[Register ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback", "", "Com.Baidu.Mapapi.Map.BaiduMap/ISnapshotReadyCallbackInvoker")]
		public partial interface ISnapshotReadyCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='BaiduMap.SnapshotReadyCallback']/method[@name='onSnapshotReady' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("onSnapshotReady", "(Landroid/graphics/Bitmap;)V", "GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler:Com.Baidu.Mapapi.Map.BaiduMap/ISnapshotReadyCallbackInvoker, BaiduMapBind")]
			void OnSnapshotReady (global::Android.Graphics.Bitmap p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback", DoNotGenerateAcw=true)]
		internal class ISnapshotReadyCallbackInvoker : global::Java.Lang.Object, ISnapshotReadyCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback", typeof (ISnapshotReadyCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ISnapshotReadyCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISnapshotReadyCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISnapshotReadyCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onSnapshotReady_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetOnSnapshotReady_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_onSnapshotReady_Landroid_graphics_Bitmap_ == null)
					cb_onSnapshotReady_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSnapshotReady_Landroid_graphics_Bitmap_);
				return cb_onSnapshotReady_Landroid_graphics_Bitmap_;
			}

			static void n_OnSnapshotReady_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnSnapshotReady (p0);
			}
#pragma warning restore 0169

			IntPtr id_onSnapshotReady_Landroid_graphics_Bitmap_;
			public unsafe void OnSnapshotReady (global::Android.Graphics.Bitmap p0)
			{
				if (id_onSnapshotReady_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_onSnapshotReady_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "onSnapshotReady", "(Landroid/graphics/Bitmap;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSnapshotReady_Landroid_graphics_Bitmap_, __args);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/BaiduMap", typeof (BaiduMap));
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

		protected BaiduMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getAllInfoWindows;
#pragma warning disable 0169
		static Delegate GetGetAllInfoWindowsHandler ()
		{
			if (cb_getAllInfoWindows == null)
				cb_getAllInfoWindows = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllInfoWindows);
			return cb_getAllInfoWindows;
		}

		static IntPtr n_GetAllInfoWindows (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.InfoWindow>.ToLocalJniHandle (__this.AllInfoWindows);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.InfoWindow> AllInfoWindows {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getAllInfoWindows' and count(parameter)=0]"
			[Register ("getAllInfoWindows", "()Ljava/util/List;", "GetGetAllInfoWindowsHandler")]
			get {
				const string __id = "getAllInfoWindows.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.InfoWindow>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool BaiduHeatMapEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBaiduHeatMapEnabled' and count(parameter)=0]"
			[Register ("isBaiduHeatMapEnabled", "()Z", "GetIsBaiduHeatMapEnabledHandler")]
			get {
				const string __id = "isBaiduHeatMapEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setBaiduHeatMapEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBaiduHeatMapEnabled", "(Z)V", "GetSetBaiduHeatMapEnabled_ZHandler")]
			set {
				const string __id = "setBaiduHeatMapEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool BuildingsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBuildingsEnabled' and count(parameter)=0]"
			[Register ("isBuildingsEnabled", "()Z", "GetIsBuildingsEnabledHandler")]
			get {
				const string __id = "isBuildingsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setBuildingsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setBuildingsEnabled", "(Z)V", "GetSetBuildingsEnabled_ZHandler")]
			set {
				const string __id = "setBuildingsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Point CompassPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getCompassPosition' and count(parameter)=0]"
			[Register ("getCompassPosition", "()Landroid/graphics/Point;", "GetGetCompassPositionHandler")]
			get {
				const string __id = "getCompassPosition.()Landroid/graphics/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCompassPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("setCompassPosition", "(Landroid/graphics/Point;)V", "GetSetCompassPosition_Landroid_graphics_Point_Handler")]
			set {
				const string __id = "setCompassPosition.(Landroid/graphics/Point;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFocusedBaseIndoorMapInfo;
#pragma warning disable 0169
		static Delegate GetGetFocusedBaseIndoorMapInfoHandler ()
		{
			if (cb_getFocusedBaseIndoorMapInfo == null)
				cb_getFocusedBaseIndoorMapInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusedBaseIndoorMapInfo);
			return cb_getFocusedBaseIndoorMapInfo;
		}

		static IntPtr n_GetFocusedBaseIndoorMapInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FocusedBaseIndoorMapInfo);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo FocusedBaseIndoorMapInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getFocusedBaseIndoorMapInfo' and count(parameter)=0]"
			[Register ("getFocusedBaseIndoorMapInfo", "()Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;", "GetGetFocusedBaseIndoorMapInfoHandler")]
			get {
				const string __id = "getFocusedBaseIndoorMapInfo.()Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isBaseIndoorMapMode;
#pragma warning disable 0169
		static Delegate GetIsBaseIndoorMapModeHandler ()
		{
			if (cb_isBaseIndoorMapMode == null)
				cb_isBaseIndoorMapMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBaseIndoorMapMode);
			return cb_isBaseIndoorMapMode;
		}

		static bool n_IsBaseIndoorMapMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBaseIndoorMapMode;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsBaseIndoorMapMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isBaseIndoorMapMode' and count(parameter)=0]"
			[Register ("isBaseIndoorMapMode", "()Z", "GetIsBaseIndoorMapModeHandler")]
			get {
				const string __id = "isBaseIndoorMapMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSupportBaiduHeatMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isSupportBaiduHeatMap' and count(parameter)=0]"
			[Register ("isSupportBaiduHeatMap", "()Z", "GetIsSupportBaiduHeatMapHandler")]
			get {
				const string __id = "isSupportBaiduHeatMap.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration LocationConfigeration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getLocationConfigeration' and count(parameter)=0]"
			[Register ("getLocationConfigeration", "()Lcom/baidu/mapapi/map/MyLocationConfiguration;", "GetGetLocationConfigerationHandler")]
			get {
				const string __id = "getLocationConfigeration.()Lcom/baidu/mapapi/map/MyLocationConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.MyLocationConfiguration LocationConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getLocationConfiguration' and count(parameter)=0]"
			[Register ("getLocationConfiguration", "()Lcom/baidu/mapapi/map/MyLocationConfiguration;", "GetGetLocationConfigurationHandler")]
			get {
				const string __id = "getLocationConfiguration.()Lcom/baidu/mapapi/map/MyLocationConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.MyLocationData LocationData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getLocationData' and count(parameter)=0]"
			[Register ("getLocationData", "()Lcom/baidu/mapapi/map/MyLocationData;", "GetGetLocationDataHandler")]
			get {
				const string __id = "getLocationData.()Lcom/baidu/mapapi/map/MyLocationData;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MyLocationData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.MapStatus MapStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapStatus' and count(parameter)=0]"
			[Register ("getMapStatus", "()Lcom/baidu/mapapi/map/MapStatus;", "GetGetMapStatusHandler")]
			get {
				const string __id = "getMapStatus.()Lcom/baidu/mapapi/map/MapStatus;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Model.LatLngBounds MapStatusLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapStatusLimit' and count(parameter)=0]"
			[Register ("getMapStatusLimit", "()Lcom/baidu/mapapi/model/LatLngBounds;", "GetGetMapStatusLimitHandler")]
			get {
				const string __id = "getMapStatusLimit.()Lcom/baidu/mapapi/model/LatLngBounds;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int MapType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMapType' and count(parameter)=0]"
			[Register ("getMapType", "()I", "GetGetMapTypeHandler")]
			get {
				const string __id = "getMapType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMapType", "(I)V", "GetSetMapType_IHandler")]
			set {
				const string __id = "setMapType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()F", "GetGetMaxZoomLevelHandler")]
			get {
				const string __id = "getMaxZoomLevel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()F", "GetGetMinZoomLevelHandler")]
			get {
				const string __id = "getMinZoomLevel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool MyLocationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isMyLocationEnabled' and count(parameter)=0]"
			[Register ("isMyLocationEnabled", "()Z", "GetIsMyLocationEnabledHandler")]
			get {
				const string __id = "isMyLocationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMyLocationEnabled", "(Z)V", "GetSetMyLocationEnabled_ZHandler")]
			set {
				const string __id = "setMyLocationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/baidu/mapapi/map/Projection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Lcom/baidu/mapapi/map/Projection;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool TrafficEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='isTrafficEnabled' and count(parameter)=0]"
			[Register ("isTrafficEnabled", "()Z", "GetIsTrafficEnabledHandler")]
			get {
				const string __id = "isTrafficEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setTrafficEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrafficEnabled", "(Z)V", "GetSetTrafficEnabled_ZHandler")]
			set {
				const string __id = "setTrafficEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/baidu/mapapi/map/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				const string __id = "getUiSettings.()Lcom/baidu/mapapi/map/UiSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UiSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_;
#pragma warning disable 0169
		static Delegate GetAddHeatMap_Lcom_baidu_mapapi_map_HeatMap_Handler ()
		{
			if (cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ == null)
				cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddHeatMap_Lcom_baidu_mapapi_map_HeatMap_);
			return cb_addHeatMap_Lcom_baidu_mapapi_map_HeatMap_;
		}

		static void n_AddHeatMap_Lcom_baidu_mapapi_map_HeatMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.HeatMap p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HeatMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddHeatMap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addHeatMap' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.HeatMap']]"
		[Register ("addHeatMap", "(Lcom/baidu/mapapi/map/HeatMap;)V", "GetAddHeatMap_Lcom_baidu_mapapi_map_HeatMap_Handler")]
		public virtual unsafe void AddHeatMap (global::Com.Baidu.Mapapi.Map.HeatMap p0)
		{
			const string __id = "addHeatMap.(Lcom/baidu/mapapi/map/HeatMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addOverlay' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.OverlayOptions']]"
		[Register ("addOverlay", "(Lcom/baidu/mapapi/map/OverlayOptions;)Lcom/baidu/mapapi/map/Overlay;", "")]
		public unsafe global::Com.Baidu.Mapapi.Map.Overlay AddOverlay (global::Com.Baidu.Mapapi.Map.OverlayOptions p0)
		{
			const string __id = "addOverlay.(Lcom/baidu/mapapi/map/OverlayOptions;)Lcom/baidu/mapapi/map/Overlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addOverlays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.OverlayOptions&gt;']]"
		[Register ("addOverlays", "(Ljava/util/List;)Ljava/util/List;", "")]
		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Overlay> AddOverlays (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.OverlayOptions> p0)
		{
			const string __id = "addOverlays.(Ljava/util/List;)Ljava/util/List;";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.OverlayOptions>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Overlay>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_Handler ()
		{
			if (cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ == null)
				cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_);
			return cb_addTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_;
		}

		static IntPtr n_AddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.TileOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddTileLayer (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='addTileLayer' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.TileOverlayOptions']]"
		[Register ("addTileLayer", "(Lcom/baidu/mapapi/map/TileOverlayOptions;)Lcom/baidu/mapapi/map/TileOverlay;", "GetAddTileLayer_Lcom_baidu_mapapi_map_TileOverlayOptions_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.TileOverlay AddTileLayer (global::Com.Baidu.Mapapi.Map.TileOverlayOptions p0)
		{
			const string __id = "addTileLayer.(Lcom/baidu/mapapi/map/TileOverlayOptions;)Lcom/baidu/mapapi/map/TileOverlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.TileOverlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='animateMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate']]"
		[Register ("animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V", "")]
		public unsafe void AnimateMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0)
		{
			const string __id = "animateMapStatus.(Lcom/baidu/mapapi/map/MapStatusUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='animateMapStatus' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate'] and parameter[2][@type='int']]"
		[Register ("animateMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;I)V", "")]
		public unsafe void AnimateMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0, int p1)
		{
			const string __id = "animateMapStatus.(Lcom/baidu/mapapi/map/MapStatusUpdate;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_changeLocationLayerOrder_Z;
#pragma warning disable 0169
		static Delegate GetChangeLocationLayerOrder_ZHandler ()
		{
			if (cb_changeLocationLayerOrder_Z == null)
				cb_changeLocationLayerOrder_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ChangeLocationLayerOrder_Z);
			return cb_changeLocationLayerOrder_Z;
		}

		static void n_ChangeLocationLayerOrder_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeLocationLayerOrder (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='changeLocationLayerOrder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("changeLocationLayerOrder", "(Z)V", "GetChangeLocationLayerOrder_ZHandler")]
		public virtual unsafe void ChangeLocationLayerOrder (bool p0)
		{
			const string __id = "changeLocationLayerOrder.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_cleanCache_I;
#pragma warning disable 0169
		static Delegate GetCleanCache_IHandler ()
		{
			if (cb_cleanCache_I == null)
				cb_cleanCache_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_CleanCache_I);
			return cb_cleanCache_I;
		}

		static void n_CleanCache_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CleanCache (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='cleanCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("cleanCache", "(I)V", "GetCleanCache_IHandler")]
		public virtual unsafe void CleanCache (int p0)
		{
			const string __id = "cleanCache.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "")]
		public unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
#pragma warning disable 0169
		static Delegate GetGetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_Handler ()
		{
			if (cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ == null)
				cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_);
			return cb_getMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_;
		}

		static IntPtr n_GetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLngBounds p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLngBounds> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Marker>.ToLocalJniHandle (__this.GetMarkersInBounds (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getMarkersInBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("getMarkersInBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Ljava/util/List;", "GetGetMarkersInBounds_Lcom_baidu_mapapi_model_LatLngBounds_Handler")]
		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.Marker> GetMarkersInBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			const string __id = "getMarkersInBounds.(Lcom/baidu/mapapi/model/LatLngBounds;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.Marker>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getProjectionMatrix;
#pragma warning disable 0169
		static Delegate GetGetProjectionMatrixHandler ()
		{
			if (cb_getProjectionMatrix == null)
				cb_getProjectionMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjectionMatrix);
			return cb_getProjectionMatrix;
		}

		static IntPtr n_GetProjectionMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetProjectionMatrix ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getProjectionMatrix' and count(parameter)=0]"
		[Register ("getProjectionMatrix", "()[F", "GetGetProjectionMatrixHandler")]
		public virtual unsafe float[] GetProjectionMatrix ()
		{
			const string __id = "getProjectionMatrix.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getViewMatrix;
#pragma warning disable 0169
		static Delegate GetGetViewMatrixHandler ()
		{
			if (cb_getViewMatrix == null)
				cb_getViewMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewMatrix);
			return cb_getViewMatrix;
		}

		static IntPtr n_GetViewMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetViewMatrix ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getViewMatrix' and count(parameter)=0]"
		[Register ("getViewMatrix", "()[F", "GetGetViewMatrixHandler")]
		public virtual unsafe float[] GetViewMatrix ()
		{
			const string __id = "getViewMatrix.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getZoomToBound_IIIIII;
#pragma warning disable 0169
		static Delegate GetGetZoomToBound_IIIIIIHandler ()
		{
			if (cb_getZoomToBound_IIIIII == null)
				cb_getZoomToBound_IIIIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int, int, float>) n_GetZoomToBound_IIIIII);
			return cb_getZoomToBound_IIIIII;
		}

		static float n_GetZoomToBound_IIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetZoomToBound (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='getZoomToBound' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("getZoomToBound", "(IIIIII)F", "GetGetZoomToBound_IIIIIIHandler")]
		public virtual unsafe float GetZoomToBound (int p0, int p1, int p2, int p3, int p4, int p5)
		{
			const string __id = "getZoomToBound.(IIIIII)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_hideInfoWindow;
#pragma warning disable 0169
		static Delegate GetHideInfoWindowHandler ()
		{
			if (cb_hideInfoWindow == null)
				cb_hideInfoWindow = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideInfoWindow);
			return cb_hideInfoWindow;
		}

		static void n_HideInfoWindow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "GetHideInfoWindowHandler")]
		public virtual unsafe void HideInfoWindow ()
		{
			const string __id = "hideInfoWindow.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
#pragma warning disable 0169
		static Delegate GetHideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler ()
		{
			if (cb_hideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ == null)
				cb_hideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_);
			return cb_hideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
		}

		static void n_HideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.HideInfoWindow (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='hideInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("hideInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V", "GetHideInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler")]
		public virtual unsafe void HideInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			const string __id = "hideInfoWindow.(Lcom/baidu/mapapi/map/InfoWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hideSDKLayer;
#pragma warning disable 0169
		static Delegate GetHideSDKLayerHandler ()
		{
			if (cb_hideSDKLayer == null)
				cb_hideSDKLayer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideSDKLayer);
			return cb_hideSDKLayer;
		}

		static void n_HideSDKLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideSDKLayer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='hideSDKLayer' and count(parameter)=0]"
		[Register ("hideSDKLayer", "()V", "GetHideSDKLayerHandler")]
		public virtual unsafe void HideSDKLayer ()
		{
			const string __id = "hideSDKLayer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='removeMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener']]"
		[Register ("removeMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V", "")]
		public unsafe void RemoveMarkerClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener p0)
		{
			const string __id = "removeMarkerClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCompassEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetCompassEnable_ZHandler ()
		{
			if (cb_setCompassEnable_Z == null)
				cb_setCompassEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCompassEnable_Z);
			return cb_setCompassEnable_Z;
		}

		static void n_SetCompassEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCompassEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCompassEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCompassEnable", "(Z)V", "GetSetCompassEnable_ZHandler")]
		public virtual unsafe void SetCompassEnable (bool p0)
		{
			const string __id = "setCompassEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCompassIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetCompassIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setCompassIcon_Landroid_graphics_Bitmap_ == null)
				cb_setCompassIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompassIcon_Landroid_graphics_Bitmap_);
			return cb_setCompassIcon_Landroid_graphics_Bitmap_;
		}

		static void n_SetCompassIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCompassIcon (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCompassIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setCompassIcon", "(Landroid/graphics/Bitmap;)V", "GetSetCompassIcon_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetCompassIcon (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "setCompassIcon.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SetCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SetCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetCustomTrafficColor (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setCustomTrafficColor' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("setCustomTrafficColor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "GetSetCustomTrafficColor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SetCustomTrafficColor (string p0, string p1, string p2, string p3)
		{
			const string __id = "setCustomTrafficColor.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setIndoorEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndoorEnable", "(Z)V", "")]
		public unsafe void SetIndoorEnable (bool p0)
		{
			const string __id = "setIndoorEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z;
#pragma warning disable 0169
		static Delegate GetSetLayerClickable_Lcom_baidu_mapapi_map_MapLayer_ZHandler ()
		{
			if (cb_setLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z == null)
				cb_setLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z);
			return cb_setLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z;
		}

		static void n_SetLayerClickable_Lcom_baidu_mapapi_map_MapLayer_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.MapLayer p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLayerClickable (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setLayerClickable' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapLayer'] and parameter[2][@type='boolean']]"
		[Register ("setLayerClickable", "(Lcom/baidu/mapapi/map/MapLayer;Z)V", "GetSetLayerClickable_Lcom_baidu_mapapi_map_MapLayer_ZHandler")]
		public virtual unsafe void SetLayerClickable (global::Com.Baidu.Mapapi.Map.MapLayer p0, bool p1)
		{
			const string __id = "setLayerClickable.(Lcom/baidu/mapapi/map/MapLayer;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatusUpdate']]"
		[Register ("setMapStatus", "(Lcom/baidu/mapapi/map/MapStatusUpdate;)V", "")]
		public unsafe void SetMapStatus (global::Com.Baidu.Mapapi.Map.MapStatusUpdate p0)
		{
			const string __id = "setMapStatus.(Lcom/baidu/mapapi/map/MapStatusUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMapStatusLimits' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("setMapStatusLimits", "(Lcom/baidu/mapapi/model/LatLngBounds;)V", "")]
		public unsafe void SetMapStatusLimits (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			const string __id = "setMapStatusLimits.(Lcom/baidu/mapapi/model/LatLngBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMaxAndMinZoomLevel' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setMaxAndMinZoomLevel", "(FF)V", "")]
		public unsafe void SetMaxAndMinZoomLevel (float p0, float p1)
		{
			const string __id = "setMaxAndMinZoomLevel.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationConfigeration' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration']]"
		[Obsolete (@"deprecated")]
		[Register ("setMyLocationConfigeration", "(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V", "")]
		public unsafe void SetMyLocationConfigeration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration p0)
		{
			const string __id = "setMyLocationConfigeration.(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationConfiguration' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MyLocationConfiguration']]"
		[Register ("setMyLocationConfiguration", "(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V", "")]
		public unsafe void SetMyLocationConfiguration (global::Com.Baidu.Mapapi.Map.MyLocationConfiguration p0)
		{
			const string __id = "setMyLocationConfiguration.(Lcom/baidu/mapapi/map/MyLocationConfiguration;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setMyLocationData' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MyLocationData']]"
		[Register ("setMyLocationData", "(Lcom/baidu/mapapi/map/MyLocationData;)V", "")]
		public unsafe void SetMyLocationData (global::Com.Baidu.Mapapi.Map.MyLocationData p0)
		{
			const string __id = "setMyLocationData.(Lcom/baidu/mapapi/map/MyLocationData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnBaseIndoorMapListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnBaseIndoorMapListener']]"
		[Register ("setOnBaseIndoorMapListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener;)V", "")]
		public unsafe void SetOnBaseIndoorMapListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener p0)
		{
			const string __id = "setOnBaseIndoorMapListener.(Lcom/baidu/mapapi/map/BaiduMap$OnBaseIndoorMapListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapClickListener']]"
		[Register ("setOnMapClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapClickListener;)V", "")]
		public unsafe void SetOnMapClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener p0)
		{
			const string __id = "setOnMapClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapDoubleClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapDoubleClickListener']]"
		[Register ("setOnMapDoubleClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener;)V", "")]
		public unsafe void SetOnMapDoubleClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener p0)
		{
			const string __id = "setOnMapDoubleClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapDoubleClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapDrawFrameCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapDrawFrameCallback']]"
		[Register ("setOnMapDrawFrameCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback;)V", "")]
		public unsafe void SetOnMapDrawFrameCallback (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDrawFrameCallback p0)
		{
			const string __id = "setOnMapDrawFrameCallback.(Lcom/baidu/mapapi/map/BaiduMap$OnMapDrawFrameCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_Handler ()
		{
			if (cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ == null)
				cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_);
			return cb_setOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_;
		}

		static void n_SetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback p0 = (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLoadedCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapLoadedCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapLoadedCallback']]"
		[Register ("setOnMapLoadedCallback", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback;)V", "GetSetOnMapLoadedCallback_Lcom_baidu_mapapi_map_BaiduMap_OnMapLoadedCallback_Handler")]
		public virtual unsafe void SetOnMapLoadedCallback (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLoadedCallback p0)
		{
			const string __id = "setOnMapLoadedCallback.(Lcom/baidu/mapapi/map/BaiduMap$OnMapLoadedCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapLongClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapLongClickListener']]"
		[Register ("setOnMapLongClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapLongClickListener;)V", "")]
		public unsafe void SetOnMapLongClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener p0)
		{
			const string __id = "setOnMapLongClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_Handler ()
		{
			if (cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ == null)
				cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_);
			return cb_setOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_;
		}

		static void n_SetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback p0 = (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapRenderCallbadk (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapRenderCallbadk' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapRenderCallback']]"
		[Register ("setOnMapRenderCallbadk", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderCallback;)V", "GetSetOnMapRenderCallbadk_Lcom_baidu_mapapi_map_BaiduMap_OnMapRenderCallback_Handler")]
		public virtual unsafe void SetOnMapRenderCallbadk (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderCallback p0)
		{
			const string __id = "setOnMapRenderCallbadk.(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapRenderValidDataListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapRenderValidDataListener']]"
		[Register ("setOnMapRenderValidDataListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderValidDataListener;)V", "")]
		public unsafe void SetOnMapRenderValidDataListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener p0)
		{
			const string __id = "setOnMapRenderValidDataListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapRenderValidDataListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapStatusChangeListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapStatusChangeListener']]"
		[Register ("setOnMapStatusChangeListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener;)V", "")]
		public unsafe void SetOnMapStatusChangeListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener p0)
		{
			const string __id = "setOnMapStatusChangeListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapStatusChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMapTouchListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMapTouchListener']]"
		[Register ("setOnMapTouchListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMapTouchListener;)V", "")]
		public unsafe void SetOnMapTouchListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener p0)
		{
			const string __id = "setOnMapTouchListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMapTouchListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerClickListener']]"
		[Register ("setOnMarkerClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V", "")]
		public unsafe void SetOnMarkerClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener p0)
		{
			const string __id = "setOnMarkerClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMarkerDragListener']]"
		[Register ("setOnMarkerDragListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerDragListener;)V", "")]
		public unsafe void SetOnMarkerDragListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener p0)
		{
			const string __id = "setOnMarkerDragListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMarkerDragListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnMyLocationClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnMyLocationClickListener']]"
		[Register ("setOnMyLocationClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener;)V", "")]
		public unsafe void SetOnMyLocationClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener p0)
		{
			const string __id = "setOnMyLocationClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnMyLocationClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnPolylineClickListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnPolylineClickListener']]"
		[Register ("setOnPolylineClickListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnPolylineClickListener;)V", "")]
		public unsafe void SetOnPolylineClickListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener p0)
		{
			const string __id = "setOnPolylineClickListener.(Lcom/baidu/mapapi/map/BaiduMap$OnPolylineClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOnSynchronizationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.OnSynchronizationListener']]"
		[Register ("setOnSynchronizationListener", "(Lcom/baidu/mapapi/map/BaiduMap$OnSynchronizationListener;)V", "")]
		public unsafe void SetOnSynchronizationListener (global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener p0)
		{
			const string __id = "setOnSynchronizationListener.(Lcom/baidu/mapapi/map/BaiduMap$OnSynchronizationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOverlayUnderPoi_Z;
#pragma warning disable 0169
		static Delegate GetSetOverlayUnderPoi_ZHandler ()
		{
			if (cb_setOverlayUnderPoi_Z == null)
				cb_setOverlayUnderPoi_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOverlayUnderPoi_Z);
			return cb_setOverlayUnderPoi_Z;
		}

		static void n_SetOverlayUnderPoi_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOverlayUnderPoi (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setOverlayUnderPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setOverlayUnderPoi", "(Z)V", "GetSetOverlayUnderPoi_ZHandler")]
		public virtual unsafe void SetOverlayUnderPoi (bool p0)
		{
			const string __id = "setOverlayUnderPoi.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setPadding", "(IIII)V", "")]
		public unsafe void SetPadding (int p0, int p1, int p2, int p3)
		{
			const string __id = "setPadding.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPixelFormatTransparent_Z;
#pragma warning disable 0169
		static Delegate GetSetPixelFormatTransparent_ZHandler ()
		{
			if (cb_setPixelFormatTransparent_Z == null)
				cb_setPixelFormatTransparent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPixelFormatTransparent_Z);
			return cb_setPixelFormatTransparent_Z;
		}

		static void n_SetPixelFormatTransparent_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixelFormatTransparent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setPixelFormatTransparent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPixelFormatTransparent", "(Z)V", "GetSetPixelFormatTransparent_ZHandler")]
		public virtual unsafe void SetPixelFormatTransparent (bool p0)
		{
			const string __id = "setPixelFormatTransparent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='setViewPadding' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setViewPadding", "(IIII)V", "")]
		public unsafe void SetViewPadding (int p0, int p1, int p2, int p3)
		{
			const string __id = "setViewPadding.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
#pragma warning disable 0169
		static Delegate GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler ()
		{
			if (cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ == null)
				cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_);
			return cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_;
		}

		static void n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindow (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V", "GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Handler")]
		public virtual unsafe void ShowInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			const string __id = "showInfoWindow.(Lcom/baidu/mapapi/map/InfoWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z;
#pragma warning disable 0169
		static Delegate GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ZHandler ()
		{
			if (cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z == null)
				cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z);
			return cb_showInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z;
		}

		static void n_ShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.InfoWindow p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindow (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showInfoWindow' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow'] and parameter[2][@type='boolean']]"
		[Register ("showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;Z)V", "GetShowInfoWindow_Lcom_baidu_mapapi_map_InfoWindow_ZHandler")]
		public virtual unsafe void ShowInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0, bool p1)
		{
			const string __id = "showInfoWindow.(Lcom/baidu/mapapi/map/InfoWindow;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showInfoWindows_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetShowInfoWindows_Ljava_util_List_Handler ()
		{
			if (cb_showInfoWindows_Ljava_util_List_ == null)
				cb_showInfoWindows_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ShowInfoWindows_Ljava_util_List_);
			return cb_showInfoWindows_Ljava_util_List_;
		}

		static void n_ShowInfoWindows_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.InfoWindow>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ShowInfoWindows (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showInfoWindows' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.InfoWindow&gt;']]"
		[Register ("showInfoWindows", "(Ljava/util/List;)V", "GetShowInfoWindows_Ljava_util_List_Handler")]
		public virtual unsafe void ShowInfoWindows (global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.InfoWindow> p0)
		{
			const string __id = "showInfoWindows.(Ljava/util/List;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.InfoWindow>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showMapIndoorPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMapIndoorPoi", "(Z)V", "")]
		public unsafe void ShowMapIndoorPoi (bool p0)
		{
			const string __id = "showMapIndoorPoi.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showMapPoi' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showMapPoi", "(Z)V", "")]
		public unsafe void ShowMapPoi (bool p0)
		{
			const string __id = "showMapPoi.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showSDKLayer;
#pragma warning disable 0169
		static Delegate GetShowSDKLayerHandler ()
		{
			if (cb_showSDKLayer == null)
				cb_showSDKLayer = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowSDKLayer);
			return cb_showSDKLayer;
		}

		static void n_ShowSDKLayer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowSDKLayer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='showSDKLayer' and count(parameter)=0]"
		[Register ("showSDKLayer", "()V", "GetShowSDKLayerHandler")]
		public virtual unsafe void ShowSDKLayer ()
		{
			const string __id = "showSDKLayer.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='snapshot' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback']]"
		[Register ("snapshot", "(Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V", "")]
		public unsafe void Snapshot (global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback p0)
		{
			const string __id = "snapshot.(Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='snapshotScope' and count(parameter)=2 and parameter[1][@type='android.graphics.Rect'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMap.SnapshotReadyCallback']]"
		[Register ("snapshotScope", "(Landroid/graphics/Rect;Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V", "")]
		public unsafe void SnapshotScope (global::Android.Graphics.Rect p0, global::Com.Baidu.Mapapi.Map.BaiduMap.ISnapshotReadyCallback p1)
		{
			const string __id = "snapshotScope.(Landroid/graphics/Rect;Lcom/baidu/mapapi/map/BaiduMap$SnapshotReadyCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_);
			return cb_switchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SwitchBaseIndoorMapFloor (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='switchBaseIndoorMapFloor' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("switchBaseIndoorMapFloor", "(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;", "GetSwitchBaseIndoorMapFloor_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError SwitchBaseIndoorMapFloor (string p0, string p1)
		{
			const string __id = "switchBaseIndoorMapFloor.(Ljava/lang/String;Ljava/lang/String;)Lcom/baidu/mapapi/map/MapBaseIndoorMapInfo$SwitchFloorError;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapBaseIndoorMapInfo.SwitchFloorError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_switchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_;
#pragma warning disable 0169
		static Delegate GetSwitchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_Handler ()
		{
			if (cb_switchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_ == null)
				cb_switchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SwitchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_);
			return cb_switchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_;
		}

		static void n_SwitchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.BaiduMap __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.MapLayer p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.MapLayer p1 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SwitchLayerOrder (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='BaiduMap']/method[@name='switchLayerOrder' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapLayer'] and parameter[2][@type='com.baidu.mapapi.map.MapLayer']]"
		[Register ("switchLayerOrder", "(Lcom/baidu/mapapi/map/MapLayer;Lcom/baidu/mapapi/map/MapLayer;)V", "GetSwitchLayerOrder_Lcom_baidu_mapapi_map_MapLayer_Lcom_baidu_mapapi_map_MapLayer_Handler")]
		public virtual unsafe void SwitchLayerOrder (global::Com.Baidu.Mapapi.Map.MapLayer p0, global::Com.Baidu.Mapapi.Map.MapLayer p1)
		{
			const string __id = "switchLayerOrder.(Lcom/baidu/mapapi/map/MapLayer;Lcom/baidu/mapapi/map/MapLayer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.BaseIndoorMapEventArgs> BaseIndoorMap {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor>(
						ref weak_implementor_SetOnBaseIndoorMapListener,
						__CreateIOnBaseIndoorMapListenerImplementor,
						SetOnBaseIndoorMapListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor>(
						ref weak_implementor_SetOnBaseIndoorMapListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor.__IsEmpty,
						__v => SetOnBaseIndoorMapListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnBaseIndoorMapListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor __CreateIOnBaseIndoorMapListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnBaseIndoorMapListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.OnMapClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.OnMapClickHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapPoiClickEventArgs> MapPoiClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.OnMapPoiClickHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.OnMapPoiClickHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapDoubleClickEventArgs> MapDoubleClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnMapDoubleClickListener,
						__CreateIOnMapDoubleClickListenerImplementor,
						SetOnMapDoubleClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor>(
						ref weak_implementor_SetOnMapDoubleClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor.__IsEmpty,
						__v => SetOnMapDoubleClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapDoubleClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor __CreateIOnMapDoubleClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapDoubleClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapLongClickEventArgs> MapLongClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => SetOnMapLongClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapRenderValidDataEventArgs> MapRenderValidData {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListenerImplementor>(
						ref weak_implementor_SetOnMapRenderValidDataListener,
						__CreateIOnMapRenderValidDataListenerImplementor,
						SetOnMapRenderValidDataListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListenerImplementor>(
						ref weak_implementor_SetOnMapRenderValidDataListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListenerImplementor.__IsEmpty,
						__v => SetOnMapRenderValidDataListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapRenderValidDataListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListenerImplementor __CreateIOnMapRenderValidDataListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapRenderValidDataListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeEventArgs> MapStatusChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeFinishEventArgs> MapStatusChangeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeFinishHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeFinishHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeStartEventArgs> MapStatusChangeStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeStartHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapStatusChangeStart2EventArgs> MapStatusChangeStart2 {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						__CreateIOnMapStatusChangeListenerImplementor,
						SetOnMapStatusChangeListener,
						__h => __h.OnMapStatusChangeStart2Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor>(
						ref weak_implementor_SetOnMapStatusChangeListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapStatusChangeListener (null),
						__h => __h.OnMapStatusChangeStart2Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapStatusChangeListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor __CreateIOnMapStatusChangeListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapStatusChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MapTouchEventArgs> MapTouch {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						__CreateIOnMapTouchListenerImplementor,
						SetOnMapTouchListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor>(
						ref weak_implementor_SetOnMapTouchListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor.__IsEmpty,
						__v => SetOnMapTouchListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapTouchListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor __CreateIOnMapTouchListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMapTouchListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDragListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor __CreateIOnMarkerDragListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMarkerDragListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.MyLocationClickEventArgs> MyLocationClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor>(
						ref weak_implementor_SetOnMyLocationClickListener,
						__CreateIOnMyLocationClickListenerImplementor,
						SetOnMyLocationClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor>(
						ref weak_implementor_SetOnMyLocationClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor.__IsEmpty,
						__v => SetOnMyLocationClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMyLocationClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor __CreateIOnMyLocationClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnMyLocationClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.PolylineClickEventArgs> PolylineClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						__CreateIOnPolylineClickListenerImplementor,
						SetOnPolylineClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor>(
						ref weak_implementor_SetOnPolylineClickListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor.__IsEmpty,
						__v => SetOnPolylineClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnPolylineClickListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor __CreateIOnPolylineClickListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnPolylineClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener"
		public event EventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.SynchronizationEventArgs> Synchronization {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListenerImplementor>(
						ref weak_implementor_SetOnSynchronizationListener,
						__CreateIOnSynchronizationListenerImplementor,
						SetOnSynchronizationListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListener, global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListenerImplementor>(
						ref weak_implementor_SetOnSynchronizationListener,
						global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListenerImplementor.__IsEmpty,
						__v => SetOnSynchronizationListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnSynchronizationListener;

		global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListenerImplementor __CreateIOnSynchronizationListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Map.BaiduMap.IOnSynchronizationListenerImplementor (this);
		}
#endregion
	}
}
