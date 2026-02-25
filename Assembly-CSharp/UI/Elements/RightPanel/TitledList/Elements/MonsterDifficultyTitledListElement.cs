using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	public class MonsterDifficultyTitledListElement : BaseTitledListElement<MonsterDifficultyTitledListElementArgs>
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		public string Difficulty
		{
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x6022", Offset = "0x6022", VA = "0x6022")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x6023", Offset = "0x6023", VA = "0x6023")]
			set
			{
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x6024", Offset = "0x6024", VA = "0x6024", Slot = "6")]
		protected override void OnInit(MonsterDifficultyTitledListElementArgs args)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x6025", Offset = "0x6025", VA = "0x6025")]
		public MonsterDifficultyTitledListElement()
		{
		}

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _difficulty;
	}
}
