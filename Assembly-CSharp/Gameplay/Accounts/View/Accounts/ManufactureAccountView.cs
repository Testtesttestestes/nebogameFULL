using System;
using Gameplay.Assistants.Manufacture.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Accounts.View.Accounts
{
	// Token: 0x02000DD8 RID: 3544
	[Token(Token = "0x2000DD8")]
	public class ManufactureAccountView : DefaultAccountView
	{
		// Token: 0x06005666 RID: 22118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005666")]
		[Address(RVA = "0xA3F3", Offset = "0xA3F3", VA = "0xA3F3")]
		public ManufactureViewInAccountView GetManufactureView()
		{
		/* --- GHIDRA: GetManufactureView ---
		void Gameplay_Accounts_View_Accounts_ManufactureAccountView__GetManufactureView
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar6;
		  int *local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a588ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__get_Count__);
		    DAT_ram_00a588ab = '\x01';
		  }
		  local_4 = (int *)0x0;
		  Gameplay_Accounts_View_Accounts_DefaultAccountView__Dispose(param1,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x210);
		        goto code_r0x80f3a041;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2a);
		code_r0x80f3a041:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x10);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x104));
		  piVar4 = *(int **)(param1 + 0x28);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f3a0df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80f3a0df:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = Gameplay_Assistants_Model_AssistantsListModel___ctor
		                    (uVar3,*(undefined4 *)(iVar5 + 0xc),&local_4,0);
		  piVar4 = local_4;
		  if (iVar5 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,1,Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		  }
		  else {
		    if (local_4 != (int *)0x0) {
		      if (((uint)*(byte *)(*local_4 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*local_4 + 100) +
		                   (uint)*(byte *)(Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo +
		                                  0xb8) * 4 + -4) !=
		          Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (local_4,Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0x28);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)
		           ) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x80f3a1b6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3a1b6:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if ((iVar5 == 0) ||
		       (iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                          (piVar4,*(undefined4 *)(*piVar4 + 0x104)),
		       0 < *(int *)(*(int *)(*(int *)(iVar5 + 0x24) + 0x18) + 0xc))) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,2,Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		      if (DAT_ram_00a588aa == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_UnityEngine_Object_Instantiate_ManufactureViewInAccountView___);
		        Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		        DAT_ram_00a588aa = '\x01';
		      }
		      if (*(int *)(param1 + 0x54) == 0) {
		        uVar3 = *(undefined4 *)(param1 + 0x50);
		        param1_01 = *(undefined4 *)(param1 + 0x4c);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar5 = func_ii_6805(param1_01,uVar3,
		                             Method_UnityEngine_Object_Instantiate_ManufactureViewInAccountView___);
		        *(int *)(param1 + 0x54) = iVar5;
		      }
		      else {
		        iVar5 = *(int *)(param1 + 0x54);
		      }
		      if (*(char *)(iVar5 + 0x40) == '\0') {
		        Gameplay_Assistants_Manufacture_View_ManufactureViewInAccountView__set_IsInit
		                  (iVar5,piVar4,0);
		      }
		    }
		    else {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,1,Method_UI_MonoBehaviourWithStates_AccountViewStates__set_CurrentState__);
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005667")]
		[Address(RVA = "0xA3F4", Offset = "0xA3F4", VA = "0xA3F4", Slot = "8")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005668")]
		[Address(RVA = "0xA3F5", Offset = "0xA3F5", VA = "0xA3F5")]
		public ManufactureAccountView()
		{
		}

		// Token: 0x04002EE1 RID: 12001
		[Token(Token = "0x4002EE1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ManufactureViewInAccountView _manufactureViewPrefab;

		// Token: 0x04002EE2 RID: 12002
		[Token(Token = "0x4002EE2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _manufactureViewContainer;

		// Token: 0x04002EE3 RID: 12003
		[Token(Token = "0x4002EE3")]
		[FieldOffset(Offset = "0x54")]
		private ManufactureViewInAccountView _manufactureView;
	}
}
