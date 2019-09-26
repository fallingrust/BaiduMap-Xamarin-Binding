using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapLayer", DoNotGenerateAcw=true)]
	public sealed partial class MapLayer : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/field[@name='MAP_LAYER_INDOOR_POI']"
		[Register ("MAP_LAYER_INDOOR_POI")]
		public static global::Com.Baidu.Mapapi.Map.MapLayer MapLayerIndoorPoi {
			get {
				const string __id = "MAP_LAYER_INDOOR_POI.Lcom/baidu/mapapi/map/MapLayer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/field[@name='MAP_LAYER_LOCATION']"
		[Register ("MAP_LAYER_LOCATION")]
		public static global::Com.Baidu.Mapapi.Map.MapLayer MapLayerLocation {
			get {
				const string __id = "MAP_LAYER_LOCATION.Lcom/baidu/mapapi/map/MapLayer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/field[@name='MAP_LAYER_OVERLAY']"
		[Register ("MAP_LAYER_OVERLAY")]
		public static global::Com.Baidu.Mapapi.Map.MapLayer MapLayerOverlay {
			get {
				const string __id = "MAP_LAYER_OVERLAY.Lcom/baidu/mapapi/map/MapLayer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/field[@name='MAP_LAYER_POI_MARKER']"
		[Register ("MAP_LAYER_POI_MARKER")]
		public static global::Com.Baidu.Mapapi.Map.MapLayer MapLayerPoiMarker {
			get {
				const string __id = "MAP_LAYER_POI_MARKER.Lcom/baidu/mapapi/map/MapLayer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapLayer", typeof (MapLayer));
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

		internal MapLayer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapLayer;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapLayer ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/MapLayer;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapLayer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapLayer']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/baidu/mapapi/map/MapLayer;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapLayer[] Values ()
		{
			const string __id = "values.()[Lcom/baidu/mapapi/map/MapLayer;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Baidu.Mapapi.Map.MapLayer[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.MapLayer));
			} finally {
			}
		}

	}
}
