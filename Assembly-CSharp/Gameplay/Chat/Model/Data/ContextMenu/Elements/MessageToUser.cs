using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2000B22")]
	public class MessageToUser : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA9 RID: 3497
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x17000DA9")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044D8")]
			[Address(RVA = "0x937E", Offset = "0x937E", VA = "0x937E", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044D9 RID: 17625 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x60044D9")]
		[Address(RVA = "0x937F", Offset = "0x937F", VA = "0x937F", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_MessageToUser__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57b6a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b6a = '\x01';
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e293dc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e293dc:
		    uVar1 = 0;
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e2945e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e2945e:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (DAT_ram_00a57ba2 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		      DAT_ram_00a57ba2 = '\x01';
		    }
		    param3_00 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0xc) + 0x18);
		    param2_00 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    iVar5 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText(iVar5,param2_00,param3_00);
		    *(undefined4 *)(iVar5 + 0xc) = param3_00;
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x110) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0x114));
		    iVar4 = *(int *)(iVar4 + 0x54);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),iVar5,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044DA RID: 17626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DA")]
		[Address(RVA = "0x9380", Offset = "0x9380", VA = "0x9380", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044DB RID: 17627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DB")]
		[Address(RVA = "0x9381", Offset = "0x9381", VA = "0x9381")]
		public MessageToUser()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_MessageToUser__get_ActionId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  int iVar5;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57b69 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b69 = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                              );
		  if (piVar2 == (int *)0x0) {
		    uVar1 = 0;
		  }
		  else {
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e29288;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e29288:
		    uVar1 = 0;
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e2930c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e2930c:
		    piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                      (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		    uVar1 = (uint)(iVar4 != *(int *)(iVar5 + 0x2c));
		  }
		  return uVar1;
		}
		*/

}
