using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.DailyQuests.Events
{
	// Token: 0x02000886 RID: 2182
	[Token(Token = "0x2000886")]
	public class DailyQuestEvents : AbstractMVCEvents
	{
		// Token: 0x0600335B RID: 13147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600335B")]
		[Address(RVA = "0x8396", Offset = "0x8396", VA = "0x8396")]
		public DailyQuestEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_DailyQuests_Events_DailyQuestEvents___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57c5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__Dispose__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_QuestChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_IQuest_TypeInfo);
		    DAT_ram_00a57c5a = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_DailyQuestsModel__DailyQuestEvents__DailyQuestsController__DailyQuestReadView__Dispose__
		            );
		  param1_01 = *(int **)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Gameplay_DailyQuests_Controller_DailyQuestReadViewMediator_QuestChangedEventHandler__
		             ,0);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_DailyQuests_Model_IQuest_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x80e3c05b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Gameplay_DailyQuests_Model_IQuest_TypeInfo,1);
		code_r0x80e3c05b:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_01,param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  return;
		}
		*/

		}

		// Token: 0x04001C06 RID: 7174
		[Token(Token = "0x4001C06")]
		[FieldOffset(Offset = "0x14")]
		public Action QuestsChangedEvent;

		// Token: 0x04001C07 RID: 7175
		[Token(Token = "0x4001C07")]
		[FieldOffset(Offset = "0x18")]
		public Action ActiveQuestsCountChangedEvent;

		// Token: 0x04001C08 RID: 7176
		[Token(Token = "0x4001C08")]
		[FieldOffset(Offset = "0x1C")]
		public Action QuestsUpdatedEvent;

		// Token: 0x04001C09 RID: 7177
		[Token(Token = "0x4001C09")]
		[FieldOffset(Offset = "0x20")]
		public Action FinishTakeRewardEvent;
	}
}
