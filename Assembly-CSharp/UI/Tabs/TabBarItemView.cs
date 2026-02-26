using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Tabs
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class TabBarItemView : MonoBehaviourWithStates<TabBarItemData.State>, IPointerClickHandler, IEventSystemHandler, ITabBarItemView
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x5DFD", Offset = "0x5DFD", VA = "0x5DFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DE")]
		public event Action<TabBarItemData> SelectEvent
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x5DFE", Offset = "0x5DFE", VA = "0x5DFE", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x5DFF", Offset = "0x5DFF", VA = "0x5DFF", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public TabBarItemData Data
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x5E00", Offset = "0x5E00", VA = "0x5E00", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x5E01", Offset = "0x5E01", VA = "0x5E01", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x5E02", Offset = "0x5E02", VA = "0x5E02", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x5E03", Offset = "0x5E03", VA = "0x5E03")]
		private void HandleDataChanged(TabBarItemData from, TabBarItemData to)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_Tabs_TabBarItemView__HandleDataChanged(int param1,int param2,undefined4 param3)
		
		{
		  uint param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a599dc == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a599dc = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x44);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  param2_00 = 0;
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    iVar1 = UnityEngine_InputSystem_Users_InputUser__UnpairDevices(uVar2,0);
		    if ((iVar1 != 0) && (*(char *)(param2 + 0x1c) != '\0')) {
		      param2_00 = (uint)(*(char *)(param1 + 0x54) == '\0');
		    }
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x44),param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x5E04", Offset = "0x5E04", VA = "0x5E04")]
		private void HandleAnimation(TabBarItemData data)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5E05", Offset = "0x5E05", VA = "0x5E05")]
		private void HandleOnCountChangedEvent(int count)
		{
		/* --- GHIDRA: HandleOnCountChangedEvent ---
		void UI_Tabs_TabBarItemView__HandleOnCountChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(param1 + 0x40),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x5E06", Offset = "0x5E06", VA = "0x5E06", Slot = "13")]
		protected virtual void DisplayCount(int count)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public bool Selected
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x5E07", Offset = "0x5E07", VA = "0x5E07", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x5E08", Offset = "0x5E08", VA = "0x5E08", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x5E09", Offset = "0x5E09", VA = "0x5E09", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void UI_Tabs_TabBarItemView__OnPointerClick(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param1 + 0x50);
		  *(undefined4 *)(param1 + 0x50) = 0;
		  UI_Tabs_TabBarItemView__get_GameObject(param1,param2_00,0,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x5E0A", Offset = "0x5E0A", VA = "0x5E0A")]
		public void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Tabs_TabBarItemView__OnDestroy(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a599dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_TabBarItemData_State___ctor__);
		    DAT_ram_00a599dd = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_TabBarItemData_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x5E0B", Offset = "0x5E0B", VA = "0x5E0B")]
		public TabBarItemView()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Tabs_TabBarItemView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a599e0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Sorting_SortControlOptionView_OnValueChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a599e0 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_UI_Sorting_SortControlOptionView_OnValueChangedEventHandler__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _fontColorSelected;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _fontColorDefault;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _animation;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x50")]
		private TabBarItemData _data;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x54")]
		private bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GuideTarget ---
		void UI_Tabs_TabBarItemView__get_GuideTarget(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    DAT_ram_00a599d9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_TabBarItemData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TabBarItemData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: add_SelectEvent ---
		void UI_Tabs_TabBarItemView__add_SelectEvent(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a599da == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TabBarItemData__TypeInfo);
		    DAT_ram_00a599da = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_TabBarItemData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_TabBarItemData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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


		/* --- GHIDRA: get_Data ---
		void UI_Tabs_TabBarItemView__get_Data(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = *(undefined4 *)(param1 + 0x50);
		  *(undefined4 *)(param1 + 0x50) = param2;
		  UI_Tabs_TabBarItemView__get_GameObject(param1,param2_00,param2,param1);
		  return;
		}
		*/


		/* --- GHIDRA: get_GameObject ---
		void UI_Tabs_TabBarItemView__get_GameObject(int *param1,int param2,int param3,undefined4 param4)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int *piVar9;
		  
		  if (DAT_ram_00a599db == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    Mono_Security_ASN1__get_Item(&long___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_TabBarItemData_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemView_HandleOnCountChangedEvent__);
		    DAT_ram_00a599db = '\x01';
		  }
		  if (param3 != 0) {
		    iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0x10],0);
		    if (iVar6 != 0) {
		      uVar7 = unnamed_function_1417(System_Action_int__TypeInfo);
		      System_Action_short___Invoke
		                (uVar7,param1,Method_UI_Tabs_TabBarItemView_HandleOnCountChangedEvent__,0);
		      if (DAT_ram_00a599d6 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		        DAT_ram_00a599d6 = '\x01';
		      }
		      iVar6 = *(int *)(param3 + 8);
		      do {
		        iVar3 = 0;
		        iVar8 = UnityEngine_UI_Image__set_sprite(iVar6,uVar7,0);
		        uVar5 = System_Action_int__TypeInfo;
		        if ((iVar8 != 0) && (iVar3 = func_ii_1082(iVar8,System_Action_int__TypeInfo), iVar3 == 0)) {
		          System_Activator__CreateInstance(iVar8,uVar5);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329(param3 + 8,iVar3,iVar6);
		        bVar1 = iVar3 != iVar6;
		        iVar6 = iVar3;
		      } while (bVar1);
		    }
		    if (DAT_ram_00a599d8 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a599d8 = '\x01';
		    }
		    piVar9 = (int *)param1[0x12];
		    if (piVar9 == (int *)0x0) {
		      piVar9 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		      param1[0x12] = (int)piVar9;
		    }
		    uVar2 = 0;
		    iVar6 = *piVar9;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xe0);
		          goto code_r0x810a1d32;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,4)
		    ;
		code_r0x810a1d32:
		    uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    if (DAT_ram_00a599d8 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		      DAT_ram_00a599d8 = '\x01';
		    }
		    piVar9 = (int *)param1[0x12];
		    if (piVar9 == (int *)0x0) {
		      piVar9 = (int *)func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_IGuideTarget___)
		      ;
		      param1[0x12] = (int)piVar9;
		    }
		    uVar2 = 0;
		    iVar6 = Mono_Security_ASN1Convert__ToOid(long___TypeInfo,1);
		    *(ulonglong *)(iVar6 + 0x10) = (ulonglong)*(uint *)(param3 + 0x14);
		    iVar3 = *piVar9;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 0xe8);
		          goto code_r0x810a1e09;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,5)
		    ;
		code_r0x810a1e09:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,iVar6,puVar4[1]);
		    UnityEngine_Object__op_Implicit(uVar7,uVar5,0);
		    iVar6 = *(int *)param1[7];
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              ((int *)param1[7],*(undefined4 *)(param3 + 0x10),*(undefined4 *)(iVar6 + 0x2d4));
		    iVar6 = *param1;
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x128) * 4))
		              (param1,*(undefined4 *)(param3 + 0xc),*(undefined4 *)(iVar6 + 300));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,*(undefined4 *)(param3 + 0x18),
		               Method_UI_MonoBehaviourWithStates_TabBarItemData_State__set_CurrentState__);
		    UI_Tabs_TabBarItemView__HandleDataChanged(param1,param3,iVar6);
		  }
		  if ((param2 != 0) &&
		     (iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0x10],0),
		     iVar6 != 0)) {
		    uVar7 = unnamed_function_1417(System_Action_int__TypeInfo);
		    System_Action_short___Invoke
		              (uVar7,param1,Method_UI_Tabs_TabBarItemView_HandleOnCountChangedEvent__,0);
		    if (DAT_ram_00a599d7 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		      DAT_ram_00a599d7 = '\x01';
		    }
		    iVar6 = *(int *)(param2 + 8);
		    do {
		      iVar3 = 0;
		      iVar8 = func_ii_7048(iVar6,uVar7,0);
		      uVar5 = System_Action_int__TypeInfo;
		      if ((iVar8 != 0) && (iVar3 = func_ii_1082(iVar8,System_Action_int__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar8,uVar5);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(param2 + 8,iVar3,iVar6);
		      bVar1 = iVar3 != iVar6;
		      iVar6 = iVar3;
		    } while (bVar1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void UI_Tabs_TabBarItemView__get_Selected(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined8 *puVar2;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  *(char *)(param1 + 0x54) = (char)param2;
		  puVar2 = (undefined8 *)(param1 + 0x20);
		  if (param2 == 0) {
		    puVar2 = (undefined8 *)(param1 + 0x30);
		  }
		  local_18 = puVar2[1];
		  local_20 = *puVar2;
		  iVar1 = **(int **)(param1 + 0x1c);
		  local_10 = local_20;
		  local_8 = local_18;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x178) * 4))
		            (*(int **)(param1 + 0x1c),&local_20,*(undefined4 *)(iVar1 + 0x17c));
		  UI_Tabs_TabBarItemView__HandleDataChanged(param1,*(undefined4 *)(param1 + 0x50),param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_Tabs_TabBarItemView__set_Selected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x4c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x50),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
