using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	[DisallowMultipleComponent]
	public class NumpadView : MonoBehaviour
	{
		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x00007998 File Offset: 0x00005B98
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000787")]
		public int Value
		{
			[Token(Token = "0x60027B6")]
			[Address(RVA = "0x78DC", Offset = "0x78DC", VA = "0x78DC")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027B5")]
			[Address(RVA = "0x78DB", Offset = "0x78DB", VA = "0x78DB")]
			set
			{
			}
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x78DD", Offset = "0x78DD", VA = "0x78DD")]
		public void SetActive(bool active)
		{
		/* --- GHIDRA: SetActive ---
		void Gameplay_Inventory_View_NumpadView__SetActive(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  
		  if (DAT_ram_00a5a0ad == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_25762);
		    Mono_Security_ASN1__get_Item(&StringLiteral_20431);
		    DAT_ram_00a5a0ad = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_20431,0);
		  if (iVar1 == 0) {
		    iVar1 = System_Collections_CollectionBase___ctor(param2,StringLiteral_25762,0);
		    if (iVar1 != 0) {
		      Gameplay_Inventory_View_NumpadView__InputNumber(param1,param2);
		      return;
		    }
		    uVar3 = func_ii_8697(param2,0);
		    Gameplay_Inventory_View_NumpadView__OnButtonClick(param1,uVar3,param2);
		  }
		  else {
		    iVar1 = **(int **)(param1 + 0x18);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0x2cc));
		    iVar2 = func_ii_4769(iVar1,0);
		    if (iVar2 == 0) {
		      piVar4 = *(int **)(param1 + 0x18);
		      if (*(int *)(iVar1 + 8) < 2) {
		        uVar3 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		      }
		      else {
		        uVar3 = System_Data_DataSet__ReadXmlSchema(iVar1,0,*(int *)(iVar1 + 8) + -1,0);
		      }
		      iVar1 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (piVar4,uVar3,*(undefined4 *)(iVar1 + 0x2d4));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x78DE", Offset = "0x78DE", VA = "0x78DE")]
		public void OnButtonClick(string value)
		{
		/* --- GHIDRA: OnButtonClick ---
		void Gameplay_Inventory_View_NumpadView__OnButtonClick(int param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  longlong lVar3;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int local_c;
		  int local_8;
		  int local_4;
		  
		  if (DAT_ram_00a5a0ae == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_28728);
		    DAT_ram_00a5a0ae = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(*(int *)(param1 + 0x1c) + 0x50) + 0x24) + -1;
		  iVar6 = **(int **)(param1 + 0x18);
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x2cc));
		  iVar6 = func_ii_4769(uVar2,0);
		  if (iVar6 == 0) {
		    iVar6 = **(int **)(param1 + 0x18);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x2cc));
		    iVar6 = func_ii_8697(uVar2,0);
		    if (iVar6 != 0) {
		      iVar6 = **(int **)(param1 + 0x18);
		      uVar2 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2c8) * 4))
		                        (*(int **)(param1 + 0x18),*(undefined4 *)(iVar6 + 0x2cc));
		      local_c = param2;
		      param3_00 = func_ii_1081(DAT_ram_00a66954,&local_c);
		      uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                        (StringLiteral_28728,uVar2,param3_00,0);
		      lVar3 = func_ii_16177(uVar2,0);
		      if (lVar3 <= iVar4) {
		        iVar6 = **(int **)(param1 + 0x18);
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		                  (*(int **)(param1 + 0x18),uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		        return;
		      }
		      bVar1 = iVar4 < 1;
		      if (bVar1) {
		        iVar4 = 0;
		      }
		      piVar5 = *(int **)(param1 + 0x18);
		      local_4 = iVar4;
		      if (bVar1) {
		        uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		      }
		      else {
		        uVar2 = func_ii_4443(&local_4,0);
		      }
		      iVar6 = *piVar5;
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		                (piVar5,uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		      return;
		    }
		  }
		  local_8 = param2;
		  if (iVar4 <= param2) {
		    local_8 = iVar4;
		  }
		  bVar1 = local_8 < 1;
		  if (bVar1) {
		    local_8 = 0;
		  }
		  piVar5 = *(int **)(param1 + 0x18);
		  if (bVar1) {
		    uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  }
		  else {
		    uVar2 = func_ii_4443(&local_8,0);
		  }
		  iVar6 = *piVar5;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar5,uVar2,*(undefined4 *)(iVar6 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x78DF", Offset = "0x78DF", VA = "0x78DF")]
		private void InputNumber(int value)
		{
		/* --- GHIDRA: InputNumber ---
		void Gameplay_Inventory_View_NumpadView__InputNumber(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  
		  uVar2 = 0;
		  iVar4 = **(int **)(param1 + 0x18);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar4 + 0x2cc));
		  iVar4 = func_ii_4769(uVar1,0);
		  if (iVar4 == 0) {
		    iVar4 = **(int **)(param1 + 0x18);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0x18),*(undefined4 *)(iVar4 + 0x2cc));
		    iVar4 = func_ii_8697(uVar1,0);
		    if ((0 < iVar4) && (iVar4 = *(int *)(param1 + 0x20), iVar4 != 0)) {
		      uVar3 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x54) + 0x38);
		      iVar5 = **(int **)(param1 + 0x18);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2c8) * 4))
		                        (*(int **)(param1 + 0x18),*(undefined4 *)(iVar5 + 0x2cc));
		      iVar5 = func_ii_4769(uVar1,0);
		      if (iVar5 == 0) {
		        iVar5 = **(int **)(param1 + 0x18);
		        uVar2 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2c8) * 4))
		                          (*(int **)(param1 + 0x18),*(undefined4 *)(iVar5 + 0x2cc));
		        uVar2 = func_ii_8697(uVar2,0);
		      }
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),uVar3,uVar2,*(undefined4 *)(iVar4 + 0x14));
		      iVar4 = **(int **)(param1 + 0x18);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		                (*(int **)(param1 + 0x18),**(undefined4 **)(DAT_ram_00a66978 + 0x5c),
		                 *(undefined4 *)(iVar4 + 0x2d4));
		      UnityEngine_CanvasGroup__get_interactable(*(undefined4 *)(param1 + 0x10),1,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(param1 + 0x14),0,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x78E0", Offset = "0x78E0", VA = "0x78E0")]
		private void OnOkHandler()
		{
		/* --- GHIDRA: OnOkHandler ---
		void Gameplay_Inventory_View_NumpadView__OnOkHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  iVar4 = **(int **)(param1 + 0x18);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar4 + 0x2cc));
		  iVar1 = func_ii_4769(iVar4,0);
		  if (iVar1 == 0) {
		    piVar3 = *(int **)(param1 + 0x18);
		    if (*(int *)(iVar4 + 8) < 2) {
		      uVar2 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		    }
		    else {
		      uVar2 = System_Data_DataSet__ReadXmlSchema(iVar4,0,*(int *)(iVar4 + 8) + -1,0);
		    }
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x78E1", Offset = "0x78E1", VA = "0x78E1")]
		private void OnBackspaceHandler()
		{
		/* --- GHIDRA: OnBackspaceHandler ---
		void Gameplay_Inventory_View_NumpadView__OnBackspaceHandler(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a0af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_NumpadView_OnArtifactSelectHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_NumpadView_OnSliderChangedHandler__);
		    DAT_ram_00a5a0af = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 100);
		  uVar1 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		  System_Action_int___Invoke
		            (uVar1,param1,Method_Gameplay_Inventory_View_NumpadView_OnArtifactSelectHandler__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 100) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 100) = iVar3;
		    uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x60);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,Method_Gameplay_Inventory_View_NumpadView_OnSliderChangedHandler__,0);
		  iVar2 = UnityEngine_UI_Image__set_sprite(uVar5,uVar1,0);
		  uVar1 = System_Action_int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x60) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x60) = iVar3;
		    uVar1 = System_Action_int__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x18),**(undefined4 **)(DAT_ram_00a66978 + 0x5c),
		             *(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x78E2", Offset = "0x78E2", VA = "0x78E2")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_NumpadView__Start(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5a0b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_NumpadView_OnArtifactSelectHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_NumpadView_OnSliderChangedHandler__);
		    DAT_ram_00a5a0b0 = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 100);
		  uVar1 = unnamed_function_1417(System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		  System_Action_int___Invoke
		            (uVar1,param1,Method_Gameplay_Inventory_View_NumpadView_OnArtifactSelectHandler__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 100) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 100) = iVar3;
		    uVar1 = System_Action_SplitArtifactView_ArtifactSelection__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_SplitArtifactView_ArtifactSelection__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar2,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  uVar5 = *(undefined4 *)(iVar4 + 0x60);
		  uVar1 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar1,param1,Method_Gameplay_Inventory_View_NumpadView_OnSliderChangedHandler__,0);
		  iVar2 = func_ii_7048(uVar5,uVar1,0);
		  uVar1 = System_Action_int__TypeInfo;
		  if (iVar2 == 0) {
		    *(undefined4 *)(iVar4 + 0x60) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0x60) = iVar3;
		    uVar1 = System_Action_int__TypeInfo;
		    iVar4 = func_ii_1082(iVar2,System_Action_int__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar2,uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x78E3", Offset = "0x78E3", VA = "0x78E3")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Inventory_View_NumpadView__OnDestroy(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_CanvasGroup__get_interactable(*(undefined4 *)(param1 + 0x10),0,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),1,0);
		  return;
		}
		*/

		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x78E4", Offset = "0x78E4", VA = "0x78E4")]
		private void OnSliderChangedHandler(int value)
		{
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x78E5", Offset = "0x78E5", VA = "0x78E5")]
		private void OnArtifactSelectHandler(SplitArtifactView.ArtifactSelection selection)
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x78E6", Offset = "0x78E6", VA = "0x78E6")]
		public NumpadView()
		{
		}

		// Token: 0x040015BC RID: 5564
		[Token(Token = "0x40015BC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CanvasGroup _contentCanvasGroup;

		// Token: 0x040015BD RID: 5565
		[Token(Token = "0x40015BD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _disableBlend;

		// Token: 0x040015BE RID: 5566
		[Token(Token = "0x40015BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _indicator;

		// Token: 0x040015BF RID: 5567
		[Token(Token = "0x40015BF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ConfirmSplitArtifactWindow _confirmSplitArtifactWindow;

		// Token: 0x040015C0 RID: 5568
		[Token(Token = "0x40015C0")]
		[FieldOffset(Offset = "0x20")]
		public Action<SplitArtifactView.ArtifactSelection, int> OnOk;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Value ---
		undefined4 Gameplay_Inventory_View_NumpadView__set_Value(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x18);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x2cc));
		  iVar2 = func_ii_4769(uVar1,0);
		  if (iVar2 == 0) {
		    iVar2 = **(int **)(param1 + 0x18);
		    uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                      (*(int **)(param1 + 0x18),*(undefined4 *)(iVar2 + 0x2cc));
		    uVar1 = func_ii_8697(uVar1,0);
		  }
		  else {
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void Gameplay_Inventory_View_NumpadView__get_Value(int param1,uint param2,undefined4 param3)
		
		{
		  UnityEngine_CanvasGroup__get_interactable(*(undefined4 *)(param1 + 0x10),param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x14),param2 ^ 1,0);
		  return;
		}
		*/

}
