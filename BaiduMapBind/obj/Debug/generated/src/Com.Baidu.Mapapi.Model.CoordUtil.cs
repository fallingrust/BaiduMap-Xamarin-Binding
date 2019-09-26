using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/CoordUtil", DoNotGenerateAcw=true)]
	public partial class CoordUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/model/CoordUtil", typeof (CoordUtil));
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

		protected CoordUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/constructor[@name='CoordUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoordUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='Coordinate_encryptEx' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String']]"
		[Register ("Coordinate_encryptEx", "(FFLjava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng Coordinate_encryptEx (float p0, float p1, string p2)
		{
			const string __id = "Coordinate_encryptEx.(FFLjava/lang/String;)Lcom/baidu/mapapi/model/LatLng;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng DecodeLocation (string p0)
		{
			const string __id = "decodeLocation.(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocationList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocationList", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> DecodeLocationList (string p0)
		{
			const string __id = "decodeLocationList.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeLocationList2D' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeLocationList2D", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng>> DecodeLocationList2D (string p0)
		{
			const string __id = "decodeLocationList2D.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng>>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='decodeNodeLocation' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeNodeLocation", "(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng DecodeNodeLocation (string p0)
		{
			const string __id = "decodeNodeLocation.(Ljava/lang/String;)Lcom/baidu/mapapi/model/LatLng;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='getDistance' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.inner.Point'] and parameter[2][@type='com.baidu.mapapi.model.inner.Point']]"
		[Register ("getDistance", "(Lcom/baidu/mapapi/model/inner/Point;Lcom/baidu/mapapi/model/inner/Point;)D", "")]
		public static unsafe double GetDistance (global::Com.Baidu.Mapapi.Model.Inner.Point p0, global::Com.Baidu.Mapapi.Model.Inner.Point p1)
		{
			const string __id = "getDistance.(Lcom/baidu/mapapi/model/inner/Point;Lcom/baidu/mapapi/model/inner/Point;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='getMCDistanceByOneLatLngAndRadius' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.model.LatLng'] and parameter[2][@type='int']]"
		[Register ("getMCDistanceByOneLatLngAndRadius", "(Lcom/baidu/mapapi/model/LatLng;I)I", "")]
		public static unsafe int GetMCDistanceByOneLatLngAndRadius (global::Com.Baidu.Mapapi.Model.LatLng p0, int p1)
		{
			const string __id = "getMCDistanceByOneLatLngAndRadius.(Lcom/baidu/mapapi/model/LatLng;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='ll2mc' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("ll2mc", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/GeoPoint;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.Inner.GeoPoint Ll2mc (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "ll2mc.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/GeoPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.GeoPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='ll2point' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("ll2point", "(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/Point;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.Inner.Point Ll2point (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "ll2point.(Lcom/baidu/mapapi/model/LatLng;)Lcom/baidu/mapapi/model/inner/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model']/class[@name='CoordUtil']/method[@name='mc2ll' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.GeoPoint']]"
		[Register ("mc2ll", "(Lcom/baidu/mapapi/model/inner/GeoPoint;)Lcom/baidu/mapapi/model/LatLng;", "")]
		public static unsafe global::Com.Baidu.Mapapi.Model.LatLng Mc2ll (global::Com.Baidu.Mapapi.Model.Inner.GeoPoint p0)
		{
			const string __id = "mc2ll.(Lcom/baidu/mapapi/model/inner/GeoPoint;)Lcom/baidu/mapapi/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
