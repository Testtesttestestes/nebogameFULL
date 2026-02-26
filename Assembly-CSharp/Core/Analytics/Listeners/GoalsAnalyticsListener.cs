using System;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012D2 RID: 4818
	[Token(Token = "0x20012D2")]
	public class GoalsAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001736")]
		protected override string Theme
		{
			[Token(Token = "0x600728C")]
			[Address(RVA = "0xBC95", Offset = "0xBC95", VA = "0xBC95", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600728D RID: 29325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728D")]
		[Address(RVA = "0xBC96", Offset = "0xBC96", VA = "0xBC96", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_GoalsAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GoalsAnalyticsListener_RewardTakenEvent__);
		    DAT_ram_00a595d5 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x60);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_GoalsAnalyticsListener_RewardTakenEvent__,
		             0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_GoalsScope_GoalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GoalsScope_GoalEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GoalsScope_GoalEventArgs__TypeInfo);
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

		// Token: 0x0600728E RID: 29326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728E")]
		[Address(RVA = "0xBC97", Offset = "0xBC97", VA = "0xBC97", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_GoalsAnalyticsListener__Deinit
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
		  
		  if (DAT_ram_00a595d6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26466);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24208);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24209);
		    DAT_ram_00a595d6 = '\x01';
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
		        goto code_r0x81035f84;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,8);
		code_r0x81035f84:
		  local_4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  func_ii_2946(param1_00,StringLiteral_24208,uVar3,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  piVar5 = *(int **)(param2 + 0x10);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x81036036;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Gameplay_DailyQuests_Model_IQuest_TypeInfo,10);
		code_r0x81036036:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  func_ii_2946(param1_00,StringLiteral_24209,uVar3,
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
		        goto code_r0x810360fb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x810360fb:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar5,uVar4,uVar3,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600728F RID: 29327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600728F")]
		[Address(RVA = "0xBC98", Offset = "0xBC98", VA = "0xBC98")]
		private void RewardTakenEvent(GoalsScope.GoalEventArgs e)
		{
		}

		// Token: 0x06007290 RID: 29328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007290")]
		[Address(RVA = "0xBC99", Offset = "0xBC99", VA = "0xBC99")]
		public GoalsAnalyticsListener()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Analytics_Listeners_GoalsAnalyticsListener___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a595d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_24266);
		    DAT_ram_00a595d7 = '\x01';
		  }
		  return StringLiteral_24266;
		}
		*/

		}

		// Token: 0x04003C06 RID: 15366
		[Token(Token = "0x4003C06")]
		private const string REWARD_TAKEN = "reward_taken";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_GoalsAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a595d4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_GoalsAnalyticsListener_RewardTakenEvent__);
		    DAT_ram_00a595d4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 0x60);
		  param1_00 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Analytics_Listeners_GoalsAnalyticsListener_RewardTakenEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_GoalsScope_GoalEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_GoalsScope_GoalEventArgs__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 8) = iVar3;
		  uVar2 = System_Action_GoalsScope_GoalEventArgs__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_GoalsScope_GoalEventArgs__TypeInfo);
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
