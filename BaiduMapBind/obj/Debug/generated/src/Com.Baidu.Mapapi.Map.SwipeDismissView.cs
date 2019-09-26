using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/SwipeDismissView", DoNotGenerateAcw=true)]
	public partial class SwipeDismissView : global::Android.Widget.RelativeLayout {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/SwipeDismissView", typeof (SwipeDismissView));
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

		protected SwipeDismissView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, global::Android.Views.View p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, global::Android.Views.View p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;ILandroid/view/View;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/constructor[@name='SwipeDismissView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.view.View']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/view/View;)V", "")]
		public unsafe SwipeDismissView (global::Android.Content.Context p0, global::Android.Views.View p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/view/View;)V";

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

		static Delegate cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
#pragma warning disable 0169
		static Delegate GetSetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler ()
		{
			if (cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ == null)
				cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_);
			return cb_setCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_;
		}

		static void n_SetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Map.SwipeDismissView __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.SwipeDismissView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0 = (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCallback (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='SwipeDismissView']/method[@name='setCallback' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.map.WearMapView.OnDismissCallback']]"
		[Register ("setCallback", "(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V", "GetSetCallback_Lcom_baidu_mapapi_map_WearMapView_OnDismissCallback_Handler")]
		public virtual unsafe void SetCallback (global::Com.Baidu.Mapapi.Map.WearMapView.IOnDismissCallback p0)
		{
			const string __id = "setCallback.(Lcom/baidu/mapapi/map/WearMapView$OnDismissCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
