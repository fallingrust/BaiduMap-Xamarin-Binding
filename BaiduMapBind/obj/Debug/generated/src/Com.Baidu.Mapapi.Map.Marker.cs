using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Marker", DoNotGenerateAcw=true)]
	public sealed partial class Marker : global::Com.Baidu.Mapapi.Map.Overlay {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/Marker", typeof (Marker));
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

		internal Marker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe float Alpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAlpha' and count(parameter)=0]"
			[Register ("getAlpha", "()F", "GetGetAlphaHandler")]
			get {
				const string __id = "getAlpha.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAlpha", "(F)V", "GetSetAlpha_FHandler")]
			set {
				const string __id = "setAlpha.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float AnchorX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAnchorX' and count(parameter)=0]"
			[Register ("getAnchorX", "()F", "GetGetAnchorXHandler")]
			get {
				const string __id = "getAnchorX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float AnchorY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getAnchorY' and count(parameter)=0]"
			[Register ("getAnchorY", "()F", "GetGetAnchorYHandler")]
			get {
				const string __id = "getAnchorY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool Clickable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isClickable' and count(parameter)=0]"
			[Register ("isClickable", "()Z", "GetIsClickableHandler")]
			get {
				const string __id = "isClickable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setClickable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setClickable", "(Z)V", "GetSetClickable_ZHandler")]
			set {
				const string __id = "setClickable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool Draggable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isDraggable' and count(parameter)=0]"
			[Register ("isDraggable", "()Z", "GetIsDraggableHandler")]
			get {
				const string __id = "isDraggable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setDraggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDraggable", "(Z)V", "GetSetDraggable_ZHandler")]
			set {
				const string __id = "setDraggable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Point FixedPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getFixedPosition' and count(parameter)=0]"
			[Register ("getFixedPosition", "()Landroid/graphics/Point;", "GetGetFixedPositionHandler")]
			get {
				const string __id = "getFixedPosition.()Landroid/graphics/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool Flat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isFlat' and count(parameter)=0]"
			[Register ("isFlat", "()Z", "GetIsFlatHandler")]
			get {
				const string __id = "isFlat.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setFlat' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlat", "(Z)V", "GetSetFlat_ZHandler")]
			set {
				const string __id = "setFlat.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Lcom/baidu/mapapi/map/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
			[Register ("setIcon", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V", "GetSetIcon_Lcom_baidu_mapapi_map_BitmapDescriptor_Handler")]
			set {
				const string __id = "setIcon.(Lcom/baidu/mapapi/map/BitmapDescriptor;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> Icons {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getIcons' and count(parameter)=0]"
			[Register ("getIcons", "()Ljava/util/ArrayList;", "GetGetIconsHandler")]
			get {
				const string __id = "getIcons.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setIcons' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;com.baidu.mapapi.map.BitmapDescriptor&gt;']]"
			[Register ("setIcons", "(Ljava/util/ArrayList;)V", "GetSetIcons_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setIcons.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Baidu.Mapapi.Map.BitmapDescriptor>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.InfoWindow InfoWindow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getInfoWindow' and count(parameter)=0]"
			[Register ("getInfoWindow", "()Lcom/baidu/mapapi/map/InfoWindow;", "GetGetInfoWindowHandler")]
			get {
				const string __id = "getInfoWindow.()Lcom/baidu/mapapi/map/InfoWindow;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsFixed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isFixed' and count(parameter)=0]"
			[Register ("isFixed", "()Z", "GetIsFixedHandler")]
			get {
				const string __id = "isFixed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsInfoWindowEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isInfoWindowEnabled' and count(parameter)=0]"
			[Register ("isInfoWindowEnabled", "()Z", "GetIsInfoWindowEnabledHandler")]
			get {
				const string __id = "isInfoWindowEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Period {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getPeriod' and count(parameter)=0]"
			[Register ("getPeriod", "()I", "GetGetPeriodHandler")]
			get {
				const string __id = "getPeriod.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPeriod' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPeriod", "(I)V", "GetSetPeriod_IHandler")]
			set {
				const string __id = "setPeriod.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe bool Perspective {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='isPerspective' and count(parameter)=0]"
			[Register ("isPerspective", "()Z", "GetIsPerspectiveHandler")]
			get {
				const string __id = "isPerspective.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPerspective' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setPerspective", "(Z)V", "GetSetPerspective_ZHandler")]
			set {
				const string __id = "setPerspective.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/baidu/mapapi/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("setPosition", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetSetPosition_Lcom_baidu_mapapi_model_LatLng_Handler")]
			set {
				const string __id = "setPosition.(Lcom/baidu/mapapi/model/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Rotate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getRotate' and count(parameter)=0]"
			[Register ("getRotate", "()F", "GetGetRotateHandler")]
			get {
				const string __id = "getRotate.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setRotate' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotate", "(F)V", "GetSetRotate_FHandler")]
			set {
				const string __id = "setRotate.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				const string __id = "getScale.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
			set {
				const string __id = "setScale.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float ScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getScaleX' and count(parameter)=0]"
			[Register ("getScaleX", "()F", "GetGetScaleXHandler")]
			get {
				const string __id = "getScaleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setScaleX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScaleX", "(F)V", "GetSetScaleX_FHandler")]
			set {
				const string __id = "setScaleX.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe float ScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getScaleY' and count(parameter)=0]"
			[Register ("getScaleY", "()F", "GetGetScaleYHandler")]
			get {
				const string __id = "getScaleY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setScaleY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScaleY", "(F)V", "GetSetScaleY_FHandler")]
			set {
				const string __id = "setScaleY.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe string Title {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getTitle' and count(parameter)=0]"
			[Register ("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
			get {
				const string __id = "getTitle.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setTitle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTitle", "(Ljava/lang/String;)V", "GetSetTitle_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTitle.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public unsafe int YOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='getYOffset' and count(parameter)=0]"
			[Register ("getYOffset", "()I", "GetGetYOffsetHandler")]
			get {
				const string __id = "getYOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setYOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYOffset", "(I)V", "GetSetYOffset_IHandler")]
			set {
				const string __id = "setYOffset.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='cancelAnimation' and count(parameter)=0]"
		[Register ("cancelAnimation", "()V", "")]
		public unsafe void CancelAnimation ()
		{
			const string __id = "cancelAnimation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='hideInfoWindow' and count(parameter)=0]"
		[Register ("hideInfoWindow", "()V", "")]
		public unsafe void HideInfoWindow ()
		{
			const string __id = "hideInfoWindow.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAnchor' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setAnchor", "(FF)V", "")]
		public unsafe void SetAnchor (float p0, float p1)
		{
			const string __id = "setAnchor.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAnimateType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimateType", "(I)V", "")]
		public unsafe void SetAnimateType (int p0)
		{
			const string __id = "setAnimateType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setAnimation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation']]"
		[Register ("setAnimation", "(Lcom/baidu/mapapi/animation/Animation;)V", "")]
		public unsafe void SetAnimation (global::Com.Baidu.Mapapi.Animation.Animation p0)
		{
			const string __id = "setAnimation.(Lcom/baidu/mapapi/animation/Animation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setFixedScreenPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setFixedScreenPosition", "(Landroid/graphics/Point;)V", "")]
		public unsafe void SetFixedScreenPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "setFixedScreenPosition.(Landroid/graphics/Point;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setPositionWithInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("setPositionWithInfoWindow", "(Lcom/baidu/mapapi/model/LatLng;)V", "")]
		public unsafe void SetPositionWithInfoWindow (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "setPositionWithInfoWindow.(Lcom/baidu/mapapi/model/LatLng;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='setToTop' and count(parameter)=0]"
		[Register ("setToTop", "()V", "")]
		public unsafe void SetToTop ()
		{
			const string __id = "setToTop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='showInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("showInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V", "")]
		public unsafe void ShowInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			const string __id = "showInfoWindow.(Lcom/baidu/mapapi/map/InfoWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='showSmoothMoveInfoWindow' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.InfoWindow']]"
		[Register ("showSmoothMoveInfoWindow", "(Lcom/baidu/mapapi/map/InfoWindow;)V", "")]
		public unsafe void ShowSmoothMoveInfoWindow (global::Com.Baidu.Mapapi.Map.InfoWindow p0)
		{
			const string __id = "showSmoothMoveInfoWindow.(Lcom/baidu/mapapi/map/InfoWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='startAnimation' and count(parameter)=0]"
		[Register ("startAnimation", "()V", "")]
		public unsafe void StartAnimation ()
		{
			const string __id = "startAnimation.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='updateInfoWindowBitmapDescriptor' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
		[Register ("updateInfoWindowBitmapDescriptor", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V", "")]
		public unsafe void UpdateInfoWindowBitmapDescriptor (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0)
		{
			const string __id = "updateInfoWindowBitmapDescriptor.(Lcom/baidu/mapapi/map/BitmapDescriptor;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='updateInfoWindowPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
		[Register ("updateInfoWindowPosition", "(Lcom/baidu/mapapi/model/LatLng;)V", "")]
		public unsafe void UpdateInfoWindowPosition (global::Com.Baidu.Mapapi.Model.LatLng p0)
		{
			const string __id = "updateInfoWindowPosition.(Lcom/baidu/mapapi/model/LatLng;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='updateInfoWindowView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("updateInfoWindowView", "(Landroid/view/View;)V", "")]
		public unsafe void UpdateInfoWindowView (global::Android.Views.View p0)
		{
			const string __id = "updateInfoWindowView.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Marker']/method[@name='updateInfoWindowYOffset' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("updateInfoWindowYOffset", "(I)V", "")]
		public unsafe void UpdateInfoWindowYOffset (int p0)
		{
			const string __id = "updateInfoWindowYOffset.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
