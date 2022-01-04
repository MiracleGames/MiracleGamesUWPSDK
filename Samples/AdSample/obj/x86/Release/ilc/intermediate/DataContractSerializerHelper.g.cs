using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
            global::System.Collections.Generic.Dictionary<global::System.Runtime.Serialization.DataContract, global::System.Runtime.Serialization.Json.JsonReadWriteDelegates> jsonDelegates = global::System.Runtime.Serialization.Json.JsonReadWriteDelegates.GetJsonDelegates();
            PopulateJsonDelegateDictionary(
                                dataContracts, 
                                jsonDelegates
                            );
        }
        static int[] s_knownContractsLists = new int[] {
              -1, }
        ;
        // Count = 381
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1299, // index: 1299, string: "Comment"
                1307, // index: 1307, string: "Goods"
                1313, // index: 1313, string: "Id"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                6, // array length: 6
                1316, // index: 1316, string: "Count"
                1322, // index: 1322, string: "Name"
                1327, // index: 1327, string: "Price"
                1333, // index: 1333, string: "ProductId"
                1343, // index: 1343, string: "Tag"
                1347, // index: 1347, string: "TransactionId"
                6, // array length: 6
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                384, // index: 384, string: "http://schemas.datacontract.org/2004/07/System"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                1361, // index: 1361, string: "app_key"
                1369, // index: 1369, string: "client_id"
                1379, // index: 1379, string: "create_time"
                1391, // index: 1391, string: "customer_key"
                1404, // index: 1404, string: "id"
                1407, // index: 1407, string: "status"
                1414, // index: 1414, string: "token"
                7, // array length: 7
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                384, // index: 384, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                1420, // index: 1420, string: "DateTime"
                1429, // index: 1429, string: "OffsetMinutes"
                2, // array length: 2
                384, // index: 384, string: "http://schemas.datacontract.org/2004/07/System"
                384, // index: 384, string: "http://schemas.datacontract.org/2004/07/System"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1443, // index: 1443, string: "code"
                1448, // index: 1448, string: "data"
                1453, // index: 1453, string: "message"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                1461, // index: 1461, string: "holidays_flag"
                1475, // index: 1475, string: "timestamp"
                2, // array length: 2
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1443, // index: 1443, string: "code"
                1448, // index: 1448, string: "data"
                1453, // index: 1453, string: "message"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1443, // index: 1443, string: "code"
                1448, // index: 1448, string: "data"
                1453, // index: 1453, string: "message"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                1485, // index: 1485, string: "Height"
                1492, // index: 1492, string: "Width"
                1498, // index: 1498, string: "icon"
                1404, // index: 1404, string: "id"
                1503, // index: 1503, string: "name"
                1508, // index: 1508, string: "sort"
                1513, // index: 1513, string: "used"
                7, // array length: 7
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                562, // index: 562, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                643, // index: 643, string: "Key"
                647, // index: 647, string: "Value"
                2, // array length: 2
                562, // index: 562, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                562, // index: 562, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                680, // index: 680, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1518, // index: 1518, string: "key"
                1522, // index: 1522, string: "value"
                2, // array length: 2
                680, // index: 680, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                680, // index: 680, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                9, // array length: 9
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                9, // array length: 9
                1528, // index: 1528, string: "Account"
                1536, // index: 1536, string: "AccountFull"
                1548, // index: 1548, string: "BindEmail"
                1558, // index: 1558, string: "BindPhone"
                1313, // index: 1313, string: "Id"
                1568, // index: 1568, string: "InitPwd"
                1576, // index: 1576, string: "PasswordProtected"
                1594, // index: 1594, string: "Result"
                1601, // index: 1601, string: "Token"
                9, // array length: 9
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1607, // index: 1607, string: "date"
                1612, // index: 1612, string: "total_time"
                1623, // index: 1623, string: "user_id"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                2, // array length: 2
                1631, // index: 1631, string: "CommandType"
                1643, // index: 1643, string: "Payload"
                2, // array length: 2
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                5, // array length: 5
                1651, // index: 1651, string: "CallbackId"
                1299, // index: 1299, string: "Comment"
                1662, // index: 1662, string: "DigitalGoodsKey"
                1678, // index: 1678, string: "OnlyMS"
                1685, // index: 1685, string: "PlayerLevel"
                5, // array length: 5
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                826, // index: 826, string: "AdType"
                1697, // index: 1697, string: "AdUnit"
                1704, // index: 1704, string: "ContinueLogin"
                1718, // index: 1718, string: "CoupletMode"
                1730, // index: 1730, string: "DisplayCloseBtn"
                950, // index: 950, string: "HorizontalAlignment"
                1052, // index: 1052, string: "VerticalAlignment"
                7, // array length: 7
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                6, // array length: 6
                833, // index: 833, string: "Interstitial"
                846, // index: 846, string: "Banner"
                853, // index: 853, string: "Couplet"
                861, // index: 861, string: "FullScreenInterstitial"
                884, // index: 884, string: "FullScreen"
                895, // index: 895, string: "ExistScreen"
                3, // array length: 3
                926, // index: 926, string: "Both"
                931, // index: 931, string: "LeftOnly"
                940, // index: 940, string: "RightOnly"
                4, // array length: 4
                1026, // index: 1026, string: "Left"
                1031, // index: 1031, string: "Center"
                1038, // index: 1038, string: "Right"
                1044, // index: 1044, string: "Stretch"
                4, // array length: 4
                1070, // index: 1070, string: "Top"
                1031, // index: 1031, string: "Center"
                1074, // index: 1074, string: "Bottom"
                1044, // index: 1044, string: "Stretch"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                3, // array length: 3
                1746, // index: 1746, string: "AdCode"
                1485, // index: 1485, string: "Height"
                1492, // index: 1492, string: "Width"
                3, // array length: 3
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                4, // array length: 4
                1753, // index: 1753, string: "AdClient"
                1762, // index: 1762, string: "AdSenseUrl"
                1773, // index: 1773, string: "AdSlot"
                1780, // index: 1780, string: "Type"
                4, // array length: 4
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                4, // array length: 4
                846, // index: 846, string: "Banner"
                1144, // index: 1144, string: "Table"
                1150, // index: 1150, string: "CoupletLeft"
                1162, // index: 1162, string: "CoupletRight"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                4, // array length: 4
                1785, // index: 1785, string: "Content"
                1793, // index: 1793, string: "ImageUrl"
                1802, // index: 1802, string: "LinkUrl"
                1810, // index: 1810, string: "Title"
                4, // array length: 4
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                5, // array length: 5
                826, // index: 826, string: "AdType"
                1816, // index: 1816, string: "AdUnitId"
                1825, // index: 1825, string: "ChannelId"
                1835, // index: 1835, string: "IsTest"
                1343, // index: 1343, string: "Tag"
                5, // array length: 5
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                273, // index: 273, string: "http://schemas.datacontract.org/2004/07/MiracleGames.Models"
                7, // array length: 7
                1237, // index: 1237, string: "Default"
                1245, // index: 1245, string: "PreRoll"
                1253, // index: 1253, string: "Start"
                1259, // index: 1259, string: "Pause"
                1265, // index: 1265, string: "Next"
                1270, // index: 1270, string: "Browse"
                1277  // index: 1277, string: "Reward"
        };
        // Count = 28
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 833, // Interstitial
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 846, // Banner
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 853, // Couplet
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 861, // FullScreenInterstitial
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 884, // FullScreen
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 895, // ExistScreen
                    Value = 6,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 926, // Both
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 931, // LeftOnly
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 940, // RightOnly
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1026, // Left
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1031, // Center
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1038, // Right
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1044, // Stretch
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1070, // Top
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1031, // Center
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1074, // Bottom
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1044, // Stretch
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 846, // Banner
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1144, // Table
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1150, // CoupletLeft
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1162, // CoupletRight
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1237, // Default
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1245, // PreRoll
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1253, // Start
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1259, // Pause
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1265, // Next
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1270, // Browse
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1277, // Reward
                    Value = 6,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=77
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutr" +
                                "al, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                "50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.DigitalGoods, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ShareResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTimeInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTime, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommonResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.InitLanguageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Cultu" +
                                "re=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                                "f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                                "0a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommandObject, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.PayCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[MiracleGames.Models.AdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nu" +
                                "ll]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CoupletDisplayMode, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[MiracleGames.Models.CoupletDisplayMode, MiracleGames, Version=1.0.0.0, Culture=neutral, Publi" +
                                "cKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                                "34e089")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934" +
                                "e089")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleGameAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 67, // 0x43
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[MiracleGames.Models.GoogleContentAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 67, // 0x43
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SharingCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                "l")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 83, // 0x53
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[MiracleGames.Models.UniversalGoogleAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 83, // 0x53
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=20
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 333, // AssetsInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 333, // AssetsInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 333, // AssetsInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 5,
                    MemberNamesListIndex = 7,
                    MemberNamespacesListIndex = 11,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 344, // DigitalGoods
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 344, // DigitalGoods
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 344, // DigitalGoods
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.DigitalGoods, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.DigitalGoods, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    ChildElementNamespacesListIndex = 15,
                    ContractNamespacesListIndex = 22,
                    MemberNamesListIndex = 24,
                    MemberNamespacesListIndex = 31,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 357, // ShareResult
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 357, // ShareResult
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 357, // ShareResult
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ShareResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ShareResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 38,
                    ContractNamespacesListIndex = 46,
                    MemberNamesListIndex = 48,
                    MemberNamespacesListIndex = 56,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 369, // DateTimeOffset
                        NamespaceIndex = 384, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 369, // DateTimeOffset
                        StableNameNamespaceIndex = 384, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 369, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 384, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.1.1, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 64,
                    ContractNamespacesListIndex = 67,
                    MemberNamesListIndex = 69,
                    MemberNamespacesListIndex = 72,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 431, // SystemTimeInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 431, // SystemTimeInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 431, // SystemTimeInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTimeInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTimeInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 75,
                    ContractNamespacesListIndex = 79,
                    MemberNamesListIndex = 81,
                    MemberNamespacesListIndex = 85,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 446, // SystemTime
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 446, // SystemTime
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 446, // SystemTime
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTime, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SystemTime, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 89,
                    ContractNamespacesListIndex = 92,
                    MemberNamesListIndex = 94,
                    MemberNamespacesListIndex = 97,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 457, // CommonResult
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 457, // CommonResult
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 457, // CommonResult
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommonResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommonResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 100,
                    ContractNamespacesListIndex = 104,
                    MemberNamesListIndex = 106,
                    MemberNamespacesListIndex = 110,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 470, // InitLanguageInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 470, // InitLanguageInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 470, // InitLanguageInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.InitLanguageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.InitLanguageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 114,
                    ContractNamespacesListIndex = 118,
                    MemberNamesListIndex = 120,
                    MemberNamespacesListIndex = 124,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 513, // ThirdLoginProvider
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 513, // ThirdLoginProvider
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 513, // ThirdLoginProvider
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 128,
                    ContractNamespacesListIndex = 136,
                    MemberNamesListIndex = 138,
                    MemberNamespacesListIndex = 146,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 620, // KeyValueOfstringstring
                        NamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 620, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 620, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 154,
                    ContractNamespacesListIndex = 157,
                    MemberNamesListIndex = 159,
                    MemberNamespacesListIndex = 162,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 653, // KeyValuePairOfstringstring
                        NamespaceIndex = 680, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 653, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 680, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 653, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 680, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    ChildElementNamespacesListIndex = 165,
                    ContractNamespacesListIndex = 168,
                    MemberNamesListIndex = 170,
                    MemberNamespacesListIndex = 173,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 747, // ThirdLoginResult
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 747, // ThirdLoginResult
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 747, // ThirdLoginResult
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginResult, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 176,
                    ContractNamespacesListIndex = 186,
                    MemberNamesListIndex = 188,
                    MemberNamespacesListIndex = 198,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 781, // UsageInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 781, // UsageInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 781, // UsageInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 208,
                    ContractNamespacesListIndex = 212,
                    MemberNamesListIndex = 214,
                    MemberNamespacesListIndex = 218,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 791, // CommandObject
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 791, // CommandObject
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 791, // CommandObject
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommandObject, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CommandObject, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 222,
                    ContractNamespacesListIndex = 225,
                    MemberNamesListIndex = 227,
                    MemberNamespacesListIndex = 230,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 805, // PayCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 805, // PayCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 805, // PayCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.PayCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.PayCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 233,
                    ContractNamespacesListIndex = 239,
                    MemberNamesListIndex = 241,
                    MemberNamespacesListIndex = 247,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 816, // AdCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 816, // AdCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 816, // AdCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 253,
                    ContractNamespacesListIndex = 261,
                    MemberNamesListIndex = 263,
                    MemberNamespacesListIndex = 271,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1081, // GoogleGameAdCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1081, // GoogleGameAdCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1081, // GoogleGameAdCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleGameAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleGameAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 300,
                    ContractNamespacesListIndex = 304,
                    MemberNamesListIndex = 306,
                    MemberNamespacesListIndex = 310,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1101, // GoogleContentAdCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1101, // GoogleContentAdCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1101, // GoogleContentAdCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 314,
                    ContractNamespacesListIndex = 319,
                    MemberNamesListIndex = 321,
                    MemberNamespacesListIndex = 326,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1175, // SharingCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1175, // SharingCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1175, // SharingCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SharingCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.SharingCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 336,
                    ContractNamespacesListIndex = 341,
                    MemberNamesListIndex = 343,
                    MemberNamespacesListIndex = 348,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1190, // UniversalGoogleAdCommand
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1190, // UniversalGoogleAdCommand
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1190, // UniversalGoogleAdCommand
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdCommand, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nul" +
                                    "l")),
                    },
                    HasDataContract = true,
                    ChildElementNamespacesListIndex = 353,
                    ContractNamespacesListIndex = 359,
                    MemberNamesListIndex = 361,
                    MemberNamespacesListIndex = 367,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=5
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 255, // ArrayOfAssetsInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 255, // ArrayOfAssetsInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 255, // ArrayOfAssetsInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutr" +
                                    "al, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 333, // AssetsInfo
                    KeyNameIndex = -1,
                    ItemNameIndex = 333, // AssetsInfo
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AssetsInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 487, // ArrayOfThirdLoginProvider
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 487, // ArrayOfThirdLoginProvider
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 487, // ArrayOfThirdLoginProvider
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Cultu" +
                                    "re=neutral, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.0.20.0, Culture=neutral, PublicKeyToken=b03f5f7f11" +
                                    "d50a3a")),
                    },
                    CollectionItemNameIndex = 513, // ThirdLoginProvider
                    KeyNameIndex = -1,
                    ItemNameIndex = 513, // ThirdLoginProvider
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.ThirdLoginProvider, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 532, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 532, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 532, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b" +
                                    "03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 620, // KeyValueOfstringstring
                    KeyNameIndex = 643, // Key
                    ItemNameIndex = 620, // KeyValueOfstringstring
                    ValueNameIndex = 647, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.1.1, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 764, // ArrayOfUsageInfo
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 764, // ArrayOfUsageInfo
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 764, // ArrayOfUsageInfo
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                                    "0a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1[[MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=null]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d5" +
                                    "0a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03" +
                                    "f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 781, // UsageInfo
                    KeyNameIndex = -1,
                    ItemNameIndex = 781, // UsageInfo
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UsageInfo, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1284, // ArrayOfanyType
                        NamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1284, // ArrayOfanyType
                        StableNameNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1284, // ArrayOfanyType
                        TopLevelElementNamespaceIndex = 562, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    CollectionItemNameIndex = 155, // anyType
                    KeyNameIndex = -1,
                    ItemNameIndex = 155, // anyType
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=6
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 826, // AdType
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 826, // AdType
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 826, // AdType
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.AdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 279,
                    MemberCount = 6,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 907, // CoupletDisplayMode
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 907, // CoupletDisplayMode
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 907, // CoupletDisplayMode
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CoupletDisplayMode, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.CoupletDisplayMode, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 286,
                    MemberCount = 3,
                    MemberListIndex = 6,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 950, // HorizontalAlignment
                        NamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 950, // HorizontalAlignment
                        StableNameNamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 950, // HorizontalAlignment
                        TopLevelElementNamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 290,
                    MemberCount = 4,
                    MemberListIndex = 9,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1052, // VerticalAlignment
                        NamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 1052, // VerticalAlignment
                        StableNameNamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 1052, // VerticalAlignment
                        TopLevelElementNamespaceIndex = 970, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=3.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 295,
                    MemberCount = 4,
                    MemberListIndex = 13,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1124, // GoogleContentAdType
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1124, // GoogleContentAdType
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1124, // GoogleContentAdType
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.GoogleContentAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 331,
                    MemberCount = 4,
                    MemberListIndex = 17,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1215, // UniversalGoogleAdType
                        NamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        StableNameIndex = 1215, // UniversalGoogleAdType
                        StableNameNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        TopLevelElementNameIndex = 1215, // UniversalGoogleAdType
                        TopLevelElementNamespaceIndex = 273, // http://schemas.datacontract.org/2004/07/MiracleGames.Models
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("MiracleGames.Models.UniversalGoogleAdType, MiracleGames, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 373,
                    MemberCount = 7,
                    MemberListIndex = 21,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static readonly byte[] s_jsonDelegatesList_Hashtable = null;
        // Count=31
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::JsonDelegateEntry[] s_jsonDelegatesList = new global::JsonDelegateEntry[] {
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 37,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type4.WriteArrayOfAssetsInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type3.ReadArrayOfAssetsInfoFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type5.ReadArrayOfAssetsInfoFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 38,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type9.WriteAssetsInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type8.ReadAssetsInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 39,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type13.WriteDigitalGoodsToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type12.ReadDigitalGoodsFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 40,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type17.WriteShareResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type16.ReadShareResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 41,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type21.WriteDateTimeOffsetToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type20.ReadDateTimeOffsetFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 43,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type25.WriteSystemTimeInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type24.ReadSystemTimeInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 44,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type29.WriteSystemTimeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type28.ReadSystemTimeFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 45,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type33.WriteCommonResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type32.ReadCommonResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 46,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type37.WriteInitLanguageInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type36.ReadInitLanguageInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 47,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type42.WriteArrayOfThirdLoginProviderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type41.ReadArrayOfThirdLoginProviderFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type43.ReadArrayOfThirdLoginProviderFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 48,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type47.WriteThirdLoginProviderToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type46.ReadThirdLoginProviderFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 49,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type52.WriteArrayOfKeyValueOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type51.ReadArrayOfKeyValueOfstringstringFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type53.ReadArrayOfKeyValueOfstringstringFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 50,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type57.WriteKeyValueOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type56.ReadKeyValueOfstringstringFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 52,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type61.WriteKeyValuePairOfstringstringToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type60.ReadKeyValuePairOfstringstringFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 54,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type65.WriteThirdLoginResultToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type64.ReadThirdLoginResultFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 55,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type70.WriteArrayOfUsageInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type69.ReadArrayOfUsageInfoFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type71.ReadArrayOfUsageInfoFromJsonIsGetOnly),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 56,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type75.WriteUsageInfoToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type74.ReadUsageInfoFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 57,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type79.WriteCommandObjectToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type78.ReadCommandObjectFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 58,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type83.WritePayCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type82.ReadPayCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 59,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type87.WriteAdCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type86.ReadAdCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 60,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 62,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 64,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 66,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 68,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type91.WriteGoogleGameAdCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type90.ReadGoogleGameAdCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 69,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type95.WriteGoogleContentAdCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type94.ReadGoogleContentAdCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 70,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 72,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type99.WriteSharingCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type98.ReadSharingCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 73,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassWriterDelegate>(global::Type103.WriteUniversalGoogleAdCommandToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatClassReaderDelegate>(global::Type102.ReadUniversalGoogleAdCommandFromJson),
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 74,
                }, 
                new global::JsonDelegateEntry() {
                    DataContractMapIndex = 76,
                    IsCollection = true,
                    WriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionWriterDelegate>(global::Type108.WriteArrayOfanyTypeToJson),
                    ReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatCollectionReaderDelegate>(global::Type107.ReadArrayOfanyTypeFromJson),
                    GetOnlyReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.Json.JsonFormatGetOnlyCollectionReaderDelegate>(global::Type109.ReadArrayOfanyTypeFromJsonIsGetOnly),
                }
        };
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','A','r','r','a','y','O','f','A','s','s','e','t','s','I','n',
            'f','o','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t',
            '.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','r','a','c','l','e','G','a','m','e','s','.','M','o','d','e',
            'l','s','\0','A','s','s','e','t','s','I','n','f','o','\0','D','i','g','i','t','a','l','G','o','o','d','s','\0','S','h','a',
            'r','e','R','e','s','u','l','t','\0','D','a','t','e','T','i','m','e','O','f','f','s','e','t','\0','h','t','t','p',':','/',
            '/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4',
            '/','0','7','/','S','y','s','t','e','m','\0','S','y','s','t','e','m','T','i','m','e','I','n','f','o','\0','S','y','s','t',
            'e','m','T','i','m','e','\0','C','o','m','m','o','n','R','e','s','u','l','t','\0','I','n','i','t','L','a','n','g','u','a',
            'g','e','I','n','f','o','\0','A','r','r','a','y','O','f','T','h','i','r','d','L','o','g','i','n','P','r','o','v','i','d',
            'e','r','\0','T','h','i','r','d','L','o','g','i','n','P','r','o','v','i','d','e','r','\0','A','r','r','a','y','O','f','K',
            'e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s',
            'c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S',
            'e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','K','e','y','V','a','l','u','e','O','f',
            's','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','\0','V','a','l','u','e','\0','K','e','y','V','a','l','u',
            'e','P','a','i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','h','t','t','p',':','/','/','s','c','h',
            'e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/',
            'S','y','s','t','e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n','e','r','i','c','\0','T','h','i',
            'r','d','L','o','g','i','n','R','e','s','u','l','t','\0','A','r','r','a','y','O','f','U','s','a','g','e','I','n','f','o',
            '\0','U','s','a','g','e','I','n','f','o','\0','C','o','m','m','a','n','d','O','b','j','e','c','t','\0','P','a','y','C','o',
            'm','m','a','n','d','\0','A','d','C','o','m','m','a','n','d','\0','A','d','T','y','p','e','\0','I','n','t','e','r','s','t',
            'i','t','i','a','l','\0','B','a','n','n','e','r','\0','C','o','u','p','l','e','t','\0','F','u','l','l','S','c','r','e','e',
            'n','I','n','t','e','r','s','t','i','t','i','a','l','\0','F','u','l','l','S','c','r','e','e','n','\0','E','x','i','s','t',
            'S','c','r','e','e','n','\0','C','o','u','p','l','e','t','D','i','s','p','l','a','y','M','o','d','e','\0','B','o','t','h',
            '\0','L','e','f','t','O','n','l','y','\0','R','i','g','h','t','O','n','l','y','\0','H','o','r','i','z','o','n','t','a','l',
            'A','l','i','g','n','m','e','n','t','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c',
            'o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','W','i','n','d','o','w','s','.','U','I',
            '.','X','a','m','l','\0','L','e','f','t','\0','C','e','n','t','e','r','\0','R','i','g','h','t','\0','S','t','r','e','t','c',
            'h','\0','V','e','r','t','i','c','a','l','A','l','i','g','n','m','e','n','t','\0','T','o','p','\0','B','o','t','t','o','m',
            '\0','G','o','o','g','l','e','G','a','m','e','A','d','C','o','m','m','a','n','d','\0','G','o','o','g','l','e','C','o','n',
            't','e','n','t','A','d','C','o','m','m','a','n','d','\0','G','o','o','g','l','e','C','o','n','t','e','n','t','A','d','T',
            'y','p','e','\0','T','a','b','l','e','\0','C','o','u','p','l','e','t','L','e','f','t','\0','C','o','u','p','l','e','t','R',
            'i','g','h','t','\0','S','h','a','r','i','n','g','C','o','m','m','a','n','d','\0','U','n','i','v','e','r','s','a','l','G',
            'o','o','g','l','e','A','d','C','o','m','m','a','n','d','\0','U','n','i','v','e','r','s','a','l','G','o','o','g','l','e',
            'A','d','T','y','p','e','\0','D','e','f','a','u','l','t','\0','P','r','e','R','o','l','l','\0','S','t','a','r','t','\0','P',
            'a','u','s','e','\0','N','e','x','t','\0','B','r','o','w','s','e','\0','R','e','w','a','r','d','\0','A','r','r','a','y','O',
            'f','a','n','y','T','y','p','e','\0','C','o','m','m','e','n','t','\0','G','o','o','d','s','\0','I','d','\0','C','o','u','n',
            't','\0','N','a','m','e','\0','P','r','i','c','e','\0','P','r','o','d','u','c','t','I','d','\0','T','a','g','\0','T','r','a',
            'n','s','a','c','t','i','o','n','I','d','\0','a','p','p','_','k','e','y','\0','c','l','i','e','n','t','_','i','d','\0','c',
            'r','e','a','t','e','_','t','i','m','e','\0','c','u','s','t','o','m','e','r','_','k','e','y','\0','i','d','\0','s','t','a',
            't','u','s','\0','t','o','k','e','n','\0','D','a','t','e','T','i','m','e','\0','O','f','f','s','e','t','M','i','n','u','t',
            'e','s','\0','c','o','d','e','\0','d','a','t','a','\0','m','e','s','s','a','g','e','\0','h','o','l','i','d','a','y','s','_',
            'f','l','a','g','\0','t','i','m','e','s','t','a','m','p','\0','H','e','i','g','h','t','\0','W','i','d','t','h','\0','i','c',
            'o','n','\0','n','a','m','e','\0','s','o','r','t','\0','u','s','e','d','\0','k','e','y','\0','v','a','l','u','e','\0','A','c',
            'c','o','u','n','t','\0','A','c','c','o','u','n','t','F','u','l','l','\0','B','i','n','d','E','m','a','i','l','\0','B','i',
            'n','d','P','h','o','n','e','\0','I','n','i','t','P','w','d','\0','P','a','s','s','w','o','r','d','P','r','o','t','e','c',
            't','e','d','\0','R','e','s','u','l','t','\0','T','o','k','e','n','\0','d','a','t','e','\0','t','o','t','a','l','_','t','i',
            'm','e','\0','u','s','e','r','_','i','d','\0','C','o','m','m','a','n','d','T','y','p','e','\0','P','a','y','l','o','a','d',
            '\0','C','a','l','l','b','a','c','k','I','d','\0','D','i','g','i','t','a','l','G','o','o','d','s','K','e','y','\0','O','n',
            'l','y','M','S','\0','P','l','a','y','e','r','L','e','v','e','l','\0','A','d','U','n','i','t','\0','C','o','n','t','i','n',
            'u','e','L','o','g','i','n','\0','C','o','u','p','l','e','t','M','o','d','e','\0','D','i','s','p','l','a','y','C','l','o',
            's','e','B','t','n','\0','A','d','C','o','d','e','\0','A','d','C','l','i','e','n','t','\0','A','d','S','e','n','s','e','U',
            'r','l','\0','A','d','S','l','o','t','\0','T','y','p','e','\0','C','o','n','t','e','n','t','\0','I','m','a','g','e','U','r',
            'l','\0','L','i','n','k','U','r','l','\0','T','i','t','l','e','\0','A','d','U','n','i','t','I','d','\0','C','h','a','n','n',
            'e','l','I','d','\0','I','s','T','e','s','t','\0'};
    }
}
