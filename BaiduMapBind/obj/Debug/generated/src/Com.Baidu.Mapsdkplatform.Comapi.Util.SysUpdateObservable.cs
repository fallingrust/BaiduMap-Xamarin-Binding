using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comapi.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comapi/util/SysUpdateObservable", DoNotGenerateAcw=true)]
	public partial class SysUpdateObservable : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comapi/util/SysUpdateObservable", typeof (SysUpdateObservable));
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

		protected SysUpdateObservable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapsdkplatform/comapi/util/SysUpdateObservable;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/baidu/mapsdkplatform/comapi/util/SysUpdateObservable;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_;
#pragma warning disable 0169
		static Delegate GetAddObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_Handler ()
		{
			if (cb_addObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_ == null)
				cb_addObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_);
			return cb_addObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_;
		}

		static void n_AddObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.ISysUpdateObserver p0 = (global::Com.Baidu.Mapsdkplatform.Comapi.Util.ISysUpdateObserver)global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.ISysUpdateObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddObserver (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='addObserver' and count(parameter)=1 and parameter[1][@type='com.baidu.mapsdkplatform.comapi.util.SysUpdateObserver']]"
		[Register ("addObserver", "(Lcom/baidu/mapsdkplatform/comapi/util/SysUpdateObserver;)V", "GetAddObserver_Lcom_baidu_mapsdkplatform_comapi_util_SysUpdateObserver_Handler")]
		public virtual unsafe void AddObserver (global::Com.Baidu.Mapsdkplatform.Comapi.Util.ISysUpdateObserver p0)
		{
			const string __id = "addObserver.(Lcom/baidu/mapsdkplatform/comapi/util/SysUpdateObserver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		public virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateNetworkInfo_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkInfo_Landroid_content_Context_Handler ()
		{
			if (cb_updateNetworkInfo_Landroid_content_Context_ == null)
				cb_updateNetworkInfo_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkInfo_Landroid_content_Context_);
			return cb_updateNetworkInfo_Landroid_content_Context_;
		}

		static void n_UpdateNetworkInfo_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkInfo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updateNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkInfo", "(Landroid/content/Context;)V", "GetUpdateNetworkInfo_Landroid_content_Context_Handler")]
		public virtual unsafe void UpdateNetworkInfo (global::Android.Content.Context p0)
		{
			const string __id = "updateNetworkInfo.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updateNetworkProxy_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetUpdateNetworkProxy_Landroid_content_Context_Handler ()
		{
			if (cb_updateNetworkProxy_Landroid_content_Context_ == null)
				cb_updateNetworkProxy_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateNetworkProxy_Landroid_content_Context_);
			return cb_updateNetworkProxy_Landroid_content_Context_;
		}

		static void n_UpdateNetworkProxy_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UpdateNetworkProxy (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkProxy", "(Landroid/content/Context;)V", "GetUpdateNetworkProxy_Landroid_content_Context_Handler")]
		public virtual unsafe void UpdateNetworkProxy (global::Android.Content.Context p0)
		{
			const string __id = "updateNetworkProxy.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_updatePhoneInfo;
#pragma warning disable 0169
		static Delegate GetUpdatePhoneInfoHandler ()
		{
			if (cb_updatePhoneInfo == null)
				cb_updatePhoneInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdatePhoneInfo);
			return cb_updatePhoneInfo;
		}

		static void n_UpdatePhoneInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comapi.Util.SysUpdateObservable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdatePhoneInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comapi.util']/class[@name='SysUpdateObservable']/method[@name='updatePhoneInfo' and count(parameter)=0]"
		[Register ("updatePhoneInfo", "()V", "GetUpdatePhoneInfoHandler")]
		public virtual unsafe void UpdatePhoneInfo ()
		{
			const string __id = "updatePhoneInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
