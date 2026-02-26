using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.RatingElements.SubRatings
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	public class SubRatingListElement : SelectedGenericListElement<SubRatingListElementArgs>
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000D66 RID: 3430 RVA: 0x00004050 File Offset: 0x00002250
		// (set) Token: 0x06000D67 RID: 3431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C1")]
		public override bool Selected
		{
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x6049", Offset = "0x6049", VA = "0x6049", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x604A", Offset = "0x604A", VA = "0x604A", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x604B", Offset = "0x604B", VA = "0x604B", Slot = "4")]
		protected override void OnInit(SubRatingListElementArgs args)
		{
		/* --- GHIDRA: OnInit ---
		void UI_Elements_RatingElements_SubRatings_SubRatingListElement__OnInit
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63977 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_SubRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a63977 = '\x01';
		  }
		  UI_Elements_GenericList_SelectedGenericListArgs_object____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectedGenericListElement_SubRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x604C", Offset = "0x604C", VA = "0x604C")]
		public SubRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_RatingElements_SubRatings_SubRatingListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  *(undefined4 *)(param1 + 8) = 0xffffffff;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/

		}

		// Token: 0x040006AA RID: 1706
		[Token(Token = "0x40006AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _normalImage;

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameRawImageLoader _icon;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Selected ---
		void UI_Elements_RatingElements_SubRatings_SubRatingListElement__get_Selected
		               (int param1,uint param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63975 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectedGenericListElement_SubRatingListElementArgs__set_Selected__
		              );
		    DAT_ram_00a63975 = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x20),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2 ^ 1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x24),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2,0);
		  *(char *)(param1 + 0x1d) = (char)param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_Selected ---
		void UI_Elements_RatingElements_SubRatings_SubRatingListElement__set_Selected
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63976 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a63976 = '\x01';
		  }
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (param1[10],*(undefined4 *)(*(int *)(param2 + 0xc) + 0x18),
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  iVar1 = *(int *)param1[0xb];
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            ((int *)param1[0xb],*(undefined4 *)(*(int *)(param2 + 0xc) + 0x10),
		             *(undefined4 *)(iVar1 + 0x2d4));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/

}
