namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write38_AdUnit(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"AdUnit", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write6_AdUnit(@"AdUnit", namespace1, ((global::MiracleGames.Models.AdUnit)o), true, false, namespace1, @"");
        }

        public void Write39_root(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"root", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write7_FormattedResult(@"root", namespace2, ((global::MiracleGames.Models.FormattedResult)o), true, false, namespace2, @"");
        }

        public void Write40_root(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"root", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write8_CertificationResult(@"root", namespace3, ((global::MiracleGames.Models.CertificationResult)o), true, false, namespace3, @"");
        }

        public void Write41_ROOT(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ROOT", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write11_GoodsPayChannel(@"ROOT", namespace4, ((global::MiracleGames.Models.GoodsPayChannel)o), true, false, namespace4, @"");
        }

        public void Write42_Assets(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Assets", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write14_AssetsList(@"Assets", namespace5, ((global::MiracleGames.Models.AssetsList)o), true, false, namespace5, @"");
        }

        public void Write43_UseAsset(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"UseAsset", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write15_UseAssetResult(@"UseAsset", namespace6, ((global::MiracleGames.Models.UseAssetResult)o), true, false, namespace6, @"");
        }

        public void Write44_microsoft(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"microsoft", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write16_MsPayInfo(@"microsoft", namespace7, ((global::MiracleGames.Models.MsPayInfo)o), true, false, namespace7, @"");
        }

        public void Write45_User(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"User", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write17_UserInfo(@"User", namespace8, ((global::MiracleGames.Models.UserInfo)o), true, false, namespace8, @"");
        }

        public void Write46_root(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"root", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write18_SimpleResult(@"root", namespace9, ((global::MiracleGames.Models.SimpleResult)o), true, false, namespace9, @"");
        }

        public void Write47_Code(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Code", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write19_CodeResult(@"Code", namespace10, ((global::MiracleGames.Models.CodeResult)o), true, false, namespace10, @"");
        }

        public void Write48_User(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"User", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write20_NewAccountInfo(@"User", namespace11, ((global::MiracleGames.Models.NewAccountInfo)o), true, false, namespace11, @"");
        }

        public void Write49_User(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"User", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write21_BindingInfo(@"User", namespace12, ((global::MiracleGames.Models.BindingInfo)o), true, false, namespace12, @"");
        }

        public void Write50_Init(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Init", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace13 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write34_AppInfo(@"Init", namespace13, ((global::MiracleGames.Models.AppInfo)o), true, false, namespace13, @"");
        }

        public void Write51_Error(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Error", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace14 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write35_ErrorInfo(@"Error", namespace14, ((global::MiracleGames.Models.ErrorInfo)o), true, false, namespace14, @"");
        }

        public void Write52_OAuth(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"OAuth", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace15 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write37_CacheUserData(@"OAuth", namespace15, ((global::MiracleGames.Models.CacheUserData)o), true, false, namespace15, @"");
        }

        void Write37_CacheUserData(string n, string ns, global::MiracleGames.Models.CacheUserData o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.CacheUserData)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CacheUserData", defaultNamespace);
            string namespace16 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"User", namespace16, ((global::System.String)o.@User));
            {
                global::MiracleGames.Models.ComboUser[] a = (global::MiracleGames.Models.ComboUser[])o.@ComboUsers;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace17 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write36_ComboUser(@"ComboUser", namespace17, ((global::MiracleGames.Models.ComboUser)a[ia]), false, false, namespace17, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write36_ComboUser(string n, string ns, global::MiracleGames.Models.ComboUser o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.ComboUser)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ComboUser", defaultNamespace);
            WriteAttribute(@"account", @"", ((global::System.String)o.@Account));
            WriteAttribute(@"psd", @"", ((global::System.String)o.@Password));
            WriteEndElement(o);
        }

        void Write35_ErrorInfo(string n, string ns, global::MiracleGames.Models.ErrorInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.ErrorInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ErrorInfo", defaultNamespace);
            WriteAttribute(@"Code", @"", ((global::System.String)o.@Code));
            WriteAttribute(@"Message", @"", ((global::System.String)o.@Message));
            WriteAttribute(@"detail", @"", ((global::System.String)o.@Detail));
            WriteEndElement(o);
        }

        void Write34_AppInfo(string n, string ns, global::MiracleGames.Models.AppInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AppInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AppInfo", defaultNamespace);
            string namespace18 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write22_Token(@"Token", namespace18, ((global::MiracleGames.Models.Token)o.@Token), false, false, namespace18, @"");
            string namespace19 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write23_AppBasicInfo(@"App", namespace19, ((global::MiracleGames.Models.AppBasicInfo)o.@AppBasicInfo), false, false, namespace19, @"");
            string namespace20 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write17_UserInfo(@"User", namespace20, ((global::MiracleGames.Models.UserInfo)o.@UserInfo), false, false, namespace20, @"");
            string namespace21 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write24_Privacy(@"Privacy", namespace21, ((global::MiracleGames.Models.Privacy)o.@Privacy), false, false, namespace21, @"");
            string namespace22 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"PlayerLevel", namespace22, System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@PlayerLevel)));
            string namespace23 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write25_Authentication(@"Authentication", namespace23, ((global::MiracleGames.Models.Authentication)o.@Authentication), false, false, namespace23, @"");
            string namespace24 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write26_Payment(@"Payment", namespace24, ((global::MiracleGames.Models.Payment)o.@Payment), false, false, namespace24, @"");
            string namespace25 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write27_Promotion(@"Promotion", namespace25, ((global::MiracleGames.Models.Promotion)o.@Promotion), false, false, namespace25, @"");
            string namespace26 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Debug", namespace26, ((global::System.String)o.@Debug));
            string namespace27 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"DisplayCustomerCenter", namespace27, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@DisplayCustomerCenter)));
            string namespace28 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::MiracleGames.Models.AssetsInfo[] a = (global::MiracleGames.Models.AssetsInfo[])((global::MiracleGames.Models.AssetsInfo[])o.@Assets);
                if (a != null){
                    WriteStartElement(@"Assets", namespace28, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace29 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write13_AssetsInfo(@"Asset", namespace29, ((global::MiracleGames.Models.AssetsInfo)a[ia]), true, false, namespace29, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace30 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::MiracleGames.Models.ThirdLoginInfo[] a = (global::MiracleGames.Models.ThirdLoginInfo[])((global::MiracleGames.Models.ThirdLoginInfo[])o.@ThirdLoginList);
                if (a != null){
                    WriteStartElement(@"ThirdLoginList", namespace30, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace31 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write28_ThirdLoginInfo(@"ThirdLogin", namespace31, ((global::MiracleGames.Models.ThirdLoginInfo)a[ia]), true, false, namespace31, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace32 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"GoogleAdURI", namespace32, ((global::System.String)o.@GoogleAdUri));
            string namespace33 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write33_AppConfig(@"Config", namespace33, ((global::MiracleGames.Models.AppConfig)o.@Config), false, false, namespace33, @"");
            WriteEndElement(o);
        }

        void Write33_AppConfig(string n, string ns, global::MiracleGames.Models.AppConfig o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AppConfig)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AppConfig", defaultNamespace);
            string namespace34 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write29_ShareConfig(@"Share", namespace34, ((global::MiracleGames.Models.ShareConfig)o.@Share), false, false, namespace34, @"");
            string namespace35 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write30_AntiAddictionConfig(@"AntiAddiction", namespace35, ((global::MiracleGames.Models.AntiAddictionConfig)o.@AntiAddiction), false, false, namespace35, @"");
            string namespace36 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write31_CommunityConfig(@"Community", namespace36, ((global::MiracleGames.Models.CommunityConfig)o.@CommunityConfig), false, false, namespace36, @"");
            string namespace37 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write32_GoogleAdConfig(@"GoogleAd", namespace37, ((global::MiracleGames.Models.GoogleAdConfig)o.@GoogleAdConfig), false, false, namespace37, @"");
            WriteEndElement(o);
        }

        void Write32_GoogleAdConfig(string n, string ns, global::MiracleGames.Models.GoogleAdConfig o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.GoogleAdConfig)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoogleAdConfig", defaultNamespace);
            string namespace38 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Open", namespace38, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Open)));
            WriteEndElement(o);
        }

        void Write31_CommunityConfig(string n, string ns, global::MiracleGames.Models.CommunityConfig o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.CommunityConfig)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CommunityConfig", defaultNamespace);
            string namespace39 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Open", namespace39, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Open)));
            WriteEndElement(o);
        }

        void Write30_AntiAddictionConfig(string n, string ns, global::MiracleGames.Models.AntiAddictionConfig o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AntiAddictionConfig)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AntiAddictionConfig", defaultNamespace);
            string namespace40 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Open", namespace40, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Open)));
            WriteEndElement(o);
        }

        void Write29_ShareConfig(string n, string ns, global::MiracleGames.Models.ShareConfig o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.ShareConfig)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ShareConfig", defaultNamespace);
            string namespace41 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"Open", namespace41, System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@Open)));
            string namespace42 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Tag", namespace42, ((global::System.String)o.@Tags));
            WriteEndElement(o);
        }

        void Write28_ThirdLoginInfo(string n, string ns, global::MiracleGames.Models.ThirdLoginInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.ThirdLoginInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ThirdLoginInfo", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteAttribute(@"Icon", @"", ((global::System.String)o.@Icon));
            WriteAttribute(@"Width", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Width)));
            WriteAttribute(@"Height", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Height)));
            WriteAttribute(@"Used", @"", ((global::System.String)o.@UsedStr));
            WriteEndElement(o);
        }

        void Write13_AssetsInfo(string n, string ns, global::MiracleGames.Models.AssetsInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AssetsInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AssetsInfo", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteAttribute(@"Comment", @"", ((global::System.String)o.@Comment));
            string namespace43 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write12_DigitalGoods(@"DigitalGoods", namespace43, ((global::MiracleGames.Models.DigitalGoods)o.@DigitalGoods), false, false, namespace43, @"");
            WriteEndElement(o);
        }

        void Write12_DigitalGoods(string n, string ns, global::MiracleGames.Models.DigitalGoods o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.DigitalGoods)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DigitalGoods", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Price", @"", System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Price)));
            WriteAttribute(@"Tag", @"", ((global::System.String)o.@Tag));
            WriteAttribute(@"Count", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Count)));
            WriteEndElement(o);
        }

        void Write27_Promotion(string n, string ns, global::MiracleGames.Models.Promotion o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Promotion)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Promotion", defaultNamespace);
            WriteAttribute(@"Url", @"", ((global::System.String)o.@Url));
            WriteEndElement(o);
        }

        void Write26_Payment(string n, string ns, global::MiracleGames.Models.Payment o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Payment)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Payment", defaultNamespace);
            WriteAttribute(@"Currency", @"", ((global::System.String)o.@Currency));
            WriteAttribute(@"Url", @"", ((global::System.String)o.@Url));
            WriteEndElement(o);
        }

        void Write25_Authentication(string n, string ns, global::MiracleGames.Models.Authentication o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Authentication)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Authentication", defaultNamespace);
            WriteAttribute(@"Url", @"", ((global::System.String)o.@Url));
            WriteEndElement(o);
        }

        void Write24_Privacy(string n, string ns, global::MiracleGames.Models.Privacy o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Privacy)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Privacy", defaultNamespace);
            string namespace44 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"UserUrl", namespace44, ((global::System.String)o.@UserUrl));
            string namespace45 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"PolicyUrl", namespace45, ((global::System.String)o.@PolicyUrl));
            WriteEndElement(o);
        }

        void Write17_UserInfo(string n, string ns, global::MiracleGames.Models.UserInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.UserInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"UserInfo", defaultNamespace);
            WriteAttribute(@"Account", @"", ((global::System.String)o.@Account));
            WriteAttribute(@"AccountFull", @"", ((global::System.String)o.@AccountFull));
            WriteAttribute(@"Type", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@Type)));
            WriteAttribute(@"BindPhone", @"", ((global::System.String)o.@BindPhoneStr));
            WriteAttribute(@"BindEmail", @"", ((global::System.String)o.@BindEmailStr));
            WriteAttribute(@"PasswordProtected", @"", ((global::System.String)o.@PasswordProtectedStr));
            string namespace46 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Id", namespace46, ((global::System.String)o.@Id));
            string namespace47 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Token", namespace47, ((global::System.String)o.@Token));
            WriteEndElement(o);
        }

        void Write23_AppBasicInfo(string n, string ns, global::MiracleGames.Models.AppBasicInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AppBasicInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AppBasicInfo", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"AppId", @"", ((global::System.String)o.@AppId));
            WriteAttribute(@"Version", @"", ((global::System.String)o.@Version));
            WriteEndElement(o);
        }

        void Write22_Token(string n, string ns, global::MiracleGames.Models.Token o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Token)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Token", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteEndElement(o);
        }

        void Write21_BindingInfo(string n, string ns, global::MiracleGames.Models.BindingInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.BindingInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BindingInfo", defaultNamespace);
            string namespace48 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"CustomerKey", namespace48, ((global::System.String)o.@CustomKey));
            string namespace49 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"BindPhone", namespace49, ((global::System.String)o.@BindPhoneStr));
            string namespace50 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"BindEmail", namespace50, ((global::System.String)o.@BindEmailStr));
            WriteEndElement(o);
        }

        void Write20_NewAccountInfo(string n, string ns, global::MiracleGames.Models.NewAccountInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.NewAccountInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"NewAccountInfo", defaultNamespace);
            string namespace51 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Account", namespace51, ((global::System.String)o.@Account));
            string namespace52 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Password", namespace52, ((global::System.String)o.@Password));
            WriteEndElement(o);
        }

        void Write19_CodeResult(string n, string ns, global::MiracleGames.Models.CodeResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.CodeResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CodeResult", defaultNamespace);
            string namespace53 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Result", namespace53, ((global::System.String)o.@Result));
            WriteEndElement(o);
        }

        void Write18_SimpleResult(string n, string ns, global::MiracleGames.Models.SimpleResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.SimpleResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SimpleResult", defaultNamespace);
            string namespace54 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"result", namespace54, ((global::System.String)o.@Result));
            string namespace55 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"msg", namespace55, ((global::System.String)o.@ErrMsg));
            WriteEndElement(o);
        }

        void Write16_MsPayInfo(string n, string ns, global::MiracleGames.Models.MsPayInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.MsPayInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MsPayInfo", defaultNamespace);
            string namespace56 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"xmlResult", namespace56, ((global::System.String)o.@Result));
            string namespace57 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"xmlErrorMsg", namespace57, ((global::System.String)o.@ErrorMsg));
            string namespace58 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"productId", namespace58, ((global::System.String)o.@ProductId));
            string namespace59 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"orderKey", namespace59, ((global::System.String)o.@OrderKey));
            string namespace60 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"amount", namespace60, System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Amount)));
            string namespace61 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"currencyCode", namespace61, ((global::System.String)o.@CurrencyCode));
            string namespace62 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"description", namespace62, ((global::System.String)o.@Desc));
            string namespace63 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"notifyUrl", namespace63, ((global::System.String)o.@NotifyUrl));
            string namespace64 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"returnUrl", namespace64, ((global::System.String)o.@ReturnUrl));
            string namespace65 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"secretKey", namespace65, ((global::System.String)o.@SecretKey));
            string namespace66 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"msGoodsKeyJson", namespace66, ((global::System.String)o.@GoodsKeyJson));
            WriteEndElement(o);
        }

        void Write15_UseAssetResult(string n, string ns, global::MiracleGames.Models.UseAssetResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.UseAssetResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"UseAssetResult", defaultNamespace);
            string namespace67 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Result", namespace67, ((global::System.String)o.@Result));
            WriteEndElement(o);
        }

        void Write14_AssetsList(string n, string ns, global::MiracleGames.Models.AssetsList o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AssetsList)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AssetsList", defaultNamespace);
            {
                global::MiracleGames.Models.AssetsInfo[] a = (global::MiracleGames.Models.AssetsInfo[])o.@Assets;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace68 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write13_AssetsInfo(@"Asset", namespace68, ((global::MiracleGames.Models.AssetsInfo)a[ia]), false, false, namespace68, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write11_GoodsPayChannel(string n, string ns, global::MiracleGames.Models.GoodsPayChannel o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.GoodsPayChannel)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoodsPayChannel", defaultNamespace);
            string namespace69 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            Write9_GoodsInfo(@"Goods", namespace69, ((global::MiracleGames.Models.GoodsInfo)o.@GoodsInfo), false, false, namespace69, @"");
            string namespace70 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::MiracleGames.Models.PayChannel[] a = (global::MiracleGames.Models.PayChannel[])((global::MiracleGames.Models.PayChannel[])o.@Channels);
                if (a != null){
                    WriteStartElement(@"List", namespace70, null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace71 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write10_PayChannel(@"Pay", namespace71, ((global::MiracleGames.Models.PayChannel)a[ia]), true, false, namespace71, @"");
                    }
                    WriteEndElement();
                }
            }
            WriteEndElement(o);
        }

        void Write10_PayChannel(string n, string ns, global::MiracleGames.Models.PayChannel o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.PayChannel)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PayChannel", defaultNamespace);
            WriteAttribute(@"Name", @"", ((global::System.String)o.@Name));
            WriteAttribute(@"Icon", @"", ((global::System.String)o.@Icon));
            WriteAttribute(@"PaymentType", @"", ((global::System.String)o.@Type));
            WriteAttribute(@"PaymentCode", @"", ((global::System.String)o.@Code));
            WriteAttribute(@"PaymentCountry", @"", ((global::System.String)o.@Country));
            WriteEndElement(o);
        }

        void Write9_GoodsInfo(string n, string ns, global::MiracleGames.Models.GoodsInfo o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.GoodsInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GoodsInfo", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteAttribute(@"Key", @"", ((global::System.String)o.@Key));
            string namespace72 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Price", namespace72, ((global::System.String)o.@Price));
            WriteEndElement(o);
        }

        void Write8_CertificationResult(string n, string ns, global::MiracleGames.Models.CertificationResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.CertificationResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"CertificationResult", defaultNamespace);
            string namespace73 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"result", namespace73, ((global::System.String)o.@Result));
            string namespace74 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"errCode", namespace74, ((global::System.String)o.@ErrCode));
            string namespace75 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"errMsg", namespace75, ((global::System.String)o.@ErrMsg));
            string namespace76 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"msg", namespace76, ((global::System.String)o.@Age));
            WriteEndElement(o);
        }

        void Write7_FormattedResult(string n, string ns, global::MiracleGames.Models.FormattedResult o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.FormattedResult)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FormattedResult", defaultNamespace);
            string namespace77 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"result", namespace77, ((global::System.String)o.@Result));
            string namespace78 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"errCode", namespace78, ((global::System.String)o.@ErrCode));
            string namespace79 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"errMsg", namespace79, ((global::System.String)o.@ErrMsg));
            WriteEndElement(o);
        }

        void Write6_AdUnit(string n, string ns, global::MiracleGames.Models.AdUnit o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.AdUnit)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AdUnit", defaultNamespace);
            WriteAttribute(@"AdvertPlaceKey", @"", ((global::System.String)o.@AdUnitId));
            WriteAttribute(@"AdvertPlaceId", @"", ((global::System.String)o.@AdvertPlaceId));
            WriteAttribute(@"Type", @"", Write1_AdType(((global::MiracleGames.Models.AdType)o.@Type)));
            WriteAttribute(@"Width", @"", System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Width)));
            WriteAttribute(@"Height", @"", System.Xml.XmlConvert.ToString((global::System.Double)((global::System.Double)o.@Height)));
            WriteAttribute(@"RefreshTime", @"", ((global::System.String)o.@RefreshTimeStr));
            WriteAttribute(@"StopFlag", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@StopFlag)));
            WriteAttribute(@"Plan", @"", ((global::System.String)o.@Plan));
            WriteAttribute(@"PopupTime", @"", ((global::System.String)o.@PopupTimeStr));
            {
                global::MiracleGames.Models.Advertisement[] a = (global::MiracleGames.Models.Advertisement[])o.@Advertisement;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        string namespace80 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write5_Advertisement(@"Ad", namespace80, ((global::MiracleGames.Models.Advertisement)a[ia]), false, false, namespace80, @"");
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write5_Advertisement(string n, string ns, global::MiracleGames.Models.Advertisement o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MiracleGames.Models.Advertisement)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Advertisement", defaultNamespace);
            WriteAttribute(@"Id", @"", ((global::System.String)o.@Id));
            WriteAttribute(@"Key", @"", ((global::System.String)o.@Key));
            WriteAttribute(@"Source", @"", ((global::System.String)o.@Source));
            WriteAttribute(@"ResourceType", @"", Write2_AdResourceType(((global::MiracleGames.Models.AdResourceType)o.@ResourceType)));
            WriteAttribute(@"Method", @"", Write3_AdMethod(((global::MiracleGames.Models.AdMethod)o.@Method)));
            WriteAttribute(@"Link", @"", ((global::System.String)o.@Link));
            WriteAttribute(@"MarketIdType", @"", ((global::System.String)o.@MarketIdType));
            WriteAttribute(@"MarketWebUrl", @"", ((global::System.String)o.@MarketWebUrl));
            WriteAttribute(@"MarketStoreUrl", @"", ((global::System.String)o.@MarketStoreUrl));
            WriteAttribute(@"MarketId", @"", ((global::System.String)o.@MarketId));
            WriteAttribute(@"IsForce", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@IsForce)));
            WriteAttribute(@"VideoTime", @"", System.Xml.XmlConvert.ToString((global::System.Int32)((global::System.Int32)o.@VideoTime)));
            WriteAttribute(@"AdvertResourceId", @"", ((global::System.String)o.@AdvertResourceId));
            WriteAttribute(@"pfnName", @"", ((global::System.String)o.@Pfn));
            WriteEndElement(o);
        }

        string Write3_AdMethod(global::MiracleGames.Models.AdMethod v) {
            string s = null;
            switch (v) {
                case global::MiracleGames.Models.AdMethod.@Store: s = @"0"; break;
                case global::MiracleGames.Models.AdMethod.@Web: s = @"1"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"MiracleGames.Models.AdMethod");
            }
            return s;
        }

        string Write2_AdResourceType(global::MiracleGames.Models.AdResourceType v) {
            string s = null;
            switch (v) {
                case global::MiracleGames.Models.AdResourceType.@Image: s = @"1"; break;
                case global::MiracleGames.Models.AdResourceType.@Web: s = @"2"; break;
                case global::MiracleGames.Models.AdResourceType.@Video: s = @"3"; break;
                case global::MiracleGames.Models.AdResourceType.@Link: s = @"4"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"MiracleGames.Models.AdResourceType");
            }
            return s;
        }

        string Write1_AdType(global::MiracleGames.Models.AdType v) {
            string s = null;
            switch (v) {
                case global::MiracleGames.Models.AdType.@Interstitial: s = @"1"; break;
                case global::MiracleGames.Models.AdType.@Banner: s = @"2"; break;
                case global::MiracleGames.Models.AdType.@Couplet: s = @"3"; break;
                case global::MiracleGames.Models.AdType.@FullScreenInterstitial: s = @"4"; break;
                case global::MiracleGames.Models.AdType.@FullScreen: s = @"5"; break;
                case global::MiracleGames.Models.AdType.@ExistScreen: s = @"6"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"MiracleGames.Models.AdType");
            }
            return s;
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read38_AdUnit(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_AdUnit && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read6_AdUnit(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":AdUnit");
            }
            return (object)o;
        }

        public object Read39_root(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_root && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read7_FormattedResult(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":root");
            }
            return (object)o;
        }

        public object Read40_root(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_root && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read8_CertificationResult(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":root");
            }
            return (object)o;
        }

        public object Read41_ROOT(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_ROOT && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read11_GoodsPayChannel(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ROOT");
            }
            return (object)o;
        }

        public object Read42_Assets(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id5_Assets && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read14_AssetsList(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Assets");
            }
            return (object)o;
        }

        public object Read43_UseAsset(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id6_UseAsset && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read15_UseAssetResult(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":UseAsset");
            }
            return (object)o;
        }

        public object Read44_microsoft(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id7_microsoft && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read16_MsPayInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":microsoft");
            }
            return (object)o;
        }

        public object Read45_User(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read17_UserInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":User");
            }
            return (object)o;
        }

        public object Read46_root(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id3_root && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read18_SimpleResult(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":root");
            }
            return (object)o;
        }

        public object Read47_Code(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id9_Code && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read19_CodeResult(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Code");
            }
            return (object)o;
        }

        public object Read48_User(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read20_NewAccountInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":User");
            }
            return (object)o;
        }

        public object Read49_User(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read21_BindingInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":User");
            }
            return (object)o;
        }

        public object Read50_Init(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id10_Init && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read34_AppInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Init");
            }
            return (object)o;
        }

        public object Read51_Error(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id11_Error && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read35_ErrorInfo(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":Error");
            }
            return (object)o;
        }

        public object Read52_OAuth(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id12_OAuth && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    o = Read37_CacheUserData(true, true, defaultNamespace);
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":OAuth");
            }
            return (object)o;
        }

        global::MiracleGames.Models.CacheUserData Read37_CacheUserData(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_CacheUserData && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.CacheUserData o;
            o = new global::MiracleGames.Models.CacheUserData();
            global::MiracleGames.Models.ComboUser[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@ComboUsers = (global::MiracleGames.Models.ComboUser[])ShrinkArray(a_1, ca_1, typeof(global::MiracleGames.Models.ComboUser), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@User = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id14_ComboUser && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        a_1 = (global::MiracleGames.Models.ComboUser[])EnsureArrayIndex(a_1, ca_1, typeof(global::MiracleGames.Models.ComboUser));a_1[ca_1++] = Read36_ComboUser(false, true, defaultNamespace);
                    }
                    else {
                        UnknownNode((object)o, @":User, :ComboUser");
                    }
                }
                else {
                    UnknownNode((object)o, @":User, :ComboUser");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            o.@ComboUsers = (global::MiracleGames.Models.ComboUser[])ShrinkArray(a_1, ca_1, typeof(global::MiracleGames.Models.ComboUser), true);
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.ComboUser Read36_ComboUser(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_ComboUser && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.ComboUser o;
            o = new global::MiracleGames.Models.ComboUser();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id15_account && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Account = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id16_psd && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Password = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":account, :psd");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.ErrorInfo Read35_ErrorInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_ErrorInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.ErrorInfo o;
            o = new global::MiracleGames.Models.ErrorInfo();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Code && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Code = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id18_Message && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Message = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id19_detail && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Detail = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Code, :Message, :detail");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AppInfo Read34_AppInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_AppInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AppInfo o;
            o = new global::MiracleGames.Models.AppInfo();
            global::MiracleGames.Models.AssetsInfo[] a_10 = null;
            int ca_10 = 0;
            global::MiracleGames.Models.ThirdLoginInfo[] a_11 = null;
            int ca_11 = 0;
            bool[] paramsRead = new bool[14];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id21_Token && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Token = Read22_Token(false, true, defaultNamespace);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id22_App && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@AppBasicInfo = Read23_AppBasicInfo(false, true, defaultNamespace);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id8_User && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@UserInfo = Read17_UserInfo(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id23_Privacy && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Privacy = Read24_Privacy(false, true, defaultNamespace);
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id24_PlayerLevel && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@PlayerLevel = System.Xml.XmlConvert.ToInt32(Reader.ReadElementContentAsString());
                        }
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id25_Authentication && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Authentication = Read25_Authentication(false, true, defaultNamespace);
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id26_Payment && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Payment = Read26_Payment(false, true, defaultNamespace);
                        paramsRead[6] = true;
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id27_Promotion && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Promotion = Read27_Promotion(false, true, defaultNamespace);
                        paramsRead[7] = true;
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id28_Debug && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Debug = Reader.ReadElementContentAsString();
                        }
                        paramsRead[8] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id29_DisplayCustomerCenter && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@DisplayCustomerCenter = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[9] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id5_Assets && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            global::MiracleGames.Models.AssetsInfo[] a_10_0 = null;
                            int ca_10_0 = 0;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations4 = 0;
                                int readerCount4 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id30_Asset && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            a_10_0 = (global::MiracleGames.Models.AssetsInfo[])EnsureArrayIndex(a_10_0, ca_10_0, typeof(global::MiracleGames.Models.AssetsInfo));a_10_0[ca_10_0++] = Read13_AssetsInfo(true, true, defaultNamespace);
                                        }
                                        else {
                                            UnknownNode(null, @":Asset");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Asset");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations4, ref readerCount4);
                                }
                            ReadEndElement();
                            }
                            o.@Assets = (global::MiracleGames.Models.AssetsInfo[])ShrinkArray(a_10_0, ca_10_0, typeof(global::MiracleGames.Models.AssetsInfo), false);
                        }
                    }
                    else if (((object) Reader.LocalName == (object)id31_ThirdLoginList && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            global::MiracleGames.Models.ThirdLoginInfo[] a_11_0 = null;
                            int ca_11_0 = 0;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations5 = 0;
                                int readerCount5 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id32_ThirdLogin && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            a_11_0 = (global::MiracleGames.Models.ThirdLoginInfo[])EnsureArrayIndex(a_11_0, ca_11_0, typeof(global::MiracleGames.Models.ThirdLoginInfo));a_11_0[ca_11_0++] = Read28_ThirdLoginInfo(true, true, defaultNamespace);
                                        }
                                        else {
                                            UnknownNode(null, @":ThirdLogin");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":ThirdLogin");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations5, ref readerCount5);
                                }
                            ReadEndElement();
                            }
                            o.@ThirdLoginList = (global::MiracleGames.Models.ThirdLoginInfo[])ShrinkArray(a_11_0, ca_11_0, typeof(global::MiracleGames.Models.ThirdLoginInfo), false);
                        }
                    }
                    else if (!paramsRead[12] && ((object) Reader.LocalName == (object)id33_GoogleAdURI && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@GoogleAdUri = Reader.ReadElementContentAsString();
                        }
                        paramsRead[12] = true;
                    }
                    else if (!paramsRead[13] && ((object) Reader.LocalName == (object)id34_Config && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Config = Read33_AppConfig(false, true, defaultNamespace);
                        paramsRead[13] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Token, :App, :User, :Privacy, :PlayerLevel, :Authentication, :Payment, :Promotion, :Debug, :DisplayCustomerCenter, :Assets, :ThirdLoginList, :GoogleAdURI, :Config");
                    }
                }
                else {
                    UnknownNode((object)o, @":Token, :App, :User, :Privacy, :PlayerLevel, :Authentication, :Payment, :Promotion, :Debug, :DisplayCustomerCenter, :Assets, :ThirdLoginList, :GoogleAdURI, :Config");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AppConfig Read33_AppConfig(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id35_AppConfig && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AppConfig o;
            o = new global::MiracleGames.Models.AppConfig();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id36_Share && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@Share = Read29_ShareConfig(false, true, defaultNamespace);
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id37_AntiAddiction && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@AntiAddiction = Read30_AntiAddictionConfig(false, true, defaultNamespace);
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id38_Community && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@CommunityConfig = Read31_CommunityConfig(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id39_GoogleAd && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@GoogleAdConfig = Read32_GoogleAdConfig(false, true, defaultNamespace);
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Share, :AntiAddiction, :Community, :GoogleAd");
                    }
                }
                else {
                    UnknownNode((object)o, @":Share, :AntiAddiction, :Community, :GoogleAd");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.GoogleAdConfig Read32_GoogleAdConfig(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_GoogleAdConfig && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.GoogleAdConfig o;
            o = new global::MiracleGames.Models.GoogleAdConfig();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations7 = 0;
            int readerCount7 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id41_Open && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Open = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Open");
                    }
                }
                else {
                    UnknownNode((object)o, @":Open");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations7, ref readerCount7);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.CommunityConfig Read31_CommunityConfig(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_CommunityConfig && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.CommunityConfig o;
            o = new global::MiracleGames.Models.CommunityConfig();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id41_Open && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Open = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Open");
                    }
                }
                else {
                    UnknownNode((object)o, @":Open");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AntiAddictionConfig Read30_AntiAddictionConfig(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_AntiAddictionConfig && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AntiAddictionConfig o;
            o = new global::MiracleGames.Models.AntiAddictionConfig();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id41_Open && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Open = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Open");
                    }
                }
                else {
                    UnknownNode((object)o, @":Open");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.ShareConfig Read29_ShareConfig(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_ShareConfig && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.ShareConfig o;
            o = new global::MiracleGames.Models.ShareConfig();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id41_Open && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Open = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementContentAsString());
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id45_Tag && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Tags = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Open, :Tag");
                    }
                }
                else {
                    UnknownNode((object)o, @":Open, :Tag");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.ThirdLoginInfo Read28_ThirdLoginInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_ThirdLoginInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.ThirdLoginInfo o;
            o = new global::MiracleGames.Models.ThirdLoginInfo();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id48_Icon && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Icon = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id49_Width && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Width = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id50_Height && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Height = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id51_Used && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@UsedStr = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id, :Icon, :Width, :Height, :Used");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations11 = 0;
            int readerCount11 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations11, ref readerCount11);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AssetsInfo Read13_AssetsInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_AssetsInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AssetsInfo o;
            o = new global::MiracleGames.Models.AssetsInfo();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id53_Comment && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Comment = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id, :Comment");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id54_DigitalGoods && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@DigitalGoods = Read12_DigitalGoods(false, true, defaultNamespace);
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @":DigitalGoods");
                    }
                }
                else {
                    UnknownNode((object)o, @":DigitalGoods");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.DigitalGoods Read12_DigitalGoods(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_DigitalGoods && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.DigitalGoods o;
            o = new global::MiracleGames.Models.DigitalGoods();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id55_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id56_Price && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Price = System.Xml.XmlConvert.ToDouble(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id45_Tag && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Tag = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id57_Count && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Count = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Name, :Price, :Tag, :Count");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations13 = 0;
            int readerCount13 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations13, ref readerCount13);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Promotion Read27_Promotion(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_Promotion && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Promotion o;
            o = new global::MiracleGames.Models.Promotion();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id58_Url && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Url = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Url");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Payment Read26_Payment(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_Payment && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Payment o;
            o = new global::MiracleGames.Models.Payment();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id59_Currency && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Currency = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id58_Url && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Url = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Currency, :Url");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Authentication Read25_Authentication(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_Authentication && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Authentication o;
            o = new global::MiracleGames.Models.Authentication();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id58_Url && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Url = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Url");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations16 = 0;
            int readerCount16 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations16, ref readerCount16);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Privacy Read24_Privacy(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_Privacy && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Privacy o;
            o = new global::MiracleGames.Models.Privacy();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations17 = 0;
            int readerCount17 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id60_UserUrl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@UserUrl = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_PolicyUrl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@PolicyUrl = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":UserUrl, :PolicyUrl");
                    }
                }
                else {
                    UnknownNode((object)o, @":UserUrl, :PolicyUrl");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations17, ref readerCount17);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.UserInfo Read17_UserInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id62_UserInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.UserInfo o;
            o = new global::MiracleGames.Models.UserInfo();
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[2] && ((object) Reader.LocalName == (object)id63_Account && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Account = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id64_AccountFull && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@AccountFull = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id65_Type && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Type = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id66_BindPhone && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@BindPhoneStr = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id67_BindEmail && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@BindEmailStr = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id68_PasswordProtected && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@PasswordProtectedStr = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Account, :AccountFull, :Type, :BindPhone, :BindEmail, :PasswordProtected");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Id = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id21_Token && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Token = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Id, :Token");
                    }
                }
                else {
                    UnknownNode((object)o, @":Id, :Token");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AppBasicInfo Read23_AppBasicInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id69_AppBasicInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AppBasicInfo o;
            o = new global::MiracleGames.Models.AppBasicInfo();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id55_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id70_AppId && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@AppId = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id71_Version && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Version = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Name, :AppId, :Version");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations19 = 0;
            int readerCount19 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations19, ref readerCount19);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Token Read22_Token(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_Token && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Token o;
            o = new global::MiracleGames.Models.Token();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.BindingInfo Read21_BindingInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id72_BindingInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.BindingInfo o;
            o = new global::MiracleGames.Models.BindingInfo();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations21 = 0;
            int readerCount21 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id73_CustomerKey && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@CustomKey = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id66_BindPhone && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@BindPhoneStr = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id67_BindEmail && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@BindEmailStr = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @":CustomerKey, :BindPhone, :BindEmail");
                    }
                }
                else {
                    UnknownNode((object)o, @":CustomerKey, :BindPhone, :BindEmail");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations21, ref readerCount21);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.NewAccountInfo Read20_NewAccountInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id74_NewAccountInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.NewAccountInfo o;
            o = new global::MiracleGames.Models.NewAccountInfo();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations22 = 0;
            int readerCount22 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id63_Account && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Account = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id75_Password && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Password = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Account, :Password");
                    }
                }
                else {
                    UnknownNode((object)o, @":Account, :Password");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations22, ref readerCount22);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.CodeResult Read19_CodeResult(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id76_CodeResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.CodeResult o;
            o = new global::MiracleGames.Models.CodeResult();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations23 = 0;
            int readerCount23 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id77_Result && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Result");
                    }
                }
                else {
                    UnknownNode((object)o, @":Result");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations23, ref readerCount23);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.SimpleResult Read18_SimpleResult(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id78_SimpleResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.SimpleResult o;
            o = new global::MiracleGames.Models.SimpleResult();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id79_result && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id80_msg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrMsg = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":result, :msg");
                    }
                }
                else {
                    UnknownNode((object)o, @":result, :msg");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.MsPayInfo Read16_MsPayInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id81_MsPayInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.MsPayInfo o;
            o = new global::MiracleGames.Models.MsPayInfo();
            bool[] paramsRead = new bool[11];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations25 = 0;
            int readerCount25 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id82_xmlResult && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id83_xmlErrorMsg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrorMsg = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id84_productId && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ProductId = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id85_orderKey && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@OrderKey = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id86_amount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Amount = System.Xml.XmlConvert.ToDouble(Reader.ReadElementContentAsString());
                        }
                        paramsRead[4] = true;
                    }
                    else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id87_currencyCode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@CurrencyCode = Reader.ReadElementContentAsString();
                        }
                        paramsRead[5] = true;
                    }
                    else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id88_description && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Desc = Reader.ReadElementContentAsString();
                        }
                        paramsRead[6] = true;
                    }
                    else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id89_notifyUrl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@NotifyUrl = Reader.ReadElementContentAsString();
                        }
                        paramsRead[7] = true;
                    }
                    else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id90_returnUrl && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ReturnUrl = Reader.ReadElementContentAsString();
                        }
                        paramsRead[8] = true;
                    }
                    else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id91_secretKey && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@SecretKey = Reader.ReadElementContentAsString();
                        }
                        paramsRead[9] = true;
                    }
                    else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id92_msGoodsKeyJson && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@GoodsKeyJson = Reader.ReadElementContentAsString();
                        }
                        paramsRead[10] = true;
                    }
                    else {
                        UnknownNode((object)o, @":xmlResult, :xmlErrorMsg, :productId, :orderKey, :amount, :currencyCode, :description, :notifyUrl, :returnUrl, :secretKey, :msGoodsKeyJson");
                    }
                }
                else {
                    UnknownNode((object)o, @":xmlResult, :xmlErrorMsg, :productId, :orderKey, :amount, :currencyCode, :description, :notifyUrl, :returnUrl, :secretKey, :msGoodsKeyJson");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations25, ref readerCount25);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.UseAssetResult Read15_UseAssetResult(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id93_UseAssetResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.UseAssetResult o;
            o = new global::MiracleGames.Models.UseAssetResult();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id77_Result && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Result");
                    }
                }
                else {
                    UnknownNode((object)o, @":Result");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AssetsList Read14_AssetsList(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id94_AssetsList && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AssetsList o;
            o = new global::MiracleGames.Models.AssetsList();
            global::MiracleGames.Models.AssetsInfo[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Assets = (global::MiracleGames.Models.AssetsInfo[])ShrinkArray(a_0, ca_0, typeof(global::MiracleGames.Models.AssetsInfo), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id30_Asset && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        a_0 = (global::MiracleGames.Models.AssetsInfo[])EnsureArrayIndex(a_0, ca_0, typeof(global::MiracleGames.Models.AssetsInfo));a_0[ca_0++] = Read13_AssetsInfo(false, true, defaultNamespace);
                    }
                    else {
                        UnknownNode((object)o, @":Asset");
                    }
                }
                else {
                    UnknownNode((object)o, @":Asset");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            o.@Assets = (global::MiracleGames.Models.AssetsInfo[])ShrinkArray(a_0, ca_0, typeof(global::MiracleGames.Models.AssetsInfo), true);
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.GoodsPayChannel Read11_GoodsPayChannel(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id95_GoodsPayChannel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.GoodsPayChannel o;
            o = new global::MiracleGames.Models.GoodsPayChannel();
            global::MiracleGames.Models.PayChannel[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations28 = 0;
            int readerCount28 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id96_Goods && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        o.@GoodsInfo = Read9_GoodsInfo(false, true, defaultNamespace);
                        paramsRead[0] = true;
                    }
                    else if (((object) Reader.LocalName == (object)id97_List && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            global::MiracleGames.Models.PayChannel[] a_1_0 = null;
                            int ca_1_0 = 0;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations29 = 0;
                                int readerCount29 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id98_Pay && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            a_1_0 = (global::MiracleGames.Models.PayChannel[])EnsureArrayIndex(a_1_0, ca_1_0, typeof(global::MiracleGames.Models.PayChannel));a_1_0[ca_1_0++] = Read10_PayChannel(true, true, defaultNamespace);
                                        }
                                        else {
                                            UnknownNode(null, @":Pay");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":Pay");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations29, ref readerCount29);
                                }
                            ReadEndElement();
                            }
                            o.@Channels = (global::MiracleGames.Models.PayChannel[])ShrinkArray(a_1_0, ca_1_0, typeof(global::MiracleGames.Models.PayChannel), false);
                        }
                    }
                    else {
                        UnknownNode((object)o, @":Goods, :List");
                    }
                }
                else {
                    UnknownNode((object)o, @":Goods, :List");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations28, ref readerCount28);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.PayChannel Read10_PayChannel(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id99_PayChannel && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.PayChannel o;
            o = new global::MiracleGames.Models.PayChannel();
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id55_Name && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id48_Icon && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Icon = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id100_PaymentType && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Type = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id101_PaymentCode && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Code = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id102_PaymentCountry && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Country = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Name, :Icon, :PaymentType, :PaymentCode, :PaymentCountry");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.GoodsInfo Read9_GoodsInfo(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id103_GoodsInfo && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.GoodsInfo o;
            o = new global::MiracleGames.Models.GoodsInfo();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id104_Key && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Key = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id, :Key");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations31 = 0;
            int readerCount31 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[2] && ((object) Reader.LocalName == (object)id56_Price && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Price = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Price");
                    }
                }
                else {
                    UnknownNode((object)o, @":Price");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations31, ref readerCount31);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.CertificationResult Read8_CertificationResult(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id105_CertificationResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.CertificationResult o;
            o = new global::MiracleGames.Models.CertificationResult();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id79_result && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id106_errCode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrCode = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id107_errMsg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrMsg = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id80_msg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Age = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @":result, :errCode, :errMsg, :msg");
                    }
                }
                else {
                    UnknownNode((object)o, @":result, :errCode, :errMsg, :msg");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.FormattedResult Read7_FormattedResult(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id108_FormattedResult && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.FormattedResult o;
            o = new global::MiracleGames.Models.FormattedResult();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id79_result && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Result = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id106_errCode && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrCode = Reader.ReadElementContentAsString();
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id107_errMsg && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@ErrMsg = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else {
                        UnknownNode((object)o, @":result, :errCode, :errMsg");
                    }
                }
                else {
                    UnknownNode((object)o, @":result, :errCode, :errMsg");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AdUnit Read6_AdUnit(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_AdUnit && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.AdUnit o;
            o = new global::MiracleGames.Models.AdUnit();
            global::MiracleGames.Models.Advertisement[] a_9 = null;
            int ca_9 = 0;
            bool[] paramsRead = new bool[10];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id109_AdvertPlaceKey && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@AdUnitId = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id110_AdvertPlaceId && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@AdvertPlaceId = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id65_Type && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Type = Read1_AdType(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id49_Width && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Width = System.Xml.XmlConvert.ToDouble(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id50_Height && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Height = System.Xml.XmlConvert.ToDouble(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id111_RefreshTime && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@RefreshTimeStr = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id112_StopFlag && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@StopFlag = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id113_Plan && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Plan = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id114_PopupTime && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@PopupTimeStr = Reader.Value;
                    paramsRead[8] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":AdvertPlaceKey, :AdvertPlaceId, :Type, :Width, :Height, :RefreshTime, :StopFlag, :Plan, :PopupTime");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Advertisement = (global::MiracleGames.Models.Advertisement[])ShrinkArray(a_9, ca_9, typeof(global::MiracleGames.Models.Advertisement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations34 = 0;
            int readerCount34 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id115_Ad && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        a_9 = (global::MiracleGames.Models.Advertisement[])EnsureArrayIndex(a_9, ca_9, typeof(global::MiracleGames.Models.Advertisement));a_9[ca_9++] = Read5_Advertisement(false, true, defaultNamespace);
                    }
                    else {
                        UnknownNode((object)o, @":Ad");
                    }
                }
                else {
                    UnknownNode((object)o, @":Ad");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations34, ref readerCount34);
            }
            o.@Advertisement = (global::MiracleGames.Models.Advertisement[])ShrinkArray(a_9, ca_9, typeof(global::MiracleGames.Models.Advertisement), true);
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.Advertisement Read5_Advertisement(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id116_Advertisement && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            if (isNull) return null;
            global::MiracleGames.Models.Advertisement o;
            o = new global::MiracleGames.Models.Advertisement();
            bool[] paramsRead = new bool[14];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id47_Id && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id104_Key && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Key = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id117_Source && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Source = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id118_ResourceType && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@ResourceType = Read2_AdResourceType(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id119_Method && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Method = Read3_AdMethod(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id120_Link && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Link = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id121_MarketIdType && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@MarketIdType = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id122_MarketWebUrl && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@MarketWebUrl = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id123_MarketStoreUrl && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@MarketStoreUrl = Reader.Value;
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id124_MarketId && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@MarketId = Reader.Value;
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id125_IsForce && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@IsForce = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id126_VideoTime && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@VideoTime = System.Xml.XmlConvert.ToInt32(Reader.Value);
                    paramsRead[11] = true;
                }
                else if (!paramsRead[12] && ((object) Reader.LocalName == (object)id127_AdvertResourceId && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@AdvertResourceId = Reader.Value;
                    paramsRead[12] = true;
                }
                else if (!paramsRead[13] && ((object) Reader.LocalName == (object)id128_pfnName && string.Equals(Reader.NamespaceURI, id2_Item))) {
                    o.@Pfn = Reader.Value;
                    paramsRead[13] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":Id, :Key, :Source, :ResourceType, :Method, :Link, :MarketIdType, :MarketWebUrl, :MarketStoreUrl, :MarketId, :IsForce, :VideoTime, :AdvertResourceId, :pfnName");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            ReadEndElement();
            return o;
        }

        global::MiracleGames.Models.AdMethod Read3_AdMethod(string s) {
            switch (s) {
                case @"0": return global::MiracleGames.Models.AdMethod.@Store;
                case @"1": return global::MiracleGames.Models.AdMethod.@Web;
                default: throw CreateUnknownConstantException(s, typeof(global::MiracleGames.Models.AdMethod));
            }
        }

        global::MiracleGames.Models.AdResourceType Read2_AdResourceType(string s) {
            switch (s) {
                case @"1": return global::MiracleGames.Models.AdResourceType.@Image;
                case @"2": return global::MiracleGames.Models.AdResourceType.@Web;
                case @"3": return global::MiracleGames.Models.AdResourceType.@Video;
                case @"4": return global::MiracleGames.Models.AdResourceType.@Link;
                default: throw CreateUnknownConstantException(s, typeof(global::MiracleGames.Models.AdResourceType));
            }
        }

        global::MiracleGames.Models.AdType Read1_AdType(string s) {
            switch (s) {
                case @"1": return global::MiracleGames.Models.AdType.@Interstitial;
                case @"2": return global::MiracleGames.Models.AdType.@Banner;
                case @"3": return global::MiracleGames.Models.AdType.@Couplet;
                case @"4": return global::MiracleGames.Models.AdType.@FullScreenInterstitial;
                case @"5": return global::MiracleGames.Models.AdType.@FullScreen;
                case @"6": return global::MiracleGames.Models.AdType.@ExistScreen;
                default: throw CreateUnknownConstantException(s, typeof(global::MiracleGames.Models.AdType));
            }
        }

        protected override void InitCallbacks() {
        }

        string id128_pfnName;
        string id26_Payment;
        string id73_CustomerKey;
        string id43_AntiAddictionConfig;
        string id78_SimpleResult;
        string id17_ErrorInfo;
        string id122_MarketWebUrl;
        string id37_AntiAddiction;
        string id11_Error;
        string id63_Account;
        string id115_Ad;
        string id97_List;
        string id61_PolicyUrl;
        string id107_errMsg;
        string id18_Message;
        string id106_errCode;
        string id62_UserInfo;
        string id76_CodeResult;
        string id101_PaymentCode;
        string id46_ThirdLoginInfo;
        string id25_Authentication;
        string id38_Community;
        string id125_IsForce;
        string id123_MarketStoreUrl;
        string id69_AppBasicInfo;
        string id39_GoogleAd;
        string id28_Debug;
        string id8_User;
        string id3_root;
        string id44_ShareConfig;
        string id127_AdvertResourceId;
        string id27_Promotion;
        string id64_AccountFull;
        string id40_GoogleAdConfig;
        string id114_PopupTime;
        string id42_CommunityConfig;
        string id111_RefreshTime;
        string id79_result;
        string id100_PaymentType;
        string id98_Pay;
        string id2_Item;
        string id90_returnUrl;
        string id121_MarketIdType;
        string id119_Method;
        string id71_Version;
        string id89_notifyUrl;
        string id35_AppConfig;
        string id15_account;
        string id113_Plan;
        string id12_OAuth;
        string id104_Key;
        string id80_msg;
        string id75_Password;
        string id23_Privacy;
        string id86_amount;
        string id41_Open;
        string id36_Share;
        string id20_AppInfo;
        string id120_Link;
        string id22_App;
        string id88_description;
        string id1_AdUnit;
        string id24_PlayerLevel;
        string id110_AdvertPlaceId;
        string id52_AssetsInfo;
        string id34_Config;
        string id13_CacheUserData;
        string id48_Icon;
        string id45_Tag;
        string id7_microsoft;
        string id112_StopFlag;
        string id10_Init;
        string id91_secretKey;
        string id74_NewAccountInfo;
        string id5_Assets;
        string id54_DigitalGoods;
        string id67_BindEmail;
        string id57_Count;
        string id70_AppId;
        string id9_Code;
        string id68_PasswordProtected;
        string id33_GoogleAdURI;
        string id83_xmlErrorMsg;
        string id51_Used;
        string id65_Type;
        string id19_detail;
        string id49_Width;
        string id99_PayChannel;
        string id105_CertificationResult;
        string id108_FormattedResult;
        string id59_Currency;
        string id85_orderKey;
        string id87_currencyCode;
        string id82_xmlResult;
        string id96_Goods;
        string id95_GoodsPayChannel;
        string id16_psd;
        string id102_PaymentCountry;
        string id53_Comment;
        string id21_Token;
        string id117_Source;
        string id55_Name;
        string id126_VideoTime;
        string id60_UserUrl;
        string id109_AdvertPlaceKey;
        string id118_ResourceType;
        string id124_MarketId;
        string id29_DisplayCustomerCenter;
        string id93_UseAssetResult;
        string id72_BindingInfo;
        string id47_Id;
        string id81_MsPayInfo;
        string id66_BindPhone;
        string id92_msGoodsKeyJson;
        string id58_Url;
        string id32_ThirdLogin;
        string id14_ComboUser;
        string id56_Price;
        string id4_ROOT;
        string id116_Advertisement;
        string id103_GoodsInfo;
        string id50_Height;
        string id94_AssetsList;
        string id77_Result;
        string id31_ThirdLoginList;
        string id84_productId;
        string id6_UseAsset;
        string id30_Asset;

        protected override void InitIDs() {
            id128_pfnName = Reader.NameTable.Add(@"pfnName");
            id26_Payment = Reader.NameTable.Add(@"Payment");
            id73_CustomerKey = Reader.NameTable.Add(@"CustomerKey");
            id43_AntiAddictionConfig = Reader.NameTable.Add(@"AntiAddictionConfig");
            id78_SimpleResult = Reader.NameTable.Add(@"SimpleResult");
            id17_ErrorInfo = Reader.NameTable.Add(@"ErrorInfo");
            id122_MarketWebUrl = Reader.NameTable.Add(@"MarketWebUrl");
            id37_AntiAddiction = Reader.NameTable.Add(@"AntiAddiction");
            id11_Error = Reader.NameTable.Add(@"Error");
            id63_Account = Reader.NameTable.Add(@"Account");
            id115_Ad = Reader.NameTable.Add(@"Ad");
            id97_List = Reader.NameTable.Add(@"List");
            id61_PolicyUrl = Reader.NameTable.Add(@"PolicyUrl");
            id107_errMsg = Reader.NameTable.Add(@"errMsg");
            id18_Message = Reader.NameTable.Add(@"Message");
            id106_errCode = Reader.NameTable.Add(@"errCode");
            id62_UserInfo = Reader.NameTable.Add(@"UserInfo");
            id76_CodeResult = Reader.NameTable.Add(@"CodeResult");
            id101_PaymentCode = Reader.NameTable.Add(@"PaymentCode");
            id46_ThirdLoginInfo = Reader.NameTable.Add(@"ThirdLoginInfo");
            id25_Authentication = Reader.NameTable.Add(@"Authentication");
            id38_Community = Reader.NameTable.Add(@"Community");
            id125_IsForce = Reader.NameTable.Add(@"IsForce");
            id123_MarketStoreUrl = Reader.NameTable.Add(@"MarketStoreUrl");
            id69_AppBasicInfo = Reader.NameTable.Add(@"AppBasicInfo");
            id39_GoogleAd = Reader.NameTable.Add(@"GoogleAd");
            id28_Debug = Reader.NameTable.Add(@"Debug");
            id8_User = Reader.NameTable.Add(@"User");
            id3_root = Reader.NameTable.Add(@"root");
            id44_ShareConfig = Reader.NameTable.Add(@"ShareConfig");
            id127_AdvertResourceId = Reader.NameTable.Add(@"AdvertResourceId");
            id27_Promotion = Reader.NameTable.Add(@"Promotion");
            id64_AccountFull = Reader.NameTable.Add(@"AccountFull");
            id40_GoogleAdConfig = Reader.NameTable.Add(@"GoogleAdConfig");
            id114_PopupTime = Reader.NameTable.Add(@"PopupTime");
            id42_CommunityConfig = Reader.NameTable.Add(@"CommunityConfig");
            id111_RefreshTime = Reader.NameTable.Add(@"RefreshTime");
            id79_result = Reader.NameTable.Add(@"result");
            id100_PaymentType = Reader.NameTable.Add(@"PaymentType");
            id98_Pay = Reader.NameTable.Add(@"Pay");
            id2_Item = Reader.NameTable.Add(@"");
            id90_returnUrl = Reader.NameTable.Add(@"returnUrl");
            id121_MarketIdType = Reader.NameTable.Add(@"MarketIdType");
            id119_Method = Reader.NameTable.Add(@"Method");
            id71_Version = Reader.NameTable.Add(@"Version");
            id89_notifyUrl = Reader.NameTable.Add(@"notifyUrl");
            id35_AppConfig = Reader.NameTable.Add(@"AppConfig");
            id15_account = Reader.NameTable.Add(@"account");
            id113_Plan = Reader.NameTable.Add(@"Plan");
            id12_OAuth = Reader.NameTable.Add(@"OAuth");
            id104_Key = Reader.NameTable.Add(@"Key");
            id80_msg = Reader.NameTable.Add(@"msg");
            id75_Password = Reader.NameTable.Add(@"Password");
            id23_Privacy = Reader.NameTable.Add(@"Privacy");
            id86_amount = Reader.NameTable.Add(@"amount");
            id41_Open = Reader.NameTable.Add(@"Open");
            id36_Share = Reader.NameTable.Add(@"Share");
            id20_AppInfo = Reader.NameTable.Add(@"AppInfo");
            id120_Link = Reader.NameTable.Add(@"Link");
            id22_App = Reader.NameTable.Add(@"App");
            id88_description = Reader.NameTable.Add(@"description");
            id1_AdUnit = Reader.NameTable.Add(@"AdUnit");
            id24_PlayerLevel = Reader.NameTable.Add(@"PlayerLevel");
            id110_AdvertPlaceId = Reader.NameTable.Add(@"AdvertPlaceId");
            id52_AssetsInfo = Reader.NameTable.Add(@"AssetsInfo");
            id34_Config = Reader.NameTable.Add(@"Config");
            id13_CacheUserData = Reader.NameTable.Add(@"CacheUserData");
            id48_Icon = Reader.NameTable.Add(@"Icon");
            id45_Tag = Reader.NameTable.Add(@"Tag");
            id7_microsoft = Reader.NameTable.Add(@"microsoft");
            id112_StopFlag = Reader.NameTable.Add(@"StopFlag");
            id10_Init = Reader.NameTable.Add(@"Init");
            id91_secretKey = Reader.NameTable.Add(@"secretKey");
            id74_NewAccountInfo = Reader.NameTable.Add(@"NewAccountInfo");
            id5_Assets = Reader.NameTable.Add(@"Assets");
            id54_DigitalGoods = Reader.NameTable.Add(@"DigitalGoods");
            id67_BindEmail = Reader.NameTable.Add(@"BindEmail");
            id57_Count = Reader.NameTable.Add(@"Count");
            id70_AppId = Reader.NameTable.Add(@"AppId");
            id9_Code = Reader.NameTable.Add(@"Code");
            id68_PasswordProtected = Reader.NameTable.Add(@"PasswordProtected");
            id33_GoogleAdURI = Reader.NameTable.Add(@"GoogleAdURI");
            id83_xmlErrorMsg = Reader.NameTable.Add(@"xmlErrorMsg");
            id51_Used = Reader.NameTable.Add(@"Used");
            id65_Type = Reader.NameTable.Add(@"Type");
            id19_detail = Reader.NameTable.Add(@"detail");
            id49_Width = Reader.NameTable.Add(@"Width");
            id99_PayChannel = Reader.NameTable.Add(@"PayChannel");
            id105_CertificationResult = Reader.NameTable.Add(@"CertificationResult");
            id108_FormattedResult = Reader.NameTable.Add(@"FormattedResult");
            id59_Currency = Reader.NameTable.Add(@"Currency");
            id85_orderKey = Reader.NameTable.Add(@"orderKey");
            id87_currencyCode = Reader.NameTable.Add(@"currencyCode");
            id82_xmlResult = Reader.NameTable.Add(@"xmlResult");
            id96_Goods = Reader.NameTable.Add(@"Goods");
            id95_GoodsPayChannel = Reader.NameTable.Add(@"GoodsPayChannel");
            id16_psd = Reader.NameTable.Add(@"psd");
            id102_PaymentCountry = Reader.NameTable.Add(@"PaymentCountry");
            id53_Comment = Reader.NameTable.Add(@"Comment");
            id21_Token = Reader.NameTable.Add(@"Token");
            id117_Source = Reader.NameTable.Add(@"Source");
            id55_Name = Reader.NameTable.Add(@"Name");
            id126_VideoTime = Reader.NameTable.Add(@"VideoTime");
            id60_UserUrl = Reader.NameTable.Add(@"UserUrl");
            id109_AdvertPlaceKey = Reader.NameTable.Add(@"AdvertPlaceKey");
            id118_ResourceType = Reader.NameTable.Add(@"ResourceType");
            id124_MarketId = Reader.NameTable.Add(@"MarketId");
            id29_DisplayCustomerCenter = Reader.NameTable.Add(@"DisplayCustomerCenter");
            id93_UseAssetResult = Reader.NameTable.Add(@"UseAssetResult");
            id72_BindingInfo = Reader.NameTable.Add(@"BindingInfo");
            id47_Id = Reader.NameTable.Add(@"Id");
            id81_MsPayInfo = Reader.NameTable.Add(@"MsPayInfo");
            id66_BindPhone = Reader.NameTable.Add(@"BindPhone");
            id92_msGoodsKeyJson = Reader.NameTable.Add(@"msGoodsKeyJson");
            id58_Url = Reader.NameTable.Add(@"Url");
            id32_ThirdLogin = Reader.NameTable.Add(@"ThirdLogin");
            id14_ComboUser = Reader.NameTable.Add(@"ComboUser");
            id56_Price = Reader.NameTable.Add(@"Price");
            id4_ROOT = Reader.NameTable.Add(@"ROOT");
            id116_Advertisement = Reader.NameTable.Add(@"Advertisement");
            id103_GoodsInfo = Reader.NameTable.Add(@"GoodsInfo");
            id50_Height = Reader.NameTable.Add(@"Height");
            id94_AssetsList = Reader.NameTable.Add(@"AssetsList");
            id77_Result = Reader.NameTable.Add(@"Result");
            id31_ThirdLoginList = Reader.NameTable.Add(@"ThirdLoginList");
            id84_productId = Reader.NameTable.Add(@"productId");
            id6_UseAsset = Reader.NameTable.Add(@"UseAsset");
            id30_Asset = Reader.NameTable.Add(@"Asset");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class AdUnitSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"AdUnit", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write38_AdUnit(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read38_AdUnit(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class FormattedResultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"root", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write39_root(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read39_root(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class CertificationResultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"root", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write40_root(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read40_root(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class GoodsPayChannelSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ROOT", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write41_ROOT(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read41_ROOT(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class AssetsListSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Assets", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write42_Assets(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read42_Assets(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class UseAssetResultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"UseAsset", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write43_UseAsset(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read43_UseAsset(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class MsPayInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"microsoft", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write44_microsoft(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read44_microsoft(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class UserInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"User", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write45_User(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read45_User(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class SimpleResultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"root", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write46_root(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read46_root(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class CodeResultSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Code", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write47_Code(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read47_Code(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class NewAccountInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"User", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write48_User(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read48_User(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class BindingInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"User", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write49_User(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read49_User(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class AppInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Init", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write50_Init(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read50_Init(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ErrorInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Error", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write51_Error(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read51_Error(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class CacheUserDataSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"OAuth", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write52_OAuth(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read52_OAuth(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.IDictionary readMethods = null;
        public override System.Collections.IDictionary ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"MiracleGames.Models.AdUnit::AdUnit:True:"] = @"Read38_AdUnit";
                    _tmp[@"MiracleGames.Models.FormattedResult::root:True:"] = @"Read39_root";
                    _tmp[@"MiracleGames.Models.CertificationResult::root:True:"] = @"Read40_root";
                    _tmp[@"MiracleGames.Models.GoodsPayChannel::ROOT:True:"] = @"Read41_ROOT";
                    _tmp[@"MiracleGames.Models.AssetsList::Assets:True:"] = @"Read42_Assets";
                    _tmp[@"MiracleGames.Models.UseAssetResult::UseAsset:True:"] = @"Read43_UseAsset";
                    _tmp[@"MiracleGames.Models.MsPayInfo::microsoft:True:"] = @"Read44_microsoft";
                    _tmp[@"MiracleGames.Models.UserInfo::User:True:"] = @"Read45_User";
                    _tmp[@"MiracleGames.Models.SimpleResult::root:True:"] = @"Read46_root";
                    _tmp[@"MiracleGames.Models.CodeResult::Code:True:"] = @"Read47_Code";
                    _tmp[@"MiracleGames.Models.NewAccountInfo::User:True:"] = @"Read48_User";
                    _tmp[@"MiracleGames.Models.BindingInfo::User:True:"] = @"Read49_User";
                    _tmp[@"MiracleGames.Models.AppInfo::Init:True:"] = @"Read50_Init";
                    _tmp[@"MiracleGames.Models.ErrorInfo::Error:True:"] = @"Read51_Error";
                    _tmp[@"MiracleGames.Models.CacheUserData::OAuth:True:"] = @"Read52_OAuth";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.IDictionary writeMethods = null;
        public override System.Collections.IDictionary WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, string>();
                    _tmp[@"MiracleGames.Models.AdUnit::AdUnit:True:"] = @"Write38_AdUnit";
                    _tmp[@"MiracleGames.Models.FormattedResult::root:True:"] = @"Write39_root";
                    _tmp[@"MiracleGames.Models.CertificationResult::root:True:"] = @"Write40_root";
                    _tmp[@"MiracleGames.Models.GoodsPayChannel::ROOT:True:"] = @"Write41_ROOT";
                    _tmp[@"MiracleGames.Models.AssetsList::Assets:True:"] = @"Write42_Assets";
                    _tmp[@"MiracleGames.Models.UseAssetResult::UseAsset:True:"] = @"Write43_UseAsset";
                    _tmp[@"MiracleGames.Models.MsPayInfo::microsoft:True:"] = @"Write44_microsoft";
                    _tmp[@"MiracleGames.Models.UserInfo::User:True:"] = @"Write45_User";
                    _tmp[@"MiracleGames.Models.SimpleResult::root:True:"] = @"Write46_root";
                    _tmp[@"MiracleGames.Models.CodeResult::Code:True:"] = @"Write47_Code";
                    _tmp[@"MiracleGames.Models.NewAccountInfo::User:True:"] = @"Write48_User";
                    _tmp[@"MiracleGames.Models.BindingInfo::User:True:"] = @"Write49_User";
                    _tmp[@"MiracleGames.Models.AppInfo::Init:True:"] = @"Write50_Init";
                    _tmp[@"MiracleGames.Models.ErrorInfo::Error:True:"] = @"Write51_Error";
                    _tmp[@"MiracleGames.Models.CacheUserData::OAuth:True:"] = @"Write52_OAuth";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.IDictionary typedSerializers = null;
        public override System.Collections.IDictionary TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.IDictionary _tmp = new System.Collections.Generic.Dictionary<string, System.Xml.Serialization.XmlSerializer>();
                    _tmp.Add(@"MiracleGames.Models.BindingInfo::User:True:", new BindingInfoSerializer());
                    _tmp.Add(@"MiracleGames.Models.AssetsList::Assets:True:", new AssetsListSerializer());
                    _tmp.Add(@"MiracleGames.Models.AppInfo::Init:True:", new AppInfoSerializer());
                    _tmp.Add(@"MiracleGames.Models.GoodsPayChannel::ROOT:True:", new GoodsPayChannelSerializer());
                    _tmp.Add(@"MiracleGames.Models.SimpleResult::root:True:", new SimpleResultSerializer());
                    _tmp.Add(@"MiracleGames.Models.MsPayInfo::microsoft:True:", new MsPayInfoSerializer());
                    _tmp.Add(@"MiracleGames.Models.ErrorInfo::Error:True:", new ErrorInfoSerializer());
                    _tmp.Add(@"MiracleGames.Models.CacheUserData::OAuth:True:", new CacheUserDataSerializer());
                    _tmp.Add(@"MiracleGames.Models.UseAssetResult::UseAsset:True:", new UseAssetResultSerializer());
                    _tmp.Add(@"MiracleGames.Models.AdUnit::AdUnit:True:", new AdUnitSerializer());
                    _tmp.Add(@"MiracleGames.Models.FormattedResult::root:True:", new FormattedResultSerializer());
                    _tmp.Add(@"MiracleGames.Models.CodeResult::Code:True:", new CodeResultSerializer());
                    _tmp.Add(@"MiracleGames.Models.NewAccountInfo::User:True:", new NewAccountInfoSerializer());
                    _tmp.Add(@"MiracleGames.Models.CertificationResult::root:True:", new CertificationResultSerializer());
                    _tmp.Add(@"MiracleGames.Models.UserInfo::User:True:", new UserInfoSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::MiracleGames.Models.AdUnit)) return true;
            if (type == typeof(global::MiracleGames.Models.FormattedResult)) return true;
            if (type == typeof(global::MiracleGames.Models.CertificationResult)) return true;
            if (type == typeof(global::MiracleGames.Models.GoodsPayChannel)) return true;
            if (type == typeof(global::MiracleGames.Models.AssetsList)) return true;
            if (type == typeof(global::MiracleGames.Models.UseAssetResult)) return true;
            if (type == typeof(global::MiracleGames.Models.MsPayInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.UserInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.SimpleResult)) return true;
            if (type == typeof(global::MiracleGames.Models.CodeResult)) return true;
            if (type == typeof(global::MiracleGames.Models.NewAccountInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.BindingInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.AppInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.ErrorInfo)) return true;
            if (type == typeof(global::MiracleGames.Models.CacheUserData)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::MiracleGames.Models.AdUnit)) return new AdUnitSerializer();
            if (type == typeof(global::MiracleGames.Models.FormattedResult)) return new FormattedResultSerializer();
            if (type == typeof(global::MiracleGames.Models.CertificationResult)) return new CertificationResultSerializer();
            if (type == typeof(global::MiracleGames.Models.GoodsPayChannel)) return new GoodsPayChannelSerializer();
            if (type == typeof(global::MiracleGames.Models.AssetsList)) return new AssetsListSerializer();
            if (type == typeof(global::MiracleGames.Models.UseAssetResult)) return new UseAssetResultSerializer();
            if (type == typeof(global::MiracleGames.Models.MsPayInfo)) return new MsPayInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.UserInfo)) return new UserInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.SimpleResult)) return new SimpleResultSerializer();
            if (type == typeof(global::MiracleGames.Models.CodeResult)) return new CodeResultSerializer();
            if (type == typeof(global::MiracleGames.Models.NewAccountInfo)) return new NewAccountInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.BindingInfo)) return new BindingInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.AppInfo)) return new AppInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.ErrorInfo)) return new ErrorInfoSerializer();
            if (type == typeof(global::MiracleGames.Models.CacheUserData)) return new CacheUserDataSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
