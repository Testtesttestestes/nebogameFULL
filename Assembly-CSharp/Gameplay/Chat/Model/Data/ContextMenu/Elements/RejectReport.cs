using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B24 RID: 2852
	[Token(Token = "0x2000B24")]
	public class RejectReport : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x17000DAB")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044E0")]
			[Address(RVA = "0x9386", Offset = "0x9386", VA = "0x9386", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x9387", Offset = "0x9387", VA = "0x9387", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_RejectReport__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a57b6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b6e = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                              );
		  if (piVar2 != (int *)0x0) {
		    uVar1 = 0;
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		          goto code_r0x80e29c97;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e29c97:
		    uVar1 = 0;
		    param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x80e29d19;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2);
		code_r0x80e29d19:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    piVar2 = *(int **)(iVar4 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo +
		                                  0xb8) * 4 + -4) !=
		          Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar2,Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    Gameplay_Chat_Control_ChatController__RequestRemoveMessage(param1_00,piVar2[2],0,piVar2);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x9388", Offset = "0x9388", VA = "0x9388", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x9389", Offset = "0x9389", VA = "0x9389")]
		public RejectReport()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_RejectReport__get_ActionId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int iVar4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57b6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b6d = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                              );
		  if (piVar2 != (int *)0x0) {
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x80e29a76;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2);
		code_r0x80e29a76:
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    if (iVar4 == 0) {
		      return 0;
		    }
		    uVar1 = 0;
		    iVar4 = *piVar2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x80e29af7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2);
		code_r0x80e29af7:
		    uVar1 = 0;
		    iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    if (*(int **)(iVar4 + 0xc) != (int *)0x0) {
		      iVar4 = **(int **)(iVar4 + 0xc);
		      if (((uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo + 0xb8) <=
		           (uint)*(byte *)(iVar4 + 0xb8)) &&
		         (*(int *)(*(int *)(iVar4 + 100) +
		                   (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo +
		                                  0xb8) * 4 + -4) ==
		          Gameplay_Chat_Model_Data_Message_ChatComplaintData_TypeInfo)) {
		        iVar4 = *piVar2;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		                *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0)
		              ;
		              goto code_r0x80e29bb3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar2,
		                                      Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                                      ,4);
		code_r0x80e29bb3:
		        piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		        iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                          (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		        uVar1 = (*(byte *)(*(int *)(*(int *)(iVar4 + 0x30) + 0x14) + 0x10) & 0x40) >> 6;
		      }
		    }
		  }
		  return uVar1;
		}
		*/

}
