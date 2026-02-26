using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Clans.Office.View.ClanWarsTab.ClanWarsHistoryTab;
using Il2CppDummyDll;
using MVC;
using Protocol.ClanWar;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model.ClanWars
{
	// Token: 0x02000A5B RID: 2651
	[Token(Token = "0x2000A5B")]
	public class ClanWarsHistoryModel : AbstractModel
	{
		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x8D82", Offset = "0x8D82", VA = "0x8D82")]
		public ClanWarsHistoryModel(UserData user, Dictionaries dict)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57fc8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Last_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Last_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___get_Count__
		              );
		    DAT_ram_00a57fc8 = '\x01';
		  }
		  if (*(int *)(*(int *)(param1 + 0x14) + 0xc) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (*(int *)(param1 + 0x14),
		                       Method_System_Linq_Enumerable_Last_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs____
		                      );
		    iVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                      (uVar2,
		                       Method_System_Linq_Enumerable_Last_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		                      );
		    uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0xc);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x17000C97")]
		public uint LastWarId
		{
			[Token(Token = "0x6003EC7")]
			[Address(RVA = "0x8D83", Offset = "0x8D83", VA = "0x8D83")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x8D84", Offset = "0x8D84", VA = "0x8D84")]
		public IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs> GetLastPage()
		{
		/* --- GHIDRA: GetLastPage ---
		void Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__GetLastPage
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param3_00;
		  int param3_01;
		  
		  if (DAT_ram_00a57fca == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___Clear__
		              );
		    DAT_ram_00a57fca = '\x01';
		  }
		  param3_00 = *(int *)(param1 + 0x14);
		  param3_01 = *(int *)(param3_00 + 0xc);
		  *(undefined4 *)(param3_00 + 0xc) = 0;
		  *(int *)(param3_00 + 0x10) = *(int *)(param3_00 + 0x10) + 1;
		  if (0 < param3_01) {
		    func_ii_2064(*(undefined4 *)(param3_00 + 8),0,param3_01,0);
		  }
		  Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__CreateHistoryList
		            (param1,param2,param3_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003EC9 RID: 16073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EC9")]
		[Address(RVA = "0x8D85", Offset = "0x8D85", VA = "0x8D85")]
		public void CreateHistoryList(IList<ProtoGetWarsHistoryAns.Types.WarHistoryRecord> history)
		{
		/* --- GHIDRA: CreateHistoryList ---
		void Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__CreateHistoryList
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a57fcb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel_ConstructArgs__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetWarsHistoryAns_Types_WarHistoryRecord__ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToArray_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Func_ProtoGetWarsHistoryAns_Types_WarHistoryRecord__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___get_Count__
		              );
		    DAT_ram_00a57fcb = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    System_Func_ProtoGetWarsHistoryAns_Types_WarHistoryRecord__ClanWarHistoryListElement_ClanWarHistoryListElementArgs__TypeInfo
		                    );
		  System_Linq_Enumerable__Where_object_
		            (uVar2,param1,
		             Method_Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel_ConstructArgs__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar2,
		                     Method_System_Linq_Enumerable_Select_ProtoGetWarsHistoryAns_Types_WarHistoryRecord__ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		                    );
		  uVar2 = func_ii_6295(uVar2,
		                       Method_System_Linq_Enumerable_ToArray_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___
		                      );
		  iVar1 = 
		  Method_System_Collections_Generic_List_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs___Add__
		  ;
		  param1_00 = *(int *)(param1 + 0x14);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ECA")]
		[Address(RVA = "0x8D86", Offset = "0x8D86", VA = "0x8D86")]
		public void AddHistoryList(IList<ProtoGetWarsHistoryAns.Types.WarHistoryRecord> history)
		{
		/* --- GHIDRA: AddHistoryList ---
		int Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__AddHistoryList
		              (int param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fcc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanWarResultDic__get_Item__);
		    DAT_ram_00a57fcc = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsHistoryTab_ClanWarHistoryListElement_ClanWarHistoryListElementArgs_TypeInfo
		                        );
		  if (DAT_ram_00a57f4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_ClanWarHistoryListElement___ctor__
		              );
		    DAT_ram_00a57f4b = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1_00,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_ClanWarHistoryListElement___ctor__
		            );
		  uVar1 = *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 8) + 0x68) + 0x1c) + 0x18);
		  *(int *)(param1_00 + 0x20) = param2;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param2 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_uint__ClanWarResultDic__get_Item__
		                    );
		  *(undefined4 *)(param1_00 + 0x24) = uVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06003ECB RID: 16075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x8D87", Offset = "0x8D87", VA = "0x8D87")]
		private ClanWarHistoryListElement.ClanWarHistoryListElementArgs ConstructArgs(ProtoGetWarsHistoryAns.Types.WarHistoryRecord warRecord)
		{
		/* --- GHIDRA: ConstructArgs ---
		void Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__ConstructArgs(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fcd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel___c_TypeInfo);
		    DAT_ram_00a57fcd = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04002352 RID: 9042
		[Token(Token = "0x4002352")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dictionaries Dict;

		// Token: 0x04002353 RID: 9043
		[Token(Token = "0x4002353")]
		[FieldOffset(Offset = "0x10")]
		public readonly string HonorAssetId;

		// Token: 0x04002354 RID: 9044
		[Token(Token = "0x4002354")]
		[FieldOffset(Offset = "0x14")]
		public readonly List<IList<ClanWarHistoryListElement.ClanWarHistoryListElementArgs>> HistoryArgsPagesStack;

		// Token: 0x04002355 RID: 9045
		[Token(Token = "0x4002355")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<uint, ClanWarResultDic> _resultDics;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LastWarId ---
		undefined4
		Gameplay_Clans_Office_Model_ClanWars_ClanWarsHistoryModel__get_LastWarId
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57fc9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Last_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs____
		              );
		    DAT_ram_00a57fc9 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_System_Linq_Enumerable_Last_IList_ClanWarHistoryListElement_ClanWarHistoryListElementArgs____
		                    );
		  return uVar1;
		}
		*/

}
