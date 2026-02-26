using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	public class SendGiftActionOnEvent_17 : AbstractActionOnEvent
	{
		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x17000932")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x7F83", Offset = "0x7F83", VA = "0x7F83", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F17")]
		[Address(RVA = "0x7F84", Offset = "0x7F84", VA = "0x7F84", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F18")]
		[Address(RVA = "0x7F85", Offset = "0x7F85", VA = "0x7F85")]
		public SendGiftActionOnEvent_17()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_SendGiftActionOnEvent_17___ctor(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57507 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_AuchanActionOnEvent_15_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_AuchanActionOnEvent_29_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingCrystalEnergy2ActionOnEvent_27_var)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingCrystalEnergyActionOnEvent_24_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingDiamonds2ActionOnEvent_26_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingDiamondsActionOnEvent_23_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingGuild2ActionOnEvent_28_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_BillingGuildActionOnEvent_25_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_CollectionActionOnEvent_19_var);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_EventActions__Type___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_EventActions__Type__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_ActionsOnEvents_GoToAccountList_32_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_MarketActionOnEvent_4_var);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_ActionsOnEvents_NextEventAction_9_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_OpenPageGroupActionOnEvent_6_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_RevengeActionOnEvent_20_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_SendGiftActionOnEvent_17_var);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_ActionsOnEvents_TextEventAction_10_var);
		    DAT_ram_00a57507 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_EventActions__Type__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_EventActions__Type___ctor__);
		  uVar1 = Gameplay_GameEvents_Model_ActionsOnEvents_ActionAccount_1_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar1 = func_ii_2734(uVar1,0);
		  func_ii_10812(param1_00,1,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_MarketActionOnEvent_4_var,0);
		  func_ii_10812(param1_00,4,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_OpenPageGroupActionOnEvent_6_var,0)
		  ;
		  func_ii_10812(param1_00,6,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_NextEventAction_9_var,0);
		  func_ii_10812(param1_00,9,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_TextEventAction_10_var,0);
		  func_ii_10812(param1_00,10,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_AuchanActionOnEvent_15_var,0);
		  func_ii_10812(param1_00,0xf,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_SendGiftActionOnEvent_17_var,0);
		  func_ii_10812(param1_00,0x11,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_CollectionActionOnEvent_19_var,0);
		  func_ii_10812(param1_00,0x13,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_RevengeActionOnEvent_20_var,0);
		  func_ii_10812(param1_00,0x14,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingDiamondsActionOnEvent_23_var
		                       ,0);
		  func_ii_10812(param1_00,0x17,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingCrystalEnergyActionOnEvent_24_var
		                       ,0);
		  func_ii_10812(param1_00,0x18,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingGuildActionOnEvent_25_var,0)
		  ;
		  func_ii_10812(param1_00,0x19,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingDiamonds2ActionOnEvent_26_var
		                       ,0);
		  func_ii_10812(param1_00,0x1a,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingCrystalEnergy2ActionOnEvent_27_var
		                       ,0);
		  func_ii_10812(param1_00,0x1b,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_BillingGuild2ActionOnEvent_28_var,0
		                      );
		  func_ii_10812(param1_00,0x1c,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_AuchanActionOnEvent_29_var,0);
		  func_ii_10812(param1_00,0x1d,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  uVar1 = func_ii_2734(Gameplay_GameEvents_Model_ActionsOnEvents_GoToAccountList_32_var,0);
		  func_ii_10812(param1_00,0x20,uVar1,
		                Method_System_Collections_Generic_Dictionary_EventActions__Type__Add__);
		  **(undefined4 **)
		    (Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo + 0x5c) = param1_00
		  ;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_SendGiftActionOnEvent_17__get_SortOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int *param1_00;
		  uint uVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57506 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    DAT_ram_00a57506 = '\x01';
		  }
		  local_4 = 0;
		  if (0 < *(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x28) + 0xc)) {
		    param2_00 = func_ii_7271(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x24) + 0x30),0,
		                             Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    iVar1 = func_ii_7090(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x18) + 0x14),param2_00,
		                         &local_4,
		                         Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__
		                        );
		    uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		    if (iVar1 != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar4 = 0;
		      param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar1 = *param1_00;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar4 * 8 + 4) * 8 + iVar1 + 0x1b0);
		            goto code_r0x80d9be1b;
		          }
		          uVar4 = uVar4 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar4);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9be1b:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,CONCAT44(uVar3,puVar2[1]));
		      Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowAuchan
		                (uVar3,local_4,0);
		    }
		  }
		  return;
		}
		*/

}
