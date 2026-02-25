using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public class MonsterDifficultyAndLevelTitledListElement : BaseTitledListElement<MonsterDifficultyAndLevelTitledListElement.MonsterDifficultyAndLevelTitledListElementArgs>
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BB")]
		public string Text
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x601D", Offset = "0x601D", VA = "0x601D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x601E", Offset = "0x601E", VA = "0x601E")]
			set
			{
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x601F", Offset = "0x601F", VA = "0x601F", Slot = "6")]
		protected override void OnInit(MonsterDifficultyAndLevelTitledListElement.MonsterDifficultyAndLevelTitledListElementArgs args)
		{
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x6020", Offset = "0x6020", VA = "0x6020")]
		public MonsterDifficultyAndLevelTitledListElement()
		{
		}

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x02000209 RID: 521
		[Token(Token = "0x2000209")]
		public class MonsterDifficultyAndLevelTitledListElementArgs : BaseTitledListElementArgs
		{
			// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x6021", Offset = "0x6021", VA = "0x6021")]
			public MonsterDifficultyAndLevelTitledListElementArgs()
			{
			}
		}
	}
}
