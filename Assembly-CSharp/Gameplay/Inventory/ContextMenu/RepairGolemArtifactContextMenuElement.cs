using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006DF RID: 1759
	[Token(Token = "0x20006DF")]
	public class RepairGolemArtifactContextMenuElement : AbstractArtifactContextMenuElement
	{
		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x17000803")]
		public override ArtikulMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6002A50")]
			[Address(RVA = "0x7AF3", Offset = "0x7AF3", VA = "0x7AF3", Slot = "4")]
			get
			{
				return ArtikulMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x7AF4", Offset = "0x7AF4", VA = "0x7AF4", Slot = "5")]
		public override bool Validate(IArtifactView artifactView)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Inventory_ContextMenu_RepairGolemArtifactContextMenuElement__Validate
		               (int param1,int *param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a1bb == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_ArtifactView_TypeInfo);
		    DAT_ram_00a5a1bb = '\x01';
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
		  Gameplay_Inventory_View_ArtifactActionPopupWindow__Show(2,param2,*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x7AF5", Offset = "0x7AF5", VA = "0x7AF5", Slot = "7")]
		public override void Handle(IArtifactView artifactView)
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x7AF6", Offset = "0x7AF6", VA = "0x7AF6")]
		public RepairGolemArtifactContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Inventory_ContextMenu_RepairGolemArtifactContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a1ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a1ba = '\x01';
		  }
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x811dfe4b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811dfe4b:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = Gameplay_Clans_Model_ClansModel__set_GolemUserData(*(undefined4 *)(iVar5 + 0x10),0);
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
		          goto code_r0x811dfedc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811dfedc:
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x230);
		          goto code_r0x811dff87;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x811dff87:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    if (iVar5 == *(int *)(*(int *)(iVar6 + 0x10) + 0x20)) {
		      uVar1 = 0;
		      iVar5 = *param2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		            goto code_r0x811e0013;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0013:
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
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0)
		              ;
		              goto code_r0x811e009d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e009d:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        iVar5 = Gameplay_Inventory_Model_InventoryBaseModel__GetArtifactById(uVar3,0);
		        if (iVar5 == 0) {
		          uVar1 = 0;
		          iVar5 = *param2;
		          if (*(ushort *)(iVar5 + 0xb6) != 0) {
		            do {
		              if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                  *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		                puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 +
		                                 0xd0);
		                goto code_r0x811e0126;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e0126:
		          uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		          iVar5 = System_Collections_Generic_Dictionary_uint__uint___TryGetValue(uVar3,0);
		          if (iVar5 == 0) {
		            uVar1 = 0;
		            iVar5 = *param2;
		            if (*(ushort *)(iVar5 + 0xb6) != 0) {
		              do {
		                if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		                    *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		                  puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 +
		                                   0xd0);
		                  goto code_r0x811e01af;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		            }
		            puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811e01af:
		            uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		            iVar5 = Core_Data_ArtifactData__get_Rank(uVar3,0);
		            if (iVar5 == 0) {
		              piVar4 = (int *)Unity_Properties_PropertyMember___ctor
		                                        (2,Gameplay_Inventory_View_IArtifactView_TypeInfo,param2);
		              iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xf8) * 4))
		                                (piVar4,*(undefined4 *)(*piVar4 + 0xfc));
		              piVar4 = (int *)Unity_Properties_PropertyMember___ctor
		                                        (2,Gameplay_Inventory_View_IArtifactView_TypeInfo,param2);
		              iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe8) * 4))
		                                (piVar4,*(undefined4 *)(*piVar4 + 0xec));
		              uVar1 = (uint)(iVar5 < iVar6);
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
		    }
		    else {
		      uVar1 = 0;
		    }
		  }
		  return uVar1;
		}
		*/

}
