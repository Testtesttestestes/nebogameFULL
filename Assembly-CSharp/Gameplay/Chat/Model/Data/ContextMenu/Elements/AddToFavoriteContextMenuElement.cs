using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	public class AddToFavoriteContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x060044C9 RID: 17609 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x17000DA6")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044C9")]
			[Address(RVA = "0x936F", Offset = "0x936F", VA = "0x936F", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044CA RID: 17610 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x9370", Offset = "0x9370", VA = "0x9370", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_AddToFavoriteContextMenuElement__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int *param1_00;
		  uint *puVar4;
		  undefined4 param1_01;
		  int iVar5;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57b62 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b62 = '\x01';
		  }
		  param1_00 = (int *)func_ii_1082(param2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e2820e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e2820e:
		    uVar1 = 0;
		    uVar2 = CONCAT44(in_register_20000014,puVar4[1]);
		    param1_01 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar2);
		    uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e28292;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e28292:
		    iVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,CONCAT44(uVar3,puVar4[1]));
		    Gameplay_Chat_Control_ChatController__RequestGetContactList
		              (param1_01,*(undefined8 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0xc) + 0x10),iVar5);
		    Gameplay_Chat_Control_ChatController__GetNotViewedMessageCount(param1_01,iVar5,iVar5);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x9371", Offset = "0x9371", VA = "0x9371", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x9372", Offset = "0x9372", VA = "0x9372")]
		public AddToFavoriteContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_AddToFavoriteContextMenuElement__get_ActionId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  uint *puVar1;
		  undefined4 param1_01;
		  longlong lVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  uint uVar7;
		  
		  uVar7 = 0;
		  if (DAT_ram_00a57b61 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a57b61 = '\x01';
		  }
		  param1_00 = (int *)func_ii_1082(param2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		  if (param1_00 != (int *)0x0) {
		    uVar7 = 0;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e27f0b;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e27f0b:
		    iVar5 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x1d8);
		          goto code_r0x80e27fb3;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e27fb3:
		    iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(piVar3,puVar1[1]);
		    iVar6 = **(int **)(iVar4 + 0x10);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x100) * 4))
		                      (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar6 + 0x104));
		    if (*(int *)(iVar4 + 0x2c) == iVar5) {
		      return 0;
		    }
		    uVar7 = 0;
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar7 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e28056;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e28056:
		    uVar7 = 0;
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x100) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x104));
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e280ee;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x80e280ee:
		    param1_01 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		    lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		    if (DAT_ram_00a57b3d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_ChatVisitorData__get_Count__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		      DAT_ram_00a57b3d = '\x01';
		    }
		    iVar4 = *(int *)(*(int *)(iVar5 + 0x34) + 0xc);
		    do {
		      uVar7 = (uint)(iVar4 < 1);
		      if (iVar4 < 1) {
		        return uVar7;
		      }
		      iVar4 = iVar4 + -1;
		      iVar6 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(iVar5 + 0x34),iVar4,
		                         Method_System_Collections_Generic_List_ChatVisitorData__get_Item__);
		    } while (*(longlong *)(*(int *)(*(int *)(iVar6 + 0x14) + 0xc) + 0x10) != lVar2);
		  }
		  return uVar7;
		}
		*/

}
