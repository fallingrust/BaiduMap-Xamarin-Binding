using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView", DoNotGenerateAcw=true)]
	public partial class WearMapView : global::Android.Views.ViewGroup, global::Android.Views.View.IOnApplyWindowInsetsListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='BT_INVIEW']"
		[Register ("BT_INVIEW")]
		public const int BtInview = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='mTask']"
		[Register ("mTask")]
		public global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask MTask {
			get {
				const string __id = "mTask.Lcom/baidu/mapapi/map/WearMapView$AnimationTask;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTask.Lcom/baidu/mapapi/map/WearMapView$AnimationTask;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/field[@name='mTimer']"
		[Register ("mTimer")]
		public global::Java.Util.Timer MTimer {
			get {
				const string __id = "mTimer.Ljava/util/Timer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Timer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTimer.Ljava/util/Timer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView$AnimationTask", DoNotGenerateAcw=true)]
		public partial class AnimationTask : global::Java.Util.TimerTask {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/WearMapView$AnimationTask", typeof (AnimationTask));
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

			protected AnimationTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']/constructor[@name='WearMapView.AnimationTask' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView']]"
			[Register (".ctor", "(Lcom/baidu/mapapi/map/WearMapView;)V", "")]
			public unsafe AnimationTask (global::Com.Baidu.Mapapi.Map.WearMapView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.AnimationTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.AnimationTask']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public override unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']"
		[Register ("com/baidu/mapapi/map/WearMapView$OnDismissCallback", "", "Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker")]
		public partial interface IOnDismissCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']/method[@name='onDismiss' and count(parameter)=0]"
			[Register ("onDismiss", "()V", "GetOnDismissHandler:Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker, BaiduMapBind")]
			void OnDismiss ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/interface[@name='WearMapView.OnDismissCallback']/method[@name='onNotify' and count(parameter)=0]"
			[Register ("onNotify", "()V", "GetOnNotifyHandler:Com.Baidu.Mapapi.Map.WearMapView/IOnDismissCallbackInvoker, BaiduMapBind")]
			void OnNotify ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView$OnDismissCallback", DoNotGenerateAcw=true)]
		internal class IOnDismissCallbackInvoker : global::Java.Lang.Object, IOnDismissCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/WearMapView$OnDismissCallback", typeof (IOnDismissCallbackInvoker));

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

			public static IOnDismissCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnDismissCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.map.WearMapView.OnDismissCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnDismissCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onDismiss;
#pragma warning disable 0169
			static Delegate GetOnDismissHandler ()
			{
				if (cb_onDismiss == null)
					cb_onDismiss = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDismiss);
				return cb_onDismiss;
			}

			static void n_OnDismiss (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnDismiss ();
			}
#pragma warning restore 0169

			IntPtr id_onDismiss;
			public unsafe void OnDismiss ()
			{
				if (id_onDismiss == IntPtr.Zero)
					id_onDismiss = JNIEnv.GetMethodID (class_ref, "onDismiss", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDismiss);
			}

			static Delegate cb_onNotify;
#pragma warning disable 0169
			static Delegate GetOnNotifyHandler ()
			{
				if (cb_onNotify == null)
					cb_onNotify = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNotify);
				return cb_onNotify;
			}

			static void n_OnNotify (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNotify ();
			}
#pragma warning restore 0169

			IntPtr id_onNotify;
			public unsafe void OnNotify ()
			{
				if (id_onNotify == IntPtr.Zero)
					id_onNotify = JNIEnv.GetMethodID (class_ref, "onNotify", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNotify);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/map/WearMapView$ScreenShape", DoNotGenerateAcw=true)]
		public sealed partial class ScreenShape : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']/field[@name='RECTANGLE']"
			[Register ("RECTANGLE")]
			public static global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape Rectangle {
				get {
					const string __id = "RECTANGLE.Lcom/baidu/mapapi/map/WearMapView$ScreenShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']/field[@name='ROUND']"
			[Register ("ROUND")]
			public static global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape Round {
				get {
					const string __id = "ROUND.Lcom/baidu/mapapi/map/WearMapView$ScreenShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']/field[@name='UNDETECTED']"
			[Register ("UNDETECTED")]
			public static global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape Undetected {
				get {
					const string __id = "UNDETECTED.Lcom/baidu/mapapi/map/WearMapView$ScreenShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/WearMapView$ScreenShape", typeof (ScreenShape));
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

			internal ScreenShape (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/map/WearMapView$ScreenShape;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/map/WearMapView$ScreenShape;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView.ScreenShape']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/map/WearMapView$ScreenShape;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/map/WearMapView$ScreenShape;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/WearMapView", typeof (WearMapView));
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

		protected WearMapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/constructor[@name='WearMapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.baidu.mapapi.map.BaiduMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/baidu/mapapi/map/BaiduMapOptions;)V", "")]
		public unsafe WearMapView (global::Android.Content.Context p0, global::Com.Baidu.Mapapi.Map.BaiduMapOptions p1)
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

		public unsafe global::Com.Baidu.Mapapi.Map.BaiduMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getMap' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getMapLevel' and count(parameter)=0]"
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

		static Delegate cb_getScaleControlViewHeight;
#pragma warning disable 0169
		static Delegate GetGetScaleControlViewHeightHandler ()
		{
			if (cb_getScaleControlViewHeight == null)
				cb_getScaleControlViewHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleControlViewHeight);
			return cb_getScaleControlViewHeight;
		}

		static int n_GetScaleControlViewHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleControlViewHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int ScaleControlViewHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getScaleControlViewHeight' and count(parameter)=0]"
			[Register ("getScaleControlViewHeight", "()I", "GetGetScaleControlViewHeightHandler")]
			get {
				const string __id = "getScaleControlViewHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScaleControlViewWidth;
#pragma warning disable 0169
		static Delegate GetGetScaleControlViewWidthHandler ()
		{
			if (cb_getScaleControlViewWidth == null)
				cb_getScaleControlViewWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScaleControlViewWidth);
			return cb_getScaleControlViewWidth;
		}

		static int n_GetScaleControlViewWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleControlViewWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int ScaleControlViewWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='getScaleControlViewWidth' and count(parameter)=0]"
			[Register ("getScaleControlViewWidth", "()I", "GetGetScaleControlViewWidthHandler")]
			get {
				const string __id = "getScaleControlViewWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_;
#pragma warning disable 0169
		static Delegate GetOnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_Handler ()
		{
			if (cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ == null)
				cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_);
			return cb_onApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_;
		}

		static IntPtr n_OnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.WindowInsets p1 = global::Java.Lang.Object.GetObject<global::Android.Views.WindowInsets> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnApplyWindowInsets (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onApplyWindowInsets' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.WindowInsets']]"
		[Register ("onApplyWindowInsets", "(Landroid/view/View;Landroid/view/WindowInsets;)Landroid/view/WindowInsets;", "GetOnApplyWindowInsets_Landroid_view_View_Landroid_view_WindowInsets_Handler")]
		public virtual unsafe global::Android.Views.WindowInsets OnApplyWindowInsets (global::Android.Views.View p0, global::Android.Views.WindowInsets p1)
		{
			const string __id = "onApplyWindowInsets.(Landroid/view/View;Landroid/view/WindowInsets;)Landroid/view/WindowInsets;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Views.WindowInsets> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_content_Context_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_content_Context_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_content_Context_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_content_Context_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/content/Context;Landroid/os/Bundle;)V", "GetOnCreate_Landroid_content_Context_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.Content.Context p0, global::Android.OS.Bundle p1)
		{
			const string __id = "onCreate.(Landroid/content/Context;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "")]
		public unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onDismiss' and count(parameter)=0]"
		[Register ("onDismiss", "()V", "")]
		public unsafe void OnDismiss ()
		{
			const string __id = "onDismiss.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onEnterAmbient' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onEnterAmbient", "(Landroid/os/Bundle;)V", "")]
		public unsafe void OnEnterAmbient (global::Android.OS.Bundle p0)
		{
			const string __id = "onEnterAmbient.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onExitAmbient;
#pragma warning disable 0169
		static Delegate GetOnExitAmbientHandler ()
		{
			if (cb_onExitAmbient == null)
				cb_onExitAmbient = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnExitAmbient);
			return cb_onExitAmbient;
		}

		static void n_OnExitAmbient (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnExitAmbient ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onExitAmbient' and count(parameter)=0]"
		[Register ("onExitAmbient", "()V", "GetOnExitAmbientHandler")]
		public virtual unsafe void OnExitAmbient ()
		{
			const string __id = "onExitAmbient.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
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

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			const string __id = "onSaveInstanceState.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setCustomMapStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_setCustomStyleFilePathAndMode_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetCustomStyleFilePathAndMode_Ljava_lang_String_IHandler ()
		{
			if (cb_setCustomStyleFilePathAndMode_Ljava_lang_String_I == null)
				cb_setCustomStyleFilePathAndMode_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetCustomStyleFilePathAndMode_Ljava_lang_String_I);
			return cb_setCustomStyleFilePathAndMode_Ljava_lang_String_I;
		}

		static void n_SetCustomStyleFilePathAndMode_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomStyleFilePathAndMode (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setCustomStyleFilePathAndMode' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("setCustomStyleFilePathAndMode", "(Ljava/lang/String;I)V", "GetSetCustomStyleFilePathAndMode_Ljava_lang_String_IHandler")]
		public virtual unsafe void SetCustomStyleFilePathAndMode (string p0, int p1)
		{
			const string __id = "setCustomStyleFilePathAndMode.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setIconCustom' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setLoadCustomMapStyleFileMode' and count(parameter)=1 and parameter[1][@type='int']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setMapCustomEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_;
#pragma warning disable 0169
		static Delegate GetSetMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_Handler ()
		{
			if (cb_setMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_ == null)
				cb_setMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_);
			return cb_setMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_;
		}

		static void n_SetMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack p1 = (global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetMapCustomStyle (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setMapCustomStyle' and count(parameter)=2 and parameter[1][@type='com.baidu.mapapi.map.MapCustomStyleOptions'] and parameter[2][@type='com.baidu.mapapi.map.MapView.CustomMapStyleCallBack']]"
		[Register ("setMapCustomStyle", "(Lcom/baidu/mapapi/map/MapCustomStyleOptions;Lcom/baidu/mapapi/map/MapView$CustomMapStyleCallBack;)V", "GetSetMapCustomStyle_Lcom_baidu_mapapi_map_MapCustomStyleOptions_Lcom_baidu_mapapi_map_MapView_CustomMapStyleCallBack_Handler")]
		public virtual unsafe void SetMapCustomStyle (global::Com.Baidu.Mapapi.Map.MapCustomStyleOptions p0, global::Com.Baidu.Mapapi.Map.MapView.ICustomMapStyleCallBack p1)
		{
			const string __id = "setMapCustomStyle.(Lcom/baidu/mapapi/map/MapCustomStyleOptions;Lcom/baidu/mapapi/map/MapView$CustomMapStyleCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMapCustomStyleEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetMapCustomStyleEnable_ZHandler ()
		{
			if (cb_setMapCustomStyleEnable_Z == null)
				cb_setMapCustomStyleEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMapCustomStyleEnable_Z);
			return cb_setMapCustomStyleEnable_Z;
		}

		static void n_SetMapCustomStyleEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMapCustomStyleEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setMapCustomStyleEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMapCustomStyleEnable", "(Z)V", "GetSetMapCustomStyleEnable_ZHandler")]
		public virtual unsafe void SetMapCustomStyleEnable (bool p0)
		{
			const string __id = "setMapCustomStyleEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMapCustomStylePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetMapCustomStylePath_Ljava_lang_String_Handler ()
		{
			if (cb_setMapCustomStylePath_Ljava_lang_String_ == null)
				cb_setMapCustomStylePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapCustomStylePath_Ljava_lang_String_);
			return cb_setMapCustomStylePath_Ljava_lang_String_;
		}

		static void n_SetMapCustomStylePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMapCustomStylePath (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setMapCustomStylePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setMapCustomStylePath", "(Ljava/lang/String;)V", "GetSetMapCustomStylePath_Ljava_lang_String_Handler")]
		public virtual unsafe void SetMapCustomStylePath (string p0)
		{
			const string __id = "setMapCustomStylePath.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
#pragma warning disable 0169
		static Delegate GetSetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler ()
		{
			if (cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == null)
				cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_);
			return cb_setOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		}

		static void n_SetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0 = (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDismissCallbackListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setOnDismissCallbackListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView.OnDismissCallback']]"
		[Register ("setOnDismissCallbackListener", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V", "GetSetOnDismissCallbackListener_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler")]
		public virtual unsafe void SetOnDismissCallbackListener (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0)
		{
			const string __id = "setOnDismissCallbackListener.(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleControlPosition_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetScaleControlPosition_Landroid_graphics_Point_Handler ()
		{
			if (cb_setScaleControlPosition_Landroid_graphics_Point_ == null)
				cb_setScaleControlPosition_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleControlPosition_Landroid_graphics_Point_);
			return cb_setScaleControlPosition_Landroid_graphics_Point_;
		}

		static void n_SetScaleControlPosition_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleControlPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setScaleControlPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setScaleControlPosition", "(Landroid/graphics/Point;)V", "GetSetScaleControlPosition_Landroid_graphics_Point_Handler")]
		public virtual unsafe void SetScaleControlPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "setScaleControlPosition.(Landroid/graphics/Point;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_;
#pragma warning disable 0169
		static Delegate GetSetShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_Handler ()
		{
			if (cb_setShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_ == null)
				cb_setShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_);
			return cb_setShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_;
		}

		static void n_SetShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetShape (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setShape' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView.ScreenShape']]"
		[Register ("setShape", "(Lcom/baidu/mapapi/map/WearMapView$ScreenShape;)V", "GetSetShape_Lcom_baidu_mapapi_map_WearMapView_ScreenShape_Handler")]
		public virtual unsafe void SetShape (global::Com.Baidu.Mapapi.Map.WearMapView.ScreenShape p0)
		{
			const string __id = "setShape.(Lcom/baidu/mapapi/map/WearMapView$ScreenShape;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setViewAnimitionEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetViewAnimitionEnable_ZHandler ()
		{
			if (cb_setViewAnimitionEnable_Z == null)
				cb_setViewAnimitionEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetViewAnimitionEnable_Z);
			return cb_setViewAnimitionEnable_Z;
		}

		static void n_SetViewAnimitionEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetViewAnimitionEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setViewAnimitionEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setViewAnimitionEnable", "(Z)V", "GetSetViewAnimitionEnable_ZHandler")]
		public virtual unsafe void SetViewAnimitionEnable (bool p0)
		{
			const string __id = "setViewAnimitionEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setZoomControlsPosition_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetSetZoomControlsPosition_Landroid_graphics_Point_Handler ()
		{
			if (cb_setZoomControlsPosition_Landroid_graphics_Point_ == null)
				cb_setZoomControlsPosition_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoomControlsPosition_Landroid_graphics_Point_);
			return cb_setZoomControlsPosition_Landroid_graphics_Point_;
		}

		static void n_SetZoomControlsPosition_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomControlsPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='setZoomControlsPosition' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("setZoomControlsPosition", "(Landroid/graphics/Point;)V", "GetSetZoomControlsPosition_Landroid_graphics_Point_Handler")]
		public virtual unsafe void SetZoomControlsPosition (global::Android.Graphics.Point p0)
		{
			const string __id = "setZoomControlsPosition.(Landroid/graphics/Point;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showScaleControl_Z;
#pragma warning disable 0169
		static Delegate GetShowScaleControl_ZHandler ()
		{
			if (cb_showScaleControl_Z == null)
				cb_showScaleControl_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowScaleControl_Z);
			return cb_showScaleControl_Z;
		}

		static void n_ShowScaleControl_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowScaleControl (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='showScaleControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showScaleControl", "(Z)V", "GetShowScaleControl_ZHandler")]
		public virtual unsafe void ShowScaleControl (bool p0)
		{
			const string __id = "showScaleControl.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showZoomControls_Z;
#pragma warning disable 0169
		static Delegate GetShowZoomControls_ZHandler ()
		{
			if (cb_showZoomControls_Z == null)
				cb_showZoomControls_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ShowZoomControls_Z);
			return cb_showZoomControls_Z;
		}

		static void n_ShowZoomControls_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.WearMapView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowZoomControls (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='WearMapView']/method[@name='showZoomControls' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("showZoomControls", "(Z)V", "GetShowZoomControls_ZHandler")]
		public virtual unsafe void ShowZoomControls (bool p0)
		{
			const string __id = "showZoomControls.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
