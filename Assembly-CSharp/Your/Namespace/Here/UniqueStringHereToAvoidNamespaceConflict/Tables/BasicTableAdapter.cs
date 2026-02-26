using System;
using System.Collections;
using Com.TheFallenGames.OSA.CustomAdapters.TableView;
using Com.TheFallenGames.OSA.CustomAdapters.TableView.Basic;
using Il2CppDummyDll;

namespace Your.Namespace.Here.UniqueStringHereToAvoidNamespaceConflicts.Tables
{
	// Token: 0x02000083 RID: 131
	[Token(Token = "0x2000083")]
	public class BasicTableAdapter : TableAdapter<TableParams, TupleViewsHolder, TupleViewsHolder>
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x57DF", Offset = "0x57DF", VA = "0x57DF", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__Start
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a62863 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTableWithCurrentData__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__get_Columns__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__set_Columns__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__set_Tuples__
		              );
		    DAT_ram_00a62863 = '\x01';
		  }
		  uVar1 = Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadBufferedDataAsync
		                    (param1,param1);
		  *(undefined4 *)(param1 + 0xa0) = uVar1;
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple___TypeInfo,500);
		  Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine
		            (param1,uVar1,0,500,param1);
		  param2_00 = *(undefined4 *)(param1 + 0xa0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableData_TypeInfo
		                        );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableData__get_ColumnClearingSupported
		            (param1_00,param2_00,uVar1,1,0);
		  *(undefined4 *)(param1 + 0xa4) = param1_00;
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_object__object__object___ResetTable
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTableWithCurrentData__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x57E0", Offset = "0x57E0", VA = "0x57E0")]
		public void LoadDataSync()
		{
		/* --- GHIDRA: LoadDataSync ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadDataSync
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a62864 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter_ReadRandomTuples__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTable__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__get_Columns__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData_TuplesChunkReader_TypeInfo
		              );
		    DAT_ram_00a62864 = '\x01';
		  }
		  param2_00 = Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadBufferedDataAsync
		                        (param1,param1);
		  param2_01 = *(undefined4 *)(param1 + 0xa0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData_TuplesChunkReader_TypeInfo
		                        );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData__ReverseTuplesListIfSupported
		            (param1_00,param1,
		             Method_Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter_ReadRandomTuples__
		             ,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData_TypeInfo
		                        );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_BufferredTableData__get_ColumnClearingSupported
		            (param1_01,param2_01,0x7ffffffe,param1_00,0x14,0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_object__object__object___RemoveItems
		            (param1,param2_00,param1_01,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTable__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x57E1", Offset = "0x57E1", VA = "0x57E1")]
		public void LoadBufferedDataSync()
		{
		/* --- GHIDRA: LoadBufferedDataSync ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadBufferedDataSync
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a62865 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData_BasicTuple___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData_BasicTuple__get_Columns__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData_BasicTuple__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple__BeginListeningForSelfDisposal__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter_ReadDataFromServerInto__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_AsyncBufferredDataSource_Loader_BasicTuple__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTable__
		              );
		    DAT_ram_00a62865 = '\x01';
		  }
		  uVar1 = Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadBufferedDataAsync
		                    (param1,param1);
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_AsyncBufferredDataSource_Loader_BasicTuple__TypeInfo
		                        );
		  System_Data_Listeners_object___get_HasListeners
		            (param1_00,param1,
		             Method_Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter_ReadDataFromServerInto__
		             ,0);
		  param1_01 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData_BasicTuple__TypeInfo
		                        );
		  Com_TheFallenGames_OSA_DataHelpers_AsyncBufferredDataSource___Il2CppFullySharedGenericType___set_ShowLogs
		            (param1_01,uVar1,0x7ffffffe,500,param1_00,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData_BasicTuple___ctor__
		            );
		  uVar1 = unnamed_function_1417
		                    (
		                    Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple__TypeInfo
		                    );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncBufferredTableData___Il2CppFullySharedGenericType___set_Columns
		            (uVar1,param1,param1_01,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple___ctor__
		            );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_object__object__object___RemoveItems
		            (param1,*(undefined4 *)(param1_01 + 8),param1_01,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__ResetTable__
		            );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_object____ctor
		            (uVar1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_Extra_AsyncLoadingUIController_BasicTuple__BeginListeningForSelfDisposal__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x57E2", Offset = "0x57E2", VA = "0x57E2")]
		public void LoadBufferedDataAsync()
		{
		/* --- GHIDRA: LoadBufferedDataAsync ---
		undefined4
		Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__LoadBufferedDataAsync
		          (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  undefined4 param1_01;
		  uint uVar3;
		  undefined4 param3;
		  int local_4;
		  
		  if (DAT_ram_00a62866 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicColumnInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableColumns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BasicColumnInfo__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BasicColumnInfo___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BasicColumnInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5532);
		    DAT_ram_00a62866 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BasicColumnInfo__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BasicColumnInfo___ctor__);
		  local_4 = 0;
		  do {
		    iVar1 = local_4;
		    uVar2 = func_ii_4443(&local_4,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_5532,uVar2,0);
		    param1_01 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicColumnInfo_TypeInfo
		                          );
		    param3 = 7;
		    if (iVar1 % 3 != 1) {
		      param3 = 1;
		    }
		    if (iVar1 % 3 == 0) {
		      param3 = 2;
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicColumnInfo__set_EnumValueType
		              (param1_01,uVar2,param3,0,0);
		    iVar1 = Method_System_Collections_Generic_List_BasicColumnInfo__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param1_01;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,param1_01,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                );
		    }
		    local_4 = local_4 + 1;
		  } while (local_4 < 0x19);
		  uVar2 = unnamed_function_1417
		                    (
		                    Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableColumns_TypeInfo
		                    );
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Basic_BasicTableColumns___ctor(uVar2,param1_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x57E3", Offset = "0x57E3", VA = "0x57E3")]
		private ITableColumns RetrieveColumns()
		{
		/* --- GHIDRA: RetrieveColumns ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__RetrieveColumns
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a62867 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine_d__7_TypeInfo
		              );
		    DAT_ram_00a62867 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine_d__7_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0x18) = param2;
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  *(undefined4 *)(param2_00 + 0x20) = param5;
		  *(undefined4 *)(param2_00 + 0x1c) = param4;
		  *(undefined4 *)(param2_00 + 0x14) = param3;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x57E4", Offset = "0x57E4", VA = "0x57E4")]
		private void ReadDataFromServerInto(BasicTuple[] into, int firstItemIndex, int countToRead, Action onDone)
		{
		/* --- GHIDRA: ReadDataFromServerInto ---
		int Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__ReadDataFromServerInto
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		              undefined4 param5,undefined4 param6)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62867 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine_d__7_TypeInfo
		              );
		    DAT_ram_00a62867 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine_d__7_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x18) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x20) = param5;
		  *(undefined4 *)(iVar1 + 0x1c) = param4;
		  *(undefined4 *)(iVar1 + 0x14) = param3;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x57E5", Offset = "0x57E5", VA = "0x57E5")]
		private IEnumerator SimulateReadDataFromServerIntoExistingTuples_Coroutine(BasicTuple[] into, int firstItemIndex, int countToRead, Action onDone)
		{
		/* --- GHIDRA: SimulateReadDataFromServerIntoExistingTuples_Coroutine ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__SimulateReadDataFromServerIntoExistingTuples_Coroutine
		               (int param1,int *param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *param3_00;
		  undefined4 param1_00;
		  int iVar3;
		  undefined8 uVar4;
		  int *param1_01;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a62868 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Random_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder__get_Columns__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableViewUtil_CreateTupleWithEmptyValues_BasicTuple___
		              );
		    DAT_ram_00a62868 = '\x01';
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  local_8 = ICSharpCode_SharpZipLib_Zip_ZipEntry___ctor(0);
		  uVar4 = func_ii_16164(&local_8,0);
		  uVar2 = unnamed_function_1417(System_Random_TypeInfo);
		  func_ii_15844(uVar2,(int)uVar4,0);
		  if (0 < param4) {
		    param1_01 = *(int **)(param1 + 0xa0);
		    do {
		      iVar6 = *param1_01;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo == *piVar7) {
		            param3_00 = (uint *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x820fa80e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      param3_00 = (uint *)func_ii_1080(param1_01,
		                                       Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo
		                                       ,0);
		code_r0x820fa80e:
		      param1_00 = (**(code **)((ulonglong)*param3_00 * 4))(param1_01,param3_00[1]);
		      iVar6 = UI_Tabs_TabBar__GetSelectedItem___Il2CppFullySharedGenericType_
		                        (param1_00,
		                         Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableViewUtil_CreateTupleWithEmptyValues_BasicTuple___
		                        );
		      Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__ReadRandomTuples
		                (param1,param1_01,param3_00,iVar6,uVar2,iVar6);
		      if ((iVar6 != 0) && (iVar3 = func_ii_1082(iVar6,*(undefined4 *)(*param2 + 0x20)), iVar3 == 0))
		      {
		        uVar2 = func_ii_1083();
		        func_ii_1050(uVar2,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2[iVar5 + 4] = iVar6;
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != param4);
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x57E6", Offset = "0x57E6", VA = "0x57E6")]
		private void ReadRandomTuples(ITuple[] into, int firstItemIndex, int numTuples)
		{
		/* --- GHIDRA: ReadRandomTuples ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__ReadRandomTuples
		               (int param1,int *param2,undefined4 param3,int *param4,int *param5,undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  uint uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int *piVar9;
		  undefined1 local_5;
		  uint local_4;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a62869 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnState_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a62869 = '\x01';
		  }
		  do {
		    iVar8 = *param2;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar4 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8);
		        if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo == *piVar5) {
		          puVar3 = (uint *)(iVar8 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x820fa931;
		        }
		        uVar4 = uVar4 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,
		                                  Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo
		                                  ,0);
		code_r0x820fa931:
		    iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    if (iVar8 <= iVar7) {
		      return;
		    }
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param5 + 0xe8) * 4))
		                      (param5,*(undefined4 *)(*param5 + 0xec));
		    if ((int)uVar4 % 10 == 0) {
		      iVar8 = *param4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo == *piVar5) {
		            puVar3 = (uint *)(piVar5[1] * 8 + iVar8 + 0xd0);
		            uVar2 = 0;
		            goto code_r0x820fac48;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		      }
		      uVar2 = 0;
		      puVar3 = (uint *)func_ii_1080(param4,
		                                    Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo,
		                                    2);
		    }
		    else {
		      iVar8 = *param2;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo == *piVar5) {
		            puVar3 = (uint *)(piVar5[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x820faa45;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param2,
		                                    Com_TheFallenGames_OSA_CustomAdapters_TableView_ITableColumns_TypeInfo
		                                    ,2);
		code_r0x820faa45:
		      piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,iVar7,puVar3[1]);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnState_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(iVar8 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x820faabf;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,
		                                    Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnState_TypeInfo
		                                    ,0);
		code_r0x820faabf:
		      piVar5 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      iVar8 = *piVar5;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnInfo_TypeInfo == *piVar9) {
		            puVar3 = (uint *)(piVar9[1] * 8 + iVar8 + 0xe0);
		            goto code_r0x820fab37;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,
		                                    Com_TheFallenGames_OSA_CustomAdapters_TableView_IColumnInfo_TypeInfo
		                                    ,4);
		code_r0x820fab37:
		      uVar2 = 0;
		      iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      if (iVar8 == 1) {
		        iVar8 = *(int *)(param1 + 0xd8);
		        if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		          func_ii_306000(System_Math_TypeInfo);
		        }
		        iVar6 = UnityEngine_Mathf__Max(0,uVar4,0);
		        uVar2 = *(undefined4 *)
		                 (iVar8 + (iVar6 % *(int *)(*(int *)(param1 + 0xd8) + 0xc)) * 4 + 0x10);
		      }
		      else if (iVar8 == 2) {
		        local_4 = uVar4;
		        uVar2 = func_ii_1081(DAT_ram_00a66954,&local_4);
		      }
		      else if ((((iVar8 != 3) && (iVar8 != 4)) && (iVar8 != 5)) && ((iVar8 != 6 && (iVar8 == 7)))) {
		        local_5 = (uVar4 & 1) == 0;
		        uVar2 = func_ii_1081(DAT_ram_00a66944,&local_5);
		      }
		      iVar8 = *param4;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar4 = 0;
		        do {
		          piVar5 = (int *)(*(int *)(iVar8 + 0x58) + uVar4 * 8);
		          if (Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo == *piVar5) {
		            puVar3 = (uint *)(piVar5[1] * 8 + iVar8 + 0xd0);
		            goto code_r0x820fac48;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar4);
		      }
		      puVar3 = (uint *)func_ii_1080(param4,
		                                    Com_TheFallenGames_OSA_CustomAdapters_TableView_ITuple_TypeInfo,
		                                    2);
		    }
		code_r0x820fac48:
		    (**(code **)((ulonglong)*puVar3 * 4))(param4,iVar7,uVar2,puVar3[1]);
		    iVar7 = iVar7 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x57E7", Offset = "0x57E7", VA = "0x57E7")]
		private void ReadRandomValueIntoTuple(ITableColumns columnsModel, int itemIndex, ITuple tuple, Random random)
		{
		/* --- GHIDRA: ReadRandomValueIntoTuple ---
		void Your_Namespace_Here_UniqueStringHereToAvoidNamespaceConflicts_Tables_BasicTableAdapter__ReadRandomValueIntoTuple
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a6286a == '\0') {
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_19809);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10662);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24594);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10663);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22758);
		    DAT_ram_00a6286a = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,5);
		  *(undefined4 *)(iVar1 + 0x10) = StringLiteral_10663;
		  *(undefined4 *)(iVar1 + 0x14) = StringLiteral_22758;
		  *(undefined4 *)(iVar1 + 0x18) = StringLiteral_24594;
		  *(undefined4 *)(iVar1 + 0x1c) = StringLiteral_19809;
		  *(undefined4 *)(iVar1 + 0x20) = StringLiteral_10662;
		  *(int *)(param1 + 0xd8) = iVar1;
		  UI_Tabs_TabBarItemData___Il2CppFullySharedGenericType___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_TableView_TableAdapter_TableParams__TupleViewsHolder__TupleViewsHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x57E8", Offset = "0x57E8", VA = "0x57E8")]
		public BasicTableAdapter()
		{
		}

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xD8")]
		private string[] _RandomStrings;
	}
}
