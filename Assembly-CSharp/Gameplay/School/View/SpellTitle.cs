using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000643 RID: 1603
	[Token(Token = "0x2000643")]
	public class SpellTitle : CustomTitle
	{
		// Token: 0x17000747 RID: 1863
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000747")]
		public string ImageUrl
		{
			[Token(Token = "0x60026DB")]
			[Address(RVA = "0x7810", Offset = "0x7810", VA = "0x7810")]
			set
			{
			}
		}

		// Token: 0x17000748 RID: 1864
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000748")]
		public string Title
		{
			[Token(Token = "0x60026DC")]
			[Address(RVA = "0x7811", Offset = "0x7811", VA = "0x7811")]
			set
			{
			}
		}

		// Token: 0x17000749 RID: 1865
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000749")]
		public int Level
		{
			[Token(Token = "0x60026DD")]
			[Address(RVA = "0x7812", Offset = "0x7812", VA = "0x7812")]
			set
			{
			}
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026DE")]
		[Address(RVA = "0x7813", Offset = "0x7813", VA = "0x7813")]
		public SpellTitle()
		{
		}

		// Token: 0x04001549 RID: 5449
		[Token(Token = "0x4001549")]
		private const string SPELL_LEVEL = "SCHOOL/SPELL/LEVEL";

		// Token: 0x0400154A RID: 5450
		[Token(Token = "0x400154A")]
		private const string LEVEL_TAG = "value";

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImageLoader _imageLoader;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _level;
	}
}
