using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Engine {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/engine/AppEngine", DoNotGenerateAcw=true)]
	public partial class AppEngine : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/engine/AppEngine", typeof (AppEngine));
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

		protected AppEngine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/constructor[@name='AppEngine' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppEngine ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='InitClass' and count(parameter)=0]"
		[Register ("InitClass", "()V", "")]
		public static unsafe void InitClass ()
		{
			const string __id = "InitClass.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='InitEngine' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("InitEngine", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool InitEngine (global::Android.Content.Context p0)
		{
			const string __id = "InitEngine.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='SetProxyInfo' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("SetProxyInfo", "(Ljava/lang/String;I)V", "")]
		public static unsafe void SetProxyInfo (string p0, int p1)
		{
			const string __id = "SetProxyInfo.(Ljava/lang/String;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='StartSocketProc' and count(parameter)=0]"
		[Register ("StartSocketProc", "()Z", "")]
		public static unsafe bool StartSocketProc ()
		{
			const string __id = "StartSocketProc.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='UnInitEngine' and count(parameter)=0]"
		[Register ("UnInitEngine", "()Z", "")]
		public static unsafe bool UnInitEngine ()
		{
			const string __id = "UnInitEngine.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.engine']/class[@name='AppEngine']/method[@name='despatchMessage' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("despatchMessage", "(IIIJ)V", "")]
		public static unsafe void DespatchMessage (int p0, int p1, int p2, long p3)
		{
			const string __id = "despatchMessage.(IIIJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
