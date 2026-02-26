using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000664 RID: 1636
	[Token(Token = "0x2000664")]
	public class SplitArtifactView : AbstractDataRenderer<ArtifactData>
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x78E7", Offset = "0x78E7", VA = "0x78E7", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_SplitArtifactView__HandleDataChanged(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a0b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_SplitArtifactView_OnLeftArtifactClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_SplitArtifactView_OnRightArtifactClick__);
		    DAT_ram_00a5a0b1 = '\x01';
		  }
		  iVar7 = *(int *)(param1 + 0x24);
		  *(undefined4 *)(iVar7 + 0x24) = 1;
		  *(undefined4 *)(*(int *)(param1 + 0x28) + 0x24) = 1;
		  uVar5 = unnamed_function_1417(System_Action_ArtifactView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Inventory_View_SplitArtifactView_OnLeftArtifactClick__,0);
		  if (DAT_ram_00a5a089 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    DAT_ram_00a5a089 = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x4c);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		    uVar2 = System_Action_ArtifactView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_ArtifactView__TypeInfo), iVar4 == 0)) break;
		    iVar4 = func_ii_4329(iVar7 + 0x4c,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1 + 0x28);
		      uVar5 = unnamed_function_1417(System_Action_ArtifactView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Inventory_View_SplitArtifactView_OnRightArtifactClick__,0);
		      if (DAT_ram_00a5a089 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		        DAT_ram_00a5a089 = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x4c);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_ArtifactView__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_ArtifactView__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar7 + 0x4c,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (*(undefined4 *)(param1 + 0x2c),0,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (*(undefined4 *)(param1 + 0x30),1,0);
		          *(undefined4 *)(param1 + 0x38) = 1;
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x78E8", Offset = "0x78E8", VA = "0x78E8")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Inventory_View_SplitArtifactView__Start
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x38) != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x2c),1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x30),0,0);
		    *(undefined4 *)(param1 + 0x38) = 0;
		    iVar1 = *(int *)(param1 + 0x34);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x78E9", Offset = "0x78E9", VA = "0x78E9")]
		private void OnLeftArtifactClick(ArtifactView view)
		{
		/* --- GHIDRA: OnLeftArtifactClick ---
		void Gameplay_Inventory_View_SplitArtifactView__OnLeftArtifactClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x38) != 1) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x2c),0,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x30),1,0);
		    *(undefined4 *)(param1 + 0x38) = 1;
		    iVar1 = *(int *)(param1 + 0x34);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x78EA", Offset = "0x78EA", VA = "0x78EA")]
		private void OnRightArtifactClick(ArtifactView view)
		{
		/* --- GHIDRA: OnRightArtifactClick ---
		void Gameplay_Inventory_View_SplitArtifactView__OnRightArtifactClick(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5a0b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_SplitArtifactView_OnLeftArtifactClick__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Inventory_View_SplitArtifactView_OnRightArtifactClick__);
		    DAT_ram_00a5a0b2 = '\x01';
		  }
		  UI_AbstractDeferredRenderer__OnDisable(param1,0);
		  iVar7 = *(int *)(param1 + 0x24);
		  uVar5 = unnamed_function_1417(System_Action_ArtifactView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,Method_Gameplay_Inventory_View_SplitArtifactView_OnLeftArtifactClick__,0);
		  if (DAT_ram_00a5a08a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    DAT_ram_00a5a08a = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x4c);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = func_ii_7048(iVar3,uVar5,0);
		    uVar2 = System_Action_ArtifactView__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_ArtifactView__TypeInfo), iVar4 == 0)) break;
		    iVar4 = func_ii_4329(iVar7 + 0x4c,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1 + 0x28);
		      uVar5 = unnamed_function_1417(System_Action_ArtifactView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Inventory_View_SplitArtifactView_OnRightArtifactClick__,0);
		      if (DAT_ram_00a5a08a == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		        DAT_ram_00a5a08a = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x4c);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_ArtifactView__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_ArtifactView__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar7 + 0x4c,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          iVar7 = **(int **)(param1 + 0x24);
		          (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                    (*(int **)(param1 + 0x24),0,*(undefined4 *)(iVar7 + 0x13c));
		          iVar7 = **(int **)(param1 + 0x28);
		          (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                    (*(int **)(param1 + 0x28),0,*(undefined4 *)(iVar7 + 0x13c));
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x78EB", Offset = "0x78EB", VA = "0x78EB", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4 Gameplay_Inventory_View_SplitArtifactView__OnDestroy(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData__get_Data__);
		    DAT_ram_00a5a0b3 = '\x01';
		  }
		  return *(undefined4 *)(param1 + 0x20);
		}
		*/

		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060027C6 RID: 10182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000788")]
		public override ArtifactData Data
		{
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x78EC", Offset = "0x78EC", VA = "0x78EC", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x78ED", Offset = "0x78ED", VA = "0x78ED", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000079B0 File Offset: 0x00005BB0
		// (set) Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000789")]
		public SplitArtifactView.ArtifactSelection CurrentSelection
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x78EE", Offset = "0x78EE", VA = "0x78EE")]
			[CompilerGenerated]
			get
			{
				return SplitArtifactView.ArtifactSelection.Left;
			}
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x78EF", Offset = "0x78EF", VA = "0x78EF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x78F0", Offset = "0x78F0", VA = "0x78F0")]
		public SplitArtifactView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_SplitArtifactView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a0b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo);
		    DAT_ram_00a5a0b6 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo + 0x5c)
		  ;
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    param2_00 = System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtikulMenuActionDic_Types_Actions__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)
		                          (Gameplay_Inventory_View_Info_ArtifactInfoActionButtonsView_TypeInfo +
		                          0x5c),iVar2,param1_00);
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

		}

		// Token: 0x040015C1 RID: 5569
		[Token(Token = "0x40015C1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _leftArtifactView;

		// Token: 0x040015C2 RID: 5570
		[Token(Token = "0x40015C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtifactView _rightArtifactView;

		// Token: 0x040015C3 RID: 5571
		[Token(Token = "0x40015C3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameObject _leftArtifactViewSelector;

		// Token: 0x040015C4 RID: 5572
		[Token(Token = "0x40015C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _rightArtifactViewSelector;

		// Token: 0x040015C5 RID: 5573
		[Token(Token = "0x40015C5")]
		[FieldOffset(Offset = "0x34")]
		public Action<SplitArtifactView.ArtifactSelection> OnArtifactSelect;

		// Token: 0x02000665 RID: 1637
		[Token(Token = "0x2000665")]
		public enum ArtifactSelection
		{
			// Token: 0x040015C8 RID: 5576
			[Token(Token = "0x40015C8")]
			Left,
			// Token: 0x040015C9 RID: 5577
			[Token(Token = "0x40015C9")]
			Right
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_Inventory_View_SplitArtifactView__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a0b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData__set_Data__);
		    DAT_ram_00a5a0b4 = '\x01';
		  }
		  UI_AbstractDataRenderer_object___remove_DataChangedEvent
		            (param1,param2,Method_UI_AbstractDataRenderer_ArtifactData__set_Data__);
		  iVar1 = **(int **)(param1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x24),param2,*(undefined4 *)(iVar1 + 0x13c));
		  iVar1 = **(int **)(param1 + 0x28);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x28),param2,*(undefined4 *)(iVar1 + 0x13c));
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentSelection ---
		void Gameplay_Inventory_View_SplitArtifactView__set_CurrentSelection
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		    DAT_ram_00a5a0b5 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		  return;
		}
		*/

}
