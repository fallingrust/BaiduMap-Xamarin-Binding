using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Model.Inner {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/model/inner/MapBound", DoNotGenerateAcw=true)]
	public partial class MapBound : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/model/inner/MapBound", typeof (MapBound));
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

		protected MapBound (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/constructor[@name='MapBound' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapBound ()
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

		static Delegate cb_getPtLB;
#pragma warning disable 0169
		static Delegate GetGetPtLBHandler ()
		{
			if (cb_getPtLB == null)
				cb_getPtLB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPtLB);
			return cb_getPtLB;
		}

		static IntPtr n_GetPtLB (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PtLB);
		}
#pragma warning restore 0169

		static Delegate cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_;
#pragma warning disable 0169
		static Delegate GetSetPtLB_Lcom_baidu_mapapi_model_inner_Point_Handler ()
		{
			if (cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ == null)
				cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPtLB_Lcom_baidu_mapapi_model_inner_Point_);
			return cb_setPtLB_Lcom_baidu_mapapi_model_inner_Point_;
		}

		static void n_SetPtLB_Lcom_baidu_mapapi_model_inner_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.Inner.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PtLB = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Model.Inner.Point PtLB {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='getPtLB' and count(parameter)=0]"
			[Register ("getPtLB", "()Lcom/baidu/mapapi/model/inner/Point;", "GetGetPtLBHandler")]
			get {
				const string __id = "getPtLB.()Lcom/baidu/mapapi/model/inner/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='setPtLB' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.Point']]"
			[Register ("setPtLB", "(Lcom/baidu/mapapi/model/inner/Point;)V", "GetSetPtLB_Lcom_baidu_mapapi_model_inner_Point_Handler")]
			set {
				const string __id = "setPtLB.(Lcom/baidu/mapapi/model/inner/Point;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPtRT;
#pragma warning disable 0169
		static Delegate GetGetPtRTHandler ()
		{
			if (cb_getPtRT == null)
				cb_getPtRT = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPtRT);
			return cb_getPtRT;
		}

		static IntPtr n_GetPtRT (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PtRT);
		}
#pragma warning restore 0169

		static Delegate cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_;
#pragma warning disable 0169
		static Delegate GetSetPtRT_Lcom_baidu_mapapi_model_inner_Point_Handler ()
		{
			if (cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ == null)
				cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPtRT_Lcom_baidu_mapapi_model_inner_Point_);
			return cb_setPtRT_Lcom_baidu_mapapi_model_inner_Point_;
		}

		static void n_SetPtRT_Lcom_baidu_mapapi_model_inner_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Baidu.Mapapi.Model.Inner.MapBound __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.MapBound> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Baidu.Mapapi.Model.Inner.Point p0 = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PtRT = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Baidu.Mapapi.Model.Inner.Point PtRT {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='getPtRT' and count(parameter)=0]"
			[Register ("getPtRT", "()Lcom/baidu/mapapi/model/inner/Point;", "GetGetPtRTHandler")]
			get {
				const string __id = "getPtRT.()Lcom/baidu/mapapi/model/inner/Point;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Model.Inner.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.model.inner']/class[@name='MapBound']/method[@name='setPtRT' and count(parameter)=1 and parameter[1][@type='com.baidu.mapapi.model.inner.Point']]"
			[Register ("setPtRT", "(Lcom/baidu/mapapi/model/inner/Point;)V", "GetSetPtRT_Lcom_baidu_mapapi_model_inner_Point_Handler")]
			set {
				const string __id = "setPtRT.(Lcom/baidu/mapapi/model/inner/Point;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
