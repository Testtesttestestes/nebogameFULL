using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Competition;
using UI.Tabs;
using Utils;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	public class CompetitionModel : AbstractModel
	{
		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x060035F1 RID: 13809 RVA: 0x0000AE48 File Offset: 0x00009048
		// (set) Token: 0x060035F2 RID: 13810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB5")]
		public Sections CurrentSection
		{
			[Token(Token = "0x60035F1")]
			[Address(RVA = "0x85FE", Offset = "0x85FE", VA = "0x85FE")]
			[CompilerGenerated]
			get
			{
				return Sections.Unknown;
			}
			[Token(Token = "0x60035F2")]
			[Address(RVA = "0x85FF", Offset = "0x85FF", VA = "0x85FF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB6")]
		public List<IDailyQuest> Quests
		{
			[Token(Token = "0x60035F3")]
			[Address(RVA = "0x8600", Offset = "0x8600", VA = "0x8600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035F4")]
			[Address(RVA = "0x8601", Offset = "0x8601", VA = "0x8601")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AB7")]
		[CanBeNull]
		public CompetitionData Competition
		{
			[Token(Token = "0x60035F5")]
			[Address(RVA = "0x8602", Offset = "0x8602", VA = "0x8602")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035F6")]
			[Address(RVA = "0x8603", Offset = "0x8603", VA = "0x8603")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AB8")]
		[NotNull]
		public OwnerRating OwnerRating
		{
			[Token(Token = "0x60035F7")]
			[Address(RVA = "0x8604", Offset = "0x8604", VA = "0x8604")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x17000AB9")]
		public float FireAnimationTimeUntilEnd
		{
			[Token(Token = "0x60035F8")]
			[Address(RVA = "0x8605", Offset = "0x8605", VA = "0x8605")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x8606", Offset = "0x8606", VA = "0x8606")]
		public CompetitionModel(OwnerRating ownerRating, IReadOnlyCollection<TabBarItemData<Sections>> sections, IReadOnlyDictionary<EventState, Sections[]> availSectionsByState, TabBarItemData<Sections> defaultSection, Dependencies dependencies)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Competition_Model_CompetitionModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  int param1_01;
		  uint uVar6;
		  undefined4 uVar7;
		  int local_4;
		  
		  if (DAT_ram_00a63ab5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_TabBarItemData_Sections____);
		    Mono_Security_ASN1__get_Item(&System_Func_TabBarItemData_Sections___bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IReadOnlyDictionary_EventState__Sections____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections___Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Model_CompetitionModel___c__DisplayClass25_0__GetAvailSections_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Model_CompetitionModel___c__DisplayClass25_0_TypeInfo);
		    DAT_ram_00a63ab5 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (System_Collections_Generic_IReadOnlyDictionary_EventState__Sections____TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar6 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x82339250;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IReadOnlyDictionary_EventState__Sections____TypeInfo
		                                ,1);
		code_r0x82339250:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,param2,&local_4,puVar1[1]);
		  if (iVar4 == 0) {
		    uVar7 = *(undefined4 *)(param1 + 0x18);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections___TypeInfo
		                      );
		    System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		              (uVar3,uVar7,
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections____ctor__
		              );
		  }
		  else {
		    iVar4 = *(int *)(param1 + 0x1c);
		    iVar5 = *(int *)(iVar4 + 0xc);
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    if (0 < iVar5) {
		      func_ii_2064(*(undefined4 *)(iVar4 + 8),0,iVar5,0);
		    }
		    iVar4 = local_4;
		    if (0 < *(int *)(local_4 + 0xc)) {
		      iVar5 = 0;
		      do {
		        iVar2 = unnamed_function_1417
		                          (
		                          Gameplay_Competition_Model_CompetitionModel___c__DisplayClass25_0_TypeInfo
		                          );
		        *(undefined1 *)(iVar2 + 8) = *(undefined1 *)(iVar5 + iVar4 + 0x10);
		        param1_01 = *(int *)(param1 + 0x1c);
		        uVar7 = *(undefined4 *)(param1 + 0x18);
		        uVar3 = unnamed_function_1417(System_Func_TabBarItemData_Sections___bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (uVar3,iVar2,
		                   Method_Gameplay_Competition_Model_CompetitionModel___c__DisplayClass25_0__GetAvailSections_b__0__
		                   ,0);
		        uVar3 = func_ii_6917(uVar7,uVar3,
		                             Method_System_Linq_Enumerable_Single_TabBarItemData_Sections____);
		        iVar2 = Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__;
		        *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		        uVar6 = *(uint *)(param1_01 + 0xc);
		        if (uVar6 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		          *(uint *)(param1_01 + 0xc) = uVar6 + 1;
		          *(undefined4 *)(*(int *)(param1_01 + 8) + uVar6 * 4 + 0x10) = uVar3;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_01,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38)
		                    );
		        }
		        iVar5 = iVar5 + 1;
		      } while (iVar5 < *(int *)(iVar4 + 0xc));
		    }
		    uVar7 = *(undefined4 *)(param1 + 0x1c);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections___TypeInfo
		                      );
		    System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		              (uVar3,uVar7,
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections____ctor__
		              );
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x8607", Offset = "0x8607", VA = "0x8607")]
		public ReadOnlyCollection<TabBarItemData<Sections>> GetAvailSections(EventState state)
		{
		/* --- GHIDRA: GetAvailSections ---
		undefined4
		Gameplay_Competition_Model_CompetitionModel__GetAvailSections(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a63ab6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Count_IDailyQuest___);
		    Mono_Security_ASN1__get_Item(&System_Func_IDailyQuest__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_Model_CompetitionModel___c__GetCompletedQuestsWithPendingRewardCount_b__26_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_CompetitionModel___c_TypeInfo);
		    DAT_ram_00a63ab6 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x5c);
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_IDailyQuest__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_Competition_Model_CompetitionModel___c__GetCompletedQuestsWithPendingRewardCount_b__26_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__Count_KeyValuePair_uint__object__
		                    (uVar1,param1_00,Method_System_Linq_Enumerable_Count_IDailyQuest___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x8608", Offset = "0x8608", VA = "0x8608")]
		public int GetCompletedQuestsWithPendingRewardCount()
		{
		/* --- GHIDRA: GetCompletedQuestsWithPendingRewardCount ---
		void Gameplay_Competition_Model_CompetitionModel__GetCompletedQuestsWithPendingRewardCount
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63ab7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_CompetitionModel___c_TypeInfo);
		    DAT_ram_00a63ab7 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Competition_Model_CompetitionModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x04001D93 RID: 7571
		[Token(Token = "0x4001D93")]
		[FieldOffset(Offset = "0xC")]
		public readonly Dependencies Dependencies;

		// Token: 0x04001D94 RID: 7572
		[Token(Token = "0x4001D94")]
		[FieldOffset(Offset = "0x10")]
		public readonly TabBarItemData DefaultSection;

		// Token: 0x04001D95 RID: 7573
		[Token(Token = "0x4001D95")]
		[FieldOffset(Offset = "0x14")]
		private readonly IReadOnlyDictionary<EventState, Sections[]> _availSectionsByState;

		// Token: 0x04001D96 RID: 7574
		[Token(Token = "0x4001D96")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<TabBarItemData<Sections>> _sections;

		// Token: 0x04001D97 RID: 7575
		[Token(Token = "0x4001D97")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<TabBarItemData<Sections>> _availSections;

		// Token: 0x04001D98 RID: 7576
		[Token(Token = "0x4001D98")]
		[FieldOffset(Offset = "0x20")]
		public BackTime BackTime;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_FireAnimationTimeUntilEnd ---
		void Gameplay_Competition_Model_CompetitionModel__get_FireAnimationTimeUntilEnd
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               int param6,undefined4 param7)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  uint *puVar2;
		  float fVar3;
		  undefined8 param1_00;
		  int *param1_01;
		  int iVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a63ab4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections___AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TabBarItemData_Sections___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDailyQuest__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21870);
		    DAT_ram_00a63ab4 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData_Sections___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TabBarItemData_Sections____ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData_Sections___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TabBarItemData_Sections____ctor__);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IDailyQuest__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IDailyQuest___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current
		            (param1,*(undefined4 *)(param6 + 0x28),0);
		  *(undefined4 *)(param1 + 0x30) = param2;
		  *(int *)(param1 + 0xc) = param6;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  func_ii_6335(*(undefined4 *)(param1 + 0x18),param3,
		               Method_System_Collections_Generic_List_TabBarItemData_Sections___AddRange__);
		  *(undefined4 *)(param1 + 0x14) = param4;
		  param1_01 = *(int **)(*(int *)(param1 + 0xc) + 8);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar5 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar5 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x82339125;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar5);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x82339125:
		  uVar1 = (**(code **)((ulonglong)*puVar2 * 4))(CONCAT44(in_register_20000004,param1_01),puVar2[1]);
		  param1_00 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar1,StringLiteral_21870,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar3 = func_ii_7331(param1_00,0);
		  *(float *)(param1 + 0x34) = fVar3;
		  return;
		}
		*/

}
