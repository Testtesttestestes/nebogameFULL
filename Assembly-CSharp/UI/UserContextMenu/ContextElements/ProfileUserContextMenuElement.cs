using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public class ProfileUserContextMenuElement : AbstractUserContextMenuElement
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x17000131")]
		public override UserMenuActionDic.Types.Actions ActionId
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x5CB1", Offset = "0x5CB1", VA = "0x5CB1", Slot = "4")]
			get
			{
				return UserMenuActionDic.Types.Actions.UnknownAction;
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x5CB2", Offset = "0x5CB2", VA = "0x5CB2", Slot = "5")]
		public override bool Validate(IUserMenuContext context)
		{
		/* --- GHIDRA: Validate ---
		void UI_UserContextMenu_ContextElements_ProfileUserContextMenuElement__Validate
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    DAT_ram_00a5b8c6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_02;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x8138e433;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x8138e433:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138e4b5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138e4b5:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_01,param2_00,0);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft
		            (param1_00,param1_01,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x5CB3", Offset = "0x5CB3", VA = "0x5CB3", Slot = "7")]
		public override void Handle(IUserMenuContext context)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x5CB4", Offset = "0x5CB4", VA = "0x5CB4")]
		public ProfileUserContextMenuElement()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ActionId ---
		uint UI_UserContextMenu_ContextElements_ProfileUserContextMenuElement__get_ActionId
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_UserContextMenu_IUserMenuContext_TypeInfo);
		    DAT_ram_00a5b8c5 = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (UI_UserContextMenu_IUserMenuContext_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8138e356;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,UI_UserContextMenu_IUserMenuContext_TypeInfo,0);
		code_r0x8138e356:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return (uint)(iVar3 != 0);
		}
		*/

}
