using UnrealSharp;
using Object = UnrealSharp.UEObject;
using Guid = SDK.Script.CoreUObjectSDK.Guid;
using Enum = SDK.Script.CoreUObjectSDK.Enum;
using DateTime = SDK.Script.CoreUObjectSDK.DateTime;
using SDK.Script.EngineSDK;
using SDK.Script.CoreUObjectSDK;
namespace SDK.Script.JsonCsvToDataTableToStructSDK
{
    public class JsonCsvToDataTableToStructBPLibrary : BlueprintFunctionLibrary
    {
        public JsonCsvToDataTableToStructBPLibrary(nint addr) : base(addr) { }
        public bool WriteDataTableToJson(DataTable InDataTable, Object ExportedText) { return Invoke<bool>(nameof(WriteDataTableToJson), InDataTable, ExportedText); }
        public bool WriteDataTableToCsv(DataTable InDataTable, Object ExportedText) { return Invoke<bool>(nameof(WriteDataTableToCsv), InDataTable, ExportedText); }
        public Object UrlEncode(Object UnencodedString) { return Invoke<Object>(nameof(UrlEncode), UnencodedString); }
        public bool StructToJsonObjectStringV2(Object OutJsonString, Struct Struct) { return Invoke<bool>(nameof(StructToJsonObjectStringV2), OutJsonString, Struct); }
        public bool StructToJsonObjectString(Object OutJsonString, ScriptStruct Struct) { return Invoke<bool>(nameof(StructToJsonObjectString), OutJsonString, Struct); }
        public bool StructArrayToJsonObjectStringV2(Object OutJsonString, Array<ScriptStruct> StructArray) { return Invoke<bool>(nameof(StructArrayToJsonObjectStringV2), OutJsonString, StructArray); }
        public bool StructArrayToJsonObjectString(Object OutJsonString, Array<ScriptStruct> StructArray) { return Invoke<bool>(nameof(StructArrayToJsonObjectString), OutJsonString, StructArray); }
        public bool SaveStringToFile(Object FileAbsolutePath, Object Content, EEncodingOptions EncodingOptions) { return Invoke<bool>(nameof(SaveStringToFile), FileAbsolutePath, Content, EncodingOptions); }
        public bool RemoveDataTableRow(DataTable InDataTable, Object RowName) { return Invoke<bool>(nameof(RemoveDataTableRow), InDataTable, RowName); }
        public DataTable ReadJsonToDataTable(Object InData, ScriptStruct TableType) { return Invoke<DataTable>(nameof(ReadJsonToDataTable), InData, TableType); }
        public DataTable ReadCsvToDataTable(Object InData, ScriptStruct TableType) { return Invoke<DataTable>(nameof(ReadCsvToDataTable), InData, TableType); }
        public Object PasteMessageFromClipboard() { return Invoke<Object>(nameof(PasteMessageFromClipboard)); }
        public bool LoadFileToString(Object FileAbsolutePath, Object Content) { return Invoke<bool>(nameof(LoadFileToString), FileAbsolutePath, Content); }
        public bool JsonStringToStructV2(Object InJsonString, Struct Struct) { return Invoke<bool>(nameof(JsonStringToStructV2), InJsonString, Struct); }
        public bool JsonStringToStructArrayV2(Object InJsonString, Array<ScriptStruct> StructArray) { return Invoke<bool>(nameof(JsonStringToStructArrayV2), InJsonString, StructArray); }
        public bool JsonStringToStructArray(Object InJsonString, Array<TableRowBase> OutRows) { return Invoke<bool>(nameof(JsonStringToStructArray), InJsonString, OutRows); }
        public bool JsonStringToStruct(Object InJsonString, TableRowBase OutRow) { return Invoke<bool>(nameof(JsonStringToStruct), InJsonString, OutRow); }
        public bool GetDataTableFirstRow(DataTable InDataTable, TableRowBase OutRow) { return Invoke<bool>(nameof(GetDataTableFirstRow), InDataTable, OutRow); }
        public DataTable CreateDataTable(Object InDataTableName, ScriptStruct TableType) { return Invoke<DataTable>(nameof(CreateDataTable), InDataTableName, TableType); }
        public void CopyMessageToClipboard(Object Text) { Invoke(nameof(CopyMessageToClipboard), Text); }
        public bool ClearDataTable(DataTable InDataTable) { return Invoke<bool>(nameof(ClearDataTable), InDataTable); }
        public bool AddDataTableRow(DataTable InDataTable, Object RowName, TableRowBase OutRow) { return Invoke<bool>(nameof(AddDataTableRow), InDataTable, RowName, OutRow); }
    }
    public enum EEncodingOptions : int
    {
        AutoDetect = 0,
        ForceAnsi = 1,
        ForceUnicode = 2,
        ForceUTF8 = 3,
        ForceUTF8WithoutBOM = 4,
        EEncodingOptions_MAX = 5,
    }
}
