using System;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000572 RID: 1394
	[Token(Token = "0x2000572")]
	public class ClanRatingListElement : ClanInRatingListElement
	{
		// Token: 0x0600218E RID: 8590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218E")]
		[Address(RVA = "0x72ED", Offset = "0x72ED", VA = "0x72ED", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Rating_View_ClanRatingListElement__ApplyArgs(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 *puVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a58020 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_ClanInRatingListElement_ClanInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a58020 = '\x01';
		  }
		  uVar2 = *(uint *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x1c);
		  if ((longlong)*(int *)(*(int *)(param1 + 0x44) + 0xc) < (longlong)(ulonglong)uVar2) {
		    param1_00 = *(undefined4 *)(param1 + 0x40);
		    if (*(char *)(*(int *)(param1 + 0x18) + 0x28) == '\0') {
		      puVar1 = (undefined4 *)(param1 + 0x48);
		    }
		    else {
		      puVar1 = (undefined4 *)(param1 + 0x4c);
		    }
		  }
		  else {
		    puVar1 = (undefined4 *)(uVar2 * 4 + *(int *)(param1 + 0x44) + 0xc);
		    param1_00 = *(undefined4 *)(param1 + 0x40);
		  }
		  func_ii_7050(param1_00,*puVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600218F")]
		[Address(RVA = "0x72EE", Offset = "0x72EE", VA = "0x72EE")]
		private void DetermineDecorSprite()
		{
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002190")]
		[Address(RVA = "0x72EF", Offset = "0x72EF", VA = "0x72EF")]
		public ClanRatingListElement()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Rating_View_ClanRatingListElement___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58021 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_UserInCommonRatingsViewsHolder_TypeInfo);
		    DAT_ram_00a58021 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Rating_View_UserInCommonRatingsViewsHolder_TypeInfo);
		  if (DAT_ram_00a58024 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_ItemViewsHolder_UserInRatingListElement___ctor__);
		    DAT_ram_00a58024 = '\x01';
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
