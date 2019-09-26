using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNISysOSAPI']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/util/JNISysOSAPI", DoNotGenerateAcw=true)]
	public partial class JNISysOSAPI : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/util/JNISysOSAPI", typeof (JNISysOSAPI));
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

		protected JNISysOSAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNISysOSAPI']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()V", "")]
		public static unsafe void Create ()
		{
			const string __id = "create.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNISysOSAPI']/method[@name='init' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("init", "(Ljava/lang/Object;)V", "")]
		public static unsafe void Init (global::Java.Lang.Object p0)
		{
			const string __id = "init.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNISysOSAPI']/method[@name='unInit' and count(parameter)=0]"
		[Register ("unInit", "()V", "")]
		public static unsafe void UnInit ()
		{
			const string __id = "unInit.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
