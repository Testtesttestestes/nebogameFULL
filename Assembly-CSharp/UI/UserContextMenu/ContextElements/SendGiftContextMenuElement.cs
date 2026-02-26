using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public class SendGiftContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x17000132")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x5CB5", Offset = "0x5CB5", VA = "0x5CB5", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093C")]
		[Address(RVA = "0x5CB6", Offset = "0x5CB6", VA = "0x5CB6", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		/* --- GHIDRA: Handle ---
		uint UI_UserContextMenu_ContextElements_SendGiftContextMenuElement__Handle
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  longlong lVar4;
		  int *param1_00;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a5b8c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a5b8c8 = '\x01';
		  }
		  iVar5 = *param2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138e6dc;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138e6dc:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar6 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x8138e78a;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8138e78a:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		  return (uint)(lVar4 != lVar3);
		}
		*/

		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x5CB7", Offset = "0x5CB7", VA = "0x5CB7", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
			return default(bool);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x5CB8", Offset = "0x5CB8", VA = "0x5CB8")]
		public SendGiftContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		void UI_UserContextMenu_ContextElements_SendGiftContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a5b8c7 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x8138e5a8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x8138e5a8:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138e62c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138e62c:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowAuchan
		            (param1_00,param2_00,0);
		  return;
		}
		*/

}
