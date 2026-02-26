using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006E0 RID: 1760
	[Token(Token = "0x20006E0")]
	public class RepairUserArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x17000804")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A54")]
			[Address(RVA = "0x7AF7", Offset = "0x7AF7", VA = "0x7AF7", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x7AF8", Offset = "0x7AF8", VA = "0x7AF8", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_RepairUserArtifactContextMenuElement__Validate
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a1bd == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ArtifactView_TypeInfo);
		    DAT_ram_00a5a1bd = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Inventory_View_ArtifactView_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(Gameplay_Inventory_View_ArtifactView_TypeInfo + 0xb8) * 4 + -4) !=
		        Gameplay_Inventory_View_ArtifactView_TypeInfo)) {
		      System_Activator__CreateInstance(param2,Gameplay_Inventory_View_ArtifactView_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Inventory_View_ArtifactActionPopupWindow__EnableSale
		            (2,param2,*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x7AF9", Offset = "0x7AF9", VA = "0x7AF9", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x7AFA", Offset = "0x7AFA", VA = "0x7AFA")]
		public RepairUserArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_RepairUserArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1bc == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1bc = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x811e032e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e032e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar5 = Core_Data_ArtikulData__get_IsGolemItem(uVar3,0);
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x811e03ba;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e03ba:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    iVar5 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(uVar3,0);
		    if (iVar5 == 0) {
		      uVar1 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811e0443;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0443:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		      iVar5 = System_Collections_Generic_Dictionary_uint__uint___TryGetValue(uVar3,0);
		      if (iVar5 == 0) {
		        uVar1 = 0;
		        iVar5 = *param2;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x811e04cc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e04cc:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        iVar5 = Core_Data_ArtifactData__get_Rank(uVar3,0);
		        if (iVar5 == 0) {
		          uVar1 = 0;
		          iVar5 = *param2;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 +
		                                 0xd0);
		                goto code_r0x811e0555;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0555:
		          uVar1 = 0;
		          piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		          iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf8) * 4))
		                            (piVar4,*(undefined4 *)(*piVar4 + 0xfc));
		          iVar6 = *param2;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 +
		                                 0xd0);
		                goto code_r0x811e05eb;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e05eb:
		          piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		          iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		                            (piVar4,*(undefined4 *)(*piVar4 + 0xec));
		          if (iVar5 < iVar6) {
		            uVar1 = 0;
		            iVar5 = *param2;
		            if (*(ushort *)(iVar5 + 0xb6) != 0) {
		              do {
		                if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                    *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		                  puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 +
		                                   0xd0);
		                  goto code_r0x811e0689;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		            }
		            puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0689:
		            iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		            iVar5 = *(int *)(iVar5 + 0x70);
		            if (DAT_ram_00a6456f == '\0') {
		              Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		              DAT_ram_00a6456f = '\x01';
		            }
		            piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		            iVar6 = *piVar4;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		                  puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 +
		                                   0x140);
		                  goto code_r0x811e0734;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		            }
		            puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811e0734:
		            uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		            iVar6 = func_ii_7112(uVar3,0);
		            uVar1 = (uint)(iVar6 == iVar5);
		          }
		          else {
		            uVar1 = 0;
		          }
		        }
		        else {
		          uVar1 = 0;
		        }
		      }
		      else {
		        uVar1 = 0;
		      }
		    }
		    else {
		      uVar1 = 0;
		    }
		  }
		  return uVar1;
		}
		*/

}
