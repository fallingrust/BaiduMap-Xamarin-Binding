using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Overlay", DoNotGenerateAcw=true)]
	public abstract partial class Overlay : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/Overlay", typeof (Overlay));
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

		protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe Overlay ()
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

		static Delegate cb_getExtraInfo;
#pragma warning disable 0169
		static Delegate GetGetExtraInfoHandler ()
		{
			if (cb_getExtraInfo == null)
				cb_getExtraInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraInfo);
			return cb_getExtraInfo;
		}

		static IntPtr n_GetExtraInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExtraInfo);
		}
#pragma warning restore 0169

		static Delegate cb_setExtraInfo_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSetExtraInfo_Landroid_os_Bundle_Handler ()
		{
			if (cb_setExtraInfo_Landroid_os_Bundle_ == null)
				cb_setExtraInfo_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtraInfo_Landroid_os_Bundle_);
			return cb_setExtraInfo_Landroid_os_Bundle_;
		}

		static void n_SetExtraInfo_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExtraInfo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle ExtraInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='getExtraInfo' and count(parameter)=0]"
			[Register ("getExtraInfo", "()Landroid/os/Bundle;", "GetGetExtraInfoHandler")]
			get {
				const string __id = "getExtraInfo.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setExtraInfo' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
			[Register ("setExtraInfo", "(Landroid/os/Bundle;)V", "GetSetExtraInfo_Landroid_os_Bundle_Handler")]
			set {
				const string __id = "setExtraInfo.(Landroid/os/Bundle;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRemoved;
#pragma warning disable 0169
		static Delegate GetIsRemovedHandler ()
		{
			if (cb_isRemoved == null)
				cb_isRemoved = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRemoved);
			return cb_isRemoved;
		}

		static bool n_IsRemoved (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRemoved;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRemoved {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='isRemoved' and count(parameter)=0]"
			[Register ("isRemoved", "()Z", "GetIsRemovedHandler")]
			get {
				const string __id = "isRemoved.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				const string __id = "setVisible.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZIndex);
			return cb_getZIndex;
		}

		static int n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_I;
#pragma warning disable 0169
		static Delegate GetSetZIndex_IHandler ()
		{
			if (cb_setZIndex_I == null)
				cb_setZIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZIndex_I);
			return cb_setZIndex_I;
		}

		static void n_SetZIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()I", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZIndex", "(I)V", "GetSetZIndex_IHandler")]
			set {
				const string __id = "setZIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='Overlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/Overlay", DoNotGenerateAcw=true)]
	internal partial class OverlayInvoker : Overlay {

		public OverlayInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/Overlay", typeof (OverlayInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
