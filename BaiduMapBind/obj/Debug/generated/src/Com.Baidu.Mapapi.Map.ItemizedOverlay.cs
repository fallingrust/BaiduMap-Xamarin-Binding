using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/ItemizedOverlay", DoNotGenerateAcw=true)]
	public partial class ItemizedOverlay : global::Com.Baidu.Mapapi.Map.Overlay {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/ItemizedOverlay", typeof (ItemizedOverlay));
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

		protected ItemizedOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/constructor[@name='ItemizedOverlay' and count(parameter)=2 and parameter[1][@type='android.graphics.drawable.Drawable'] and parameter[2][@type='com.baidu.mapapi.map.MapView']]"
		[Register (".ctor", "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V", "")]
		public unsafe ItemizedOverlay (global::Android.Graphics.Drawables.Drawable p0, global::Com.Baidu.Mapapi.Map.MapView p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/graphics/drawable/Drawable;Lcom/baidu/mapapi/map/MapView;)V";

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

		static Delegate cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddItem_Lcom_baidu_mapapi_map_OverlayOptions_Handler ()
		{
			if (cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ == null)
				cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddItem_Lcom_baidu_mapapi_map_OverlayOptions_);
			return cb_addItem_Lcom_baidu_mapapi_map_OverlayOptions_;
		}

		static void n_AddItem_Lcom_baidu_mapapi_map_OverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.OverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.OverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.OverlayOptions']]"
		[Register ("addItem", "(Lcom/baidu/mapapi/map/OverlayOptions;)V", "GetAddItem_Lcom_baidu_mapapi_map_OverlayOptions_Handler")]
		public virtual unsafe void AddItem (global::Com.Baidu.Mapapi.Map.OverlayOptions p0)
		{
			const string __id = "addItem.(Lcom/baidu/mapapi/map/OverlayOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reAddAll;
#pragma warning disable 0169
		static Delegate GetReAddAllHandler ()
		{
			if (cb_reAddAll == null)
				cb_reAddAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReAddAll);
			return cb_reAddAll;
		}

		static void n_ReAddAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReAddAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='reAddAll' and count(parameter)=0]"
		[Register ("reAddAll", "()V", "GetReAddAllHandler")]
		public virtual unsafe void ReAddAll ()
		{
			const string __id = "reAddAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeAll;
#pragma warning disable 0169
		static Delegate GetRemoveAllHandler ()
		{
			if (cb_removeAll == null)
				cb_removeAll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAll);
			return cb_removeAll;
		}

		static void n_RemoveAll (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.ItemizedOverlay __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.ItemizedOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='ItemizedOverlay']/method[@name='removeAll' and count(parameter)=0]"
		[Register ("removeAll", "()V", "GetRemoveAllHandler")]
		public virtual unsafe void RemoveAll ()
		{
			const string __id = "removeAll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
