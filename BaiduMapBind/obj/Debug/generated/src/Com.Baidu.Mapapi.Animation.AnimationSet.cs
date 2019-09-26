using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/animation/AnimationSet", DoNotGenerateAcw=true)]
	public partial class AnimationSet : global::Com.Baidu.Mapapi.Animation.Animation {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/animation/AnimationSet", typeof (AnimationSet));
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

		protected AnimationSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/constructor[@name='AnimationSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AnimationSet ()
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

		static Delegate cb_addAnimation_Lcom_baidu_mapapi_animation_Animation_;
#pragma warning disable 0169
		static Delegate GetAddAnimation_Lcom_baidu_mapapi_animation_Animation_Handler ()
		{
			if (cb_addAnimation_Lcom_baidu_mapapi_animation_Animation_ == null)
				cb_addAnimation_Lcom_baidu_mapapi_animation_Animation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddAnimation_Lcom_baidu_mapapi_animation_Animation_);
			return cb_addAnimation_Lcom_baidu_mapapi_animation_Animation_;
		}

		static void n_AddAnimation_Lcom_baidu_mapapi_animation_Animation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Animation.Animation p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddAnimation (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='addAnimation' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation']]"
		[Register ("addAnimation", "(Lcom/baidu/mapapi/animation/Animation;)V", "GetAddAnimation_Lcom_baidu_mapapi_animation_Animation_Handler")]
		public virtual unsafe void AddAnimation (global::Com.Baidu.Mapapi.Animation.Animation p0)
		{
			const string __id = "addAnimation.(Lcom/baidu/mapapi/animation/Animation;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='cancel' and count(parameter)=0]"
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
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener p0 = (global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.Animation.IAnimationListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimationListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='setAnimationListener' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.animation.Animation.AnimationListener']]"
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

		static Delegate cb_setAnimatorSetMode_I;
#pragma warning disable 0169
		static Delegate GetSetAnimatorSetMode_IHandler ()
		{
			if (cb_setAnimatorSetMode_I == null)
				cb_setAnimatorSetMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnimatorSetMode_I);
			return cb_setAnimatorSetMode_I;
		}

		static void n_SetAnimatorSetMode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAnimatorSetMode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='setAnimatorSetMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnimatorSetMode", "(I)V", "GetSetAnimatorSetMode_IHandler")]
		public virtual unsafe void SetAnimatorSetMode (int p0)
		{
			const string __id = "setAnimatorSetMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
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
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDuration (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='setDuration' and count(parameter)=1 and parameter[1][@type='long']]"
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
			global::Com.Baidu.Mapapi.Animation.AnimationSet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Animation.AnimationSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Animations.IInterpolator p0 = (global::Android.Views.Animations.IInterpolator)global::Java.Lang.Object.GetObject<global::Android.Views.Animations.IInterpolator> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInterpolator (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.animation']/class[@name='AnimationSet']/method[@name='setInterpolator' and count(parameter)=1 and parameter[1][@type='android.view.animation.Interpolator']]"
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
