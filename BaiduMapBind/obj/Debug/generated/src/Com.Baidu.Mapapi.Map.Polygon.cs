using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Polygon", DoNotGenerateAcw=true)]
	public sealed partial class Polygon : global::Com.Baidu.Mapapi.Map.Overlay {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/Polygon", typeof (Polygon));
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

		internal Polygon (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				const string __id = "getFillColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				const string __id = "setFillColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.HoleOptions HoleOption {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getHoleOption' and count(parameter)=0]"
			[Register ("getHoleOption", "()Lcom/baidu/mapapi/map/HoleOptions;", "GetGetHoleOptionHandler")]
			get {
				const string __id = "getHoleOption.()Lcom/baidu/mapapi/map/HoleOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.HoleOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setHoleOption' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.HoleOptions']]"
			[Register ("setHoleOption", "(Lcom/baidu/mapapi/map/HoleOptions;)V", "GetSetHoleOption_Lcom_baidu_mapapi_map_HoleOptions_Handler")]
			set {
				const string __id = "setHoleOption.(Lcom/baidu/mapapi/map/HoleOptions;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.HoleOptions> HoleOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getHoleOptions' and count(parameter)=0]"
			[Register ("getHoleOptions", "()Ljava/util/List;", "GetGetHoleOptionsHandler")]
			get {
				const string __id = "getHoleOptions.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.HoleOptions>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setHoleOptions' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.map.HoleOptions&gt;']]"
			[Register ("setHoleOptions", "(Ljava/util/List;)V", "GetSetHoleOptions_Ljava_util_List_Handler")]
			set {
				const string __id = "setHoleOptions.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.HoleOptions>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Model.LatLng> Points {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getPoints' and count(parameter)=0]"
			[Register ("getPoints", "()Ljava/util/List;", "GetGetPointsHandler")]
			get {
				const string __id = "getPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setPoints' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.baidu.mapapi.model.LatLng&gt;']]"
			[Register ("setPoints", "(Ljava/util/List;)V", "GetSetPoints_Ljava_util_List_Handler")]
			set {
				const string __id = "setPoints.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Model.LatLng>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.Stroke Stroke {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='getStroke' and count(parameter)=0]"
			[Register ("getStroke", "()Lcom/baidu/mapapi/map/Stroke;", "GetGetStrokeHandler")]
			get {
				const string __id = "getStroke.()Lcom/baidu/mapapi/map/Stroke;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Stroke> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Polygon']/method[@name='setStroke' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.Stroke']]"
			[Register ("setStroke", "(Lcom/baidu/mapapi/map/Stroke;)V", "GetSetStroke_Lcom_baidu_mapapi_map_Stroke_Handler")]
			set {
				const string __id = "setStroke.(Lcom/baidu/mapapi/map/Stroke;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
