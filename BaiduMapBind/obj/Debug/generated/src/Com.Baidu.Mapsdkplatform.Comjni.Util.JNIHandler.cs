using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIHandler']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/util/JNIHandler", DoNotGenerateAcw=true)]
	public partial class JNIHandler : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/util/JNIHandler", typeof (JNIHandler));
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

		protected JNIHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.util']/class[@name='JNIHandler']/method[@name='registerNativeHandler' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("registerNativeHandler", "(Ljava/lang/String;)V", "")]
		public static unsafe void RegisterNativeHandler (string p0)
		{
			const string __id = "registerNativeHandler.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
