using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000577 RID: 1399
	[Token(Token = "0x2000577")]
	public class CultRatingListElement : CultInRatingListElement
	{
		// Token: 0x06002199 RID: 8601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002199")]
		[Address(RVA = "0x72F8", Offset = "0x72F8", VA = "0x72F8", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Rating_View_CultRatingListElement__ApplyArgs(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a58028 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_CultInRatingListElement_CultInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a58028 = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x24);
		  if (*(int *)(*(int *)(param1 + 0x38) + 0xc) < iVar1) {
		    param1_00 = *(undefined4 *)(param1 + 0x34);
		    if (*(char *)(*(int *)(param1 + 0x18) + 0x28) == '\0') {
		      puVar2 = (undefined4 *)(param1 + 0x3c);
		    }
		    else {
		      puVar2 = (undefined4 *)(param1 + 0x40);
		    }
		  }
		  else {
		    puVar2 = (undefined4 *)(iVar1 * 4 + *(int *)(param1 + 0x38) + 0xc);
		    param1_00 = *(undefined4 *)(param1 + 0x34);
		  }
		  func_ii_7050(param1_00,*puVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219A")]
		[Address(RVA = "0x72F9", Offset = "0x72F9", VA = "0x72F9")]
		private void DetermineDecorSprite()
		{
		/* --- GHIDRA: DetermineDecorSprite ---
		void Gameplay_Rating_View_CultRatingListElement__DetermineDecorSprite
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58026 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_CultInRatingListElement_CultInRatingListElementArgs___ctor__
		              );
		    DAT_ram_00a58026 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_CultInRatingListElement_CultInRatingListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600219B")]
		[Address(RVA = "0x72FA", Offset = "0x72FA", VA = "0x72FA")]
		public CultRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Rating_View_CultRatingListElement___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58029 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_CultInRatingsViewsHolder_TypeInfo);
		    DAT_ram_00a58029 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_View_CultInRatingsViewsHolder_TypeInfo);
		  if (DAT_ram_00a5802c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_CultInRatingListElement___ctor__);
		    DAT_ram_00a5802c = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400125B RID: 4699
		[Token(Token = "0x400125B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x0400125C RID: 4700
		[Token(Token = "0x400125C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x0400125D RID: 4701
		[Token(Token = "0x400125D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x0400125E RID: 4702
		[Token(Token = "0x400125E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
