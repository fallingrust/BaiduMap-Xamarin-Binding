using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Mapsdkvi.Com.Gdi.Bgl.Android.Java {

	// Metadata.xml XPath class reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']"
	[global::Android.Runtime.Register ("mapsdkvi/com/gdi/bgl/android/java/EnvDrawText", DoNotGenerateAcw=true)]
	public partial class EnvDrawText : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='bBmpChange']"
		[Register ("bBmpChange")]
		public static bool BBmpChange {
			get {
				const string __id = "bBmpChange.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "bBmpChange.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='bmp']"
		[Register ("bmp")]
		public static global::Android.Graphics.Bitmap Bmp {
			get {
				const string __id = "bmp.Landroid/graphics/Bitmap;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "bmp.Landroid/graphics/Bitmap;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='buffer']"
		[Register ("buffer")]
		public static IList<int> Buffer {
			get {
				const string __id = "buffer.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/field[@name='fontCache']"
		[Register ("fontCache")]
		public static global::Android.Util.SparseArray FontCache {
			get {
				const string __id = "fontCache.Landroid/util/SparseArray;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Util.SparseArray> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "fontCache.Landroid/util/SparseArray;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("mapsdkvi/com/gdi/bgl/android/java/EnvDrawText", typeof (EnvDrawText));
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

		protected EnvDrawText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/constructor[@name='EnvDrawText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EnvDrawText ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='drawText' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("drawText", "(Ljava/lang/String;II[IIIIII)[I", "")]
		public static unsafe int[] DrawText (string p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7, int p8)
		{
			const string __id = "drawText.(Ljava/lang/String;II[IIIIII)[I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='drawTextAlpha' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawTextAlpha", "(Ljava/lang/String;III)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap DrawTextAlpha (string p0, int p1, int p2, int p3)
		{
			const string __id = "drawTextAlpha.(Ljava/lang/String;III)Landroid/graphics/Bitmap;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='drawTextExt' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int']]"
		[Register ("drawTextExt", "(Ljava/lang/String;II[IIIIII)Landroid/graphics/Bitmap;", "")]
		public static unsafe global::Android.Graphics.Bitmap DrawTextExt (string p0, int p1, int p2, int[] p3, int p4, int p5, int p6, int p7, int p8)
		{
			const string __id = "drawTextExt.(Ljava/lang/String;II[IIIIII)Landroid/graphics/Bitmap;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (p8);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='getTextSize' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTextSize", "(Ljava/lang/String;II)[S", "")]
		public static unsafe short[] GetTextSize (string p0, int p1, int p2)
		{
			const string __id = "getTextSize.(Ljava/lang/String;II)[S";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (short[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (short));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='getTextSizeExt' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getTextSizeExt", "(Ljava/lang/String;II)[F", "")]
		public static unsafe float[] GetTextSizeExt (string p0, int p1, int p2)
		{
			const string __id = "getTextSizeExt.(Ljava/lang/String;II)[F";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='registFontCache' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Typeface']]"
		[Register ("registFontCache", "(ILandroid/graphics/Typeface;)V", "")]
		public static unsafe void RegistFontCache (int p0, global::Android.Graphics.Typeface p1)
		{
			const string __id = "registFontCache.(ILandroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='mapsdkvi.com.gdi.bgl.android.java']/class[@name='EnvDrawText']/method[@name='removeFontCache' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeFontCache", "(I)V", "")]
		public static unsafe void RemoveFontCache (int p0)
		{
			const string __id = "removeFontCache.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
