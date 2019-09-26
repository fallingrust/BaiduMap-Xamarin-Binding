using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapView", DoNotGenerateAcw=true)]
	public sealed partial class MapView : global::Android.Views.ViewGroup {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='MapView.CustomMapStyleCallBack']"
		[Register ("com/baidu/mapapi/map/MapView$CustomMapStyleCallBack", "", "Com.Baidu.Mapapi.Map.MapView/ICustomMapStyleCallBackInvoker")]
		public partial interface ICustomMapStyleCallBack : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='MapView.CustomMapStyleCallBack']/method[@name='onCustomMapStyleLoadFailed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("onCustomMapStyleLoadFailed", "(ILjava/lang/String;Ljava/lang/String;)Z", "GetOnCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_Handler:Com.Baidu.Mapapi.Map.MapView/ICustomMapStyleCallBackInvoker, BaiduMapBind")]
			bool OnCustomMapStyleLoadFailed (int p0, string p1, string p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='MapView.CustomMapStyleCallBack']/method[@name='onCustomMapStyleLoadSuccess' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
			[Register ("onCustomMapStyleLoadSuccess", "(ZLjava/lang/String;)Z", "GetOnCustomMapStyleLoadSuccess_ZLjava_lang_String_Handler:Com.Baidu.Mapapi.Map.MapView/ICustomMapStyleCallBackInvoker, BaiduMapBind")]
			bool OnCustomMapStyleLoadSuccess (bool p0, string p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='MapView.CustomMapStyleCallBack']/method[@name='onPreLoadLastCustomMapStyle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onPreLoadLastCustomMapStyle", "(Ljava/lang/String;)Z", "GetOnPreLoadLastCustomMapStyle_Ljava_lang_String_Handler:Com.Baidu.Mapapi.Map.MapView/ICustomMapStyleCallBackInvoker, BaiduMapBind")]
			bool OnPreLoadLastCustomMapStyle (string p0);

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/MapView$CustomMapStyleCallBack", DoNotGenerateAcw=true)]
		internal class ICustomMapStyleCallBackInvoker : global::Java.Lang.Object, ICustomMapStyleCallBack {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/MapView$CustomMapStyleCallBack", typeof (ICustomMapStyleCallBackInvoker));

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

			public static ICustomMapStyleCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICustomMapStyleCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.MapView.CustomMapStyleCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICustomMapStyleCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_Handler ()
			{
				if (cb_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_ == null)
					cb_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_);
				return cb_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_;
			}

			static bool n_OnCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCustomMapStyleLoadFailed (p0, p1, p2);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_;
			public unsafe bool OnCustomMapStyleLoadFailed (int p0, string p1, string p2)
			{
				if (id_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCustomMapStyleLoadFailed", "(ILjava/lang/String;Ljava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				IntPtr native_p2 = JNIEnv.NewString (p2);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCustomMapStyleLoadFailed_ILjava_lang_String_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				return __ret;
			}

			static Delegate cb_onCustomMapStyleLoadSuccess_ZLjava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnCustomMapStyleLoadSuccess_ZLjava_lang_String_Handler ()
			{
				if (cb_onCustomMapStyleLoadSuccess_ZLjava_lang_String_ == null)
					cb_onCustomMapStyleLoadSuccess_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, bool>) n_OnCustomMapStyleLoadSuccess_ZLjava_lang_String_);
				return cb_onCustomMapStyleLoadSuccess_ZLjava_lang_String_;
			}

			static bool n_OnCustomMapStyleLoadSuccess_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool p0, IntPtr native_p1)
			{
				global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCustomMapStyleLoadSuccess (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onCustomMapStyleLoadSuccess_ZLjava_lang_String_;
			public unsafe bool OnCustomMapStyleLoadSuccess (bool p0, string p1)
			{
				if (id_onCustomMapStyleLoadSuccess_ZLjava_lang_String_ == IntPtr.Zero)
					id_onCustomMapStyleLoadSuccess_ZLjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCustomMapStyleLoadSuccess", "(ZLjava/lang/String;)Z");
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCustomMapStyleLoadSuccess_ZLjava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p1);
				return __ret;
			}

			static Delegate cb_onPreLoadLastCustomMapStyle_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnPreLoadLastCustomMapStyle_Ljava_lang_String_Handler ()
			{
				if (cb_onPreLoadLastCustomMapStyle_Ljava_lang_String_ == null)
					cb_onPreLoadLastCustomMapStyle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_OnPreLoadLastCustomMapStyle_Ljava_lang_String_);
				return cb_onPreLoadLastCustomMapStyle_Ljava_lang_String_;
			}

			static bool n_OnPreLoadLastCustomMapStyle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPreLoadLastCustomMapStyle (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onPreLoadLastCustomMapStyle_Ljava_lang_String_;
			public unsafe bool OnPreLoadLastCustomMapStyle (string p0)
			{
				if (id_onPreLoadLastCustomMapStyle_Ljava_lang_String_ == IntPtr.Zero)
					id_onPreLoadLastCustomMapStyle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onPreLoadLastCustomMapStyle", "(Ljava/lang/String;)Z");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPreLoadLastCustomMapStyle_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/MapView", typeof (MapView));
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

		internal MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Com.Baidu.Mapapi.Map.BaiduMapOptions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.LogoPosition LogoPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getLogoPosition' and count(parameter)=0]"
			[Register ("getLogoPosition", "()Lcom/baidu/mapapi/map/LogoPosition;", "GetGetLogoPositionHandler")]
			get {
				const string __id = "getLogoPosition.()Lcom/baidu/mapapi/map/LogoPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.LogoPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.LogoPosition']]"
			[Register ("setLogoPosition", "(Lcom/baidu/mapapi/map/LogoPosition;)V", "GetSetLogoPosition_Lcom_baidu_mapapi_map_LogoPosition_Handler")]
			set {
				const string __id = "setLogoPosition.(Lcom/baidu/mapapi/map/LogoPosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/baidu/mapapi/map/BaiduMap;", "GetGetMapHandler")]
			get {
				const string __id = "getMap.()Lcom/baidu/mapapi/map/BaiduMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BaiduMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int MapLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getMapLevel' and count(parameter)=0]"
			[Register ("getMapLevel", "()I", "GetGetMapLevelHandler")]
			get {
				const string __id = "getMapLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Point ScaleControlPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getScaleControlPosition' and count(parameter)=0]"
			[Register ("getScaleControlPosition", "()Landroid/graphics/Point;", "GetGetScaleControlPositionHandler")]
			get {
				const string __id = "getScaleControlPosition.()Landroid/graphics/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setScaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("setScaleControlPosition", "(Landroid/graphics/Point;)V", "GetSetScaleControlPosition_Landroid_graphics_Point_Handler")]
			set {
				const string __id = "setScaleControlPosition.(Landroid/graphics/Point;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe int ScaleControlViewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getScaleControlViewHeight' and count(parameter)=0]"
			[Register ("getScaleControlViewHeight", "()I", "GetGetScaleControlViewHeightHandler")]
			get {
				const string __id = "getScaleControlViewHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ScaleControlViewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getScaleControlViewWidth' and count(parameter)=0]"
			[Register ("getScaleControlViewWidth", "()I", "GetGetScaleControlViewWidthHandler")]
			get {
				const string __id = "getScaleControlViewWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.Graphics.Point ZoomControlsPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='getZoomControlsPosition' and count(parameter)=0]"
			[Register ("getZoomControlsPosition", "()Landroid/graphics/Point;", "GetGetZoomControlsPositionHandler")]
			get {
				const string __id = "getZoomControlsPosition.()Landroid/graphics/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setZoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
			[Register ("setZoomControlsPosition", "(Landroid/graphics/Point;)V", "GetSetZoomControlsPosition_Landroid_graphics_Point_Handler")]
			set {
				const string __id = "setZoomControlsPosition.(Landroid/graphics/Point;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='cancelRenderMap' and count(parameter)=0]"
		[Register ("cancelRenderMap", "()V", "")]
		public unsafe void CancelRenderMap ()
		{
			const string __id = "cancelRenderMap.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='handleMultiTouch' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("handleMultiTouch", "(FFFF)Z", "")]
		public unsafe bool HandleMultiTouch (float p0, float p1, float p2, float p3)
		{
			const string __id = "handleMultiTouch.(FFFF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='handleTouchDown' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("handleTouchDown", "(FF)V", "")]
		public unsafe void HandleTouchDown (float p0, float p1)
		{
			const string __id = "handleTouchDown.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='handleTouchMove' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("handleTouchMove", "(FF)Z", "")]
		public unsafe bool HandleTouchMove (float p0, float p1)
		{
			const string __id = "handleTouchMove.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='handleTouchUp' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("handleTouchUp", "(FF)Z", "")]
		public unsafe bool HandleTouchUp (float p0, float p1)
		{
			const string __id = "handleTouchUp.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='inRangeOfView' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("inRangeOfView", "(FF)Z", "")]
		public unsafe bool InRangeOfView (float p0, float p1)
		{
			const string __id = "inRangeOfView.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V", "")]
		public unsafe void OnCreate (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			const string __id = "onCreate.(Landroid/content/Context;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "")]
		protected override sealed unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "")]
		public unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "")]
		public unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			const string __id = "onSaveInstanceState.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='renderMap' and count(parameter)=0]"
		[Register ("renderMap", "()V", "")]
		public unsafe void RenderMap ()
		{
			const string __id = "renderMap.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setCustomMapStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("setCustomMapStylePath", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetCustomMapStylePath (string p0)
		{
			const string __id = "setCustomMapStylePath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setCustomStyleFilePathAndMode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setCustomStyleFilePathAndMode", "(Ljava/lang/String;I)V", "")]
		public unsafe void SetCustomStyleFilePathAndMode (string p0, int p1)
		{
			const string __id = "setCustomStyleFilePathAndMode.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setIconCustom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setIconCustom", "(I)V", "")]
		public static unsafe void SetIconCustom (int p0)
		{
			const string __id = "setIconCustom.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setLoadCustomMapStyleFileMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setLoadCustomMapStyleFileMode", "(I)V", "")]
		public static unsafe void SetLoadCustomMapStyleFileMode (int p0)
		{
			const string __id = "setLoadCustomMapStyleFileMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setMapCustomEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setMapCustomEnable", "(Z)V", "")]
		public static unsafe void SetMapCustomEnable (bool p0)
		{
			const string __id = "setMapCustomEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setMapCustomStyle' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapCustomStyleOptions'] and parameter[2][@type='com.baidu.mapapi.map.MapView.CustomMapStyleCallBack']]"
		[Register ("setMapCustomStyle", "(Lcom/baidu/mapapi/map/MapCustomStyleOptions;Lcom/baidu/mapapi/map/MapView$CustomMapStyleCallBack;)V", "")]
		public unsafe void SetMapCustomStyle (global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions p0, global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack p1)
		{
			const string __id = "setMapCustomStyle.(Lcom/baidu/mapapi/map/MapCustomStyleOptions;Lcom/baidu/mapapi/map/MapView$CustomMapStyleCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setMapCustomStyleEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMapCustomStyleEnable", "(Z)V", "")]
		public unsafe void SetMapCustomStyleEnable (bool p0)
		{
			const string __id = "setMapCustomStyleEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setMapCustomStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMapCustomStylePath", "(Ljava/lang/String;)V", "")]
		public unsafe void SetMapCustomStylePath (string p0)
		{
			const string __id = "setMapCustomStylePath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setUpViewEventToMapView' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("setUpViewEventToMapView", "(Landroid/view/MotionEvent;)V", "")]
		public unsafe void SetUpViewEventToMapView (global::Android.Views.MotionEvent p0)
		{
			const string __id = "setUpViewEventToMapView.(Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='setZOrderMediaOverlay' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZOrderMediaOverlay", "(Z)V", "")]
		public unsafe void SetZOrderMediaOverlay (bool p0)
		{
			const string __id = "setZOrderMediaOverlay.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='showScaleControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showScaleControl", "(Z)V", "")]
		public unsafe void ShowScaleControl (bool p0)
		{
			const string __id = "showScaleControl.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='MapView']/method[@name='showZoomControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showZoomControls", "(Z)V", "")]
		public unsafe void ShowZoomControls (bool p0)
		{
			const string __id = "showZoomControls.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
