using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.DailyQuests;
using Protocol.Dic;
using Utils;

namespace Gameplay.DailyQuests.Model
{
	// Token: 0x0200087A RID: 2170
	[Token(Token = "0x200087A")]
	public class DailyQuestsModel : AbstractModel
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A18")]
		public List<IDailyQuest> CurrentDailyQuests
		{
			[Token(Token = "0x6003300")]
			[Address(RVA = "0x8352", Offset = "0x8352", VA = "0x8352")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003301")]
			[Address(RVA = "0x8353", Offset = "0x8353", VA = "0x8353")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A19")]
		public List<IGoal> CurrentGoals
		{
			[Token(Token = "0x6003302")]
			[Address(RVA = "0x8354", Offset = "0x8354", VA = "0x8354")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003303")]
			[Address(RVA = "0x8355", Offset = "0x8355", VA = "0x8355")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1A")]
		public IList<DailyQuestCategoriesDic> Categories
		{
			[Token(Token = "0x6003304")]
			[Address(RVA = "0x8356", Offset = "0x8356", VA = "0x8356")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003305")]
			[Address(RVA = "0x8357", Offset = "0x8357", VA = "0x8357")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003306 RID: 13062 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6003306")]
		[Address(RVA = "0x8358", Offset = "0x8358", VA = "0x8358")]
		public int GetCompletedQuestsWithPendingRewardCount()
		{
		/* --- GHIDRA: GetCompletedQuestsWithPendingRewardCount ---
		int Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57c3d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0_TypeInfo);
		    DAT_ram_00a57c3d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Func_IDailyQuest__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__0__
		             ,0);
		  iVar3 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Count_IDailyQuest___);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__1__
		             ,0);
		  iVar1 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Count_IGoal___);
		  return iVar1 + iVar3;
		}
		*/

		/* --- GHIDRA: GetCompletedQuestsWithPendingRewardCount ---
		int Gameplay_DailyQuests_Model_DailyQuestsModel__GetCompletedQuestsWithPendingRewardCount
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57c3d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0_TypeInfo);
		    DAT_ram_00a57c3d = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = param2;
		  uVar4 = *(undefined4 *)(param1 + 0x14);
		  uVar2 = unnamed_function_1417(System_Func_IDailyQuest__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__0__
		             ,0);
		  iVar3 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Count_IDailyQuest___);
		  uVar4 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass18_0__GetNotCompletedQuestsCount_b__1__
		             ,0);
		  iVar1 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar4,uVar2,Method_System_Linq_Enumerable_Count_IGoal___);
		  return iVar1 + iVar3;
		}
		*/

			return 0;
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x6003307")]
		[Address(RVA = "0x8359", Offset = "0x8359", VA = "0x8359")]
		public int GetCompletedQuestsWithPendingRewardCount(uint categoryId)
		{
			return 0;
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x6003308")]
		[Address(RVA = "0x835A", Offset = "0x835A", VA = "0x835A")]
		public int GetNotCompletedQuestsCount(uint categoryId)
		{
		/* --- GHIDRA: GetNotCompletedQuestsCount ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__GetNotCompletedQuestsCount
		               (int param1,undefined4 param2)
		
		{
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  *(undefined8 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003309")]
		[Address(RVA = "0x835B", Offset = "0x835B", VA = "0x835B", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c3e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__List_IQuest___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGoal___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IGoal__TypeInfo);
		    DAT_ram_00a57c3e = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IDailyQuest__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IGoal__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IGoal___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__List_IQuest___TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar1,Method_System_Collections_Generic_Dictionary_uint__List_IQuest____ctor__);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  return;
		}
		*/

		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330A")]
		[Address(RVA = "0x835C", Offset = "0x835C", VA = "0x835C")]
		public DailyQuestsModel(UserData user, IDictProvider dictProvider, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 *puVar7;
		  
		  if (DAT_ram_00a57c3f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Keys__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_DailyQuestCategoriesDic__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_uint__DailyQuestCategoriesDic___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_DailyQuestCategoriesDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__DailyQuestCategoriesDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_DailyQuestCategoriesDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateCategories_b__21_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass21_0__PopulateCategories_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass21_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c3f = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass21_0_TypeInfo);
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x80e39598;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e39598:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  *(undefined4 *)(iVar2 + 8) = uVar4;
		  uVar4 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x24),
		                     Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Keys__);
		  uVar5 = unnamed_function_1417(System_Func_uint__DailyQuestCategoriesDic__TypeInfo);
		  System_Linq_Enumerable__Distinct_uint_
		            (uVar5,iVar2,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass21_0__PopulateCategories_b__0__
		             ,0);
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,uVar5,
		                     Method_System_Linq_Enumerable_Select_uint__DailyQuestCategoriesDic___);
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  iVar2 = puVar7[3];
		  if (iVar2 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar7 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar7;
		    iVar2 = unnamed_function_1417(System_Func_DailyQuestCategoriesDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar2,uVar5,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateCategories_b__21_1__,
		               0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0xc) =
		         iVar2;
		  }
		  uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar4,iVar2,
		                     Method_System_Linq_Enumerable_OrderBy_DailyQuestCategoriesDic__uint___);
		  uVar4 = func_ii_6295(uVar4,Method_System_Linq_Enumerable_ToArray_DailyQuestCategoriesDic___);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  return;
		}
		*/

		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330B")]
		[Address(RVA = "0x835D", Offset = "0x835D", VA = "0x835D")]
		private void PopulateCategories()
		{
		/* --- GHIDRA: PopulateCategories ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__PopulateCategories
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  undefined4 local_c;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57c40 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IQuest__TypeInfo);
		    DAT_ram_00a57c40 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e3976a;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e3976a:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar3 = Core_Extensions_Dict_DictExt__GetCollectionRankInfoDic
		                    (uVar2,*(undefined4 *)(param2 + 0xc),&local_4,0);
		  iVar5 = local_4;
		  if (iVar3 != 0) {
		    uVar2 = unnamed_function_1417(Gameplay_DailyQuests_Model_DailyQuestData_TypeInfo);
		    Gameplay_DailyQuests_Model_DailyQuestData__remove_QuestChangedEvent(uVar2,param2,iVar5,iVar5);
		    iVar5 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(local_4 + 0x10),&local_8,
		                       Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__
		                      );
		    if (iVar5 == 0) {
		      iVar5 = unnamed_function_1417(System_Collections_Generic_List_IQuest__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar5,Method_System_Collections_Generic_List_IQuest___ctor__);
		      local_8 = iVar5;
		      System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(local_4 + 0x10),iVar5,
		                 Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		    }
		    iVar5 = Method_System_Collections_Generic_List_IQuest__Add__;
		    *(int *)(local_8 + 0x10) = *(int *)(local_8 + 0x10) + 1;
		    uVar6 = *(uint *)(local_8 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(local_8 + 8) + 0xc)) {
		      *(uint *)(local_8 + 0xc) = uVar6 + 1;
		      *(undefined4 *)(*(int *)(local_8 + 8) + uVar6 * 4 + 0x10) = uVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (local_8,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		    return uVar2;
		  }
		  local_c = *(undefined4 *)(param2 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  uVar4 = unnamed_function_2232(&StringLiteral_4773);
		  uVar2 = func_ii_4419(uVar4,uVar2,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar2,0);
		  uVar2 = unnamed_function_2232
		                    (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateDailyQuest__);
		  func_ii_1050(uVar4,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600330C")]
		[Address(RVA = "0x835E", Offset = "0x835E", VA = "0x835E")]
		private IDailyQuest CreateDailyQuest(ProtoGetQuestsAns.Types.UserQuest quest)
		{
		/* --- GHIDRA: CreateDailyQuest ---
		int Gameplay_DailyQuests_Model_DailyQuestsModel__CreateDailyQuest
		              (int param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  undefined4 local_c;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a57c41 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_GoalData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IQuest__TypeInfo);
		    DAT_ram_00a57c41 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  param1_00 = *(int **)(param1 + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x80e3999d;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e3999d:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar3 = Core_Extensions_Dict_DictExt__TryGetDailyQuestsDic
		                    (uVar2,*(undefined4 *)(param2 + 0xc),&local_4,0);
		  iVar5 = local_4;
		  if (iVar3 != 0) {
		    iVar3 = unnamed_function_1417(Gameplay_DailyQuests_Model_GoalData_TypeInfo);
		    *(int *)(iVar3 + 0x14) = iVar5;
		    *(int *)(iVar3 + 8) = param2;
		    iVar5 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                      (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(local_4 + 0x10),&local_8,
		                       Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__
		                      );
		    if (iVar5 == 0) {
		      iVar5 = unnamed_function_1417(System_Collections_Generic_List_IQuest__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (iVar5,Method_System_Collections_Generic_List_IQuest___ctor__);
		      local_8 = iVar5;
		      System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		                (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(local_4 + 0x10),iVar5,
		                 Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		    }
		    iVar5 = Method_System_Collections_Generic_List_IQuest__Add__;
		    *(int *)(local_8 + 0x10) = *(int *)(local_8 + 0x10) + 1;
		    uVar6 = *(uint *)(local_8 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(local_8 + 8) + 0xc)) {
		      *(uint *)(local_8 + 0xc) = uVar6 + 1;
		      *(int *)(*(int *)(local_8 + 8) + uVar6 * 4 + 0x10) = iVar3;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (local_8,iVar3,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    }
		    return iVar3;
		  }
		  local_c = *(undefined4 *)(param2 + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_c);
		  uVar4 = unnamed_function_2232(&StringLiteral_4774);
		  uVar2 = func_ii_4419(uVar4,uVar2,0);
		  uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar4 = unnamed_function_1417(uVar4);
		  System_String__Concat(uVar4,uVar2,0);
		  uVar2 = unnamed_function_2232(&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateGoal__);
		  func_ii_1050(uVar4,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600330D")]
		[Address(RVA = "0x835F", Offset = "0x835F", VA = "0x835F")]
		private IGoal CreateGoal(ProtoGetQuestsAns.Types.UserQuest quest)
		{
		/* --- GHIDRA: CreateGoal ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__CreateGoal
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57c42 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_IGoal__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_IGoal__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_IGoal__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGoal__Remove__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest__Remove__);
		    DAT_ram_00a57c42 = '\x01';
		  }
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_IGoal__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e39bea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_IGoal__TypeInfo,0);
		code_r0x80e39bea:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar7 == 0) {
		    return;
		  }
		  uVar1 = 0;
		  iVar7 = *param2;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_IGoal__TypeInfo ==
		          *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e39c6a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_IGoal__TypeInfo,0);
		code_r0x80e39c6a:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e39d36;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3a00f:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a017;
		    }
		code_r0x80e39d36:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3a00f;
		    if (iVar7 == 0) {
		      iVar7 = 0;
		      goto code_r0x80e3a060;
		    }
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_IGoal__TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80e39e10;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_IGoal__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e39fdd:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a017;
		    }
		code_r0x80e39e10:
		    DAT_ram_009d3e38 = 0;
		    piVar6 = (int *)import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e39fdd;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,
		               *(undefined4 *)(param1 + 0x18),piVar6,
		               Method_System_Collections_Generic_List_IGoal__Remove__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a017;
		    }
		    uVar4 = *(undefined4 *)(param1 + 0x24);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 0x128);
		          goto code_r0x80e39f26;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar6,
		                        Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xd);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e39ff1:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a017;
		    }
		code_r0x80e39f26:
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e39ff1;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar4,param3_00,
		                       Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Item__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a017;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x389,uVar4,piVar6,
		               Method_System_Collections_Generic_List_IQuest__Remove__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e3a017:
		  iVar7 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar7 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar7;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x80e3a060:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *local_4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e3a0d8;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e3a0d8:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x37,&local_c);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330E")]
		[Address(RVA = "0x8360", Offset = "0x8360", VA = "0x8360")]
		public void RemoveGoals(IList<IGoal> goals)
		{
		/* --- GHIDRA: RemoveGoals ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__RemoveGoals(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint uVar6;
		  int iVar7;
		  int *piVar8;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  int local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57c43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IGoal__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IGoal__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IGoal__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGoal__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IQuest___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IQuest__TypeInfo);
		    DAT_ram_00a57c43 = '\x01';
		  }
		  local_14 = 0;
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Clear__);
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_IGoal__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IGoal__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a5e7;
		    }
		    iVar7 = local_24;
		    if (iVar1 == 0) goto code_r0x80e3a630;
		    uVar4 = *(undefined4 *)(param1 + 0x24);
		    piVar5 = local_8._4_4_;
		    iVar7 = *local_8._4_4_;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar6 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar6 * 8);
		        if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar7 + 0x128);
		          goto code_r0x80e3a30e;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar6);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xd);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3a42a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a5e7;
		    }
		code_r0x80e3a30e:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3a42a;
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39d,uVar4,uVar3,&local_14
		                       ,
		                       Method_System_Collections_Generic_Dictionary_uint__List_IQuest___TryGetValue__
		                      );
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a5e7;
		    }
		    if (iVar1 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_IQuest__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar7,
		                   Method_System_Collections_Generic_List_IQuest___ctor__);
		        if (DAT_ram_009d3e38 != 1) {
		          uVar4 = *(undefined4 *)(param1 + 0x24);
		          iVar1 = *piVar5;
		          local_14 = iVar7;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar6 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar6 * 8);
		              if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *piVar8) {
		                puVar2 = (undefined4 *)(piVar8[1] * 8 + iVar1 + 0x128);
		                goto code_r0x80e3a4a9;
		              }
		              uVar6 = uVar6 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar6);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar2 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                              Gameplay_DailyQuests_Model_IQuest_TypeInfo,0xd);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x80e3a4a9:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,uVar4,uVar3,
		                         local_14,
		                         Method_System_Collections_Generic_Dictionary_uint__List_IQuest___Add__);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 != 1) goto code_r0x80e3a522;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e3a5e7;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e3a5e7;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3a5e7;
		    }
		code_r0x80e3a522:
		    iVar7 = Method_System_Collections_Generic_List_IQuest__Add__;
		    *(int *)(local_14 + 0x10) = *(int *)(local_14 + 0x10) + 1;
		    uVar6 = *(uint *)(local_14 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(local_14 + 8) + 0xc)) {
		      *(uint *)(local_14 + 0xc) = uVar6 + 1;
		      *(int **)(*(int *)(local_14 + 8) + uVar6 * 4 + 0x10) = piVar5;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,local_14,piVar5,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e3a5e7:
		        iVar7 = global_1;
		        iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar7 == iVar1) {
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar7 = *piVar5;
		          DAT_ram_009d3e38 = 0;
		          local_24 = iVar7;
		          import::env::invoke_v(0x123);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 != 1) {
		code_r0x80e3a630:
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 0) {
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x38,&local_24);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          import::env::__cxa_find_matching_catch_3(0);
		          unnamed_function_937();
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__resumeException(uVar4);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  } while( true );
		}
		*/

		}

		// Token: 0x0600330F RID: 13071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600330F")]
		[Address(RVA = "0x8361", Offset = "0x8361", VA = "0x8361")]
		public void ResetDailyQuestsCategories()
		{
		/* --- GHIDRA: ResetDailyQuestsCategories ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__ResetDailyQuestsCategories
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a57c44 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateGoal__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_IGoal__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IGoal___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IGoal___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoGetQuestsAns_Types_UserQuest__IGoal__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateGoals_b__26_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateGoals_b__26_1__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c44 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_ProtoGetQuestsAns_Types_UserQuest__IGoal__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateGoal__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IGoal___
		                    );
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[4];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar4,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateGoals_b__26_0__,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0x10) =
		         iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Where_IGoal___);
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[5];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_IGoal__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar3,uVar4,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateGoals_b__26_1__,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0x14) =
		         iVar3;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_OrderBy_IGoal__uint___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_IGoal___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  Gameplay_DailyQuests_Model_DailyQuestsModel___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003310")]
		[Address(RVA = "0x8362", Offset = "0x8362", VA = "0x8362")]
		public void PopulateGoals(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		/* --- GHIDRA: PopulateGoals ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__PopulateGoals
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c45 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateDailyQuest__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_IDailyQuest__uint___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IDailyQuest___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateDailyQuests_b__27_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c45 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Func_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateDailyQuest__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest___
		                    );
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[6];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IDailyQuest__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__PopulateDailyQuests_b__27_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0x18) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_OrderBy_IDailyQuest__uint___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_IDailyQuest___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  Gameplay_DailyQuests_Model_DailyQuestsModel___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003311")]
		[Address(RVA = "0x8363", Offset = "0x8363", VA = "0x8363")]
		public void PopulateDailyQuests(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		/* --- GHIDRA: PopulateDailyQuests ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__PopulateDailyQuests
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c46 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateDailyQuest__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IDailyQuest___);
		    Mono_Security_ASN1__get_Item
		              (&System_Func_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest__AddRange__);
		    DAT_ram_00a57c46 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (System_Func_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateDailyQuest__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IDailyQuest___
		                    );
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_IDailyQuest___);
		  func_ii_6335(*(undefined4 *)(param1 + 0x14),uVar1,
		               Method_System_Collections_Generic_List_IDailyQuest__AddRange__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003312 RID: 13074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003312")]
		[Address(RVA = "0x8364", Offset = "0x8364", VA = "0x8364")]
		public IDailyQuest[] AddDailyQuests(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		/* --- GHIDRA: AddDailyQuests ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__AddDailyQuests
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c47 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateGoal__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IGoal___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IGoal___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_ProtoGetQuestsAns_Types_UserQuest__IGoal__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGoal__AddRange__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__AddGoals_b__29_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c47 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Func_ProtoGetQuestsAns_Types_UserQuest__IGoal__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar1,param1,Method_Gameplay_DailyQuests_Model_DailyQuestsModel_CreateGoal__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (param2,uVar1,
		                     Method_System_Linq_Enumerable_Select_ProtoGetQuestsAns_Types_UserQuest__IGoal___
		                    );
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[7];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__AddGoals_b__29_0__,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0x1c) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Where_IGoal___);
		  uVar1 = func_ii_6295(uVar1,Method_System_Linq_Enumerable_ToArray_IGoal___);
		  func_ii_6335(*(undefined4 *)(param1 + 0x18),uVar1,
		               Method_System_Collections_Generic_List_IGoal__AddRange__);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003313")]
		[Address(RVA = "0x8365", Offset = "0x8365", VA = "0x8365")]
		public IGoal[] AddGoals(IEnumerable<ProtoGetQuestsAns.Types.UserQuest> userDailyQuests)
		{
		/* --- GHIDRA: AddGoals ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__AddGoals
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass30_0__GetQuest_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass30_0_TypeInfo);
		    DAT_ram_00a57c48 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass30_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Func_IDailyQuest__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass30_0__GetQuest_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_IDailyQuest___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003314")]
		[Address(RVA = "0x8366", Offset = "0x8366", VA = "0x8366")]
		public IDailyQuest GetQuest(uint id)
		{
		/* --- GHIDRA: GetQuest ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__GetQuest
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57c49 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass31_0__GetGoal_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass31_0_TypeInfo);
		    DAT_ram_00a57c49 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass31_0_TypeInfo)
		  ;
		  *(undefined4 *)(param2_00 + 8) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param2_00,
		             Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__DisplayClass31_0__GetGoal_b__0__
		             ,0);
		  uVar1 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,Method_System_Linq_Enumerable_FirstOrDefault_IGoal___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003315")]
		[Address(RVA = "0x8367", Offset = "0x8367", VA = "0x8367")]
		public IGoal GetGoal(uint id)
		{
		/* --- GHIDRA: GetGoal ---
		undefined4
		Gameplay_DailyQuests_Model_DailyQuestsModel__GetGoal
		          (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57c4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_IQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_IQuest___);
		    Mono_Security_ASN1__get_Item(&System_Func_IQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetQuestsByCategory_b__32_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c4a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 0x24),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__List_IQuest___get_Item__);
		  if (param3 != 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    }
		    puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    param1_00 = puVar2[8];
		    if (param1_00 == 0) {
		      if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		        puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		      }
		      param2_00 = *puVar2;
		      param1_00 = unnamed_function_1417(System_Func_IQuest__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (param1_00,param2_00,
		                 Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetQuestsByCategory_b__32_0__
		                 ,0);
		      *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 0x20) =
		           param1_00;
		    }
		    uVar1 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar1,param1_00,Method_System_Linq_Enumerable_Where_IQuest___);
		    uVar1 = System_Linq_Enumerable__Select_object__object_
		                      (uVar1,Method_System_Linq_Enumerable_ToList_IQuest___);
		  }
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003316")]
		[Address(RVA = "0x8368", Offset = "0x8368", VA = "0x8368")]
		public List<IQuest> GetQuestsByCategory(uint categoryId, bool activeOnly = false)
		{
		/* --- GHIDRA: GetQuestsByCategory ---
		int Gameplay_DailyQuests_Model_DailyQuestsModel__GetQuestsByCategory(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 *puVar3;
		  float fVar4;
		  float fVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  uint uVar9;
		  int *piVar10;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57c4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IDailyQuest__get_Current__);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IDailyQuest__GetEnumerator__);
		    DAT_ram_00a57c4b = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_IDailyQuest__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  iVar8 = 0;
		code_r0x80e3ae47:
		  while( true ) {
		    param2_00 = iVar8;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_IDailyQuest__MoveNext__);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3b1a8;
		    }
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return param2_00;
		    }
		    piVar7 = local_8._4_4_;
		    iVar8 = *local_8._4_4_;
		    uVar9 = (uint)*(ushort *)(iVar8 + 0xb6);
		    if (param2_00 == 0) break;
		    if (uVar9 != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		        if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo == *piVar10) {
		          puVar3 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e3aff2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar9 != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3b0c0:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3b1a8;
		    }
		code_r0x80e3aff2:
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e3b0c0;
		    DAT_ram_009d3e38 = 0;
		    fVar4 = import::env::invoke_fii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,uVar6,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3b1a8;
		    }
		    DAT_ram_009d3e38 = 0;
		    fVar5 = import::env::invoke_fii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x39,param2_00,0);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e3b1a8;
		    }
		    iVar8 = param2_00;
		    if (fVar4 < fVar5) {
		      iVar8 = *piVar7;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar9 * 8);
		          if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo == *piVar10) {
		            puVar3 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x80e3b149;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar9);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e3b196;
		code_r0x80e3b149:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80e3b196:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e3b1a8:
		        iVar8 = global_1;
		        iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar8 == iVar2) {
		          piVar7 = (int *)import::env::__cxa_begin_catch(uVar6);
		          iVar2 = *piVar7;
		          DAT_ram_009d3e38 = 0;
		          local_20 = iVar2;
		          import::env::invoke_v(0x123);
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 != 1) {
		            if (iVar2 == 0) {
		              DAT_ram_009d3e38 = 0;
		              return param2_00;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar6 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3a,&local_20);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) {
		          import::env::__resumeException(uVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		  }
		  if (uVar9 != 0) {
		    uVar1 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8);
		      if (Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(iVar8 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x80e3af27;
		      }
		      uVar1 = uVar1 + 1;
		    } while (uVar9 != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                      Gameplay_DailyQuests_Model_IDailyQuest_TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x80e3af27:
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 != 1) goto code_r0x80e3ae47;
		  }
		  DAT_ram_009d3e38 = 0;
		  param2_00 = 0;
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80e3b1a8;
		}
		*/

			return null;
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x8369", Offset = "0x8369", VA = "0x8369")]
		public BackTime GetLowestBackTime()
		{
		/* --- GHIDRA: GetLowestBackTime ---
		void Gameplay_DailyQuests_Model_DailyQuestsModel__GetLowestBackTime(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57c4c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c4c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x04001BE9 RID: 7145
		[Token(Token = "0x4001BE9")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04001BEA RID: 7146
		[Token(Token = "0x4001BEA")]
		[FieldOffset(Offset = "0x10")]
		public readonly IGame Game;

		// Token: 0x04001BEE RID: 7150
		[Token(Token = "0x4001BEE")]
		[FieldOffset(Offset = "0x20")]
		public IQuest CurrentQuest;

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<uint, List<IQuest>> _questsByCategories;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Categories ---
		int Gameplay_DailyQuests_Model_DailyQuestsModel__set_Categories(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57c3b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IGoal___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IGoal__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetCompletedQuestsWithPendingRewardCount_b__16_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetCompletedQuestsWithPendingRewardCount_b__16_1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		    DAT_ram_00a57c3b = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[1];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_IDailyQuest__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,uVar5,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetCompletedQuestsWithPendingRewardCount_b__16_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 4) = iVar3;
		  }
		  iVar3 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_Count_IDailyQuest___);
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		  iVar4 = puVar2[2];
		  if (iVar4 == 0) {
		    if (*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar2;
		    iVar4 = unnamed_function_1417(System_Func_IGoal__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar4,uVar5,
		               Method_Gameplay_DailyQuests_Model_DailyQuestsModel___c__GetCompletedQuestsWithPendingRewardCount_b__16_1__
		               ,0);
		    *(int *)(*(int *)(Gameplay_DailyQuests_Model_DailyQuestsModel___c_TypeInfo + 0x5c) + 8) = iVar4;
		  }
		  iVar4 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar1,iVar4,Method_System_Linq_Enumerable_Count_IGoal___);
		  return iVar4 + iVar3;
		}
		*/

}
