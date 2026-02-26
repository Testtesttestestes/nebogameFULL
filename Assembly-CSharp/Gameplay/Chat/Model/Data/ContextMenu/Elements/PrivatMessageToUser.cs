using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.UserContextMenu;
using UI.UserContextMenu.ContextElements;

namespace Gameplay.Chat.Model.Data.ContextMenu.Elements
{
	// Token: 0x02000B23 RID: 2851
	[Token(Token = "0x2000B23")]
	public class PrivatMessageToUser : AbstractUserContextMenuElement
	{
		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x17000DAA")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x60044DC")]
			[Address(RVA = "0x9382", Offset = "0x9382", VA = "0x9382", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x060044DD RID: 17629 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x60044DD")]
		[Address(RVA = "0x9383", Offset = "0x9383", VA = "0x9383", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void Gameplay_Chat_Model_Data_ContextMenu_Elements_PrivatMessageToUser__Validate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57b6c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b6c = '\x01';
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
		          goto code_r0x80e29823;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e29823:
		    uVar1 = 0;
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e298a5;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0);
		code_r0x80e298a5:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (DAT_ram_00a57ba1 == '\0') {
		      Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		      Mono_Security_ASN1__get_Item(&StringLiteral_1705);
		      DAT_ram_00a57ba1 = '\x01';
		    }
		    param3_00 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0xc) + 0x18);
		    iVar5 = unnamed_function_1417(Gameplay_Chat_Model_Data_Message_InputMessage_TypeInfo);
		    Gameplay_Chat_Model_Data_Message_InputMessage__set_MessageText
		              (iVar5,StringLiteral_1705,param3_00);
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

		// Token: 0x060044DE RID: 17630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DE")]
		[Address(RVA = "0x9384", Offset = "0x9384", VA = "0x9384", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x060044DF RID: 17631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x9385", Offset = "0x9385", VA = "0x9385")]
		public PrivatMessageToUser()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint Gameplay_Chat_Model_Data_ContextMenu_Elements_PrivatMessageToUser__get_ActionId
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a57b6b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo);
		    DAT_ram_00a57b6b = '\x01';
		  }
		  piVar2 = (int *)func_ii_1082(param2,Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo
		                              );
		  if (piVar2 != (int *)0x0) {
		    iVar5 = *piVar2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80e2962b;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar2,
		                                  Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4);
		code_r0x80e2962b:
		    uVar1 = 0;
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0x104));
		    if ((*(byte *)(*(int *)(*(int *)(iVar5 + 0x30) + 0x14) + 0x10) & 4) != 0) {
		      iVar5 = *piVar2;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e296ce;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,0
		                                   );
		code_r0x80e296ce:
		      uVar1 = 0;
		      iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar6 = *piVar2;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xe0);
		            goto code_r0x80e29752;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar2,
		                                    Gameplay_Chat_Model_Data_ContextMenu_IChatMenuContext_TypeInfo,4
		                                   );
		code_r0x80e29752:
		      piVar2 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x100) * 4))
		                        (piVar2,*(undefined4 *)(*piVar2 + 0x104));
		      uVar1 = (uint)(iVar5 != *(int *)(iVar6 + 0x2c));
		    }
		  }
		  return uVar1;
		}
		*/

}
