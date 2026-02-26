using System;
using System.Collections.Generic;
using Gameplay.Craft.Controller;
using Gameplay.Craft.Events;
using Gameplay.Craft.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.ProgressBars;
using UI.Filters;
using UI.Tabs;
using UI.Toggle;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B8 RID: 2232
	[Token(Token = "0x20008B8")]
	public class CraftWindow : ClosableBaseWindow<CraftWindow.CraftWindowArgs>
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A64")]
		public override string WindowId
		{
			[Token(Token = "0x600346E")]
			[Address(RVA = "0x8498", Offset = "0x8498", VA = "0x8498", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x0600346F RID: 13423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A65")]
		public TabBar TabBar
		{
			[Token(Token = "0x600346F")]
			[Address(RVA = "0x8499", Offset = "0x8499", VA = "0x8499")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A66")]
		public CraftInfoBox InfoBox
		{
			[Token(Token = "0x6003470")]
			[Address(RVA = "0x849A", Offset = "0x849A", VA = "0x849A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003471 RID: 13425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A67")]
		public TextMeshProUGUI ProfessionLevelText
		{
			[Token(Token = "0x6003471")]
			[Address(RVA = "0x849B", Offset = "0x849B", VA = "0x849B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003472 RID: 13426 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A68")]
		public ProgressBarWithText ProgressBar
		{
			[Token(Token = "0x6003472")]
			[Address(RVA = "0x849C", Offset = "0x849C", VA = "0x849C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003473 RID: 13427 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A69")]
		public Button MaxLevelButton
		{
			[Token(Token = "0x6003473")]
			[Address(RVA = "0x849D", Offset = "0x849D", VA = "0x849D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003474 RID: 13428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6A")]
		public TextMeshProUGUI MaxLevelText
		{
			[Token(Token = "0x6003474")]
			[Address(RVA = "0x849E", Offset = "0x849E", VA = "0x849E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003475 RID: 13429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6B")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6003475")]
			[Address(RVA = "0x849F", Offset = "0x849F", VA = "0x849F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003476 RID: 13430 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6C")]
		public CraftWindowStates WindowStates
		{
			[Token(Token = "0x6003476")]
			[Address(RVA = "0x84A0", Offset = "0x84A0", VA = "0x84A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003477 RID: 13431 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6D")]
		public GreenToggle CompletedToggle
		{
			[Token(Token = "0x6003477")]
			[Address(RVA = "0x84A1", Offset = "0x84A1", VA = "0x84A1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003478 RID: 13432 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A6E")]
		public Button InChestButton
		{
			[Token(Token = "0x6003478")]
			[Address(RVA = "0x84A2", Offset = "0x84A2", VA = "0x84A2")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003479")]
		[Address(RVA = "0x84A3", Offset = "0x84A3", VA = "0x84A3")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Craft_View_CraftWindow__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57d05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs__OnShow__);
		    DAT_ram_00a57d05 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs__OnShow__);
		  iVar1 = *(int *)(param1 + 0x70);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + param2_00 * 4 + 0x10),0,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(iVar1 + 0xc));
		  }
		  Gameplay_Craft_View_CraftWindow__ScrollTo(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x0600347A RID: 13434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x84A4", Offset = "0x84A4", VA = "0x84A4", Slot = "22")]
		protected override void OnShow(CraftWindow.CraftWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Craft_View_CraftWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57d06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs__OnClose__);
		    DAT_ram_00a57d06 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs__OnClose__);
		  if (*(char *)(param1 + 0x84) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x7c);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x80);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x80),*(undefined4 *)(iVar2 + 0x134));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x74);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x74),*(undefined4 *)(iVar2 + 0xec));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x74) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x84A5", Offset = "0x84A5", VA = "0x84A5", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Craft_View_CraftWindow__OnClose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a57d07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__CraftRecipesViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Craft_View_CraftWindow___c__DisplayClass45_0__SetRecipes_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_View_CraftWindow___c__DisplayClass45_0_TypeInfo);
		    DAT_ram_00a57d07 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_Craft_View_CraftWindow___c__DisplayClass45_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x44),*(undefined4 *)(iVar1 + 0x3bc));
		  param1_01 = *(int **)(param1 + 0x44);
		  if ((char)param1_01[0x14] != '\0') {
		    Gameplay_Craft_View_CraftRecipesOSAView__RemoveItemsFrom
		              (param1_01,*(undefined4 *)(param2_00 + 0xc),param1_01);
		    return;
		  }
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param2_00,
		             Method_Gameplay_Craft_View_CraftWindow___c__DisplayClass45_0__SetRecipes_b__0__,0);
		  (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x298) * 4))
		            (param1_01,param1_00,*(undefined4 *)(*param1_01 + 0x29c));
		  return;
		}
		*/

		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x84A6", Offset = "0x84A6", VA = "0x84A6")]
		public void SetRecipes(IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		/* --- GHIDRA: SetRecipes ---
		undefined4
		Gameplay_Craft_View_CraftWindow__SetRecipes
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_Craft_View_CraftSlotListElement___ctor
		                    (*(undefined4 *)(param1 + 0x60),param2,param3,param1);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x84A7", Offset = "0x84A7", VA = "0x84A7")]
		public List<CraftSlotListElement> CreateManufactureSlots(IList<CraftSlotDic> dics, Action<CraftSlotListElement> selectCallback)
		{
		/* --- GHIDRA: CreateManufactureSlots ---
		void Gameplay_Craft_View_CraftWindow__CreateManufactureSlots
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57d08 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28672);
		    DAT_ram_00a57d08 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x68);
		  local_4 = param2;
		  uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		  local_8 = param3;
		  param3_00 = func_ii_1081(DAT_ram_00a66954,&local_8);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_28672,uVar1,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x84A8", Offset = "0x84A8", VA = "0x84A8")]
		public void SetCounter(int currentValue, int totalValue)
		{
		/* --- GHIDRA: SetCounter ---
		void Gameplay_Craft_View_CraftWindow__SetCounter(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x44);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x390) * 4))
		            (*(int **)(param1 + 0x44),param2,0,0,*(undefined4 *)(iVar1 + 0x394));
		  return;
		}
		*/

		}

		// Token: 0x0600347F RID: 13439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600347F")]
		[Address(RVA = "0x84A9", Offset = "0x84A9", VA = "0x84A9")]
		public void ScrollTo(int index)
		{
		/* --- GHIDRA: ScrollTo ---
		void Gameplay_Craft_View_CraftWindow__ScrollTo(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a57d09 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Events_CraftEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Model_CraftModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Craft_Controller_CraftViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57d09 = '\x01';
		  }
		  if (*(char *)(param1 + 0x84) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80e49ce8;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e49ce8:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    uVar4 = unnamed_function_1417(Gameplay_Craft_Model_CraftModel_TypeInfo);
		    Gameplay_Craft_Model_CraftModel__set_OriginTime(uVar4,uVar3,0);
		    *(undefined4 *)(param1 + 0x74) = uVar4;
		    uVar3 = unnamed_function_1417(Gameplay_Craft_Events_CraftEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x78) = uVar3;
		    uVar7 = *(undefined4 *)(param1 + 0x74);
		    uVar4 = unnamed_function_1417(Gameplay_Craft_Controller_CraftController_TypeInfo);
		    Gameplay_Craft_Events_CraftEvents___ctor(uVar4,uVar7,uVar3,0);
		    *(undefined4 *)(param1 + 0x7c) = uVar4;
		    uVar3 = *(undefined4 *)(param1 + 0x74);
		    uVar7 = *(undefined4 *)(param1 + 0x78);
		    piVar5 = (int *)unnamed_function_1417(Gameplay_Craft_Controller_CraftViewMediator_TypeInfo);
		    Gameplay_Craft_Controller_CraftController___c__DisplayClass4_0___TakeArtifacts_b__0
		              (piVar5,uVar3,uVar7,uVar4,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		              (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		    *(int **)(param1 + 0x80) = piVar5;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x7c),0);
		    *(undefined1 *)(param1 + 0x84) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003480")]
		[Address(RVA = "0x84AA", Offset = "0x84AA", VA = "0x84AA")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Craft_View_CraftWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (*(char *)(param1 + 0x84) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x7c);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x80);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x80),*(undefined4 *)(iVar2 + 0x134));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x74);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x74),*(undefined4 *)(iVar2 + 0xec));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x74) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003481 RID: 13441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003481")]
		[Address(RVA = "0x84AB", Offset = "0x84AB", VA = "0x84AB")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Craft_View_CraftWindow__DestroyMVC(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d0a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs___ctor__);
		    DAT_ram_00a57d0a = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_CraftWindow_CraftWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003482 RID: 13442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003482")]
		[Address(RVA = "0x84AC", Offset = "0x84AC", VA = "0x84AC")]
		public CraftWindow()
		{
		}

		// Token: 0x04001CA4 RID: 7332
		[Token(Token = "0x4001CA4")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Craft/CraftWindow";

		// Token: 0x04001CA5 RID: 7333
		[Token(Token = "0x4001CA5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private CraftWindowStates _windowStates;

		// Token: 0x04001CA6 RID: 7334
		[Token(Token = "0x4001CA6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TabBar _tabBarView;

		// Token: 0x04001CA7 RID: 7335
		[Token(Token = "0x4001CA7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private CraftRecipesOSAView _oSAView;

		// Token: 0x04001CA8 RID: 7336
		[Token(Token = "0x4001CA8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x04001CA9 RID: 7337
		[Token(Token = "0x4001CA9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CraftInfoBox _infoBox;

		// Token: 0x04001CAA RID: 7338
		[Token(Token = "0x4001CAA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI _professionLevelText;

		// Token: 0x04001CAB RID: 7339
		[Token(Token = "0x4001CAB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private ProgressBarWithText _progressBar;

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _maxLevelButton;

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private TextMeshProUGUI _maxLevelText;

		// Token: 0x04001CAE RID: 7342
		[Token(Token = "0x4001CAE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CraftSlotsView _craftSlots;

		// Token: 0x04001CAF RID: 7343
		[Token(Token = "0x4001CAF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private GreenToggle _completedToggle;

		// Token: 0x04001CB0 RID: 7344
		[Token(Token = "0x4001CB0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TextMeshProUGUI _craftSlotsCounterText;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Button _inChestButton;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject[] _enableOnInit;

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[FieldOffset(Offset = "0x74")]
		private CraftModel _model;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		[FieldOffset(Offset = "0x78")]
		private CraftEvents _events;

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[FieldOffset(Offset = "0x7C")]
		private CraftController _controller;

		// Token: 0x04001CB6 RID: 7350
		[Token(Token = "0x4001CB6")]
		[FieldOffset(Offset = "0x80")]
		private CraftViewMediator _mediator;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[FieldOffset(Offset = "0x84")]
		private bool _mvcSetUp;

		// Token: 0x020008B9 RID: 2233
		[Token(Token = "0x20008B9")]
		public class CraftWindowArgs : BaseWindowArgs
		{
			// Token: 0x06003483 RID: 13443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003483")]
			[Address(RVA = "0x84AD", Offset = "0x84AD", VA = "0x84AD")]
			public CraftWindowArgs()
			{
			}

			// Token: 0x04001CB8 RID: 7352
			[Token(Token = "0x4001CB8")]
			[FieldOffset(Offset = "0x18")]
			public uint SchemeId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_InChestButton ---
		void Gameplay_Craft_View_CraftWindow__get_InChestButton(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x70);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

}
