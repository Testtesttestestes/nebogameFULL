using System;
using Gameplay.ArtifactComparer.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactComparer.View.Rows
{
	// Token: 0x02000CDF RID: 3295
	[Token(Token = "0x2000CDF")]
	public class ArtifactComparerRowView : MonoBehaviour
	{
		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x06005041 RID: 20545 RVA: 0x0000EB50 File Offset: 0x0000CD50
		// (set) Token: 0x06005042 RID: 20546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103E")]
		public uint? Index
		{
			[Token(Token = "0x6005041")]
			[Address(RVA = "0x9E52", Offset = "0x9E52", VA = "0x9E52")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005042")]
			[Address(RVA = "0x9E53", Offset = "0x9E53", VA = "0x9E53")]
			set
			{
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x06005043 RID: 20547 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005044 RID: 20548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700103F")]
		public ArtifactComparerRowData Data
		{
			[Token(Token = "0x6005043")]
			[Address(RVA = "0x9E54", Offset = "0x9E54", VA = "0x9E54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005044")]
			[Address(RVA = "0x9E55", Offset = "0x9E55", VA = "0x9E55")]
			set
			{
			}
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005045")]
		[Address(RVA = "0x9E56", Offset = "0x9E56", VA = "0x9E56", Slot = "4")]
		protected virtual void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowView__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  uint param2_00;
		  int iVar2;
		  int iVar3;
		  ulonglong local_8;
		  
		  if (DAT_ram_00a58a2a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_uint__get_HasValue__);
		    DAT_ram_00a58a2a = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x24) != '\0'),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(*(char *)(param1 + 0x24) != '\0'),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  if (*(char *)(param1 + 0x24) == '\0') {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (uint)(*(int *)(*(int *)(param1 + 0x2c) + 0x14) != 0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  if ((*(ulonglong *)(param1 + 0x24) & 0xff) != 0) {
		    local_8 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor
		              (&local_8,(uint)(*(ulonglong *)(param1 + 0x24) >> 0x20) & 1,
		               Method_System_Nullable_uint___ctor__);
		    iVar3 = 0x20;
		    if ((local_8 & 0xff) == 0) {
		      iVar3 = 0x1c;
		    }
		    iVar2 = 0x1c;
		    if (local_8 < 0x100000000) {
		      iVar2 = iVar3;
		    }
		    uVar1 = *(undefined4 *)(param1 + iVar2);
		    func_ii_7050(*(undefined4 *)(param1 + 0x10),uVar1,0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x14),uVar1,0);
		    func_ii_7050(*(undefined4 *)(param1 + 0x18),uVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005046")]
		[Address(RVA = "0x9E57", Offset = "0x9E57", VA = "0x9E57", Slot = "5")]
		protected virtual void HandleIndexChanged()
		{
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005047")]
		[Address(RVA = "0x9E58", Offset = "0x9E58", VA = "0x9E58")]
		public ArtifactComparerRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowView___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a58a2b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a58a2b = '\x01';
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
		          goto code_r0x80f61431;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x80f61431:
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

		// Token: 0x04002BCF RID: 11215
		[Token(Token = "0x4002BCF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg1;

		// Token: 0x04002BD0 RID: 11216
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg2;

		// Token: 0x04002BD1 RID: 11217
		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg3;

		// Token: 0x04002BD2 RID: 11218
		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Sprite _bgDarkSprite;

		// Token: 0x04002BD3 RID: 11219
		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _bgLightSprite;

		// Token: 0x04002BD4 RID: 11220
		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0x24")]
		private uint? _index;

		// Token: 0x04002BD5 RID: 11221
		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x2C")]
		private ArtifactComparerRowData _data;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Index ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowView__get_Index
		               (int *param1,undefined8 *param2,undefined4 param3)
		
		{
		  *(undefined8 *)(param1 + 9) = *param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_ArtifactComparer_View_Rows_ArtifactComparerRowView__get_Data
		               (int *param1,int param2,undefined4 param3)
		
		{
		  param1[0xb] = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/

}
