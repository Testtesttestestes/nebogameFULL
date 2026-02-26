using System;
using Gameplay.Inventory.View.Info;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x02000616 RID: 1558
	[Token(Token = "0x2000616")]
	public class MarketArtukulInfoPopupWindow : ArtikulInfoPopupWindow
	{
		// Token: 0x060025D2 RID: 9682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D2")]
		[Address(RVA = "0x7710", Offset = "0x7710", VA = "0x7710", Slot = "22")]
		protected override void OnShow(ArtikulInfoPopupWindow.ArtikulInfoPopupWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Market_View_MarketArtukulInfoPopupWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57de2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_View_MarketArtukulInfoPopupWindow_MarketButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57de2 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__OnClose__
		            );
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x58) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Market_View_MarketArtukulInfoPopupWindow_MarketButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D3")]
		[Address(RVA = "0x7711", Offset = "0x7711", VA = "0x7711", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Market_View_MarketArtukulInfoPopupWindow__OnClose(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57de3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57de3 = '\x01';
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
		        goto code_r0x80e65956;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80e65956:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ArtikulInfoPopupWindow_ArtikulInfoPopupWindowArgs__get_WindowArgs__
		                      );
		  iVar4 = **(int **)(iVar3 + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x130) * 4))
		                    (*(int **)(iVar3 + 0x18),*(undefined4 *)(iVar4 + 0x134));
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowClanIsleBuildings
		            (param1_00,*(undefined4 *)(*(int *)(iVar3 + 8) + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D4")]
		[Address(RVA = "0x7712", Offset = "0x7712", VA = "0x7712")]
		private void MarketButtonClickedEventHandler()
		{
		/* --- GHIDRA: MarketButtonClickedEventHandler ---
		void Gameplay_Market_View_MarketArtukulInfoPopupWindow__MarketButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Inventory_View_Info_ArtikulInfoPopupWindow__OnShow(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025D5")]
		[Address(RVA = "0x7713", Offset = "0x7713", VA = "0x7713")]
		public MarketArtukulInfoPopupWindow()
		{
		}

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		public new const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/MarketArtikulInfoPopupWindow";

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _marketButton;
	}
}
