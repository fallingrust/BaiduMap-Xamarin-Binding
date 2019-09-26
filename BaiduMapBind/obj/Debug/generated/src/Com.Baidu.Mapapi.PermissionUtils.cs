using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='PermissionUtils']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/PermissionUtils", DoNotGenerateAcw=true)]
	public partial class PermissionUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/PermissionUtils", typeof (PermissionUtils));
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

		protected PermissionUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Baidu.Mapapi.PermissionUtils Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='PermissionUtils']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/baidu/mapapi/PermissionUtils;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/baidu/mapapi/PermissionUtils;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.PermissionUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isIndoorNaviAuthorized;
#pragma warning disable 0169
		static Delegate GetIsIndoorNaviAuthorizedHandler ()
		{
			if (cb_isIndoorNaviAuthorized == null)
				cb_isIndoorNaviAuthorized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsIndoorNaviAuthorized);
			return cb_isIndoorNaviAuthorized;
		}

		static bool n_IsIndoorNaviAuthorized (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.PermissionUtils __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.PermissionUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsIndoorNaviAuthorized;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsIndoorNaviAuthorized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='PermissionUtils']/method[@name='isIndoorNaviAuthorized' and count(parameter)=0]"
			[Register ("isIndoorNaviAuthorized", "()Z", "GetIsIndoorNaviAuthorizedHandler")]
			get {
				const string __id = "isIndoorNaviAuthorized.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
