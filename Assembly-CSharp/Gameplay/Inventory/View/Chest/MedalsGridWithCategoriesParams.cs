using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	[Serializable]
	public class MedalsGridWithCategoriesParams : GridParams
	{
		// Token: 0x060028B4 RID: 10420 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028B4")]
		[Address(RVA = "0x79D3", Offset = "0x79D3", VA = "0x79D3", Slot = "9")]
		protected override GameObject CreateCellGroupPrefabGameObject()
		{
			return null;
		}

		// Token: 0x060028B5 RID: 10421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B5")]
		[Address(RVA = "0x79D4", Offset = "0x79D4", VA = "0x79D4")]
		public MedalsGridWithCategoriesParams()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Chest_MedalsGridWithCategoriesParams___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a11e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder__CollectViews__
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
		    DAT_ram_00a5a11e = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_object____ctor
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_MedalCellViewHolder__CollectViews__
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

		// Token: 0x04001679 RID: 5753
		[Token(Token = "0x4001679")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _cellGroupPrefab;
	}
}
