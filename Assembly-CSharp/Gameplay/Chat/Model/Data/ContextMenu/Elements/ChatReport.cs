using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B1F RID: 2847
	[Token(Token = "0x2000B1F")]
	public class ChatReport : AbstractUserContextMenuElement
	{
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x17000DA7")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044CD")]
			[Address(RVA = "0x9373", Offset = "0x9373", VA = "0x9373", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044CE RID: 17614 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x9374", Offset = "0x9374", VA = "0x9374", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_ChatReport__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57b64 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b64 = '\x01';
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
		          goto code_r0x80e287d2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e287d2:
		    uVar1 = 0;
		    param1_01 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80e28856;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2);
		code_r0x80e28856:
		    iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    Gameplay_Chat_Control_ChatController__RequestSendMessage
		              (param1_01,*(undefined4 *)(iVar3 + 8),*(undefined4 *)(*(int *)(iVar3 + 0xc) + 8),iVar3
		              );
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060044CF RID: 17615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x9375", Offset = "0x9375", VA = "0x9375", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x9376", Offset = "0x9376", VA = "0x9376")]
		public ChatReport()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_ChatReport__get_ActionId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57b63 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b63 = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                              );
		  if (piVar2 != (int *)0x0) {
		    iVar6 = *piVar2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x80e284f0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e284f0:
		    uVar1 = 0;
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		    if ((*(byte *)(*(int *)(*(int *)(iVar6 + 0x30) + 0x14) + 0x10) & 0x80) != 0) {
		      iVar6 = *piVar2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80e28596;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2
		                                   );
		code_r0x80e28596:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      if (iVar6 == 0) {
		        return 0;
		      }
		      uVar1 = 0;
		      iVar6 = *piVar2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80e28619;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2
		                                   );
		code_r0x80e28619:
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      if (*(int *)(*(int *)(iVar6 + 0xc) + 8) == 0) {
		        return 0;
		      }
		      uVar1 = 0;
		      iVar6 = *piVar2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		            goto code_r0x80e286a0;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,2
		                                   );
		code_r0x80e286a0:
		      uVar1 = 0;
		      iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      if (*(int **)(iVar6 + 0xc) != (int *)0x0) {
		        iVar6 = **(int **)(iVar6 + 0xc);
		        if (((uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo + 0xb8)
		             <= (uint)*(byte *)(iVar6 + 0xb8)) &&
		           (*(int *)(*(int *)(iVar6 + 100) +
		                     (uint)*(byte *)(Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo +
		                                    0xb8) * 4 + -4) ==
		            Gameplay_Chat_Model_Data_Message_ChatUserMessageData_TypeInfo)) {
		          iVar6 = Unity_Properties_PropertyMember___ctor
		                            (0,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,piVar2
		                            );
		          piVar2 = (int *)Unity_Properties_PropertyMember___ctor
		                                    (4,
		                                     Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,
		                                     piVar2);
		          iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                            (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		          uVar1 = (uint)(iVar6 != *(int *)(iVar5 + 0x2c));
		        }
		      }
		    }
		  }
		  return uVar1;
		}
		*/

}
