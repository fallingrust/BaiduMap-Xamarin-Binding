using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/NetworkUtil", DoNotGenerateAcw=true)]
	public partial class NetworkUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/NetworkUtil", typeof (NetworkUtil));
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

		protected NetworkUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/constructor[@name='NetworkUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetworkUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='getActiveNetworkInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getActiveNetworkInfo", "(Landroid/content/Context;)Landroid/net/NetworkInfo;", "")]
		public static unsafe global::Android.Net.NetworkInfo GetActiveNetworkInfo (global::Android.Content.Context p0)
		{
			const string __id = "getActiveNetworkInfo.(Landroid/content/Context;)Landroid/net/NetworkInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='getCurrentNetMode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getCurrentNetMode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetCurrentNetMode (global::Android.Content.Context p0)
		{
			const string __id = "getCurrentNetMode.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='initConnectState' and count(parameter)=0]"
		[Register ("initConnectState", "()Z", "")]
		public static unsafe bool InitConnectState ()
		{
			const string __id = "initConnectState.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='isNetworkAvailable' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isNetworkAvailable", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsNetworkAvailable (global::Android.Content.Context p0)
		{
			const string __id = "isNetworkAvailable.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='isWifiConnected' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isWifiConnected", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsWifiConnected (global::Android.Content.Context p0)
		{
			const string __id = "isWifiConnected.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='isWifiConnected' and count(parameter)=1 and parameter[1][@type='android.net.NetworkInfo']]"
		[Register ("isWifiConnected", "(Landroid/net/NetworkInfo;)Z", "")]
		public static unsafe bool IsWifiConnected (global::Android.Net.NetworkInfo p0)
		{
			const string __id = "isWifiConnected.(Landroid/net/NetworkInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi']/class[@name='NetworkUtil']/method[@name='updateNetworkProxy' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateNetworkProxy", "(Landroid/content/Context;)V", "")]
		public static unsafe void UpdateNetworkProxy (global::Android.Content.Context p0)
		{
			const string __id = "updateNetworkProxy.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
