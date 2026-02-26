using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	public class RemoveFromFavorite : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x17000DAC")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x938A", Offset = "0x938A", VA = "0x938A", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044E5 RID: 17637 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x60044E5")]
		[Address(RVA = "0x938B", Offset = "0x938B", VA = "0x938B", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_RemoveFromFavorite__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  undefined4 param2_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57b70 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b70 = '\x01';
		  }
		  param1_00 = (int *)func_ii_1082(param2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		          goto code_r0x80e2a1bc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e2a1bc:
		    uVar1 = 0;
		    param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e2a240;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e2a240:
		    param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    Gameplay_Chat_Control_ChatController__RemoveFromFavorites(param1_01,param2_00,puVar2);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044E6 RID: 17638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E6")]
		[Address(RVA = "0x938C", Offset = "0x938C", VA = "0x938C", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044E7 RID: 17639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E7")]
		[Address(RVA = "0x938D", Offset = "0x938D", VA = "0x938D")]
		public RemoveFromFavorite()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_RemoveFromFavorite___ctor
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57b71 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ChatModel__ChatEvents__Dispose__);
		    DAT_ram_00a57b71 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ChatModel__ChatEvents__Dispose__);
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_RemoveFromFavorite__get_ActionId
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
		  if (DAT_ram_00a57b6f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a57b6f = '\x01';
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
		          goto code_r0x80e29ebd;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e29ebd:
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
		          goto code_r0x80e29f65;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x23);
		code_r0x80e29f65:
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
		          goto code_r0x80e2a008;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e2a008:
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
		          goto code_r0x80e2a0a0;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x80e2a0a0:
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
		      uVar7 = (uint)(0 < iVar4);
		      if (uVar7 == 0) {
		        return 0;
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
