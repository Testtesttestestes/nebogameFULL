using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012CD RID: 4813
	[Token(Token = "0x20012CD")]
	public class DailyQuestAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x0600726E RID: 29294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001730")]
		protected override string Theme
		{
			[Token(Token = "0x600726E")]
			[Address(RVA = "0xBC77", Offset = "0xBC77", VA = "0xBC77", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600726F RID: 29295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600726F")]
		[Address(RVA = "0xBC78", Offset = "0xBC78", VA = "0xBC78", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_DailyQuestAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595c0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_DailyQuestAnalyticsListener_RewardTakenEvent__);
		    DAT_ram_00a595c0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x5c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DailyQuestAnalyticsListener_RewardTakenEvent__,0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007270 RID: 29296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007270")]
		[Address(RVA = "0xBC79", Offset = "0xBC79", VA = "0xBC79", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_DailyQuestAnalyticsListener__Deinit
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a595c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22490);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22489);
		    DAT_ram_00a595c1 = '\x01';
		  }
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  piVar5 = *(int **)(param2 + 0x10);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x100);
		        goto code_r0x8103481d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,8);
		code_r0x8103481d:
		  local_4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_22489,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0x10);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x810348cf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,10);
		code_r0x810348cf:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  func_ii_2946(param1_00,StringLiteral_22490,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = (int *)param1[2];
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar3 = StringLiteral_26466;
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x81034994;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x81034994:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06007271 RID: 29297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007271")]
		[Address(RVA = "0xBC7A", Offset = "0xBC7A", VA = "0xBC7A")]
		private void RewardTakenEvent(DailyQuestScope.DailyQuestEventArgs e)
		{
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007272")]
		[Address(RVA = "0xBC7B", Offset = "0xBC7B", VA = "0xBC7B")]
		public DailyQuestAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_DailyQuestAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595c2 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_22555);
		    DAT_ram_00a595c2 = '\x01';
		  }
		  return StringLiteral_22555;
		}
		*/

		}

		// Token: 0x04003BFD RID: 15357
		[Token(Token = "0x4003BFD")]
		private const string REWARD_TAKEN = "reward_taken";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_DailyQuestAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595bf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_DailyQuestAnalyticsListener_RewardTakenEvent__);
		    DAT_ram_00a595bf = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x5c);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_DailyQuestAnalyticsListener_RewardTakenEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_DailyQuestScope_DailyQuestEventArgs__TypeInfo);
		  if (iVar4 != 0) {
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
