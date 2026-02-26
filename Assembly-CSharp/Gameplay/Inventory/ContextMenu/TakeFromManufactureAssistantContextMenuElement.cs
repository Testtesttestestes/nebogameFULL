using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E6 RID: 1766
	[Token(Token = "0x20006E6")]
	public class TakeFromManufactureAssistantContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x1700080A")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A6D")]
			[Address(RVA = "0x7B10", Offset = "0x7B10", VA = "0x7B10", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6002A6E")]
		[Address(RVA = "0x7B11", Offset = "0x7B11", VA = "0x7B11", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_TakeFromManufactureAssistantContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a1ca == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo);
		    DAT_ram_00a5a1ca = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1f8);
		        goto code_r0x811e19f3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x811e19f3:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar6 = **(int **)(iVar5 + 0x14);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                    (*(int **)(iVar5 + 0x14),*(undefined4 *)(iVar6 + 0x104));
		  iVar5 = func_ii_7485(uVar3,3,&local_4,0);
		  if (iVar5 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x210);
		          goto code_r0x811e1aca;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2a);
		code_r0x811e1aca:
		    uVar1 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    iVar6 = **(int **)(iVar5 + 0x10);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                      (*(int **)(iVar5 + 0x10),*(undefined4 *)(iVar6 + 0x104));
		    piVar4 = local_4;
		    iVar5 = *local_4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x811e1b68;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(local_4,
		                                  Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		code_r0x811e1b68:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    iVar5 = Gameplay_Assistants_Model_AssistantsListModel___ctor
		                      (uVar3,*(undefined4 *)(iVar5 + 0xc),&local_8,0);
		    if (iVar5 != 0) {
		      if (local_8 != (int *)0x0) {
		        if (((uint)*(byte *)(*local_8 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo + 0xb8))
		           || (*(int *)(*(int *)(*local_8 + 100) +
		                        (uint)*(byte *)(
		                                       Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo
		                                       + 0xb8) * 4 + -4) !=
		               Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (local_8,Gameplay_Assistants_Manufacture_ManufactureAssistant_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      uVar1 = 0;
		      iVar5 = local_8[5];
		      iVar6 = *param2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x811e1c3e;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e1c3e:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      Gameplay_Assistants_Manufacture_Control_ManufactureAssistController__TryPut(iVar5,uVar3,0);
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A6F")]
		[Address(RVA = "0x7B12", Offset = "0x7B12", VA = "0x7B12", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A70")]
		[Address(RVA = "0x7B13", Offset = "0x7B13", VA = "0x7B13")]
		public TakeFromManufactureAssistantContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_TakeFromManufactureAssistantContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 param1_00;
		  int iVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a5a1c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a5a1c9 = '\x01';
		  }
		  iVar2 = *param2;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar3 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x811e1863;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e1863:
		  param1_00 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  iVar2 = Core_Data_ArtikulData__get_IsDismantableOnClanIsle(param1_00,0);
		  if (iVar2 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    uVar3 = 0;
		    iVar2 = *param2;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar3 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar3 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x811e18ef;
		        }
		        uVar3 = uVar3 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar3);
		    }
		    puVar1 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e18ef:
		    iVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		    uVar3 = (uint)(*(int *)(iVar2 + 0x80) == 5);
		  }
		  return uVar3;
		}
		*/

}
