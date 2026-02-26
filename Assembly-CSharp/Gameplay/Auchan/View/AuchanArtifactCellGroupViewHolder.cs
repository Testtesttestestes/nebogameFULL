using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C88 RID: 3208
	[Token(Token = "0x2000C88")]
	public class AuchanArtifactCellGroupViewHolder : CellGroupViewsHolder<AuchanArtifactCellViewHolder>
	{
		// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x9C6E", Offset = "0x9C6E", VA = "0x9C6E", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder__CollectViews
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x28),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  piVar2 = *(int **)(param1 + 0x2c);
		  uVar1 = System_Uri__get_Authority(param2,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x9C6F", Offset = "0x9C6F", VA = "0x9C6F")]
		public void ShowHeader(string text)
		{
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x9C70", Offset = "0x9C70", VA = "0x9C70")]
		public void ClearHeader()
		{
		/* --- GHIDRA: ClearHeader ---
		void Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder__ClearHeader
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59852 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder___ctor__
		              );
		    DAT_ram_00a59852 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3E")]
		[Address(RVA = "0x9C71", Offset = "0x9C71", VA = "0x9C71")]
		public AuchanArtifactCellGroupViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Auchan_View_AuchanArtifactCellGroupViewHolder___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a59853 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_Controller_AuchanArtifactComparers_ByCost_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_Controller_AuchanArtifactComparers_ByDiscount_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Auchan_Controller_AuchanArtifactComparers_ByQuality_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___Add__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___TypeInfo);
		    DAT_ram_00a59853 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData____ctor__);
		  uVar2 = unnamed_function_1417(Gameplay_Auchan_Controller_AuchanArtifactComparers_ByCost_TypeInfo);
		  Gameplay_Auchan_Controller_AuchanArtifactComparers_ByCost__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Auchan_Controller_AuchanArtifactComparers_ByQuality_TypeInfo);
		  Gameplay_Auchan_Controller_AuchanArtifactComparers_ByQuality__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417
		                    (Gameplay_Auchan_Controller_AuchanArtifactComparers_ByDiscount_TypeInfo);
		  Gameplay_Auchan_Controller_AuchanArtifactComparers_ByDiscount__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_AuchanArtifactData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

		}

		// Token: 0x04002ABA RID: 10938
		[Token(Token = "0x4002ABA")]
		[FieldOffset(Offset = "0x24")]
		private ContentSizeFitter _contentSizeFitterComponent;

		// Token: 0x04002ABB RID: 10939
		[Token(Token = "0x4002ABB")]
		[FieldOffset(Offset = "0x28")]
		private Transform _headerGroup;

		// Token: 0x04002ABC RID: 10940
		[Token(Token = "0x4002ABC")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _headerLabel;
	}
}
