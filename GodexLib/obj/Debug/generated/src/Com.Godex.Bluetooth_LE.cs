using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Godex {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']"
	[global::Android.Runtime.Register ("com/godex/Bluetooth_LE", DoNotGenerateAcw=true)]
	public partial class Bluetooth_LE : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Bluetooth_LE", typeof (Bluetooth_LE));
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

		protected Bluetooth_LE (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']/constructor[@name='Bluetooth_LE' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Bluetooth_LE (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_BLERead;
#pragma warning disable 0169
		static Delegate GetBLEReadHandler ()
		{
			if (cb_BLERead == null)
				cb_BLERead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BLERead);
			return cb_BLERead;
		}

		static IntPtr n_BLERead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Godex.Bluetooth_LE __this = global::Java.Lang.Object.GetObject<global::Com.Godex.Bluetooth_LE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BLERead ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']/method[@name='BLERead' and count(parameter)=0]"
		[Register ("BLERead", "()[B", "GetBLEReadHandler")]
		public virtual unsafe byte[] BLERead ()
		{
			const string __id = "BLERead.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_BLESend_arrayB;
#pragma warning disable 0169
		static Delegate GetBLESend_arrayBHandler ()
		{
			if (cb_BLESend_arrayB == null)
				cb_BLESend_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_BLESend_arrayB);
			return cb_BLESend_arrayB;
		}

		static bool n_BLESend_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_databyte)
		{
			global::Com.Godex.Bluetooth_LE __this = global::Java.Lang.Object.GetObject<global::Com.Godex.Bluetooth_LE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] databyte = (byte[]) JNIEnv.GetArray (native_databyte, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool __ret = __this.BLESend (databyte);
			if (databyte != null)
				JNIEnv.CopyArray (databyte, native_databyte);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']/method[@name='BLESend' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("BLESend", "([B)Z", "GetBLESend_arrayBHandler")]
		public virtual unsafe bool BLESend (byte[] databyte)
		{
			const string __id = "BLESend.([B)Z";
			IntPtr native_databyte = JNIEnv.NewArray (databyte);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_databyte);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (databyte != null) {
					JNIEnv.CopyArray (native_databyte, databyte);
					JNIEnv.DeleteLocalRef (native_databyte);
				}
			}
		}

		static Delegate cb_ConnectBLE_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetConnectBLE_Ljava_lang_String_Handler ()
		{
			if (cb_ConnectBLE_Ljava_lang_String_ == null)
				cb_ConnectBLE_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ConnectBLE_Ljava_lang_String_);
			return cb_ConnectBLE_Ljava_lang_String_;
		}

		static bool n_ConnectBLE_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_MacAddress)
		{
			global::Com.Godex.Bluetooth_LE __this = global::Java.Lang.Object.GetObject<global::Com.Godex.Bluetooth_LE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string MacAddress = JNIEnv.GetString (native_MacAddress, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ConnectBLE (MacAddress);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']/method[@name='ConnectBLE' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("ConnectBLE", "(Ljava/lang/String;)Z", "GetConnectBLE_Ljava_lang_String_Handler")]
		public virtual unsafe bool ConnectBLE (string MacAddress)
		{
			const string __id = "ConnectBLE.(Ljava/lang/String;)Z";
			IntPtr native_MacAddress = JNIEnv.NewString (MacAddress);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_MacAddress);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_MacAddress);
			}
		}

		static Delegate cb_DisconnectBLE;
#pragma warning disable 0169
		static Delegate GetDisconnectBLEHandler ()
		{
			if (cb_DisconnectBLE == null)
				cb_DisconnectBLE = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_DisconnectBLE);
			return cb_DisconnectBLE;
		}

		static bool n_DisconnectBLE (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Godex.Bluetooth_LE __this = global::Java.Lang.Object.GetObject<global::Com.Godex.Bluetooth_LE> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisconnectBLE ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Bluetooth_LE']/method[@name='DisconnectBLE' and count(parameter)=0]"
		[Register ("DisconnectBLE", "()Z", "GetDisconnectBLEHandler")]
		public virtual unsafe bool DisconnectBLE ()
		{
			const string __id = "DisconnectBLE.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
