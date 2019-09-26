using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapStatusUpdateFactory", DoNotGenerateAcw=true)]
	public sealed partial class MapStatusUpdateFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapStatusUpdateFactory", typeof (MapStatusUpdateFactory));
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

		internal MapStatusUpdateFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLng' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("newLatLng", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLng (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "newLatLng.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds']]"
		[Register ("newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0)
		{
			const string __id = "newLatLngBounds.(Lcom/baidu/mapapi/model/LatLngBounds;)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=3 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;II)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0, int p1, int p2)
		{
			const string __id = "newLatLngBounds.(Lcom/baidu/mapapi/model/LatLngBounds;II)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngBounds' and count(parameter)=5 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("newLatLngBounds", "(Lcom/baidu/mapapi/model/LatLngBounds;IIII)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngBounds (global::Com.Baidu.Mapapi.Model.LatLngBounds p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "newLatLngBounds.(Lcom/baidu/mapapi/model/LatLngBounds;IIII)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='float']]"
		[Register ("newLatLngZoom", "(Lcom/baidu/mapapi/model/LatLng;F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngZoom (global::Com.Baidu.Mapapi.Model.LatLng p0, float p1)
		{
			const string __id = "newLatLngZoom.(Lcom/baidu/mapapi/model/LatLng;F)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newLatLngZoom' and count(parameter)=5 and parameter[1][@type='com.baidu.mapapi.model.LatLngBounds'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("newLatLngZoom", "(Lcom/baidu/mapapi/model/LatLngBounds;IIII)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewLatLngZoom (global::Com.Baidu.Mapapi.Model.LatLngBounds p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "newLatLngZoom.(Lcom/baidu/mapapi/model/LatLngBounds;IIII)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='newMapStatus' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.MapStatus']]"
		[Register ("newMapStatus", "(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate NewMapStatus (global::Com.Baidu.Mapapi.Map.MapStatus p0)
		{
			const string __id = "newMapStatus.(Lcom/baidu/mapapi/map/MapStatus;)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("scrollBy", "(II)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ScrollBy (int p0, int p1)
		{
			const string __id = "scrollBy.(II)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomBy", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomBy (float p0)
		{
			const string __id = "zoomBy.(F)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("zoomBy", "(FLandroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomBy (float p0, global::Android.Graphics.Point p1)
		{
			const string __id = "zoomBy.(FLandroid/graphics/Point;)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomIn ()
		{
			const string __id = "zoomIn.()Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomOut ()
		{
			const string __id = "zoomOut.()Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapStatusUpdateFactory']/method[@name='zoomTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("zoomTo", "(F)Lcom/baidu/mapapi/map/MapStatusUpdate;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Map.MapStatusUpdate ZoomTo (float p0)
		{
			const string __id = "zoomTo.(F)Lcom/baidu/mapapi/map/MapStatusUpdate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapStatusUpdate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
