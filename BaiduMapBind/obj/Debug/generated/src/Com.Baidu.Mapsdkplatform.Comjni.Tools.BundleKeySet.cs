using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='BundleKeySet']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/tools/BundleKeySet", DoNotGenerateAcw=true)]
	public partial class BundleKeySet : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/tools/BundleKeySet", typeof (BundleKeySet));
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

		protected BundleKeySet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='BundleKeySet']/constructor[@name='BundleKeySet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BundleKeySet ()
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

		static Delegate cb_getBundleKeys_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetGetBundleKeys_Landroid_os_Bundle_Handler ()
		{
			if (cb_getBundleKeys_Landroid_os_Bundle_ == null)
				cb_getBundleKeys_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBundleKeys_Landroid_os_Bundle_);
			return cb_getBundleKeys_Landroid_os_Bundle_;
		}

		static IntPtr n_GetBundleKeys_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapsdkplatform.Comjni.Tools.BundleKeySet __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapsdkplatform.Comjni.Tools.BundleKeySet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetBundleKeys (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='BundleKeySet']/method[@name='getBundleKeys' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("getBundleKeys", "(Landroid/os/Bundle;)[Ljava/lang/String;", "GetGetBundleKeys_Landroid_os_Bundle_Handler")]
		public virtual unsafe string[] GetBundleKeys (global::Android.OS.Bundle p0)
		{
			const string __id = "getBundleKeys.(Landroid/os/Bundle;)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
