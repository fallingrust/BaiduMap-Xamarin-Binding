using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/InfoWindow", DoNotGenerateAcw=true)]
	public partial class InfoWindow : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='InfoWindow.OnInfoWindowClickListener']"
		[Register ("com/baidu/mapapi/map/InfoWindow$OnInfoWindowClickListener", "", "Com.Baidu.Mapapi.Map.InfoWindow/IOnInfoWindowClickListenerInvoker")]
		public partial interface IOnInfoWindowClickListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='InfoWindow.OnInfoWindowClickListener']/method[@name='onInfoWindowClick' and count(parameter)=0]"
			[Register ("onInfoWindowClick", "()V", "GetOnInfoWindowClickHandler:Com.Baidu.Mapapi.Map.InfoWindow/IOnInfoWindowClickListenerInvoker, BaiduMapBind")]
			void OnInfoWindowClick ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/InfoWindow$OnInfoWindowClickListener", DoNotGenerateAcw=true)]
		internal class IOnInfoWindowClickListenerInvoker : global::Java.Lang.Object, IOnInfoWindowClickListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/InfoWindow$OnInfoWindowClickListener", typeof (IOnInfoWindowClickListenerInvoker));

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

			public static IOnInfoWindowClickListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnInfoWindowClickListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.InfoWindow.OnInfoWindowClickListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnInfoWindowClickListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onInfoWindowClick;
#pragma warning disable 0169
			static Delegate GetOnInfoWindowClickHandler ()
			{
				if (cb_onInfoWindowClick == null)
					cb_onInfoWindowClick = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInfoWindowClick);
				return cb_onInfoWindowClick;
			}

			static void n_OnInfoWindowClick (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.InfoWindow.IOnInfoWindowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow.IOnInfoWindowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnInfoWindowClick ();
			}
#pragma warning restore 0169

			IntPtr id_onInfoWindowClick;
			public unsafe void OnInfoWindowClick ()
			{
				if (id_onInfoWindowClick == IntPtr.Zero)
					id_onInfoWindowClick = JNIEnv.GetMethodID (class_ref, "onInfoWindowClick", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInfoWindowClick);
			}

		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/map/InfoWindow_OnInfoWindowClickListenerImplementor")]
		internal sealed partial class IOnInfoWindowClickListenerImplementor : global::Java.Lang.Object, IOnInfoWindowClickListener {

			object sender;

			public IOnInfoWindowClickListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/map/InfoWindow_OnInfoWindowClickListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnInfoWindowClick ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnInfoWindowClickListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/InfoWindow", typeof (InfoWindow));
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

		protected InfoWindow (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/constructor[@name='InfoWindow' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.baidu.mapapi.model.LatLng'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/baidu/mapapi/model/LatLng;I)V", "")]
		public unsafe InfoWindow (global::Android.Views.View p0, global::Com.Baidu.Mapapi.Model.LatLng p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;Lcom/baidu/mapapi/model/LatLng;I)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/constructor[@name='InfoWindow' and count(parameter)=5 and parameter[1][@type='android.view.View'] and parameter[2][@type='com.baidu.mapapi.model.LatLng'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int']]"
		[Register (".ctor", "(Landroid/view/View;Lcom/baidu/mapapi/model/LatLng;IZI)V", "")]
		public unsafe InfoWindow (global::Android.Views.View p0, global::Com.Baidu.Mapapi.Model.LatLng p1, int p2, bool p3, int p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;Lcom/baidu/mapapi/model/LatLng;IZI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/constructor[@name='InfoWindow' and count(parameter)=4 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor'] and parameter[2][@type='com.baidu.mapapi.model.LatLng'] and parameter[3][@type='int'] and parameter[4][@type='com.baidu.mapapi.map.InfoWindow.OnInfoWindowClickListener']]"
		[Register (".ctor", "(Lcom/baidu/mapapi/map/BitmapDescriptor;Lcom/baidu/mapapi/model/LatLng;ILcom/baidu/mapapi/map/InfoWindow$OnInfoWindowClickListener;)V", "")]
		public unsafe InfoWindow (global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0, global::Com.Baidu.Mapapi.Model.LatLng p1, int p2, global::Com.Baidu.Mapapi.Map.InfoWindow.IOnInfoWindowClickListener p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/baidu/mapapi/map/BitmapDescriptor;Lcom/baidu/mapapi/model/LatLng;ILcom/baidu/mapapi/map/InfoWindow$OnInfoWindowClickListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmapDescriptor;
#pragma warning disable 0169
		static Delegate GetGetBitmapDescriptorHandler ()
		{
			if (cb_getBitmapDescriptor == null)
				cb_getBitmapDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmapDescriptor);
			return cb_getBitmapDescriptor;
		}

		static IntPtr n_GetBitmapDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapDescriptor);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_;
#pragma warning disable 0169
		static Delegate GetSetBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_Handler ()
		{
			if (cb_setBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_ == null)
				cb_setBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_);
			return cb_setBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_;
		}

		static void n_SetBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.BitmapDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BitmapDescriptor = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Map.BitmapDescriptor BitmapDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='getBitmapDescriptor' and count(parameter)=0]"
			[Register ("getBitmapDescriptor", "()Lcom/baidu/mapapi/map/BitmapDescriptor;", "GetGetBitmapDescriptorHandler")]
			get {
				const string __id = "getBitmapDescriptor.()Lcom/baidu/mapapi/map/BitmapDescriptor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='setBitmapDescriptor' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.BitmapDescriptor']]"
			[Register ("setBitmapDescriptor", "(Lcom/baidu/mapapi/map/BitmapDescriptor;)V", "GetSetBitmapDescriptor_Lcom_baidu_mapapi_map_BitmapDescriptor_Handler")]
			set {
				const string __id = "setBitmapDescriptor.(Lcom/baidu/mapapi/map/BitmapDescriptor;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_baidu_mapapi_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_baidu_mapapi_model_LatLng_Handler ()
		{
			if (cb_setPosition_Lcom_baidu_mapapi_model_LatLng_ == null)
				cb_setPosition_Lcom_baidu_mapapi_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_baidu_mapapi_model_LatLng_);
			return cb_setPosition_Lcom_baidu_mapapi_model_LatLng_;
		}

		static void n_SetPosition_Lcom_baidu_mapapi_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Model.LatLng Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/baidu/mapapi/model/LatLng;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/baidu/mapapi/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng']]"
			[Register ("setPosition", "(Lcom/baidu/mapapi/model/LatLng;)V", "GetSetPosition_Lcom_baidu_mapapi_model_LatLng_Handler")]
			set {
				const string __id = "setPosition.(Lcom/baidu/mapapi/model/LatLng;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Tag);
		}
#pragma warning restore 0169

		static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_String_Handler ()
		{
			if (cb_setTag_Ljava_lang_String_ == null)
				cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_String_);
			return cb_setTag_Ljava_lang_String_;
		}

		static void n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Tag = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTag", "(Ljava/lang/String;)V", "GetSetTag_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTag.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.View = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
			set {
				const string __id = "setView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYOffset;
#pragma warning disable 0169
		static Delegate GetGetYOffsetHandler ()
		{
			if (cb_getYOffset == null)
				cb_getYOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetYOffset);
			return cb_getYOffset;
		}

		static int n_GetYOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setYOffset_I;
#pragma warning disable 0169
		static Delegate GetSetYOffset_IHandler ()
		{
			if (cb_setYOffset_I == null)
				cb_setYOffset_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetYOffset_I);
			return cb_setYOffset_I;
		}

		static void n_SetYOffset_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.InfoWindow __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.InfoWindow> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YOffset = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int YOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='getYOffset' and count(parameter)=0]"
			[Register ("getYOffset", "()I", "GetGetYOffsetHandler")]
			get {
				const string __id = "getYOffset.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='InfoWindow']/method[@name='setYOffset' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setYOffset", "(I)V", "GetSetYOffset_IHandler")]
			set {
				const string __id = "setYOffset.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
