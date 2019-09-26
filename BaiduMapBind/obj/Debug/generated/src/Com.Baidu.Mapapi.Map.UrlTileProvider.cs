using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Baidu.Mapapi.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']"
	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UrlTileProvider", DoNotGenerateAcw=true)]
	public abstract partial class UrlTileProvider : global::Java.Lang.Object, global::Com.Baidu.Mapapi.Map.ITileProvider {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/baidu/mapapi/map/UrlTileProvider", typeof (UrlTileProvider));
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

		protected UrlTileProvider (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/constructor[@name='UrlTileProvider' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UrlTileProvider ()
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

		static Delegate cb_getTileUrl;
#pragma warning disable 0169
		static Delegate GetGetTileUrlHandler ()
		{
			if (cb_getTileUrl == null)
				cb_getTileUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTileUrl);
			return cb_getTileUrl;
		}

		static IntPtr n_GetTileUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TileUrl);
		}
#pragma warning restore 0169

		public abstract string TileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=0]"
			[Register ("getTileUrl", "()Ljava/lang/String;", "GetGetTileUrlHandler")] get;
		}

		static Delegate cb_getMaxDisLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxDisLevelHandler ()
		{
			if (cb_getMaxDisLevel == null)
				cb_getMaxDisLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxDisLevel);
			return cb_getMaxDisLevel;
		}

		static int n_GetMaxDisLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxDisLevel;
		}
#pragma warning restore 0169

		public abstract int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
			[Register ("getMaxDisLevel", "()I", "GetGetMaxDisLevelHandler")] get;
		}

		static Delegate cb_getMinDisLevel;
#pragma warning disable 0169
		static Delegate GetGetMinDisLevelHandler ()
		{
			if (cb_getMinDisLevel == null)
				cb_getMinDisLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinDisLevel);
			return cb_getMinDisLevel;
		}

		static int n_GetMinDisLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Baidu.Mapapi.Map.UrlTileProvider __this = global::Java.Lang.Object.GetObject<global::Com.Baidu.Mapapi.Map.UrlTileProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinDisLevel;
		}
#pragma warning restore 0169

		public abstract int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/baidu/mapapi/map/UrlTileProvider", DoNotGenerateAcw=true)]
	internal partial class UrlTileProviderInvoker : UrlTileProvider {

		public UrlTileProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/baidu/mapapi/map/UrlTileProvider", typeof (UrlTileProviderInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string TileUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getTileUrl' and count(parameter)=0]"
			[Register ("getTileUrl", "()Ljava/lang/String;", "GetGetTileUrlHandler")]
			get {
				const string __id = "getTileUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int MaxDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMaxDisLevel' and count(parameter)=0]"
			[Register ("getMaxDisLevel", "()I", "GetGetMaxDisLevelHandler")]
			get {
				const string __id = "getMaxDisLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe int MinDisLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.baidu.mapapi.map']/class[@name='UrlTileProvider']/method[@name='getMinDisLevel' and count(parameter)=0]"
			[Register ("getMinDisLevel", "()I", "GetGetMinDisLevelHandler")]
			get {
				const string __id = "getMinDisLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
