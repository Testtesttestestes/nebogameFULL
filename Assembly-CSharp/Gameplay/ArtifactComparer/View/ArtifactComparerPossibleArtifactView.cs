using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000CD3")]
	public class ArtifactComparerPossibleArtifactView : MonoBehaviour
	{
		// Token: 0x1700102B RID: 4139
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700102B")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x6004FEC")]
			[Address(RVA = "0x9E00", Offset = "0x9E00", VA = "0x9E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700102C")]
		public bool Selected
		{
			[Token(Token = "0x6004FED")]
			[Address(RVA = "0x9E01", Offset = "0x9E01", VA = "0x9E01")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004FEE")]
			[Address(RVA = "0x9E02", Offset = "0x9E02", VA = "0x9E02")]
			set
			{
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEF")]
		[Address(RVA = "0x9E03", Offset = "0x9E03", VA = "0x9E03")]
		public ArtifactComparerPossibleArtifactView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerPossibleArtifactView___ctor
		               (int param1,int param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  longlong lVar2;
		  float param3_00;
		  float param3_01;
		  undefined4 *puVar3;
		  ulonglong uVar4;
		  ulonglong uVar5;
		  longlong lVar6;
		  longlong lVar7;
		  ulonglong local_8;
		  
		  param3_01 = 0.0;
		  param3_00 = 0.0;
		  if (DAT_ram_00a58a03 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a58a03 = '\x01';
		  }
		  local_8 = (ulonglong)CONCAT14((undefined1)param4,param1);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (param3 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x1c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x24),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x28),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x28),0);
		    Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___ctor
		              (param1,*(undefined4 *)(param1 + 0x10),0.0,param1,param1);
		    Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___ctor
		              (param1,*(undefined4 *)(param1 + 0x14),0.0,param1,param1);
		    Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___SetData_g__SetBarValue_13_0
		              (param1,*(undefined4 *)(param1 + 0x20),param2,&local_8,param1);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar4 = *(ulonglong *)(param3 + 0x60);
		  uVar5 = *(ulonglong *)(param2 + 0x60);
		  if ((longlong)uVar5 < 0) {
		    if ((longlong)uVar4 < 0) {
		code_r0x80f5d57b:
		      if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Math_TypeInfo);
		        uVar4 = *(ulonglong *)(param3 + 0x60);
		      }
		      lVar6 = (uVar4 ^ (longlong)uVar4 >> 0x3f) - ((longlong)uVar4 >> 0x3f);
		      lVar7 = (uVar5 ^ (longlong)uVar5 >> 0x3f) - ((longlong)uVar5 >> 0x3f);
		      lVar2 = System_Math__Min(1,lVar6 + lVar7,0);
		      param3_00 = (float)lVar6 / (float)lVar2;
		      param3_01 = (float)lVar7 / (float)lVar2;
		      if (*(longlong *)(param3 + 0x60) < *(longlong *)(param2 + 0x60)) goto code_r0x80f5d659;
		      if (*(longlong *)(param3 + 0x60) <= *(longlong *)(param2 + 0x60)) {
		        func_ii_7050(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x38),0);
		        func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x38),0);
		        func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x28),0);
		        puVar3 = (undefined4 *)(param1 + 0x28);
		        goto code_r0x80f5d68f;
		      }
		    }
		    else {
		      param3_00 = 1.0;
		    }
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x34),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x30),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x2c),0);
		    puVar3 = (undefined4 *)(param1 + 0x28);
		  }
		  else {
		    if (-1 < (longlong)uVar4) goto code_r0x80f5d57b;
		    param3_01 = 1.0;
		code_r0x80f5d659:
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),*(undefined4 *)(param1 + 0x30),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x34),0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1 + 0x28),0);
		    puVar3 = (undefined4 *)(param1 + 0x2c);
		  }
		code_r0x80f5d68f:
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*puVar3,0);
		  Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___ctor
		            (param1,*(undefined4 *)(param1 + 0x10),param3_01,param1,param1);
		  Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___ctor
		            (param1,*(undefined4 *)(param1 + 0x14),param3_00,param1,param1);
		  Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___SetData_g__SetBarValue_13_0
		            (param1,*(undefined4 *)(param1 + 0x20),param2,&local_8,param1);
		  Gameplay_ArtifactComparer_View_ArtifactComparerPowerBars___SetData_g__SetBarValue_13_0
		            (param1,*(undefined4 *)(param1 + 0x24),param3,&local_8,param1);
		  return;
		}
		*/

		}

		// Token: 0x04002B7C RID: 11132
		[Token(Token = "0x4002B7C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _selectionImage;

		// Token: 0x04002B7D RID: 11133
		[Token(Token = "0x4002B7D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04002B7E RID: 11134
		[Token(Token = "0x4002B7E")]
		[FieldOffset(Offset = "0x18")]
		private bool _selected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Selected ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerPossibleArtifactView__get_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x18) = (undefined1)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x18),0);
		  return;
		}
		*/

}
