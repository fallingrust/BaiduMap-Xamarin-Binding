using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/animation/Transformation", DoNotGenerateAcw=true)]
	public partial class Transformation : global::Com.Baidu.Mapapi.Animation.Animation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/animation/Transformation", typeof (Transformation));
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

		protected Transformation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/constructor[@name='Transformation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point...']]"
		[Register (".ctor", "([Landroid/graphics/Point;)V", "")]
		public unsafe Transformation (params global::Android.Graphics.Point[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Landroid/graphics/Point;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/constructor[@name='Transformation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.LatLng...']]"
		[Register (".ctor", "([Lcom/baidu/mapapi/model/LatLng;)V", "")]
		public unsafe Transformation (params global::Com.Baidu.Mapapi.Model.LatLng[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/baidu/mapapi/model/LatLng;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
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
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public override unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

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
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0 = (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation.AnimationListener']]"
		[Register ("setAnimationListener", "(Lcom/baidu/mapapi/animation/Animation$AnimationListener;)V", "GetSetAnimationListener_Lcom_baidu_mapapi_animation_Animation_AnimationListener_Handler")]
		public override unsafe void SetAnimationListener (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0)
		{
			const string __id = "setAnimationListener.(Lcom/baidu/mapapi/animation/Animation$AnimationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setDuration", "(J)V", "GetSetDuration_JHandler")]
		public override unsafe void SetDuration (long p0)
		{
			const string __id = "setDuration.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
		[Register ("setInterpolator", "(Landroid/view/animation/Interpolator;)V", "GetSetInterpolator_Landroid_view_animation_Interpolator_Handler")]
		public override unsafe void SetInterpolator (global::Android.Views.Animations.IInterpolator p0)
		{
			const string __id = "setInterpolator.(Landroid/view/animation/Interpolator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRepeatCount_I;
#pragma warning disable 0169
		static Delegate GetSetRepeatCount_IHandler ()
		{
			if (cb_setRepeatCount_I == null)
				cb_setRepeatCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRepeatCount_I);
			return cb_setRepeatCount_I;
		}

		static void n_SetRepeatCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeatCount (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='setRepeatCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRepeatCount", "(I)V", "GetSetRepeatCount_IHandler")]
		public virtual unsafe void SetRepeatCount (int p0)
		{
			const string __id = "setRepeatCount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_;
#pragma warning disable 0169
		static Delegate GetSetRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_Handler ()
		{
			if (cb_setRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_ == null)
				cb_setRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_);
			return cb_setRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_;
		}

		static void n_SetRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Animation.Transformation __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Transformation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetRepeatMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='Transformation']/method[@name='setRepeatMode' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation.RepeatMode']]"
		[Register ("setRepeatMode", "(Lcom/baidu/mapapi/animation/Animation$RepeatMode;)V", "GetSetRepeatMode_Lcom_baidu_mapapi_animation_Animation_RepeatMode_Handler")]
		public virtual unsafe void SetRepeatMode (global::Com.Baidu.Mapapi.Animation.Animation.RepeatMode p0)
		{
			const string __id = "setRepeatMode.(Lcom/baidu/mapapi/animation/Animation$RepeatMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
}
