using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE2 RID: 3298
	[Token(Token = "0x2000CE2")]
	public class ArtifactComparerRowViewSpell : ArtifactComparerRowView
	{
		// Token: 0x0600504C RID: 20556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504C")]
		[Address(RVA = "0x9E5D", Offset = "0x9E5D", VA = "0x9E5D", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504D")]
		[Address(RVA = "0x9E5E", Offset = "0x9E5E", VA = "0x9E5E")]
		public ArtifactComparerRowViewSpell()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowViewSpell___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58a2e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a58a2e = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x30);
		  if (*(int *)(param1 + 0x2c) == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		              (piVar4,StringLiteral_5,*(undefined4 *)(*piVar4 + 0x2d4));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  uVar1 = 0;
		  param1_00 = *(int **)(*(int *)(param1 + 0x2c) + 0xc);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f61839;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f61839:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x2d0) * 4))
		            (piVar4,uVar3,*(undefined4 *)(*piVar4 + 0x2d4));
		  uVar1 = 0;
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  piVar4 = *(int **)(*(int *)(param1 + 0x2c) + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f618e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f618e2:
		  uVar1 = 0;
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar5 != 0),0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x38),0);
		  piVar4 = *(int **)(*(int *)(param1 + 0x2c) + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x80f61980;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f61980:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,(uint)(iVar5 != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ModifierRowView _valueRow1;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ModifierRowView _valueRow2;
	}
}
