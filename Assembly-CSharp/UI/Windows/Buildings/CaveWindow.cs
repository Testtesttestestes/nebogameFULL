using System;
using System.Collections.Generic;
using AssetContent;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Gameplay.Cave;
using Gameplay.Cave.Controller;
using Gameplay.Horde.View;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UI.Wiki;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002B0 RID: 688
	[Token(Token = "0x20002B0")]
	public class CaveWindow : BaseBuildingWindow<CaveWindowArgs>
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001023 RID: 4131 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024E")]
		public override string WindowId
		{
			[Token(Token = "0x6001023")]
			[Address(RVA = "0x622D", Offset = "0x622D", VA = "0x622D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700024F")]
		public Button SearchButton
		{
			[Token(Token = "0x6001024")]
			[Address(RVA = "0x622E", Offset = "0x622E", VA = "0x622E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001025 RID: 4133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000250")]
		public Button ChestButton
		{
			[Token(Token = "0x6001025")]
			[Address(RVA = "0x622F", Offset = "0x622F", VA = "0x622F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000251")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x6001026")]
			[Address(RVA = "0x6230", Offset = "0x6230", VA = "0x6230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001027 RID: 4135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000252")]
		public MonsterInfoView MonsterInfoView
		{
			[Token(Token = "0x6001027")]
			[Address(RVA = "0x6231", Offset = "0x6231", VA = "0x6231")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000253")]
		public HordeView HordeView
		{
			[Token(Token = "0x6001028")]
			[Address(RVA = "0x6232", Offset = "0x6232", VA = "0x6232")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001029 RID: 4137 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600102A RID: 4138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000254")]
		public string ResourceImageAssetId
		{
			[Token(Token = "0x6001029")]
			[Address(RVA = "0x6233", Offset = "0x6233", VA = "0x6233")]
			get
			{
				return null;
			}
			[Token(Token = "0x600102A")]
			[Address(RVA = "0x6234", Offset = "0x6234", VA = "0x6234")]
			set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000255")]
		public string ResourceText
		{
			[Token(Token = "0x600102B")]
			[Address(RVA = "0x6235", Offset = "0x6235", VA = "0x6235")]
			get
			{
				return null;
			}
			[Token(Token = "0x600102C")]
			[Address(RVA = "0x6236", Offset = "0x6236", VA = "0x6236")]
			set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000256")]
		public int ResourceAmount
		{
			[Token(Token = "0x600102D")]
			[Address(RVA = "0x6237", Offset = "0x6237", VA = "0x6237")]
			set
			{
			}
		}

		// Token: 0x17000257 RID: 599
		// (set) Token: 0x0600102E RID: 4142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		public bool Active
		{
			[Token(Token = "0x600102E")]
			[Address(RVA = "0x6238", Offset = "0x6238", VA = "0x6238")]
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000258")]
		public Price SearchPrice
		{
			[Token(Token = "0x600102F")]
			[Address(RVA = "0x6239", Offset = "0x6239", VA = "0x6239")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001030")]
		[Address(RVA = "0x623A", Offset = "0x623A", VA = "0x623A", Slot = "22")]
		protected override void OnShow(CaveWindowArgs args)
		{
		/* --- GHIDRA: <set_ResourceImageAssetId>b__27_0 ---
		void UI_Windows_Buildings_CaveWindow___set_ResourceImageAssetId_b__27_0
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x6c) = 0;
		  return;
		}
		*/

		/* --- GHIDRA: OnShow ---
		void UI_Windows_Buildings_CaveWindow__OnShow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58aa3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_CaveModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_Controller_CaveWindowMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58aa3 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_Cave_CaveEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x70) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80f6e984;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f6e984:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x220);
		        goto code_r0x80f6ea36;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80f6ea36:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Cave_CaveModel_TypeInfo);
		  Gameplay_Cave_CaveModel__Dispose(uVar4,uVar2,uVar7,0);
		  *(undefined4 *)(param1 + 0x74) = uVar4;
		  uVar7 = *(undefined4 *)(param1 + 0x70);
		  uVar2 = unnamed_function_1417(Gameplay_Cave_CaveController_TypeInfo);
		  Gameplay_Chat_Control_ChatViewMediator___HandleMessageDeleteRequestEvent_b__31_0
		            (uVar2,uVar4,uVar7,0);
		  *(undefined4 *)(param1 + 0x78) = uVar2;
		  uVar4 = *(undefined4 *)(param1 + 0x74);
		  uVar7 = *(undefined4 *)(param1 + 0x70);
		  piVar5 = (int *)unnamed_function_1417(Gameplay_Cave_Controller_CaveWindowMediator_TypeInfo);
		  Gameplay_Cave_CaveModel_MonsterInCave___ctor(piVar5,uVar4,uVar7,uVar2,0);
		  *(int **)(param1 + 0x7c) = piVar5;
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x78),0);
		  return;
		}
		*/

		}

		// Token: 0x06001031 RID: 4145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001031")]
		[Address(RVA = "0x623B", Offset = "0x623B", VA = "0x623B")]
		private void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		void UI_Windows_Buildings_CaveWindow__InitMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0x134));
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Cave_ResourceRewardBehaviour___ctor(*(undefined4 *)(param1 + 0x70),0);
		  *(undefined8 *)(param1 + 0x78) = 0;
		  *(undefined8 *)(param1 + 0x70) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001032")]
		[Address(RVA = "0x623C", Offset = "0x623C", VA = "0x623C")]
		private void DeinitMVC()
		{
		/* --- GHIDRA: DeinitMVC ---
		void UI_Windows_Buildings_CaveWindow__DeinitMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58aa4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs__UserIsle__OnClose__);
		    DAT_ram_00a58aa4 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs__UserIsle__OnClose__);
		  if (*(int *)(param1 + 0x6c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x6c),0,0);
		  }
		  *(undefined4 *)(param1 + 0x6c) = 0;
		  iVar1 = **(int **)(param1 + 0x7c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x7c),*(undefined4 *)(iVar1 + 0x134));
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x78),0);
		  Gameplay_Cave_ResourceRewardBehaviour___ctor(*(undefined4 *)(param1 + 0x70),0);
		  *(undefined8 *)(param1 + 0x78) = 0;
		  *(undefined8 *)(param1 + 0x70) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001033 RID: 4147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001033")]
		[Address(RVA = "0x623D", Offset = "0x623D", VA = "0x623D", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		undefined4 UI_Windows_Buildings_CaveWindow__OnClose(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 100),0);
		  iVar1 = func_ii_7305(param1_00,0);
		  if (iVar1 == 0) {
		    return 1;
		  }
		  return (uint)(*(char *)(*(int *)(param1 + 100) + 0x3d) != '\0');
		}
		*/

		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6001034")]
		[Address(RVA = "0x623E", Offset = "0x623E", VA = "0x623E", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void UI_Windows_Buildings_CaveWindow__CheckForClose(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58aa5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs___ctor__);
		    DAT_ram_00a58aa5 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object____Il2CppFullySharedGenericType___OnShow
		            (param1,Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs___ctor__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001035")]
		[Address(RVA = "0x623F", Offset = "0x623F", VA = "0x623F")]
		public CaveWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_CaveWindow___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58aa6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_CaveWindow__set_ResourceImageAssetId_b__27_1__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DG_Tweening_TweenExtensions_Play_TweenerCore_Color__Color__ColorOptions____);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a58aa6 = '\x01';
		  }
		  uVar1 = Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic
		                    (*(undefined4 *)(param1 + 0x4c),1.0,0.3,0);
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_UI_Windows_Buildings_CaveWindow__set_ResourceImageAssetId_b__27_1__,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar1,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		                    );
		  uVar1 = DG_Tweening_TweenExtensions__Pause_object_
		                    (uVar1,
		                     Method_DG_Tweening_TweenExtensions_Play_TweenerCore_Color__Color__ColorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/CavePopupWindow";

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _tip;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _searchButton;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Price _searchPrice;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImage _resouceImage;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _resourceAmountBG;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _resourceAmount;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _chestButton;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private List<RectTransform> _windowComponents;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MonsterInfoView _monsterInfoView;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private HordeView _hordeView;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private WikiUriRouter _wiki;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x6C")]
		private TweenerCore<Color, Color, ColorOptions> _tweenerCore;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x70")]
		private CaveEvents _events;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x74")]
		private CaveModel _model;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x78")]
		private CaveController _controller;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x7C")]
		private CaveWindowMediator _caveViewMediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_HordeView ---
		undefined4 UI_Windows_Buildings_CaveWindow__get_HordeView(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = AssetContent_GameImage___ctor(*(undefined4 *)(param1 + 0x4c),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ResourceImageAssetId ---
		void UI_Windows_Buildings_CaveWindow__get_ResourceImageAssetId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58aa0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_CaveWindow__set_ResourceImageAssetId_b__27_0__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DG_Tweening_TweenExtensions_Play_TweenerCore_Color__Color__ColorOptions____);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		              );
		    DAT_ram_00a58aa0 = '\x01';
		  }
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(*(undefined4 *)(param1 + 0x4c),param2,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 != 0),0);
		  if (*(int *)(param1 + 0x6c) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x6c),0,0);
		  }
		  uVar1 = Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic
		                    (*(undefined4 *)(param1 + 0x4c),0.0,0.3,0);
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param1,
		             Method_UI_Windows_Buildings_CaveWindow__set_ResourceImageAssetId_b__27_0__,0);
		  uVar1 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar1,param1_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Color__Color__ColorOptions____
		                    );
		  uVar1 = DG_Tweening_TweenExtensions__Pause_object_
		                    (uVar1,
		                     Method_DG_Tweening_TweenExtensions_Play_TweenerCore_Color__Color__ColorOptions____
		                    );
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: set_ResourceImageAssetId ---
		undefined4 UI_Windows_Buildings_CaveWindow__set_ResourceImageAssetId(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x40);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x40),*(undefined4 *)(iVar2 + 0x2cc));
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ResourceText ---
		void UI_Windows_Buildings_CaveWindow__get_ResourceText
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  uint uVar1;
		  int iVar2;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		  uVar1 = func_ii_4769(param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,uVar1 ^ 1,0);
		  iVar2 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x40),param2,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_ResourceText ---
		void UI_Windows_Buildings_CaveWindow__set_ResourceText(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  local_4 = param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < param2),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < param2),0);
		  piVar2 = *(int **)(param1 + 0x54);
		  uVar1 = func_ii_4443(&local_4,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_ResourceAmount ---
		void UI_Windows_Buildings_CaveWindow__set_ResourceAmount
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int param1_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a58aa1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Item__);
		    DAT_ram_00a58aa1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    do {
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,param2_00,
		                         Method_System_Collections_Generic_List_RectTransform__get_Item__);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,param2,0);
		      param2_00 = param2_00 + 1;
		      param1_00 = *(int *)(param1 + 0x5c);
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_SearchPrice ---
		void UI_Windows_Buildings_CaveWindow__get_SearchPrice(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a58aa2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs__UserIsle__OnShow__);
		    DAT_ram_00a58aa2 = '\x01';
		  }
		  UI_Windows_Buildings_BaseBuildingWindow_object__object___OnClose
		            (param1,param2,
		             Method_UI_Windows_Buildings_BaseBuildingWindow_CaveWindowArgs__UserIsle__OnShow__);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x60),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  if (DAT_ram_00a58aa1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RectTransform__get_Item__);
		    DAT_ram_00a58aa1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    param2 = 0;
		    do {
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (param1_00,param2,
		                         Method_System_Collections_Generic_List_RectTransform__get_Item__);
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,0,0);
		      param2 = param2 + 1;
		      param1_00 = *(int *)(param1 + 0x5c);
		    } while (param2 < *(int *)(param1_00 + 0xc));
		  }
		  UI_Windows_Buildings_CaveWindow__OnShow(param1,param2);
		  return;
		}
		*/

}
