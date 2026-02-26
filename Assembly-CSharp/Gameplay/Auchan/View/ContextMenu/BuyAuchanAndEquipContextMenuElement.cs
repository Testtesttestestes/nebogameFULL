using System;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Auchan.View.ContextMenu
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	public class BuyAuchanAndEquipContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x06004E5B RID: 20059 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x17000FDD")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6004E5B")]
			[Address(RVA = "0x9C8D", Offset = "0x9C8D", VA = "0x9C8D", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x9C8E", Offset = "0x9C8E", VA = "0x9C8E", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Auchan_View_ContextMenu_BuyAuchanAndEquipContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a59866 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    DAT_ram_00a59866 = '\x01';
		  }
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x8107c037;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107c037:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if ((*(int *)(iVar4 + 0x80) == 3) &&
		     (iVar4 = *(int *)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) +
		                      0xc), iVar4 != 0)) {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x8107c0cf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107c0cf:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),uVar3,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x9C8F", Offset = "0x9C8F", VA = "0x9C8F", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x9C90", Offset = "0x9C90", VA = "0x9C90")]
		public BuyAuchanAndEquipContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Auchan_View_ContextMenu_BuyAuchanAndEquipContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59865 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59865 = '\x01';
		  }
		  local_4 = 0;
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8107bc9c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107bc9c:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  iVar5 = Core_Data_ArtifactData__get_Rank(uVar4,0);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x8107bd27;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107bd27:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		    iVar5 = Core_Data_ArtikulData__get_IsEquipment(uVar4,0);
		    if (iVar5 == 0) {
		      uVar1 = 0;
		    }
		    else {
		      uVar1 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x8107bdb1;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107bdb1:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		      iVar5 = func_ii_7597(uVar4,0);
		      if (iVar5 == 0) {
		        uVar1 = 0;
		      }
		      else {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar5 = *param1_00;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x120
		                               );
		              goto code_r0x8107be67;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8107be67:
		        iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		        uVar4 = *(undefined4 *)(iVar5 + 0x10);
		        uVar1 = 0;
		        iVar5 = *param2;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x8107beee;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107beee:
		        param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		        uVar1 = Gameplay_Inventory_Model_InventoryBaseModel__ParseSlotChanges
		                          (uVar4,param2_00,&local_4,0);
		      }
		    }
		  }
		  else {
		    uVar1 = 0;
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8107bf78;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x8107bf78:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  return uVar1 & *(int *)(iVar5 + 0x80) == 3;
		}
		*/

}
