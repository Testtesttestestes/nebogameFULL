using System;
using AssetContent.Loaders;
using Gameplay.Bank.Model;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C38 RID: 3128
	[Token(Token = "0x2000C38")]
	public class BankOptionArtikulContainerView : MonoBehaviour
	{
		// Token: 0x17000F5E RID: 3934
		// (set) Token: 0x06004C44 RID: 19524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F5E")]
		public BankOptionArtikulContainerData Data
		{
			[Token(Token = "0x6004C44")]
			[Address(RVA = "0x9A87", Offset = "0x9A87", VA = "0x9A87")]
			set
			{
			}
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x9A88", Offset = "0x9A88", VA = "0x9A88")]
		public BankOptionArtikulContainerView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Bank_View_BankOptionArtikulContainerView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59769 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12569);
		    DAT_ram_00a59769 = '\x01';
		  }
		  return StringLiteral_12569;
		}
		*/

		}

		// Token: 0x0400298E RID: 10638
		[Token(Token = "0x400298E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x0400298F RID: 10639
		[Token(Token = "0x400298F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _mainTitle;

		// Token: 0x04002990 RID: 10640
		[Token(Token = "0x4002990")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _descText;

		// Token: 0x04002991 RID: 10641
		[Token(Token = "0x4002991")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _artikulsContainer;

		// Token: 0x04002992 RID: 10642
		[Token(Token = "0x4002992")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImageLoader _qualityBigBgLoader;

		// Token: 0x04002993 RID: 10643
		[Token(Token = "0x4002993")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _artikulTitle;

		// Token: 0x04002994 RID: 10644
		[Token(Token = "0x4002994")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _countText;

		// Token: 0x04002995 RID: 10645
		[Token(Token = "0x4002995")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _artikulsGridView;

		// Token: 0x04002996 RID: 10646
		[Token(Token = "0x4002996")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _layoutGroup;

		// Token: 0x04002997 RID: 10647
		[Token(Token = "0x4002997")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private ArtikulView _artikulViewPrefab;
	}
}
