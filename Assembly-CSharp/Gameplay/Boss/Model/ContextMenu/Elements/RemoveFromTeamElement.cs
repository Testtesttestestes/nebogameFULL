using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Boss.Model.ContextMenu.Elements
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	public class RemoveFromTeamElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x060048BB RID: 18619 RVA: 0x0000D7E8 File Offset: 0x0000B9E8
		[Token(Token = "0x17000ED5")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60048BB")]
			[Address(RVA = "0x9734", Offset = "0x9734", VA = "0x9734", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x0000D800 File Offset: 0x0000BA00
		[Token(Token = "0x60048BC")]
		[Address(RVA = "0x9735", Offset = "0x9735", VA = "0x9735", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Boss_Model_ContextMenu_Elements_RemoveFromTeamElement__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 param1_01;
		  undefined8 uVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5789e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5789e = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo);
		  if (piVar2 != (int *)0x0) {
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
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1e0);
		          goto code_r0x80df0a84;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df0a84:
		    uVar6 = CONCAT44(in_register_20000014,puVar3[1]);
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar6);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    iVar5 = *(int *)(iVar5 + 0x18);
		    uVar1 = 0;
		    iVar7 = *piVar2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80df0b09;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo,0
		                                 );
		code_r0x80df0b09:
		    iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,CONCAT44(uVar4,puVar3[1]));
		    uVar6 = *(undefined8 *)(iVar7 + 8);
		    if (DAT_ram_00a5788d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		      DAT_ram_00a5788d = '\x01';
		    }
		    System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		              (*(undefined4 *)(iVar5 + 0xc),uVar6,
		               Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		    iVar5 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(iVar5 + 0xc),uVar6,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    uVar4 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    param1_01 = *(undefined4 *)(iVar5 + 0xc);
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80df0bde;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo,0
		                                 );
		code_r0x80df0bde:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,CONCAT44(uVar4,puVar3[1]));
		    iVar5 = *piVar2;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                      (piVar2,*(undefined4 *)(iVar5 + 0xe4));
		    uVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar4,0);
		    Gameplay_Boss_Controller_BossInstanceController__InviteAssistant(param1_01,uVar6,iVar5);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BD")]
		[Address(RVA = "0x9736", Offset = "0x9736", VA = "0x9736", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048BE")]
		[Address(RVA = "0x9737", Offset = "0x9737", VA = "0x9737")]
		public RemoveFromTeamElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		undefined4
		Gameplay_Boss_Model_ContextMenu_Elements_RemoveFromTeamElement__get_ActionId
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  int iVar6;
		  undefined4 param1_01;
		  undefined8 uVar7;
		  longlong lVar8;
		  int iVar9;
		  uint uVar10;
		  
		  if (DAT_ram_00a5789d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5789d = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo);
		  if (piVar2 != (int *)0x0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar10 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + iVar6 + 0x1e0);
		          goto code_r0x80df0773;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x80df0773:
		    uVar7 = CONCAT44(in_register_20000014,puVar3[1]);
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar7);
		    uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar6 = *(int *)(iVar6 + 0x18);
		    uVar10 = 0;
		    iVar9 = *piVar2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8)) {
		          puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80df07f8;
		        }
		        uVar10 = uVar10 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar10);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo,0
		                                 );
		code_r0x80df07f8:
		    iVar9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,CONCAT44(uVar5,puVar3[1]));
		    uVar7 = *(undefined8 *)(iVar9 + 8);
		    iVar9 = 0;
		    if (DAT_ram_00a5788d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		      DAT_ram_00a5788d = '\x01';
		    }
		    uVar1 = uVar7;
		    iVar4 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                      (*(undefined4 *)(iVar6 + 0xc),uVar7,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		    uVar5 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    if (iVar4 != 0) {
		      iVar9 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                        (*(undefined4 *)(iVar6 + 0xc),uVar7,
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                        );
		      uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    }
		    iVar6 = *(int *)(*(int *)(iVar9 + 8) + 0x3c);
		    if (iVar6 != 0) {
		      uVar10 = 0;
		      lVar8 = *(longlong *)(*(int *)(iVar6 + 0x34) + 0x20);
		      iVar6 = *piVar2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		            puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80df08e7;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo
		                                    ,0);
		code_r0x80df08e7:
		      uVar7 = CONCAT44(uVar5,puVar3[1]);
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,uVar7);
		      uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      if (lVar8 == *(longlong *)(iVar6 + 0x10)) {
		        uVar10 = 0;
		        param1_01 = *(undefined4 *)(*(int *)(iVar9 + 8) + 0x3c);
		        iVar6 = *piVar2;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8)) {
		              puVar3 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80df0971;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar10);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar2,
		                                      Gameplay_Boss_Model_ContextMenu_IBossMenuContext_TypeInfo,0);
		code_r0x80df0971:
		        piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,CONCAT44(uVar5,puVar3[1]));
		        uVar5 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xe0) * 4))
		                          (piVar2,*(undefined4 *)(*piVar2 + 0xe4));
		        uVar7 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar5,0);
		        iVar6 = func_ii_7046(param1_01,uVar7,1);
		        if (iVar6 != 0) {
		          return 1;
		        }
		      }
		    }
		  }
		  return 0;
		}
		*/

}
