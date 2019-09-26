using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/animation/Animation", DoNotGenerateAcw=true)]
	public abstract partial class Animation : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.baidu.mapapi.animation']/interface[@name='Animation.AnimationListener']"
		[Register ("com/baidu/mapapi/animation/Animation$AnimationListener", "", "Com.Baidu.Mapapi.Animation.Animation/IAnimationListenerInvoker")]
		public partial interface IAnimationListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/interface[@name='Animation.AnimationListener']/method[@name='onAnimationCancel' and count(parameter)=0]"
			[Register ("onAnimationCancel", "()V", "GetOnAnimationCancelHandler:Com.Baidu.Mapapi.Animation.Animation/IAnimationListenerInvoker, BaiduMapBind")]
			void OnAnimationCancel ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/interface[@name='Animation.AnimationListener']/method[@name='onAnimationEnd' and count(parameter)=0]"
			[Register ("onAnimationEnd", "()V", "GetOnAnimationEndHandler:Com.Baidu.Mapapi.Animation.Animation/IAnimationListenerInvoker, BaiduMapBind")]
			void OnAnimationEnd ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/interface[@name='Animation.AnimationListener']/method[@name='onAnimationRepeat' and count(parameter)=0]"
			[Register ("onAnimationRepeat", "()V", "GetOnAnimationRepeatHandler:Com.Baidu.Mapapi.Animation.Animation/IAnimationListenerInvoker, BaiduMapBind")]
			void OnAnimationRepeat ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/interface[@name='Animation.AnimationListener']/method[@name='onAnimationStart' and count(parameter)=0]"
			[Register ("onAnimationStart", "()V", "GetOnAnimationStartHandler:Com.Baidu.Mapapi.Animation.Animation/IAnimationListenerInvoker, BaiduMapBind")]
			void OnAnimationStart ();

		}

		[global::Android.Runtime.Register ("com/baidu/mapapi/animation/Animation$AnimationListener", DoNotGenerateAcw=true)]
		internal class IAnimationListenerInvoker : global::Java.Lang.Object, IAnimationListener {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/animation/Animation$AnimationListener", typeof (IAnimationListenerInvoker));

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

			public static IAnimationListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IAnimationListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.baidu.mapapi.animation.Animation.AnimationListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IAnimationListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onAnimationCancel;
#pragma warning disable 0169
			static Delegate GetOnAnimationCancelHandler ()
			{
				if (cb_onAnimationCancel == null)
					cb_onAnimationCancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationCancel);
				return cb_onAnimationCancel;
			}

			static void n_OnAnimationCancel (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationCancel ();
			}
#pragma warning restore 0169

			IntPtr id_onAnimationCancel;
			public unsafe void OnAnimationCancel ()
			{
				if (id_onAnimationCancel == IntPtr.Zero)
					id_onAnimationCancel = JNIEnv.GetMethodID (class_ref, "onAnimationCancel", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationCancel);
			}

			static Delegate cb_onAnimationEnd;
#pragma warning disable 0169
			static Delegate GetOnAnimationEndHandler ()
			{
				if (cb_onAnimationEnd == null)
					cb_onAnimationEnd = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationEnd);
				return cb_onAnimationEnd;
			}

			static void n_OnAnimationEnd (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationEnd ();
			}
#pragma warning restore 0169

			IntPtr id_onAnimationEnd;
			public unsafe void OnAnimationEnd ()
			{
				if (id_onAnimationEnd == IntPtr.Zero)
					id_onAnimationEnd = JNIEnv.GetMethodID (class_ref, "onAnimationEnd", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationEnd);
			}

			static Delegate cb_onAnimationRepeat;
#pragma warning disable 0169
			static Delegate GetOnAnimationRepeatHandler ()
			{
				if (cb_onAnimationRepeat == null)
					cb_onAnimationRepeat = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationRepeat);
				return cb_onAnimationRepeat;
			}

			static void n_OnAnimationRepeat (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationRepeat ();
			}
#pragma warning restore 0169

			IntPtr id_onAnimationRepeat;
			public unsafe void OnAnimationRepeat ()
			{
				if (id_onAnimationRepeat == IntPtr.Zero)
					id_onAnimationRepeat = JNIEnv.GetMethodID (class_ref, "onAnimationRepeat", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationRepeat);
			}

			static Delegate cb_onAnimationStart;
#pragma warning disable 0169
			static Delegate GetOnAnimationStartHandler ()
			{
				if (cb_onAnimationStart == null)
					cb_onAnimationStart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnAnimationStart);
				return cb_onAnimationStart;
			}

			static void n_OnAnimationStart (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnAnimationStart ();
			}
#pragma warning restore 0169

			IntPtr id_onAnimationStart;
			public unsafe void OnAnimationStart ()
			{
				if (id_onAnimationStart == IntPtr.Zero)
					id_onAnimationStart = JNIEnv.GetMethodID (class_ref, "onAnimationStart", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAnimationStart);
			}

		}

		[global::Android.Runtime.Register ("mono/com/baidu/mapapi/animation/Animation_AnimationListenerImplementor")]
		internal sealed partial class IAnimationListenerImplementor : global::Java.Lang.Object, IAnimationListener {

			object sender;

			public IAnimationListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/baidu/mapapi/animation/Animation_AnimationListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnAnimationCancelHandler;
#pragma warning restore 0649

			public void OnAnimationCancel ()
			{
				var __h = OnAnimationCancelHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnAnimationEndHandler;
#pragma warning restore 0649

			public void OnAnimationEnd ()
			{
				var __h = OnAnimationEndHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnAnimationRepeatHandler;
#pragma warning restore 0649

			public void OnAnimationRepeat ()
			{
				var __h = OnAnimationRepeatHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnAnimationStartHandler;
#pragma warning restore 0649

			public void OnAnimationStart ()
			{
				var __h = OnAnimationStartHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IAnimationListenerImplementor value)
			{
				return value.OnAnimationCancelHandler == null && value.OnAnimationEndHandler == null && value.OnAnimationRepeatHandler == null && value.OnAnimationStartHandler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation.RepeatMode']"
		[global::Android.Runtime.Register ("com/baidu/mapapi/animation/Animation$RepeatMode", DoNotGenerateAcw=true)]
		public sealed partial class RepeatMode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation.RepeatMode']/field[@name='RESTART']"
			[Register ("RESTART")]
			public static global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode Restart {
				get {
					const string __id = "RESTART.Lcom/baidu/mapapi/animation/Animation$RepeatMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation.RepeatMode']/field[@name='REVERSE']"
			[Register ("REVERSE")]
			public static global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode Reverse {
				get {
					const string __id = "REVERSE.Lcom/baidu/mapapi/animation/Animation$RepeatMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/animation/Animation$RepeatMode", typeof (RepeatMode));
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

			internal RepeatMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation.RepeatMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/baidu/mapapi/animation/Animation$RepeatMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/baidu/mapapi/animation/Animation$RepeatMode;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation.RepeatMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/baidu/mapapi/animation/Animation$RepeatMode;", "")]
			public static unsafe global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode[] Values ()
			{
				const string __id = "values.()[Lcom/baidu/mapapi/animation/Animation$RepeatMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/animation/Animation", typeof (Animation));
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

		protected Animation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/constructor[@name='Animation' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Animation ()
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

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Animation.Animation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel ();

		static Delegate cb_setAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_;
#pragma warning disable 0169
		static Delegate GetSetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_Handler ()
		{
			if (cb_setAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_ == null)
				cb_setAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_);
			return cb_setAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_;
		}

		static void n_SetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Animation.Animation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0 = (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation.AnimationListener']]"
		[Register ("setAnimationListener", "(Lcom/baidu/mapapi/animation/Animation$AnimationListener;)V", "GetSetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_Handler")]
		public abstract void SetAnimationListener (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0);

		static Delegate cb_setDuration_J;
#pragma warning disable 0169
		static Delegate GetSetDuration_JHandler ()
		{
			if (cb_setDuration_J == null)
				cb_setDuration_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetDuration_J);
			return cb_setDuration_J;
		}

		static void n_SetDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Baidu.Mapapi.Animation.Animation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
		public abstract void SetDuration (long p0);

		static Delegate cb_setInterpolator_Landroid_view_animation_Interpolator_;
#pragma warning disable 0169
		static Delegate GetSetInterpolator_Landroid_view_animation_Interpolator_Handler ()
		{
			if (cb_setInterpolator_Landroid_view_animation_Interpolator_ == null)
				cb_setInterpolator_Landroid_view_animation_Interpolator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInterpolator_Landroid_view_animation_Interpolator_);
			return cb_setInterpolator_Landroid_view_animation_Interpolator_;
		}

		static void n_SetInterpolator_Landroid_view_animation_Interpolator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Animation.Animation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public abstract void SetInterpolator (global::Android.Views.Animations.IInterpolator p0);

#region "Event implementation for Com.Baidu.Mapapi.Animation.Animation.IAnimationListener"
		public event EventHandler AnimationCancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationCancelHandler -= value);
			}
		}

		public event EventHandler AnimationEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationEndHandler -= value);
			}
		}

		public event EventHandler AnimationRepeat {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationRepeatHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationRepeatHandler -= value);
			}
		}

		public event EventHandler AnimationStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						__CreateIAnimationListenerImplementor,
						SetAnimationListener,
						__h => __h.OnAnimationStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener, global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor>(
						ref weak_implementor_SetAnimationListener,
						global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor.__IsEmpty,
						__v => SetAnimationListener (null),
						__h => __h.OnAnimationStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAnimationListener;

		global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor __CreateIAnimationListenerImplementor ()
		{
			return new global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/animation/Animation", DoNotGenerateAcw=true)]
	internal partial class AnimationInvoker : Animation {

		public AnimationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/animation/Animation", typeof (AnimationInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation.AnimationListener']]"
		[Register ("setAnimationListener", "(Lcom/baidu/mapapi/animation/Animation$AnimationListener;)V", "GetSetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_Handler")]
		public override unsafe void SetAnimationListener (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0)
		{
			const string __id = "setAnimationListener.(Lcom/baidu/mapapi/animation/Animation$AnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
		public override unsafe void SetDuration (long p0)
		{
			const string __id = "setDuration.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Animation']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			const string __id = "setInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
