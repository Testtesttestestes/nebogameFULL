using System;
using Gameplay.Isles.User;
using Gameplay.TradeAndCraft.Events;
using Gameplay.TradeAndCraft.Model;
using Gameplay.TradeAndCraft.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.TradeAndCraft.Controller
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	public class TradeOptionsViewMediator : AbstractViewMediator<TradeAndCraftModel, TradeAndCraftEvents, TradeAndCraftController, TradeOptionsWindow>
	{
		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x6D77", Offset = "0x6D77", VA = "0x6D77")]
		public TradeOptionsViewMediator(TradeAndCraftModel model, TradeAndCraftEvents events, TradeAndCraftController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a584dc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__TradeOptionsWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AccountsButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AuchanButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MarketButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MyShopButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a584dc = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AuchanButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AccountsButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MarketButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x48);
		    uVar1 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MyShopButtonClickedEventHandler__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingItemView__add_ClickedEvent(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AuchanButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x40) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_AccountsButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x44) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MarketButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x48);
		    uVar1 = unnamed_function_1417(System_Action_BaseBuildingData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar1,param1,
		               Method_Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator_MyShopButtonClickedEventHandler__
		               ,0);
		    UI_Windows_Buildings_BaseBuildingItemView__remove_ActionButtonClickedEvent(uVar3,uVar1,0);
		    Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__set_View(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x170004EB RID: 1259
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004EB")]
		public override TradeOptionsWindow View
		{
			[Token(Token = "0x6001BF9")]
			[Address(RVA = "0x6D78", Offset = "0x6D78", VA = "0x6D78", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x6D79", Offset = "0x6D79", VA = "0x6D79")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a584de == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584de = '\x01';
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
		        goto code_r0x80efa0b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80efa0b8:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowBank(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x6D7A", Offset = "0x6D7A", VA = "0x6D7A")]
		private void AuchanButtonClickedEventHandler()
		{
		/* --- GHIDRA: AuchanButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__AuchanButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a584df == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584df = '\x01';
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
		        goto code_r0x80efa18c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80efa18c:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowDiscountsWindow
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x6D7B", Offset = "0x6D7B", VA = "0x6D7B")]
		private void AccountsButtonClickedEventHandler()
		{
		/* --- GHIDRA: AccountsButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__AccountsButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a584e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a584e0 = '\x01';
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
		        goto code_r0x80efa260;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80efa260:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowClanIsleBuildings
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x6D7C", Offset = "0x6D7C", VA = "0x6D7C")]
		private void MarketButtonClickedEventHandler()
		{
		/* --- GHIDRA: MarketButtonClickedEventHandler ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__MarketButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = *(int **)(param1 + 0x18);
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x11c));
		  return;
		}
		*/

		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x6D7D", Offset = "0x6D7D", VA = "0x6D7D")]
		private void MyShopButtonClickedEventHandler(BaseBuildingData data)
		{
		}

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x18")]
		private UserIsle _myIsle;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_TradeAndCraft_Controller_TradeOptionsViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a584dd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TradeAndCraftModel__TradeAndCraftEvents__TradeAndCraftController__TradeOptionsWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountHandler_TypeInfo);
		    DAT_ram_00a584dd = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(*(int *)(param1[6] + 0x10) + 0x24),3,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  if ((iVar2 != 0) &&
		     (iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0), iVar2 != 0))
		  {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar2 + 0x48),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = **(int **)(iVar2 + 0x48);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		              (*(int **)(iVar2 + 0x48),local_4,*(undefined4 *)(iVar5 + 0xf4));
		    param1_00 = *(int **)(param1[2] + 0xc);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(iVar2 + 0x48);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_Discounts_Model_IDiscountHandler_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80ef9fe6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Discounts_Model_IDiscountHandler_TypeInfo,0);
		code_r0x80ef9fe6:
		    (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  }
		  return;
		}
		*/

}
