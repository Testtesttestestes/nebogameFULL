using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE1 RID: 3297
	[Token(Token = "0x2000CE1")]
	public class ArtifactComparerRowViewInfo : ArtifactComparerRowView
	{
		// Token: 0x0600504A RID: 20554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504A")]
		[Address(RVA = "0x9E5B", Offset = "0x9E5B", VA = "0x9E5B", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504B")]
		[Address(RVA = "0x9E5C", Offset = "0x9E5C", VA = "0x9E5C")]
		public ArtifactComparerRowViewInfo()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowViewInfo___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58a2d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a58a2d = '\x01';
		  }
		  if (*(int *)(param1 + 0x2c) != 0) {
		    uVar1 = 0;
		    piVar4 = *(int **)(param1 + 0x30);
		    param1_00 = *(int **)(*(int *)(param1 + 0x2c) + 0xc);
		    iVar5 = *param1_00;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x80f616f7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f616f7:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    iVar5 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		              (piVar4,uVar3,*(undefined4 *)(iVar5 + 0x2d4));
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x34),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1 + 0x2c) + 0x10) != 0),0);
		    iVar5 = *(int *)(*(int *)(param1 + 0x2c) + 0x10);
		    if (iVar5 != 0) {
		      UI_Requirements_RequirementsView__GetRowPrefab(*(undefined4 *)(param1 + 0x34),iVar5,0);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) != 0),0);
		    iVar5 = *(int *)(*(int *)(param1 + 0x2c) + 0x14);
		    if (iVar5 != 0) {
		      UI_Requirements_RequirementsView__GetRowPrefab(*(undefined4 *)(param1 + 0x38),iVar5,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LoaderValueRowView _valueRow1;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _valueRow1Title;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private LoaderValueRowView _valueRow2;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _valueRow2Title;
	}
}
