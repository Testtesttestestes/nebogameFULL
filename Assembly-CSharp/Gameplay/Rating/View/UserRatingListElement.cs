using System;
using Gameplay.Clans.Office.View.ClanResumesTab;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Rating.View
{
	// Token: 0x02000588 RID: 1416
	[Token(Token = "0x2000588")]
	public class UserRatingListElement : UserInRatingListElement
	{
		// Token: 0x060021C7 RID: 8647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x7326", Offset = "0x7326", VA = "0x7326", Slot = "11")]
		protected override void ApplyArgs()
		{
		/* --- GHIDRA: ApplyArgs ---
		void Gameplay_Rating_View_UserRatingListElement__ApplyArgs(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  
		  if (DAT_ram_00a5803a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__get_args__
		              );
		    DAT_ram_00a5803a = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x18) + 0x28);
		  if ((iVar1 < 1) || (*(int *)(*(int *)(param1 + 0x3c) + 0xc) < iVar1)) {
		    param1_00 = *(undefined4 *)(param1 + 0x38);
		    if (*(char *)(*(int *)(param1 + 0x18) + 0x2c) == '\0') {
		      puVar2 = (undefined4 *)(param1 + 0x40);
		    }
		    else {
		      puVar2 = (undefined4 *)(param1 + 0x44);
		    }
		  }
		  else {
		    puVar2 = (undefined4 *)(iVar1 * 4 + *(int *)(param1 + 0x3c) + 0xc);
		    param1_00 = *(undefined4 *)(param1 + 0x38);
		  }
		  func_ii_7050(param1_00,*puVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x7327", Offset = "0x7327", VA = "0x7327")]
		private void DetermineDecorSprite()
		{
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x7328", Offset = "0x7328", VA = "0x7328")]
		public UserRatingListElement()
		{
		}

		// Token: 0x04001290 RID: 4752
		[Token(Token = "0x4001290")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Image _decorIcon;

		// Token: 0x04001291 RID: 4753
		[Token(Token = "0x4001291")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite[] _placesDecors;

		// Token: 0x04001292 RID: 4754
		[Token(Token = "0x4001292")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _defaultDecor;

		// Token: 0x04001293 RID: 4755
		[Token(Token = "0x4001293")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite _myDecor;
	}
}
