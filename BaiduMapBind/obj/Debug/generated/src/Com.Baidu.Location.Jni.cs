using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']"
	[global::Android.Runtime.Register ("com/baidu/location/Jni", DoNotGenerateAcw=true)]
	public partial class Jni : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/Jni", typeof (Jni));
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

		protected Jni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/constructor[@name='Jni' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Jni ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='coorEncrypt' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='java.lang.String']]"
		[Register ("coorEncrypt", "(DDLjava/lang/String;)[D", "")]
		public static unsafe double[] CoorEncrypt (double p0, double p1, string p2)
		{
			const string __id = "coorEncrypt.(DDLjava/lang/String;)[D";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='en1' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("en1", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string En1 (string p0)
		{
			const string __id = "en1.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode (string p0)
		{
			const string __id = "encode.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode2' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode2", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Encode2 (string p0)
		{
			const string __id = "encode2.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encode3' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encode3", "(Ljava/lang/String;)Ljava/lang/Long;", "")]
		public static unsafe global::Java.Lang.Long Encode3 (string p0)
		{
			const string __id = "encode3.(Ljava/lang/String;)Ljava/lang/Long;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encodeOfflineLocationUpdateRequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeOfflineLocationUpdateRequest", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeOfflineLocationUpdateRequest (string p0)
		{
			const string __id = "encodeOfflineLocationUpdateRequest.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='encodeTp4' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encodeTp4", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string EncodeTp4 (string p0)
		{
			const string __id = "encodeTp4.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='getGpsSwiftRadius' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("getGpsSwiftRadius", "(FDD)D", "")]
		public static unsafe double GetGpsSwiftRadius (float p0, double p1, double p2)
		{
			const string __id = "getGpsSwiftRadius.(FDD)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location']/class[@name='Jni']/method[@name='getldkaiv' and count(parameter)=0]"
		[Register ("getldkaiv", "()Ljava/lang/String;", "")]
		public static unsafe string Getldkaiv ()
		{
			const string __id = "getldkaiv.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
