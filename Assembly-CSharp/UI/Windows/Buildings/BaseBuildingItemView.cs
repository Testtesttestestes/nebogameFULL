using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public abstract class BaseBuildingItemView : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023A")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000FCF")]
			[Address(RVA = "0x61E3", Offset = "0x61E3", VA = "0x61E3", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x61E4", Offset = "0x61E4", VA = "0x61E4", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		/* --- GHIDRA: <Awake>b__29_0 ---
		void UI_Windows_Buildings_BaseBuildingItemView___Awake_b__29_0(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x44);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x3c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023B")]
		public bool DiscountWidgetEnabled
		{
			[Token(Token = "0x6000FD1")]
			[Address(RVA = "0x61E5", Offset = "0x61E5", VA = "0x61E5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FD2")]
			[Address(RVA = "0x61E6", Offset = "0x61E6", VA = "0x61E6")]
			set
			{
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x00004548 File Offset: 0x00002748
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023C")]
		public uint BuildingTypeId
		{
			[Token(Token = "0x6000FD3")]
			[Address(RVA = "0x61E7", Offset = "0x61E7", VA = "0x61E7")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000FD4")]
			[Address(RVA = "0x61E8", Offset = "0x61E8", VA = "0x61E8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023D")]
		public Price Price
		{
			[Token(Token = "0x6000FD5")]
			[Address(RVA = "0x61E9", Offset = "0x61E9", VA = "0x61E9")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000FE RID: 254
		// (add) Token: 0x06000FD6 RID: 4054 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FD7 RID: 4055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FE")]
		public event Action<BaseBuildingData> ActionButtonClickedEvent
		{
			[Token(Token = "0x6000FD6")]
			[Address(RVA = "0x61EA", Offset = "0x61EA", VA = "0x61EA")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x61EB", Offset = "0x61EB", VA = "0x61EB")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000FF RID: 255
		// (add) Token: 0x06000FD8 RID: 4056 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000FF")]
		public event Action<BaseBuildingData> ClickedEvent
		{
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x61EC", Offset = "0x61EC", VA = "0x61EC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FD9")]
			[Address(RVA = "0x61ED", Offset = "0x61ED", VA = "0x61ED")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x61EE", Offset = "0x61EE", VA = "0x61EE")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Windows_Buildings_BaseBuildingItemView__Awake(int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4),0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x61EF", Offset = "0x61EF", VA = "0x61EF")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Windows_Buildings_BaseBuildingItemView__OnDestroy
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,param2,*(undefined4 *)(*param1 + 0xf4));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,param3,param4,*(undefined4 *)(*param1 + 0xfc));
		  param1_01 = param1[8];
		  param2_00 = 0x100;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[7],0);
		  iVar1 = func_ii_7305(param1_00,0);
		  if (iVar1 == 0) {
		    param2_00 = 0x200;
		  }
		  TMPro_TMP_Text__get_verticalAlignment(param1_01,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x61F0", Offset = "0x61F0", VA = "0x61F0")]
		public void SetData(BaseBuildingData userBuildingData, UserData ownerUserData, UserData ownUserData)
		{
		/* --- GHIDRA: SetData ---
		void UI_Windows_Buildings_BaseBuildingItemView__SetData(int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 in_register_20000024;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  float fVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  longlong lVar9;
		  int iVar10;
		  longlong param3_00;
		  
		  if (DAT_ram_00a58a81 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3695);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3694);
		    DAT_ram_00a58a81 = '\x01';
		  }
		  *(int **)(param1 + 0x3c) = param2;
		  piVar7 = *(int **)(param1 + 0x20);
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0xec));
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))(param2,uVar1);
		  iVar10 = *piVar7;
		  uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),uVar3);
		  uVar2 = CONCAT44(in_register_20000024,*(undefined4 *)(iVar10 + 0x2d4));
		  (**(code **)((ulonglong)*(uint *)(iVar10 + 0x2d0) * 4))(piVar7,uVar1,uVar2);
		  uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar8 = *(undefined4 *)(param1 + 0x24);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar4 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                    (*(undefined4 *)(param1 + 0x3c),0);
		  UI_Elements_Counters_CounterAutoHide___ctor(uVar8,uVar4,0);
		  uVar8 = *(undefined4 *)(param1 + 0x28);
		  iVar10 = **(int **)(param1 + 0x3c);
		  uVar1 = CONCAT44(uVar3,*(undefined4 *)(iVar10 + 0x114));
		  uVar4 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x110) * 4))(*(int **)(param1 + 0x3c),uVar1);
		  uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar8,uVar4,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar10 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                     (*(undefined4 *)(param1 + 0x3c),0);
		  if ((iVar10 != 0) && (iVar10 = func_ii_8742(*(undefined4 *)(param1 + 0x3c),0), iVar10 == 0)) {
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  iVar10 = func_ii_8742(*(undefined4 *)(param1 + 0x3c),0);
		  piVar7 = (int *)UI_Rewards_AbstractRewardsRender__SetRewards
		                            (*(undefined4 *)(param1 + 0x1c),
		                             Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___)
		  ;
		  if (iVar10 != 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = func_ii_7508(StringLiteral_3694,1,0,1,0,0,0,0);
		    uVar1 = CONCAT44(uVar3,uVar4);
		    (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		              (piVar7,uVar1,CONCAT44(uVar5,*(undefined4 *)(*piVar7 + 0x2d4)));
		    uVar3 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar5,1,0);
		    uVar5 = *(undefined4 *)(param1 + 0x14);
		    iVar10 = **(int **)(param1 + 0x3c);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x118) * 4))
		                      (*(int **)(param1 + 0x3c),CONCAT44(uVar3,*(undefined4 *)(iVar10 + 0x11c)));
		    fVar6 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x3c) + 0x14),0);
		    if (fVar6 < 1.8446744e+19 && 0.0 <= fVar6) {
		      lVar9 = (longlong)fVar6;
		    }
		    else {
		      lVar9 = 0;
		    }
		    if (ABS(fVar6) < 9.223372e+18) {
		      param3_00 = (longlong)fVar6;
		    }
		    else {
		      param3_00 = -0x8000000000000000;
		    }
		    if (0.0 <= fVar6) {
		      param3_00 = lVar9;
		    }
		    UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar5,uVar1,param3_00,0);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar4 = func_ii_7508(StringLiteral_3695,1,0,1,0,0,0,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar7 + 0x2d0) * 4))
		            (piVar7,CONCAT44(uVar3,uVar4),CONCAT44(uVar5,*(undefined4 *)(*piVar7 + 0x2d4)));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x61F1", Offset = "0x61F1", VA = "0x61F1", Slot = "6")]
		public virtual void UpdateView(BaseBuildingData userBuildingData)
		{
		}

		// Token: 0x06000FDE RID: 4062
		[Token(Token = "0x6000FDE")]
		protected abstract void HandleActionButton(UserData ownerUserData, UserData loggedUser);

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x61F2", Offset = "0x61F2", VA = "0x61F2")]
		protected BaseBuildingItemView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_BaseBuildingItemView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x3c),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ProgressBarWithTimer _upgradeProgress;

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Button _openBuildingButton;

		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected Button _actionButton;

		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected LevelCounter _levelCounter;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameRawImageLoader _miniature;

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected Price _price;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform _discountWidget;

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x34")]
		private bool _discountWidgetEnabled;

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x3C")]
		protected BaseBuildingData _buildingData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DiscountTargets ---
		void UI_Windows_Buildings_BaseBuildingItemView__get_DiscountTargets
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a7b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a58a7b = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__OrderBy_object__ulong_
		                    (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  if (uVar1 != *(byte *)(param1 + 0x34)) {
		    *(char *)(param1 + 0x34) = (char)uVar1;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x34),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountWidgetEnabled ---
		void UI_Windows_Buildings_BaseBuildingItemView__get_DiscountWidgetEnabled
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 != *(byte *)(param1 + 0x34)) {
		    *(char *)(param1 + 0x34) = (char)param2;
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(param1 + 0x30),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)*(byte *)(param1 + 0x34),0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Price ---
		void UI_Windows_Buildings_BaseBuildingItemView__get_Price
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a7c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a7c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ActionButtonClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView__add_ActionButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a7d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a7d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ActionButtonClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView__remove_ActionButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a7e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a7e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a7f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a7f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView__remove_ClickedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58a80 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_BaseBuildingItemView__Awake_b__29_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_BaseBuildingItemView__Awake_b__29_1__)
		    ;
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58a80 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Windows_Buildings_BaseBuildingItemView__Awake_b__29_0__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Windows_Buildings_BaseBuildingItemView__Awake_b__29_1__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
