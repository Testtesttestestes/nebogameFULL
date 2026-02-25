using System;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x02000971 RID: 2417
	[Token(Token = "0x2000971")]
	public class TurnHint : MonoBehaviour
	{
		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x0000B700 File Offset: 0x00009900
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B4C")]
		public bool Visible
		{
			[Token(Token = "0x6003988")]
			[Address(RVA = "0x8919", Offset = "0x8919", VA = "0x8919")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003989")]
			[Address(RVA = "0x891A", Offset = "0x891A", VA = "0x891A")]
			set
			{
			}
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x891B", Offset = "0x891B", VA = "0x891B")]
		private void HandleVisibleChanged()
		{
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x891C", Offset = "0x891C", VA = "0x891C")]
		public void Move(int srcX, int srcY, int dstX, int dstY)
		{
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x891D", Offset = "0x891D", VA = "0x891D")]
		public TurnHint()
		{
		}

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineAnimation _arrowAnimation;

		// Token: 0x04001FDA RID: 8154
		[Token(Token = "0x4001FDA")]
		[FieldOffset(Offset = "0x14")]
		private bool _visible;
	}
}
