using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Discounts.Model;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.Counters;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	public abstract class BaseBuildingItemView2 : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700023E")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x61F5", Offset = "0x61F5", VA = "0x61F5", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x61F6", Offset = "0x61F6", VA = "0x61F6", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00004560 File Offset: 0x00002760
		// (set) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023F")]
		public bool DiscountWidgetEnabled
		{
			[Token(Token = "0x6000FE4")]
			[Address(RVA = "0x61F7", Offset = "0x61F7", VA = "0x61F7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FE5")]
			[Address(RVA = "0x61F8", Offset = "0x61F8", VA = "0x61F8")]
			set
			{
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x06000FE7 RID: 4071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000240")]
		public uint BuildingTypeId
		{
			[Token(Token = "0x6000FE6")]
			[Address(RVA = "0x61F9", Offset = "0x61F9", VA = "0x61F9")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000FE7")]
			[Address(RVA = "0x61FA", Offset = "0x61FA", VA = "0x61FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000100 RID: 256
		// (add) Token: 0x06000FE8 RID: 4072 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FE9 RID: 4073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000100")]
		public event Action<BaseBuildingData> ActionButtonClickedEvent
		{
			[Token(Token = "0x6000FE8")]
			[Address(RVA = "0x61FB", Offset = "0x61FB", VA = "0x61FB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FE9")]
			[Address(RVA = "0x61FC", Offset = "0x61FC", VA = "0x61FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000101 RID: 257
		// (add) Token: 0x06000FEA RID: 4074 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000FEB RID: 4075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000101")]
		public event Action<BaseBuildingData> ClickedEvent
		{
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x61FD", Offset = "0x61FD", VA = "0x61FD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x61FE", Offset = "0x61FE", VA = "0x61FE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEC")]
		[Address(RVA = "0x61FF", Offset = "0x61FF", VA = "0x61FF")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Windows_Buildings_BaseBuildingItemView2__Start(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58a88 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingItemView2_ActionButtonClickedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_BaseBuildingItemView2_OpenBuilding__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58a88 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_Buildings_BaseBuildingItemView2_ActionButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Windows_Buildings_BaseBuildingItemView2_OpenBuilding__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x6200", Offset = "0x6200", VA = "0x6200")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Windows_Buildings_BaseBuildingItemView2__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x34),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x6201", Offset = "0x6201", VA = "0x6201")]
		private void OpenBuilding()
		{
		/* --- GHIDRA: OpenBuilding ---
		void UI_Windows_Buildings_BaseBuildingItemView2__OpenBuilding(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x3c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x34),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x6202", Offset = "0x6202", VA = "0x6202")]
		private void ActionButtonClickedEventHandler()
		{
		/* --- GHIDRA: ActionButtonClickedEventHandler ---
		void UI_Windows_Buildings_BaseBuildingItemView2__ActionButtonClickedEventHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int param1_01;
		  undefined4 param2_00;
		  
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,param2,param3,param4,*(undefined4 *)(*param1 + 0xf4));
		  param1_01 = param1[7];
		  param2_00 = 0x100;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1[10],0);
		  iVar1 = func_ii_7305(param1_00,0);
		  if (iVar1 == 0) {
		    param2_00 = 0x200;
		  }
		  TMPro_TMP_Text__get_verticalAlignment(param1_01,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x6203", Offset = "0x6203", VA = "0x6203")]
		public void Init(BaseBuildingData userBuildingData, UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: Init ---
		void UI_Windows_Buildings_BaseBuildingItemView2__Init
		               (int *param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  int *piVar2;
		  undefined4 *puVar3;
		  uint *puVar4;
		  float param2_01;
		  int iVar5;
		  int iVar6;
		  
		  param1[0xd] = (int)param2;
		  piVar2 = (int *)param1[7];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe8) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xec));
		  iVar5 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar5 + 0x2d4));
		  iVar5 = param1[8];
		  uVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1[0xd],0);
		  UI_Elements_Counters_CounterAutoHide___ctor(iVar5,uVar1,0);
		  iVar5 = param1[9];
		  iVar6 = *(int *)param1[0xd];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    ((int *)param1[0xd],*(undefined4 *)(iVar6 + 0x114));
		  AssetContent_GameImage__get_AssetId(iVar5,uVar1,0);
		  iVar5 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1[0xd],0);
		  param2_01 = 0.0;
		  if (iVar5 == 0) {
		    param2_01 = 1.0;
		  }
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (param1[9],param2_01,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[5],0);
		  param2_00 = func_ii_8742(param1[0xd],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  iVar5 = func_ii_8742(param1[0xd],0);
		  if (iVar5 == 0) {
		    iVar5 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param1[0xd],0);
		    if (iVar5 == 0) {
		      puVar3 = (undefined4 *)(*param1 + 0x10c);
		      puVar4 = (uint *)(*param1 + 0x108);
		    }
		    else {
		      iVar5 = *(int *)param1[0xd];
		      iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x120) * 4))
		                        ((int *)param1[0xd],*(undefined4 *)(iVar5 + 0x124));
		      iVar6 = *param1;
		      if (iVar5 == 0) {
		        puVar3 = (undefined4 *)(iVar6 + 0xfc);
		        puVar4 = (uint *)(iVar6 + 0xf8);
		      }
		      else {
		        puVar3 = (undefined4 *)(iVar6 + 0x104);
		        puVar4 = (uint *)(iVar6 + 0x100);
		      }
		    }
		  }
		  else {
		    puVar3 = (undefined4 *)(*param1 + 0x114);
		    puVar4 = (uint *)(*param1 + 0x110);
		  }
		  (**(code **)((ulonglong)*puVar4 * 4))(param1,param3,param4,*puVar3);
		  return;
		}
		*/

		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x6204", Offset = "0x6204", VA = "0x6204", Slot = "6")]
		public virtual void UpdateView(BaseBuildingData userBuildingData, UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: UpdateView ---
		void UI_Windows_Buildings_BaseBuildingItemView2__UpdateView
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58a89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58a89 = '\x01';
		  }
		  UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		            (*(undefined4 *)(param1 + 0x28),2,
		             Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 == param3),0);
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x1c) + 0xb8);
		  iVar2 = **(int **)(param1 + 0x34);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		                    (*(int **)(param1 + 0x34),*(undefined4 *)(iVar2 + 0x13c));
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(param1_00,param3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x6205", Offset = "0x6205", VA = "0x6205", Slot = "7")]
		protected virtual void HandleMidLevelState(UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: HandleMidLevelState ---
		void UI_Windows_Buildings_BaseBuildingItemView2__HandleMidLevelState
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x6206", Offset = "0x6206", VA = "0x6206", Slot = "8")]
		protected virtual void HandleMaxLevelState(UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: HandleMaxLevelState ---
		void UI_Windows_Buildings_BaseBuildingItemView2__HandleMaxLevelState
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a58a8a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58a8a = '\x01';
		  }
		  UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		            (*(undefined4 *)(param1 + 0x28),1,
		             Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(param2 == param3),0);
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x1c) + 0xb8);
		  iVar2 = **(int **)(param1 + 0x34);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x138) * 4))
		                    (*(int **)(param1 + 0x34),*(undefined4 *)(iVar2 + 0x13c));
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(param1_00,param3,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x6207", Offset = "0x6207", VA = "0x6207", Slot = "9")]
		protected virtual void HandleZeroLevelState(UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: HandleZeroLevelState ---
		void UI_Windows_Buildings_BaseBuildingItemView2__HandleZeroLevelState
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 param2_00;
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  float fVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  int iVar4;
		  longlong param3_00;
		  
		  if (DAT_ram_00a58a8b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a58a8b = '\x01';
		  }
		  UI_Elements_ImageWithStates_Int32Enum___get_CurrentState
		            (*(undefined4 *)(param1 + 0x28),3,
		             Method_UI_Elements_ImageWithStates_BuildButtonWithStates_State__set_CurrentState__);
		  param1_00 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x1c) + 0xb8);
		  uVar1 = Gameplay_World_Model_BaseBuildingData__GetUpgradeRequirementsProvider
		                    (*(undefined4 *)(param1 + 0x34),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(param1_00,param3,uVar1,0);
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  iVar4 = **(int **)(param1 + 0x34);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x118) * 4))
		                        (*(int **)(param1 + 0x34),
		                         CONCAT44(in_register_20000014,*(undefined4 *)(iVar4 + 0x11c)));
		  fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x34) + 0x14),0);
		  if (fVar2 < 1.8446744e+19 && 0.0 <= fVar2) {
		    lVar3 = (longlong)fVar2;
		  }
		  else {
		    lVar3 = 0;
		  }
		  if (ABS(fVar2) < 9.223372e+18) {
		    param3_00 = (longlong)fVar2;
		  }
		  else {
		    param3_00 = -0x8000000000000000;
		  }
		  if (0.0 <= fVar2) {
		    param3_00 = lVar3;
		  }
		  UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar1,param2_00,param3_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x6208", Offset = "0x6208", VA = "0x6208", Slot = "10")]
		protected virtual void HandleUpgradingState(UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x6209", Offset = "0x6209", VA = "0x6209")]
		protected BaseBuildingItemView2()
		{
		}

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected ProgressBarWithTimer _upgradeProgress;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Button _openBuildingButton;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected TextMeshProUGUI _title;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected LevelCounter _levelCounter;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected GameImage _miniature;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected BuildButtonWithStates _actionButton;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected GameObject _discountWidget;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x30")]
		private bool _discountWidgetEnabled;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x34")]
		protected BaseBuildingData _buildingData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DiscountTargets ---
		void UI_Windows_Buildings_BaseBuildingItemView2__get_DiscountTargets
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint param2_00;
		  
		  if (DAT_ram_00a58a82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		    DAT_ram_00a58a82 = '\x01';
		  }
		  param2_00 = System_Linq_Enumerable__OrderBy_object__ulong_
		                        (param2,Method_System_Linq_Enumerable_Any_IDiscountArgs___);
		  if (param2_00 != *(byte *)(param1 + 0x30)) {
		    *(char *)(param1 + 0x30) = (char)param2_00;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x2c),param2_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_DiscountWidgetEnabled ---
		void UI_Windows_Buildings_BaseBuildingItemView2__get_DiscountWidgetEnabled
		               (int param1,uint param2,undefined4 param3)
		
		{
		  if (param2 != *(byte *)(param1 + 0x30)) {
		    *(char *)(param1 + 0x30) = (char)param2;
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x2c),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_BuildingTypeId ---
		void UI_Windows_Buildings_BaseBuildingItemView2__set_BuildingTypeId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a83 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a83 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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
		void UI_Windows_Buildings_BaseBuildingItemView2__add_ActionButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a84 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a84 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BaseBuildingData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BaseBuildingData__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x3c,iVar2,param1_00);
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
		void UI_Windows_Buildings_BaseBuildingItemView2__remove_ActionButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a85 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a85 = '\x01';
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


		/* --- GHIDRA: add_ClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView2__add_ClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a86 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BaseBuildingData__TypeInfo);
		    DAT_ram_00a58a86 = '\x01';
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


		/* --- GHIDRA: remove_ClickedEvent ---
		void UI_Windows_Buildings_BaseBuildingItemView2__remove_ClickedEvent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58a87 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_Buildings_BaseBuildingItemView2_ActionButtonClickedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_Buildings_BaseBuildingItemView2_OpenBuilding__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58a87 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x28) + 0x1c) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_UI_Windows_Buildings_BaseBuildingItemView2_ActionButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_UI_Windows_Buildings_BaseBuildingItemView2_OpenBuilding__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
