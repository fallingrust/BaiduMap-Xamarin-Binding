using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Location.Indoor.Mapversion {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']"
	[global::Android.Runtime.Register ("com/baidu/location/indoor/mapversion/IndoorJni", DoNotGenerateAcw=true)]
	public partial class IndoorJni : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/location/indoor/mapversion/IndoorJni", typeof (IndoorJni));
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

		protected IndoorJni (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='a' and count(parameter)=4 and parameter[1][@type='java.io.File'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='double'] and parameter[4][@type='float[]']]"
		[Register ("a", "(Ljava/io/File;Landroid/graphics/Bitmap;D[F)Ljava/lang/String;", "")]
		public static unsafe string A (global::Java.IO.File p0, global::Android.Graphics.Bitmap p1, double p2, float[] p3)
		{
			const string __id = "a.(Ljava/io/File;Landroid/graphics/Bitmap;D[F)Ljava/lang/String;";
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='a' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.File']]"
		[Register ("a", "(Ljava/lang/String;Ljava/io/File;)Z", "")]
		public static unsafe bool A (string p0, global::Java.IO.File p1)
		{
			const string __id = "a.(Ljava/lang/String;Ljava/io/File;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='compressImage' and count(parameter)=4 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("compressImage", "([IIILjava/lang/String;)V", "")]
		public static unsafe void CompressImage (int[] p0, int p1, int p2, string p3)
		{
			const string __id = "compressImage.([IIILjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='initPf' and count(parameter)=0]"
		[Register ("initPf", "()V", "")]
		public static unsafe void InitPf ()
		{
			const string __id = "initPf.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='pgo' and count(parameter)=0]"
		[Register ("pgo", "()[F", "")]
		public static unsafe float[] Pgo ()
		{
			const string __id = "pgo.()[F";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='phs' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='long']]"
		[Register ("phs", "(IFFFJ)V", "")]
		public static unsafe void Phs (int p0, float p1, float p2, float p3, long p4)
		{
			const string __id = "phs.(IFFFJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='preprocessImage' and count(parameter)=8 and parameter[1][@type='int[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='double'] and parameter[7][@type='double'] and parameter[8][@type='java.lang.String']]"
		[Register ("preprocessImage", "([IIIDDDDLjava/lang/String;)V", "")]
		public static unsafe void PreprocessImage (int[] p0, int p1, int p2, double p3, double p4, double p5, double p6, string p7)
		{
			const string __id = "preprocessImage.([IIIDDDDLjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (native_p7);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='resetPf' and count(parameter)=0]"
		[Register ("resetPf", "()V", "")]
		public static unsafe void ResetPf ()
		{
			const string __id = "resetPf.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfDr' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='long']]"
		[Register ("setPfDr", "(DDJ)[D", "")]
		public static unsafe double[] SetPfDr (double p0, double p1, long p2)
		{
			const string __id = "setPfDr.(DDJ)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfGeoMap' and count(parameter)=4 and parameter[1][@type='double[][]'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setPfGeoMap", "([[DLjava/lang/String;II)V", "")]
		public static unsafe void SetPfGeoMap (double[][] p0, string p1, int p2, int p3)
		{
			const string __id = "setPfGeoMap.([[DLjava/lang/String;II)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfGeomag' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setPfGeomag", "(D)V", "")]
		public static unsafe void SetPfGeomag (double p0)
		{
			const string __id = "setPfGeomag.(D)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfGps' and count(parameter)=6 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='double'] and parameter[6][@type='long']]"
		[Register ("setPfGps", "(DDDDDJ)[D", "")]
		public static unsafe double[] SetPfGps (double p0, double p1, double p2, double p3, double p4, long p5)
		{
			const string __id = "setPfGps.(DDDDDJ)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfRdnt' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='short[][]'] and parameter[3][@type='double'] and parameter[4][@type='double'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='double'] and parameter[8][@type='double']]"
		[Register ("setPfRdnt", "(Ljava/lang/String;[[SDDIIDD)V", "")]
		public static unsafe void SetPfRdnt (string p0, short[][] p1, double p2, double p3, int p4, int p5, double p6, double p7)
		{
			const string __id = "setPfRdnt.(Ljava/lang/String;[[SDDIIDD)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='setPfWf' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='long']]"
		[Register ("setPfWf", "(DDDJ)[D", "")]
		public static unsafe double[] SetPfWf (double p0, double p1, double p2, long p3)
		{
			const string __id = "setPfWf.(DDDJ)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.location.indoor.mapversion']/class[@name='IndoorJni']/method[@name='stopPdr' and count(parameter)=0]"
		[Register ("stopPdr", "()V", "")]
		public static unsafe void StopPdr ()
		{
			const string __id = "stopPdr.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
