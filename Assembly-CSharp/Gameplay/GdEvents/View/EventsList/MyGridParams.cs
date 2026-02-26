using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	[Serializable]
	public class MyGridParams : GridParams
	{
		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x17000863")]
		public float HeaderSize
		{
			[Token(Token = "0x6002C1A")]
			[Address(RVA = "0x7CAA", Offset = "0x7CAA", VA = "0x7CAA")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C1B")]
		[Address(RVA = "0x7CAB", Offset = "0x7CAB", VA = "0x7CAB", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
		/* --- GHIDRA: CreateCellGroupPrefabGameObject ---
		void Com_TheFallenGames_OSA_Demos_GridWithCategories_MyGridParams__CreateCellGroupPrefabGameObject
		               (int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 100) = 0x42480000;
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridParams__InitOrReinitCellGroupPrefabLayoutGroup
		            (param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: CreateCellGroupPrefabGameObject ---
		undefined4
		Gameplay_GdEvents_View_EventsList_MyGridParams__CreateCellGroupPrefabGameObject
		          (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_VerticalLayoutGroup___)
		    ;
		    DAT_ram_00a5a2a2 = '\x01';
		  }
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (param2,Method_UnityEngine_GameObject_AddComponent_VerticalLayoutGroup___);
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002C1C")]
		[Address(RVA = "0x7CAC", Offset = "0x7CAC", VA = "0x7CAC", Slot = "10")]
		protected override LayoutGroup AddLayoutGroupToCellGroupPrefab(GameObject cellGroupGameObject)
		{
		/* --- GHIDRA: AddLayoutGroupToCellGroupPrefab ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyGridParams__AddLayoutGroupToCellGroupPrefab
		               (int param1,int *param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a540cc == '\0') {
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup_TypeInfo);
		    DAT_ram_00a540cc = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridParams__AddLayoutGroupToCellGroupPrefab
		            (param1,param2,0);
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(*param2 + 0xb8)) &&
		       (param1_00 = param2,
		       *(int *)(*(int *)(*param2 + 100) +
		                (uint)*(byte *)(Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup_TypeInfo + 0xb8) *
		                4 + -4) != Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup__get_ForcedSpacing
		            (param1_00,*(float *)(*(int *)(param1 + 0x4c) + 0x18),0);
		  Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup__get_ChildrenControlSize(param1_00,1,0);
		  Com_TheFallenGames_OSA_Util_PackedGridLayoutGroup__get_BiggerChildrenFirst
		            (param1_00,(uint)*(byte *)(param1 + 0x60),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C1D")]
		[Address(RVA = "0x7CAD", Offset = "0x7CAD", VA = "0x7CAD")]
		public MyGridParams()
		{
		/* --- GHIDRA: .ctor ---
		float Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyGridParams___ctor
		                (int param1,undefined4 param2)
		
		{
		  return *(float *)(param1 + 0x24) / *(float *)(param1 + 0x20);
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Com_TheFallenGames_OSA_Demos_SelectAndDelete_MyGridParams___ctor(int param1,undefined4 param2)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a540b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo);
		    DAT_ram_00a540b0 = '\x01';
		  }
		  if (*(int *)(Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Com_TheFallenGames_OSA_Demos_Common_DemosUtil_TypeInfo);
		  }
		  Com_TheFallenGames_OSA_Demos_Common_DemosUtil__GetRandomSmallImageURL(&local_10,1,0);
		  *(undefined8 *)(param1 + 0x14) = local_8;
		  *(undefined8 *)(param1 + 0xc) = local_10;
		  return;
		}
		*/

		}

		// Token: 0x04001827 RID: 6183
		[Token(Token = "0x4001827")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _CellGroupPrefab;

		// Token: 0x04001828 RID: 6184
		[Token(Token = "0x4001828")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _HeaderSize;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: InitOrReinitCellGroupPrefabLayoutGroup ---
		float Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyGridParams__InitOrReinitCellGroupPrefabLayoutGroup
		                (int param1,int param2,undefined4 param3)
		
		{
		  return *(float *)(param1 + 0x2c) * (float)*(int *)(param2 + 0x1c);
		}
		*/


		/* --- GHIDRA: GetCellWidthFor ---
		void Com_TheFallenGames_OSA_Demos_GridDifferentItemSizes_MyGridParams__GetCellWidthFor
		               (int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x60) = 1;
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridParams__InitOrReinitCellGroupPrefabLayoutGroup
		            (param1,0);
		  return;
		}
		*/

}
