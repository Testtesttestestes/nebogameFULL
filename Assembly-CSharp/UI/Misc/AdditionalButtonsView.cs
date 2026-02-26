using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Misc
{
	// Token: 0x020001D5 RID: 469
	[Token(Token = "0x20001D5")]
	public class AdditionalButtonsView : MonoBehaviour
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x5F56", Offset = "0x5F56", VA = "0x5F56")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Misc_AdditionalButtonsView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a6390d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Misc_AdditionalButtonsView_CharacterButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Misc_AdditionalButtonsView_ChestButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6390d = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Misc_AdditionalButtonsView_ChestButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Misc_AdditionalButtonsView_CharacterButtonClickedEventHandler__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C48")]
		[Address(RVA = "0x5F57", Offset = "0x5F57", VA = "0x5F57")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Misc_AdditionalButtonsView__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a6390e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    DAT_ram_00a6390e = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b0);
		        goto code_r0x8231a2ca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x8231a2ca:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x8231a376;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8231a376:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  param1_01 = unnamed_function_1417
		                        (Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(param1_01,uVar3,0);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft
		            (param1_00,param1_01,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x5F58", Offset = "0x5F58", VA = "0x5F58")]
		private void CharacterButtonClickedEventHandler()
		{
		/* --- GHIDRA: CharacterButtonClickedEventHandler ---
		void UI_Misc_AdditionalButtonsView__CharacterButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a6390f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6390f = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x8231a46b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8231a46b:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_Inventory_InventoryManager__ShowChestWindow(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x5F59", Offset = "0x5F59", VA = "0x5F59")]
		private void ChestButtonClickedEventHandler()
		{
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x5F5A", Offset = "0x5F5A", VA = "0x5F5A")]
		public AdditionalButtonsView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Misc_AdditionalButtonsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  UI_Misc_DynamicGridLayoutGroup__SetLayoutVertical(param1,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _chestButton;

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _userInfoButton;
	}
}
