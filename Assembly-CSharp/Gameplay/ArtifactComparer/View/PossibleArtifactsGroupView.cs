using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000CDB")]
	public class PossibleArtifactsGroupView : MonoBehaviour
	{
		// Token: 0x06005019 RID: 20505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005019")]
		[Address(RVA = "0x9E2D", Offset = "0x9E2D", VA = "0x9E2D")]
		protected void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__Awake
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView_ViewOnClickEvent__)
		    ;
		    DAT_ram_00a58a17 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_ArtifactView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView_ViewOnClickEvent__,0);
		  Gameplay_Inventory_View_ArtifactView__get_GuideTarget(param1_00,uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501A")]
		[Address(RVA = "0x9E2E", Offset = "0x9E2E", VA = "0x9E2E")]
		private void OnReleasePooledObject(ArtifactComparerPossibleArtifactView pooledObject)
		{
		/* --- GHIDRA: OnReleasePooledObject ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__OnReleasePooledObject
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a18 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    DAT_ram_00a58a18 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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

		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x0600501B RID: 20507 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600501C RID: 20508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001E6")]
		public event Action<ArtifactData> SelectArtifactEvent
		{
			[Token(Token = "0x600501B")]
			[Address(RVA = "0x9E2F", Offset = "0x9E2F", VA = "0x9E2F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600501C")]
			[Address(RVA = "0x9E30", Offset = "0x9E30", VA = "0x9E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001038")]
		public ArtikulTypeDic ArtikulTypeDic
		{
			[Token(Token = "0x600501D")]
			[Address(RVA = "0x9E31", Offset = "0x9E31", VA = "0x9E31")]
			get
			{
				return null;
			}
			[Token(Token = "0x600501E")]
			[Address(RVA = "0x9E32", Offset = "0x9E32", VA = "0x9E32")]
			set
			{
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001039")]
		public List<ArtifactData> Artifacts
		{
			[Token(Token = "0x600501F")]
			[Address(RVA = "0x9E33", Offset = "0x9E33", VA = "0x9E33")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005020")]
			[Address(RVA = "0x9E34", Offset = "0x9E34", VA = "0x9E34")]
			set
			{
			}
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x1D92", Offset = "0x1D92", VA = "0x1D92")]
		private void HandleArtifactsChanged()
		{
		/* --- GHIDRA: HandleArtifactsChanged ---
		int * Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__HandleArtifactsChanged(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x9E35", Offset = "0x9E35", VA = "0x9E35")]
		private void ViewOnClickEvent(ArtifactView artifactView)
		{
		/* --- GHIDRA: ViewOnClickEvent ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__ViewOnClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  piVar1 = *(int **)(param1 + 0x10);
		  if (*(int *)(param1 + 0x24) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = func_ii_7568(*(int *)(param1 + 0x24),0);
		  }
		  iVar3 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar1,uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x1D94", Offset = "0x1D94", VA = "0x1D94")]
		public void SelectComparableArtifact(ArtifactData comparableArtifact)
		{
		/* --- GHIDRA: SelectComparableArtifact ---
		int * Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__SelectComparableArtifact
		                (int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x9E36", Offset = "0x9E36", VA = "0x9E36")]
		private void HandleArtikulTypeDicChanged()
		{
		/* --- GHIDRA: HandleArtikulTypeDicChanged ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__HandleArtikulTypeDicChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a1c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__TypeInfo);
		    DAT_ram_00a58a1c = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_ArtifactComparerPossibleArtifactView__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_ArtifactComparerPossibleArtifactView___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005025")]
		[Address(RVA = "0x9E37", Offset = "0x9E37", VA = "0x9E37")]
		public PossibleArtifactsGroupView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a1d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SkillSelectorItemView__TypeInfo);
		    DAT_ram_00a58a1d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SkillSelectorItemView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SkillSelectorItemView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ArtifactComparerPossibleArtifactView _artifactViewPrefab;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x1C")]
		private GameObjectPool<ArtifactComparerPossibleArtifactView> _possibleArtifactsPool;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x20")]
		private List<ArtifactComparerPossibleArtifactView> _currentPossibleArtifacts;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x24")]
		private ArtikulTypeDic _artikulTypeDic;

		// Token: 0x04002BB5 RID: 11189
		[Token(Token = "0x4002BB5")]
		[FieldOffset(Offset = "0x2C")]
		private List<ArtifactData> _artifacts;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectArtifactEvent ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__add_SelectArtifactEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58a19 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactData__TypeInfo);
		    DAT_ram_00a58a19 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: get_ArtikulTypeDic ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__get_ArtikulTypeDic
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  *(int *)(param1 + 0x24) = param2;
		  piVar1 = *(int **)(param1 + 0x10);
		  if (param2 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = func_ii_7568(param2,0);
		  }
		  iVar3 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar1,uVar2,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: get_Artifacts ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__get_Artifacts
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  Core_Extensions_Dict_ArtikulTypeDicExt__GetTitle(param1,param1);
		  return;
		}
		*/


		/* --- GHIDRA: set_Artifacts ---
		void Gameplay_ArtifactComparer_View_PossibleArtifactsGroupView__set_Artifacts
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x28);
		  if (iVar2 != 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

}
