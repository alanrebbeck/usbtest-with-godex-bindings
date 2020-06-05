using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Godex {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex']"
	[global::Android.Runtime.Register ("com/godex/Godex", DoNotGenerateAcw=true)]
	public partial class Godex : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex']/field[@name='Insb']"
		[Register ("Insb")]
		public static bool Insb {
			get {
				const string __id = "Insb.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "Insb.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']"
		[global::Android.Runtime.Register ("com/godex/Godex$AsiaEncoding", DoNotGenerateAcw=true)]
		public sealed partial class AsiaEncoding : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/field[@name='BIG5']"
			[Register ("BIG5")]
			public static global::Com.Godex.Godex.AsiaEncoding Big5 {
				get {
					const string __id = "BIG5.Lcom/godex/Godex$AsiaEncoding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsiaEncoding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/field[@name='EUC_KR']"
			[Register ("EUC_KR")]
			public static global::Com.Godex.Godex.AsiaEncoding EucKr {
				get {
					const string __id = "EUC_KR.Lcom/godex/Godex$AsiaEncoding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsiaEncoding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/field[@name='GB2312']"
			[Register ("GB2312")]
			public static global::Com.Godex.Godex.AsiaEncoding Gb2312 {
				get {
					const string __id = "GB2312.Lcom/godex/Godex$AsiaEncoding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsiaEncoding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/field[@name='SJIS']"
			[Register ("SJIS")]
			public static global::Com.Godex.Godex.AsiaEncoding Sjis {
				get {
					const string __id = "SJIS.Lcom/godex/Godex$AsiaEncoding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsiaEncoding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$AsiaEncoding", typeof (AsiaEncoding));
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

			internal AsiaEncoding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$AsiaEncoding;", "")]
			public static unsafe global::Com.Godex.Godex.AsiaEncoding ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$AsiaEncoding;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsiaEncoding> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsiaEncoding']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$AsiaEncoding;", "")]
			public static unsafe global::Com.Godex.Godex.AsiaEncoding[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$AsiaEncoding;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.AsiaEncoding[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.AsiaEncoding));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']"
		[global::Android.Runtime.Register ("com/godex/Godex$AsianFontID", DoNotGenerateAcw=true)]
		public sealed partial class AsianFontID : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/field[@name='Z1']"
			[Register ("Z1")]
			public static global::Com.Godex.Godex.AsianFontID Z1 {
				get {
					const string __id = "Z1.Lcom/godex/Godex$AsianFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsianFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/field[@name='Z2']"
			[Register ("Z2")]
			public static global::Com.Godex.Godex.AsianFontID Z2 {
				get {
					const string __id = "Z2.Lcom/godex/Godex$AsianFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsianFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/field[@name='Z3']"
			[Register ("Z3")]
			public static global::Com.Godex.Godex.AsianFontID Z3 {
				get {
					const string __id = "Z3.Lcom/godex/Godex$AsianFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsianFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/field[@name='Z4']"
			[Register ("Z4")]
			public static global::Com.Godex.Godex.AsianFontID Z4 {
				get {
					const string __id = "Z4.Lcom/godex/Godex$AsianFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsianFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$AsianFontID", typeof (AsianFontID));
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

			internal AsianFontID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$AsianFontID;", "")]
			public static unsafe global::Com.Godex.Godex.AsianFontID ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$AsianFontID;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.AsianFontID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.AsianFontID']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$AsianFontID;", "")]
			public static unsafe global::Com.Godex.Godex.AsianFontID[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$AsianFontID;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.AsianFontID[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.AsianFontID));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']"
		[global::Android.Runtime.Register ("com/godex/Godex$BarCodeType", DoNotGenerateAcw=true)]
		public sealed partial class BarCodeType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Codabar']"
			[Register ("Codabar")]
			public static global::Com.Godex.Godex.BarCodeType Codabar {
				get {
					const string __id = "Codabar.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code128_Auto']"
			[Register ("Code128_Auto")]
			public static global::Com.Godex.Godex.BarCodeType Code128Auto {
				get {
					const string __id = "Code128_Auto.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code128_Subset']"
			[Register ("Code128_Subset")]
			public static global::Com.Godex.Godex.BarCodeType Code128Subset {
				get {
					const string __id = "Code128_Subset.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39']"
			[Register ("Code39")]
			public static global::Com.Godex.Godex.BarCodeType Code39 {
				get {
					const string __id = "Code39.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39_Check']"
			[Register ("Code39_Check")]
			public static global::Com.Godex.Godex.BarCodeType Code39Check {
				get {
					const string __id = "Code39_Check.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39_Extended']"
			[Register ("Code39_Extended")]
			public static global::Com.Godex.Godex.BarCodeType Code39Extended {
				get {
					const string __id = "Code39_Extended.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39_ExtendedCheck']"
			[Register ("Code39_ExtendedCheck")]
			public static global::Com.Godex.Godex.BarCodeType Code39ExtendedCheck {
				get {
					const string __id = "Code39_ExtendedCheck.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39_ExtendedCheckS']"
			[Register ("Code39_ExtendedCheckS")]
			public static global::Com.Godex.Godex.BarCodeType Code39ExtendedCheckS {
				get {
					const string __id = "Code39_ExtendedCheckS.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code39_ExtendedS']"
			[Register ("Code39_ExtendedS")]
			public static global::Com.Godex.Godex.BarCodeType Code39ExtendedS {
				get {
					const string __id = "Code39_ExtendedS.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Code93']"
			[Register ("Code93")]
			public static global::Com.Godex.Godex.BarCodeType Code93 {
				get {
					const string __id = "Code93.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN128']"
			[Register ("EAN128")]
			public static global::Com.Godex.Godex.BarCodeType Ean128 {
				get {
					const string __id = "EAN128.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN13']"
			[Register ("EAN13")]
			public static global::Com.Godex.Godex.BarCodeType Ean13 {
				get {
					const string __id = "EAN13.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN13_Add2']"
			[Register ("EAN13_Add2")]
			public static global::Com.Godex.Godex.BarCodeType EAN13Add2 {
				get {
					const string __id = "EAN13_Add2.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN13_Add5']"
			[Register ("EAN13_Add5")]
			public static global::Com.Godex.Godex.BarCodeType EAN13Add5 {
				get {
					const string __id = "EAN13_Add5.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN8']"
			[Register ("EAN8")]
			public static global::Com.Godex.Godex.BarCodeType Ean8 {
				get {
					const string __id = "EAN8.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN8_Add2']"
			[Register ("EAN8_Add2")]
			public static global::Com.Godex.Godex.BarCodeType EAN8Add2 {
				get {
					const string __id = "EAN8_Add2.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='EAN8_Add5']"
			[Register ("EAN8_Add5")]
			public static global::Com.Godex.Godex.BarCodeType EAN8Add5 {
				get {
					const string __id = "EAN8_Add5.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='FIM']"
			[Register ("FIM")]
			public static global::Com.Godex.Godex.BarCodeType Fim {
				get {
					const string __id = "FIM.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='GermanPost']"
			[Register ("GermanPost")]
			public static global::Com.Godex.Godex.BarCodeType GermanPost {
				get {
					const string __id = "GermanPost.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='HIBC']"
			[Register ("HIBC")]
			public static global::Com.Godex.Godex.BarCodeType Hibc {
				get {
					const string __id = "HIBC.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5']"
			[Register ("I2of5")]
			public static global::Com.Godex.Godex.BarCodeType I2of5 {
				get {
					const string __id = "I2of5.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5_CheckDigit']"
			[Register ("I2of5_CheckDigit")]
			public static global::Com.Godex.Godex.BarCodeType I2of5CheckDigit {
				get {
					const string __id = "I2of5_CheckDigit.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5_CheckDigitNoRead']"
			[Register ("I2of5_CheckDigitNoRead")]
			public static global::Com.Godex.Godex.BarCodeType I2of5CheckDigitNoRead {
				get {
					const string __id = "I2of5_CheckDigitNoRead.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5_Industrial']"
			[Register ("I2of5_Industrial")]
			public static global::Com.Godex.Godex.BarCodeType I2of5Industrial {
				get {
					const string __id = "I2of5_Industrial.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5_ShippingBearerBars']"
			[Register ("I2of5_ShippingBearerBars")]
			public static global::Com.Godex.Godex.BarCodeType I2of5ShippingBearerBars {
				get {
					const string __id = "I2of5_ShippingBearerBars.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='I2of5_Standard']"
			[Register ("I2of5_Standard")]
			public static global::Com.Godex.Godex.BarCodeType I2of5Standard {
				get {
					const string __id = "I2of5_Standard.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='ISBT']"
			[Register ("ISBT")]
			public static global::Com.Godex.Godex.BarCodeType Isbt {
				get {
					const string __id = "ISBT.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='ITF14']"
			[Register ("ITF14")]
			public static global::Com.Godex.Godex.BarCodeType Itf14 {
				get {
					const string __id = "ITF14.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='JPPostnet']"
			[Register ("JPPostnet")]
			public static global::Com.Godex.Godex.BarCodeType JPPostnet {
				get {
					const string __id = "JPPostnet.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Logmars']"
			[Register ("Logmars")]
			public static global::Com.Godex.Godex.BarCodeType Logmars {
				get {
					const string __id = "Logmars.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='MSI_1MOD10']"
			[Register ("MSI_1MOD10")]
			public static global::Com.Godex.Godex.BarCodeType Msi1mod10 {
				get {
					const string __id = "MSI_1MOD10.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='MSI_1MOD1110']"
			[Register ("MSI_1MOD1110")]
			public static global::Com.Godex.Godex.BarCodeType Msi1mod1110 {
				get {
					const string __id = "MSI_1MOD1110.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='MSI_2MOD10']"
			[Register ("MSI_2MOD10")]
			public static global::Com.Godex.Godex.BarCodeType Msi2mod10 {
				get {
					const string __id = "MSI_2MOD10.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='MSI_NoDigitCheck']"
			[Register ("MSI_NoDigitCheck")]
			public static global::Com.Godex.Godex.BarCodeType MSINoDigitCheck {
				get {
					const string __id = "MSI_NoDigitCheck.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Plant11_13']"
			[Register ("Plant11_13")]
			public static global::Com.Godex.Godex.BarCodeType Plant1113 {
				get {
					const string __id = "Plant11_13.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Plessey']"
			[Register ("Plessey")]
			public static global::Com.Godex.Godex.BarCodeType Plessey {
				get {
					const string __id = "Plessey.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='PostNET']"
			[Register ("PostNET")]
			public static global::Com.Godex.Godex.BarCodeType PostNET {
				get {
					const string __id = "PostNET.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='RPS128']"
			[Register ("RPS128")]
			public static global::Com.Godex.Godex.BarCodeType Rps128 {
				get {
					const string __id = "RPS128.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='Telepen']"
			[Register ("Telepen")]
			public static global::Com.Godex.Godex.BarCodeType Telepen {
				get {
					const string __id = "Telepen.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UCC_128']"
			[Register ("UCC_128")]
			public static global::Com.Godex.Godex.BarCodeType Ucc128 {
				get {
					const string __id = "UCC_128.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UCC_EAN128_KMART']"
			[Register ("UCC_EAN128_KMART")]
			public static global::Com.Godex.Godex.BarCodeType UccEan128Kmart {
				get {
					const string __id = "UCC_EAN128_KMART.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UCC_EAN128_RANDOM']"
			[Register ("UCC_EAN128_RANDOM")]
			public static global::Com.Godex.Godex.BarCodeType UccEan128Random {
				get {
					const string __id = "UCC_EAN128_RANDOM.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCA']"
			[Register ("UPCA")]
			public static global::Com.Godex.Godex.BarCodeType Upca {
				get {
					const string __id = "UPCA.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCA_Add2']"
			[Register ("UPCA_Add2")]
			public static global::Com.Godex.Godex.BarCodeType UPCAAdd2 {
				get {
					const string __id = "UPCA_Add2.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCA_Add5']"
			[Register ("UPCA_Add5")]
			public static global::Com.Godex.Godex.BarCodeType UPCAAdd5 {
				get {
					const string __id = "UPCA_Add5.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCE']"
			[Register ("UPCE")]
			public static global::Com.Godex.Godex.BarCodeType Upce {
				get {
					const string __id = "UPCE.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCE_Add2']"
			[Register ("UPCE_Add2")]
			public static global::Com.Godex.Godex.BarCodeType UPCEAdd2 {
				get {
					const string __id = "UPCE_Add2.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/field[@name='UPCE_Add5']"
			[Register ("UPCE_Add5")]
			public static global::Com.Godex.Godex.BarCodeType UPCEAdd5 {
				get {
					const string __id = "UPCE_Add5.Lcom/godex/Godex$BarCodeType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$BarCodeType", typeof (BarCodeType));
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

			internal BarCodeType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe string Type {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/method[@name='getType' and count(parameter)=0]"
				[Register ("getType", "()Ljava/lang/String;", "")]
				get {
					const string __id = "getType.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$BarCodeType;", "")]
			public static unsafe global::Com.Godex.Godex.BarCodeType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$BarCodeType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarCodeType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarCodeType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$BarCodeType;", "")]
			public static unsafe global::Com.Godex.Godex.BarCodeType[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$BarCodeType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.BarCodeType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.BarCodeType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']"
		[global::Android.Runtime.Register ("com/godex/Godex$BarGS1Type", DoNotGenerateAcw=true)]
		public sealed partial class BarGS1Type : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Expanded']"
			[Register ("Expanded")]
			public static global::Com.Godex.Godex.BarGS1Type Expanded {
				get {
					const string __id = "Expanded.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Expanded_Stacked']"
			[Register ("Expanded_Stacked")]
			public static global::Com.Godex.Godex.BarGS1Type ExpandedStacked {
				get {
					const string __id = "Expanded_Stacked.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Limited']"
			[Register ("Limited")]
			public static global::Com.Godex.Godex.BarGS1Type Limited {
				get {
					const string __id = "Limited.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Omnidir']"
			[Register ("Omnidir")]
			public static global::Com.Godex.Godex.BarGS1Type Omnidir {
				get {
					const string __id = "Omnidir.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Stacked']"
			[Register ("Stacked")]
			public static global::Com.Godex.Godex.BarGS1Type Stacked {
				get {
					const string __id = "Stacked.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Stacked_Omnidir']"
			[Register ("Stacked_Omnidir")]
			public static global::Com.Godex.Godex.BarGS1Type StackedOmnidir {
				get {
					const string __id = "Stacked_Omnidir.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/field[@name='Truncated']"
			[Register ("Truncated")]
			public static global::Com.Godex.Godex.BarGS1Type Truncated {
				get {
					const string __id = "Truncated.Lcom/godex/Godex$BarGS1Type;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$BarGS1Type", typeof (BarGS1Type));
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

			internal BarGS1Type (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$BarGS1Type;", "")]
			public static unsafe global::Com.Godex.Godex.BarGS1Type ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$BarGS1Type;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.BarGS1Type> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.BarGS1Type']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$BarGS1Type;", "")]
			public static unsafe global::Com.Godex.Godex.BarGS1Type[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$BarGS1Type;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.BarGS1Type[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.BarGS1Type));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']"
		[global::Android.Runtime.Register ("com/godex/Godex$DownlaodFontID", DoNotGenerateAcw=true)]
		public sealed partial class DownlaodFontID : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='A']"
			[Register ("A")]
			public static global::Com.Godex.Godex.DownlaodFontID A {
				get {
					const string __id = "A.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='B']"
			[Register ("B")]
			public static global::Com.Godex.Godex.DownlaodFontID B {
				get {
					const string __id = "B.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='C']"
			[Register ("C")]
			public static global::Com.Godex.Godex.DownlaodFontID C {
				get {
					const string __id = "C.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='D']"
			[Register ("D")]
			public static global::Com.Godex.Godex.DownlaodFontID D {
				get {
					const string __id = "D.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='E']"
			[Register ("E")]
			public static global::Com.Godex.Godex.DownlaodFontID E {
				get {
					const string __id = "E.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='F']"
			[Register ("F")]
			public static global::Com.Godex.Godex.DownlaodFontID F {
				get {
					const string __id = "F.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='G']"
			[Register ("G")]
			public static global::Com.Godex.Godex.DownlaodFontID G {
				get {
					const string __id = "G.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='H']"
			[Register ("H")]
			public static global::Com.Godex.Godex.DownlaodFontID H {
				get {
					const string __id = "H.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='I']"
			[Register ("I")]
			public static global::Com.Godex.Godex.DownlaodFontID I {
				get {
					const string __id = "I.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='J']"
			[Register ("J")]
			public static global::Com.Godex.Godex.DownlaodFontID J {
				get {
					const string __id = "J.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='K']"
			[Register ("K")]
			public static global::Com.Godex.Godex.DownlaodFontID K {
				get {
					const string __id = "K.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='L']"
			[Register ("L")]
			public static global::Com.Godex.Godex.DownlaodFontID L {
				get {
					const string __id = "L.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='M']"
			[Register ("M")]
			public static global::Com.Godex.Godex.DownlaodFontID M {
				get {
					const string __id = "M.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='N']"
			[Register ("N")]
			public static global::Com.Godex.Godex.DownlaodFontID N {
				get {
					const string __id = "N.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='None']"
			[Register ("None")]
			public static global::Com.Godex.Godex.DownlaodFontID None {
				get {
					const string __id = "None.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='O']"
			[Register ("O")]
			public static global::Com.Godex.Godex.DownlaodFontID O {
				get {
					const string __id = "O.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='P']"
			[Register ("P")]
			public static global::Com.Godex.Godex.DownlaodFontID P {
				get {
					const string __id = "P.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='Q']"
			[Register ("Q")]
			public static global::Com.Godex.Godex.DownlaodFontID Q {
				get {
					const string __id = "Q.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='R']"
			[Register ("R")]
			public static global::Com.Godex.Godex.DownlaodFontID R {
				get {
					const string __id = "R.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='S']"
			[Register ("S")]
			public static global::Com.Godex.Godex.DownlaodFontID S {
				get {
					const string __id = "S.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='T']"
			[Register ("T")]
			public static global::Com.Godex.Godex.DownlaodFontID T {
				get {
					const string __id = "T.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='U']"
			[Register ("U")]
			public static global::Com.Godex.Godex.DownlaodFontID U {
				get {
					const string __id = "U.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/field[@name='Z']"
			[Register ("Z")]
			public static global::Com.Godex.Godex.DownlaodFontID Z {
				get {
					const string __id = "Z.Lcom/godex/Godex$DownlaodFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$DownlaodFontID", typeof (DownlaodFontID));
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

			internal DownlaodFontID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$DownlaodFontID;", "")]
			public static unsafe global::Com.Godex.Godex.DownlaodFontID ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$DownlaodFontID;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.DownlaodFontID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.DownlaodFontID']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$DownlaodFontID;", "")]
			public static unsafe global::Com.Godex.Godex.DownlaodFontID[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$DownlaodFontID;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.DownlaodFontID[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.DownlaodFontID));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']"
		[global::Android.Runtime.Register ("com/godex/Godex$InternalFontID", DoNotGenerateAcw=true)]
		public sealed partial class InternalFontID : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='A']"
			[Register ("A")]
			public static global::Com.Godex.Godex.InternalFontID A {
				get {
					const string __id = "A.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='B']"
			[Register ("B")]
			public static global::Com.Godex.Godex.InternalFontID B {
				get {
					const string __id = "B.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='C']"
			[Register ("C")]
			public static global::Com.Godex.Godex.InternalFontID C {
				get {
					const string __id = "C.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='D']"
			[Register ("D")]
			public static global::Com.Godex.Godex.InternalFontID D {
				get {
					const string __id = "D.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='E']"
			[Register ("E")]
			public static global::Com.Godex.Godex.InternalFontID E {
				get {
					const string __id = "E.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='F']"
			[Register ("F")]
			public static global::Com.Godex.Godex.InternalFontID F {
				get {
					const string __id = "F.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='G']"
			[Register ("G")]
			public static global::Com.Godex.Godex.InternalFontID G {
				get {
					const string __id = "G.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='H']"
			[Register ("H")]
			public static global::Com.Godex.Godex.InternalFontID H {
				get {
					const string __id = "H.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='I']"
			[Register ("I")]
			public static global::Com.Godex.Godex.InternalFontID I {
				get {
					const string __id = "I.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/field[@name='J']"
			[Register ("J")]
			public static global::Com.Godex.Godex.InternalFontID J {
				get {
					const string __id = "J.Lcom/godex/Godex$InternalFontID;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$InternalFontID", typeof (InternalFontID));
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

			internal InternalFontID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$InternalFontID;", "")]
			public static unsafe global::Com.Godex.Godex.InternalFontID ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$InternalFontID;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.InternalFontID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.InternalFontID']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$InternalFontID;", "")]
			public static unsafe global::Com.Godex.Godex.InternalFontID[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$InternalFontID;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.InternalFontID[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.InternalFontID));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']"
		[global::Android.Runtime.Register ("com/godex/Godex$Readable", DoNotGenerateAcw=true)]
		public sealed partial class Readable : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Bottom_Centered']"
			[Register ("Bottom_Centered")]
			public static global::Com.Godex.Godex.Readable BottomCentered {
				get {
					const string __id = "Bottom_Centered.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Bottom_Left']"
			[Register ("Bottom_Left")]
			public static global::Com.Godex.Godex.Readable BottomLeft {
				get {
					const string __id = "Bottom_Left.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Bottom_Right']"
			[Register ("Bottom_Right")]
			public static global::Com.Godex.Godex.Readable BottomRight {
				get {
					const string __id = "Bottom_Right.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='None']"
			[Register ("None")]
			public static global::Com.Godex.Godex.Readable None {
				get {
					const string __id = "None.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Top_Centered']"
			[Register ("Top_Centered")]
			public static global::Com.Godex.Godex.Readable TopCentered {
				get {
					const string __id = "Top_Centered.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Top_Left']"
			[Register ("Top_Left")]
			public static global::Com.Godex.Godex.Readable TopLeft {
				get {
					const string __id = "Top_Left.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/field[@name='Top_Right']"
			[Register ("Top_Right")]
			public static global::Com.Godex.Godex.Readable TopRight {
				get {
					const string __id = "Top_Right.Lcom/godex/Godex$Readable;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex$Readable", typeof (Readable));
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

			internal Readable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/godex/Godex$Readable;", "")]
			public static unsafe global::Com.Godex.Godex.Readable ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/godex/Godex$Readable;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Godex.Godex.Readable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex.Readable']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/godex/Godex$Readable;", "")]
			public static unsafe global::Com.Godex.Godex.Readable[] Values ()
			{
				const string __id = "values.()[Lcom/godex/Godex$Readable;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Godex.Godex.Readable[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Godex.Godex.Readable));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/godex/Godex", typeof (Godex));
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

		protected Godex (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.godex']/class[@name='Godex']/constructor[@name='Godex' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Godex ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='AsiaFont_TextOut' and count(parameter)=9 and parameter[1][@type='com.godex.Godex.AsianFontID'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='com.godex.Godex.AsiaEncoding']]"
		[Register ("AsiaFont_TextOut", "(Lcom/godex/Godex$AsianFontID;IIIIILjava/lang/String;Ljava/lang/String;Lcom/godex/Godex$AsiaEncoding;)V", "")]
		public static unsafe void AsiaFont_TextOut (global::Com.Godex.Godex.AsianFontID FontID, int PosX, int PoxY, int Mul_X, int Mul_Y, int spaceChar, string RotationStyle, string Data, global::Com.Godex.Godex.AsiaEncoding encoding)
		{
			const string __id = "AsiaFont_TextOut.(Lcom/godex/Godex$AsianFontID;IIIIILjava/lang/String;Ljava/lang/String;Lcom/godex/Godex$AsiaEncoding;)V";
			IntPtr native_RotationStyle = JNIEnv.NewString (RotationStyle);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((FontID == null) ? IntPtr.Zero : ((global::Java.Lang.Object) FontID).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PoxY);
				__args [3] = new JniArgumentValue (Mul_X);
				__args [4] = new JniArgumentValue (Mul_Y);
				__args [5] = new JniArgumentValue (spaceChar);
				__args [6] = new JniArgumentValue (native_RotationStyle);
				__args [7] = new JniArgumentValue (native_Data);
				__args [8] = new JniArgumentValue ((encoding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encoding).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_RotationStyle);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='BMPformat' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("BMPformat", "(Landroid/graphics/Bitmap;)[B", "")]
		public static unsafe byte[] BMPformat (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "BMPformat.(Landroid/graphics/Bitmap;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_1D' and count(parameter)=9 and parameter[1][@type='com.godex.Godex.BarCodeType'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='com.godex.Godex.Readable'] and parameter[9][@type='java.lang.String']]"
		[Register ("Bar_1D", "(Lcom/godex/Godex$BarCodeType;IIIIIILcom/godex/Godex$Readable;Ljava/lang/String;)V", "")]
		public static unsafe void Bar_1D (global::Com.Godex.Godex.BarCodeType Type, int PosX, int PosY, int Narrow, int Width, int Height, int Rotation, global::Com.Godex.Godex.Readable readable, string Data)
		{
			const string __id = "Bar_1D.(Lcom/godex/Godex$BarCodeType;IIIIIILcom/godex/Godex$Readable;Ljava/lang/String;)V";
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((Type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Type).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PosY);
				__args [3] = new JniArgumentValue (Narrow);
				__args [4] = new JniArgumentValue (Width);
				__args [5] = new JniArgumentValue (Height);
				__args [6] = new JniArgumentValue (Rotation);
				__args [7] = new JniArgumentValue ((readable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) readable).Handle);
				__args [8] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_Aztec' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("Bar_Aztec", "(IIIILjava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Bar_Aztec (int PosX, int PosY, int Rotation, int Mul, string ECICS, int Type, string MenuSymbol, string Data)
		{
			const string __id = "Bar_Aztec.(IIIILjava/lang/String;ILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_ECICS = JNIEnv.NewString (ECICS);
			IntPtr native_MenuSymbol = JNIEnv.NewString (MenuSymbol);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (Rotation);
				__args [3] = new JniArgumentValue (Mul);
				__args [4] = new JniArgumentValue (native_ECICS);
				__args [5] = new JniArgumentValue (Type);
				__args [6] = new JniArgumentValue (native_MenuSymbol);
				__args [7] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ECICS);
				JNIEnv.DeleteLocalRef (native_MenuSymbol);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_DataMatrix' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register ("Bar_DataMatrix", "(IIILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void Bar_DataMatrix (int PosX, int PosY, int Enlarge, string Rotation, string Data)
		{
			const string __id = "Bar_DataMatrix.(IIILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_Rotation = JNIEnv.NewString (Rotation);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (Enlarge);
				__args [3] = new JniArgumentValue (native_Rotation);
				__args [4] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_Rotation);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_GS1Databar' and count(parameter)=9 and parameter[1][@type='com.godex.Godex.BarGS1Type'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='com.godex.Godex.Readable'] and parameter[9][@type='java.lang.String']]"
		[Register ("Bar_GS1Databar", "(Lcom/godex/Godex$BarGS1Type;IIIIIILcom/godex/Godex$Readable;Ljava/lang/String;)V", "")]
		public static unsafe void Bar_GS1Databar (global::Com.Godex.Godex.BarGS1Type Type, int PosX, int PosY, int Narrow, int Segment, int Height, int Rotation, global::Com.Godex.Godex.Readable readable, string Data)
		{
			const string __id = "Bar_GS1Databar.(Lcom/godex/Godex$BarGS1Type;IIIIIILcom/godex/Godex$Readable;Ljava/lang/String;)V";
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((Type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) Type).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PosY);
				__args [3] = new JniArgumentValue (Narrow);
				__args [4] = new JniArgumentValue (Segment);
				__args [5] = new JniArgumentValue (Height);
				__args [6] = new JniArgumentValue (Rotation);
				__args [7] = new JniArgumentValue ((readable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) readable).Handle);
				__args [8] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_Maxicode' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='java.lang.String']]"
		[Register ("Bar_Maxicode", "(IIIIIILjava/lang/String;IILjava/lang/String;)V", "")]
		public static unsafe void Bar_Maxicode (int PosX, int PosY, int SymbolNo, int SetNO, int Mode, int CountryCode, string PostalCode, int Class, int Rotation, string Data)
		{
			const string __id = "Bar_Maxicode.(IIIIIILjava/lang/String;IILjava/lang/String;)V";
			IntPtr native_PostalCode = JNIEnv.NewString (PostalCode);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (SymbolNo);
				__args [3] = new JniArgumentValue (SetNO);
				__args [4] = new JniArgumentValue (Mode);
				__args [5] = new JniArgumentValue (CountryCode);
				__args [6] = new JniArgumentValue (native_PostalCode);
				__args [7] = new JniArgumentValue (Class);
				__args [8] = new JniArgumentValue (Rotation);
				__args [9] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_PostalCode);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_PDF147' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
		[Register ("Bar_PDF147", "(IIIIIIIILjava/lang/String;)V", "")]
		public static unsafe void Bar_PDF147 (int PosX, int PosY, int Width, int Height, int Row, int Col, int ErrLevel, int Rotation, string Data)
		{
			const string __id = "Bar_PDF147.(IIIIIIIILjava/lang/String;)V";
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (Width);
				__args [3] = new JniArgumentValue (Height);
				__args [4] = new JniArgumentValue (Row);
				__args [5] = new JniArgumentValue (Col);
				__args [6] = new JniArgumentValue (ErrLevel);
				__args [7] = new JniArgumentValue (Rotation);
				__args [8] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='Bar_QRCode' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String']]"
		[Register ("Bar_QRCode", "(IIIILjava/lang/String;IIILjava/lang/String;)V", "")]
		public static unsafe void Bar_QRCode (int PosX, int PosY, int Mode, int Type, string ErrLevel, int Mask, int Mul, int Rotation, string Data)
		{
			const string __id = "Bar_QRCode.(IIIILjava/lang/String;IIILjava/lang/String;)V";
			IntPtr native_ErrLevel = JNIEnv.NewString (ErrLevel);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (Mode);
				__args [3] = new JniArgumentValue (Type);
				__args [4] = new JniArgumentValue (native_ErrLevel);
				__args [5] = new JniArgumentValue (Mask);
				__args [6] = new JniArgumentValue (Mul);
				__args [7] = new JniArgumentValue (Rotation);
				__args [8] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ErrLevel);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='CheckStatus' and count(parameter)=0]"
		[Register ("CheckStatus", "()Ljava/lang/String;", "")]
		public static unsafe string CheckStatus ()
		{
			const string __id = "CheckStatus.()Ljava/lang/String;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='InternalFont_TextOut' and count(parameter)=8 and parameter[1][@type='com.godex.Godex.InternalFontID'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("InternalFont_TextOut", "(Lcom/godex/Godex$InternalFontID;IIIIILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void InternalFont_TextOut (global::Com.Godex.Godex.InternalFontID FontID, int PosX, int PoxY, int Mul_X, int Mul_Y, int spaceChar, string RotationStyle, string Data)
		{
			const string __id = "InternalFont_TextOut.(Lcom/godex/Godex$InternalFontID;IIIIILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_RotationStyle = JNIEnv.NewString (RotationStyle);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((FontID == null) ? IntPtr.Zero : ((global::Java.Lang.Object) FontID).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PoxY);
				__args [3] = new JniArgumentValue (Mul_X);
				__args [4] = new JniArgumentValue (Mul_Y);
				__args [5] = new JniArgumentValue (spaceChar);
				__args [6] = new JniArgumentValue (native_RotationStyle);
				__args [7] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_RotationStyle);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='SoftFont_TextOut' and count(parameter)=8 and parameter[1][@type='com.godex.Godex.DownlaodFontID'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("SoftFont_TextOut", "(Lcom/godex/Godex$DownlaodFontID;IIIIILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void SoftFont_TextOut (global::Com.Godex.Godex.DownlaodFontID FontID, int PosX, int PoxY, int Mul_X, int Mul_Y, int spaceChar, string RotationStyle, string Data)
		{
			const string __id = "SoftFont_TextOut.(Lcom/godex/Godex$DownlaodFontID;IIIIILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_RotationStyle = JNIEnv.NewString (RotationStyle);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((FontID == null) ? IntPtr.Zero : ((global::Java.Lang.Object) FontID).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PoxY);
				__args [3] = new JniArgumentValue (Mul_X);
				__args [4] = new JniArgumentValue (Mul_Y);
				__args [5] = new JniArgumentValue (spaceChar);
				__args [6] = new JniArgumentValue (native_RotationStyle);
				__args [7] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_RotationStyle);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='TrueTypeFont_TextOut' and count(parameter)=8 and parameter[1][@type='com.godex.Godex.DownlaodFontID'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("TrueTypeFont_TextOut", "(Lcom/godex/Godex$DownlaodFontID;IIIIILjava/lang/String;Ljava/lang/String;)V", "")]
		public static unsafe void TrueTypeFont_TextOut (global::Com.Godex.Godex.DownlaodFontID FontID, int PosX, int PoxY, int Font_W, int Font_H, int spaceChar, string RotationStyle, string Data)
		{
			const string __id = "TrueTypeFont_TextOut.(Lcom/godex/Godex$DownlaodFontID;IIIIILjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_RotationStyle = JNIEnv.NewString (RotationStyle);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((FontID == null) ? IntPtr.Zero : ((global::Java.Lang.Object) FontID).Handle);
				__args [1] = new JniArgumentValue (PosX);
				__args [2] = new JniArgumentValue (PoxY);
				__args [3] = new JniArgumentValue (Font_W);
				__args [4] = new JniArgumentValue (Font_H);
				__args [5] = new JniArgumentValue (spaceChar);
				__args [6] = new JniArgumentValue (native_RotationStyle);
				__args [7] = new JniArgumentValue (native_Data);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_RotationStyle);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='WiFiPrinterSearch' and count(parameter)=0]"
		[Register ("WiFiPrinterSearch", "()Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> WiFiPrinterSearch ()
		{
			const string __id = "WiFiPrinterSearch.()Ljava/util/ArrayList;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()Z", "")]
		public static unsafe bool Close ()
		{
			const string __id = "close.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='debug' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("debug", "(I)V", "")]
		public static unsafe void Debug (int select)
		{
			const string __id = "debug.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (select);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextDownload' and count(parameter)=9 and parameter[1][@type='android.graphics.Typeface'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='java.lang.String']]"
		[Register ("ecTextDownload", "(Landroid/graphics/Typeface;IIIZZZLjava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool EcTextDownload (global::Android.Graphics.Typeface typeface, int Style, int Size, int Degree, bool Inverse, bool Underline, bool Strikeout, string FileName, string Data)
		{
			const string __id = "ecTextDownload.(Landroid/graphics/Typeface;IIIZZZLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_FileName = JNIEnv.NewString (FileName);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				__args [1] = new JniArgumentValue (Style);
				__args [2] = new JniArgumentValue (Size);
				__args [3] = new JniArgumentValue (Degree);
				__args [4] = new JniArgumentValue (Inverse);
				__args [5] = new JniArgumentValue (Underline);
				__args [6] = new JniArgumentValue (Strikeout);
				__args [7] = new JniArgumentValue (native_FileName);
				__args [8] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_FileName);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextDownload' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='boolean'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='java.lang.String']]"
		[Register ("ecTextDownload", "(Ljava/lang/String;IIZZZLjava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool EcTextDownload (string TTFpath, int Size, int Degree, bool Inverse, bool Underline, bool Strikeout, string FileName, string Data)
		{
			const string __id = "ecTextDownload.(Ljava/lang/String;IIZZZLjava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_TTFpath = JNIEnv.NewString (TTFpath);
			IntPtr native_FileName = JNIEnv.NewString (FileName);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_TTFpath);
				__args [1] = new JniArgumentValue (Size);
				__args [2] = new JniArgumentValue (Degree);
				__args [3] = new JniArgumentValue (Inverse);
				__args [4] = new JniArgumentValue (Underline);
				__args [5] = new JniArgumentValue (Strikeout);
				__args [6] = new JniArgumentValue (native_FileName);
				__args [7] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_TTFpath);
				JNIEnv.DeleteLocalRef (native_FileName);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextOut' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Typeface'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='java.lang.String']]"
		[Register ("ecTextOut", "(IILandroid/graphics/Typeface;IIIZZZLjava/lang/String;)Z", "")]
		public static unsafe bool EcTextOut (int PosX, int PosY, global::Android.Graphics.Typeface typeface, int Style, int Size, int Degree, bool Inverse, bool Underline, bool Strikeout, string Data)
		{
			const string __id = "ecTextOut.(IILandroid/graphics/Typeface;IIIZZZLjava/lang/String;)Z";
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				__args [3] = new JniArgumentValue (Style);
				__args [4] = new JniArgumentValue (Size);
				__args [5] = new JniArgumentValue (Degree);
				__args [6] = new JniArgumentValue (Inverse);
				__args [7] = new JniArgumentValue (Underline);
				__args [8] = new JniArgumentValue (Strikeout);
				__args [9] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextOut' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='boolean'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='java.lang.String']]"
		[Register ("ecTextOut", "(IILjava/lang/String;IIZZZLjava/lang/String;)Z", "")]
		public static unsafe bool EcTextOut (int PosX, int PosY, string TTFpath, int Size, int Degree, bool Inverse, bool Underline, bool Strikeout, string Data)
		{
			const string __id = "ecTextOut.(IILjava/lang/String;IIZZZLjava/lang/String;)Z";
			IntPtr native_TTFpath = JNIEnv.NewString (TTFpath);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (native_TTFpath);
				__args [3] = new JniArgumentValue (Size);
				__args [4] = new JniArgumentValue (Degree);
				__args [5] = new JniArgumentValue (Inverse);
				__args [6] = new JniArgumentValue (Underline);
				__args [7] = new JniArgumentValue (Strikeout);
				__args [8] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_TTFpath);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextOutWordWrap' and count(parameter)=11 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Typeface'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='boolean'] and parameter[11][@type='java.lang.String']]"
		[Register ("ecTextOutWordWrap", "(IILandroid/graphics/Typeface;IIIIZZZLjava/lang/String;)Z", "")]
		public static unsafe bool EcTextOutWordWrap (int PosX, int PosY, global::Android.Graphics.Typeface typeface, int Style, int Size, int WrapWidth, int Degree, bool Inverse, bool Underline, bool Strikeout, string Data)
		{
			const string __id = "ecTextOutWordWrap.(IILandroid/graphics/Typeface;IIIIZZZLjava/lang/String;)Z";
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [11];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				__args [3] = new JniArgumentValue (Style);
				__args [4] = new JniArgumentValue (Size);
				__args [5] = new JniArgumentValue (WrapWidth);
				__args [6] = new JniArgumentValue (Degree);
				__args [7] = new JniArgumentValue (Inverse);
				__args [8] = new JniArgumentValue (Underline);
				__args [9] = new JniArgumentValue (Strikeout);
				__args [10] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='ecTextOutWordWrap' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean'] and parameter[9][@type='boolean'] and parameter[10][@type='java.lang.String']]"
		[Register ("ecTextOutWordWrap", "(IILjava/lang/String;IIIZZZLjava/lang/String;)Z", "")]
		public static unsafe bool EcTextOutWordWrap (int PosX, int PosY, string TTFpath, int Size, int WrapWidth, int Degree, bool Inverse, bool Underline, bool Strikeout, string Data)
		{
			const string __id = "ecTextOutWordWrap.(IILjava/lang/String;IIIZZZLjava/lang/String;)Z";
			IntPtr native_TTFpath = JNIEnv.NewString (TTFpath);
			IntPtr native_Data = JNIEnv.NewString (Data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (PosX);
				__args [1] = new JniArgumentValue (PosY);
				__args [2] = new JniArgumentValue (native_TTFpath);
				__args [3] = new JniArgumentValue (Size);
				__args [4] = new JniArgumentValue (WrapWidth);
				__args [5] = new JniArgumentValue (Degree);
				__args [6] = new JniArgumentValue (Inverse);
				__args [7] = new JniArgumentValue (Underline);
				__args [8] = new JniArgumentValue (Strikeout);
				__args [9] = new JniArgumentValue (native_Data);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_TTFpath);
				JNIEnv.DeleteLocalRef (native_Data);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='getMainContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMainContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void GetMainContext (global::Android.Content.Context context)
		{
			const string __id = "getMainContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("loadImage", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool LoadImage (string filepath, string ID_name)
		{
			const string __id = "loadImage.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_filepath = JNIEnv.NewString (filepath);
			IntPtr native_ID_name = JNIEnv.NewString (ID_name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_filepath);
				__args [1] = new JniArgumentValue (native_ID_name);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filepath);
				JNIEnv.DeleteLocalRef (native_ID_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='openport' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openport", "(Ljava/lang/String;I)Z", "")]
		public static unsafe bool Openport (string address, int connect)
		{
			const string __id = "openport.(Ljava/lang/String;I)Z";
			IntPtr native_address = JNIEnv.NewString (address);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_address);
				__args [1] = new JniArgumentValue (connect);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_address);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='printCmdFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("printCmdFile", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool PrintCmdFile (string filepath)
		{
			const string __id = "printCmdFile.(Ljava/lang/String;)Z";
			IntPtr native_filepath = JNIEnv.NewString (filepath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filepath);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_filepath);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='putImage' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Bitmap']]"
		[Register ("putImage", "(IILandroid/graphics/Bitmap;)Z", "")]
		public static unsafe bool PutImage (int px, int py, global::Android.Graphics.Bitmap picture)
		{
			const string __id = "putImage.(IILandroid/graphics/Bitmap;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (px);
				__args [1] = new JniArgumentValue (py);
				__args [2] = new JniArgumentValue ((picture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) picture).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='read' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("read", "([Ljava/lang/String;)I", "")]
		public static unsafe int Read (string[] message)
		{
			const string __id = "read.([Ljava/lang/String;)I";
			IntPtr native_message = JNIEnv.NewArray (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (message != null) {
					JNIEnv.CopyArray (native_message, message);
					JNIEnv.DeleteLocalRef (native_message);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='readByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("readByte", "([B)I", "")]
		public static unsafe int ReadByte (byte[] data)
		{
			const string __id = "readByte.([B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='sendCommand' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sendCommand", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool SendCommand (string messages)
		{
			const string __id = "sendCommand.(Ljava/lang/String;)Z";
			IntPtr native_messages = JNIEnv.NewString (messages);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_messages);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_messages);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='sendCommand' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendCommand", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool SendCommand (string messages, string code)
		{
			const string __id = "sendCommand.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_messages = JNIEnv.NewString (messages);
			IntPtr native_code = JNIEnv.NewString (code);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_messages);
				__args [1] = new JniArgumentValue (native_code);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_messages);
				JNIEnv.DeleteLocalRef (native_code);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='setup' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register ("setup", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public static unsafe bool Setup (string mm, string dark, string speed, string mode, string gap, string top)
		{
			const string __id = "setup.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_mm = JNIEnv.NewString (mm);
			IntPtr native_dark = JNIEnv.NewString (dark);
			IntPtr native_speed = JNIEnv.NewString (speed);
			IntPtr native_mode = JNIEnv.NewString (mode);
			IntPtr native_gap = JNIEnv.NewString (gap);
			IntPtr native_top = JNIEnv.NewString (top);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_mm);
				__args [1] = new JniArgumentValue (native_dark);
				__args [2] = new JniArgumentValue (native_speed);
				__args [3] = new JniArgumentValue (native_mode);
				__args [4] = new JniArgumentValue (native_gap);
				__args [5] = new JniArgumentValue (native_top);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_mm);
				JNIEnv.DeleteLocalRef (native_dark);
				JNIEnv.DeleteLocalRef (native_speed);
				JNIEnv.DeleteLocalRef (native_mode);
				JNIEnv.DeleteLocalRef (native_gap);
				JNIEnv.DeleteLocalRef (native_top);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.godex']/class[@name='Godex']/method[@name='writeByte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("writeByte", "([B)Z", "")]
		public static unsafe bool WriteByte (byte[] gmsgBuffer)
		{
			const string __id = "writeByte.([B)Z";
			IntPtr native_gmsgBuffer = JNIEnv.NewArray (gmsgBuffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_gmsgBuffer);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (gmsgBuffer != null) {
					JNIEnv.CopyArray (native_gmsgBuffer, gmsgBuffer);
					JNIEnv.DeleteLocalRef (native_gmsgBuffer);
				}
			}
		}

	}
}
