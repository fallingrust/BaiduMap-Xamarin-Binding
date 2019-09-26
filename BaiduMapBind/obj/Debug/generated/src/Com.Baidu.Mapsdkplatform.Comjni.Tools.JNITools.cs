using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapsdkplatform.Comjni.Tools {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']"
	[global::Android.Runtime.Register ("com/baidu/mapsdkplatform/comjni/tools/JNITools", DoNotGenerateAcw=true)]
	public partial class JNITools : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapsdkplatform/comjni/tools/JNITools", typeof (JNITools));
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

		protected JNITools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='GetToken' and count(parameter)=0]"
			[Register ("GetToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "GetToken.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='CoordinateEncryptEx' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Object']]"
		[Register ("CoordinateEncryptEx", "(FFLjava/lang/String;Ljava/lang/Object;)Z", "")]
		public static unsafe bool CoordinateEncryptEx (float p0, float p1, string p2, global::Java.Lang.Object p3)
		{
			const string __id = "CoordinateEncryptEx.(FFLjava/lang/String;Ljava/lang/Object;)Z";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='CoordinateEncryptMc' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.Object']]"
		[Register ("CoordinateEncryptMc", "(FFLjava/lang/Object;)Z", "")]
		public static unsafe bool CoordinateEncryptMc (float p0, float p1, global::Java.Lang.Object p2)
		{
			const string __id = "CoordinateEncryptMc.(FFLjava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='GetDistanceByMC' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("GetDistanceByMC", "(Ljava/lang/Object;)V", "")]
		public static unsafe void GetDistanceByMC (global::Java.Lang.Object p0)
		{
			const string __id = "GetDistanceByMC.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='TransGeoStr2ComplexPt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransGeoStr2ComplexPt", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool TransGeoStr2ComplexPt (global::Java.Lang.Object p0)
		{
			const string __id = "TransGeoStr2ComplexPt.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='TransGeoStr2Pt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransGeoStr2Pt", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool TransGeoStr2Pt (global::Java.Lang.Object p0)
		{
			const string __id = "TransGeoStr2Pt.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='TransNodeStr2Pt' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("TransNodeStr2Pt", "(Ljava/lang/Object;)V", "")]
		public static unsafe void TransNodeStr2Pt (global::Java.Lang.Object p0)
		{
			const string __id = "TransNodeStr2Pt.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='baiduToGcj' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("baiduToGcj", "(DD)[D", "")]
		public static unsafe double[] BaiduToGcj (double p0, double p1)
		{
			const string __id = "baiduToGcj.(DD)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='gcjToBaidu' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("gcjToBaidu", "(DD)[D", "")]
		public static unsafe double[] GcjToBaidu (double p0, double p1)
		{
			const string __id = "gcjToBaidu.(DD)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='initClass' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='int']]"
		[Register ("initClass", "(Ljava/lang/Object;I)I", "")]
		public static unsafe int InitClass (global::Java.Lang.Object p0, int p1)
		{
			const string __id = "initClass.(Ljava/lang/Object;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='openLogEnable' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='int']]"
		[Register ("openLogEnable", "(ZI)V", "")]
		public static unsafe void OpenLogEnable (bool p0, int p1)
		{
			const string __id = "openLogEnable.(ZI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapsdkplatform.comjni.tools']/class[@name='JNITools']/method[@name='wgsToBaidu' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("wgsToBaidu", "(DD)[D", "")]
		public static unsafe double[] WgsToBaidu (double p0, double p1)
		{
			const string __id = "wgsToBaidu.(DD)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}
}
