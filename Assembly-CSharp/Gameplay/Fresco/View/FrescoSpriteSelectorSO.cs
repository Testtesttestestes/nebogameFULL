using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007F7 RID: 2039
	[Token(Token = "0x20007F7")]
	[CreateAssetMenu(fileName = "FrescoSpriteSelector", menuName = "Heavens/FrescoSpriteSelector", order = 0)]
	public class FrescoSpriteSelectorSO : ScriptableObject
	{
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000961")]
		public List<FrescoSpriteSelectorSO.SpriteSelectorElement> SpriteSelector
		{
			[Token(Token = "0x6002FEF")]
			[Address(RVA = "0x8055", Offset = "0x8055", VA = "0x8055")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x8056", Offset = "0x8056", VA = "0x8056")]
		public FrescoSpriteSelectorSO()
		{
		}

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0xC")]
		[SerializeField]
		private List<FrescoSpriteSelectorSO.SpriteSelectorElement> _spriteSelector;

		// Token: 0x020007F8 RID: 2040
		[Token(Token = "0x20007F8")]
		[Serializable]
		public class SpriteSelectorElement
		{
			// Token: 0x06002FF1 RID: 12273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF1")]
			[Address(RVA = "0x8057", Offset = "0x8057", VA = "0x8057")]
			public SpriteSelectorElement()
			{
			}

			// Token: 0x04001A32 RID: 6706
			[Token(Token = "0x4001A32")]
			[FieldOffset(Offset = "0x8")]
			public Vector2Int Ratio;

			// Token: 0x04001A33 RID: 6707
			[Token(Token = "0x4001A33")]
			[FieldOffset(Offset = "0x10")]
			public int RowCount;

			// Token: 0x04001A34 RID: 6708
			[Token(Token = "0x4001A34")]
			[FieldOffset(Offset = "0x14")]
			public int FieldHeight;

			// Token: 0x04001A35 RID: 6709
			[Token(Token = "0x4001A35")]
			[FieldOffset(Offset = "0x18")]
			public int GridHeight;

			// Token: 0x04001A36 RID: 6710
			[Token(Token = "0x4001A36")]
			[FieldOffset(Offset = "0x1C")]
			public Sprite InnerBorder;

			// Token: 0x04001A37 RID: 6711
			[Token(Token = "0x4001A37")]
			[FieldOffset(Offset = "0x20")]
			public Sprite OuterBorder;

			// Token: 0x04001A38 RID: 6712
			[Token(Token = "0x4001A38")]
			[FieldOffset(Offset = "0x24")]
			public Sprite SlotBg;
		}
	}
}
