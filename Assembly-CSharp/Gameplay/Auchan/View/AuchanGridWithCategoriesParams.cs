using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C87 RID: 3207
	[Token(Token = "0x2000C87")]
	[Serializable]
	public class AuchanGridWithCategoriesParams : GridParams
	{
		// Token: 0x06004E38 RID: 20024 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x9C6B", Offset = "0x9C6B", VA = "0x9C6B", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06004E39 RID: 20025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD7")]
		public Sprite[] MarkerSprites
		{
			[Token(Token = "0x6004E39")]
			[Address(RVA = "0x9C6C", Offset = "0x9C6C", VA = "0x9C6C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x9C6D", Offset = "0x9C6D", VA = "0x9C6D")]
		public AuchanGridWithCategoriesParams()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_View_AuchanGridWithCategoriesParams___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59851 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder__CollectViews__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_TextMeshProUGUI___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_8809);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8808);
		    DAT_ram_00a59851 = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_object____ctor
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_AuchanArtifactCellViewHolder__CollectViews__
		            );
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 8),0);
		  uVar1 = UnityEngine_GameObject__GetComponent_object_
		                    (uVar1,Method_UnityEngine_GameObject_AddComponent_ContentSizeFitter___);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  UnityEngine_UI_ContentSizeFitter__get_verticalFit(uVar1,2,0);
		  UnityEngine_Object__op_Implicit(*(undefined4 *)(param1 + 0x24),1,0);
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_8808,param1 + 0x28,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_Transform___
		            );
		  frame8_Logic_Misc_Other_Extensions_TransformExtensions__GetComponentAtPath_object_
		            (*(undefined4 *)(param1 + 8),StringLiteral_8809,param1 + 0x2c,
		             Method_frame8_Logic_Misc_Other_Extensions_TransformExtensions_GetComponentAtPath_TextMeshProUGUI___
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002AB8 RID: 10936
		[Token(Token = "0x4002AB8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cellGroupPrefab;

		// Token: 0x04002AB9 RID: 10937
		[Token(Token = "0x4002AB9")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Sprite[] _markersSprites;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_MarkerSprites ---
		void Gameplay_Auchan_View_AuchanGridWithCategoriesParams__get_MarkerSprites
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59850 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Sprite___TypeInfo);
		    DAT_ram_00a59850 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Sprite___TypeInfo,4);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_GridParams__InitOrReinitCellGroupPrefabLayoutGroup
		            (param1,0);
		  return;
		}
		*/

}
