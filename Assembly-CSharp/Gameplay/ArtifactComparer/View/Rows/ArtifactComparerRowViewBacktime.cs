using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CE0 RID: 3296
	[Token(Token = "0x2000CE0")]
	public class ArtifactComparerRowViewBacktime : ArtifactComparerRowView
	{
		// Token: 0x06005048 RID: 20552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005048")]
		[Address(RVA = "0x9E59", Offset = "0x9E59", VA = "0x9E59", Slot = "4")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005049")]
		[Address(RVA = "0x9E5A", Offset = "0x9E5A", VA = "0x9E5A")]
		public ArtifactComparerRowViewBacktime()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowViewBacktime___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58a2c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a58a2c = '\x01';
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
		          goto code_r0x80f61594;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f61594:
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
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x38),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		    }
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x3c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) != 0),0);
		    iVar5 = *(int *)(*(int *)(param1 + 0x2c) + 0x14);
		    if (iVar5 != 0) {
		      UI_Requirements_RequirementsView__GetRowPrefab(*(undefined4 *)(param1 + 0x3c),iVar5,0);
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x40),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x04002BD6 RID: 11222
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private BackTimeRowView _valueRow1;

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _valueRow1Title;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BackTimeRowView _valueRow2;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _valueRow2Title;
	}
}
