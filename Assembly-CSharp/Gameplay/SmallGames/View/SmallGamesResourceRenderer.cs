using System;
using Core.Money;
using Gameplay.ResourceBar.View;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200051F RID: 1311
	[Token(Token = "0x200051F")]
	public class SmallGamesResourceRenderer : MonoBehaviour
	{
		// Token: 0x06001F35 RID: 7989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x709C", Offset = "0x709C", VA = "0x709C")]
		public void SetIndex(int index)
		{
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x709D", Offset = "0x709D", VA = "0x709D")]
		public void Init(Money resource, Dictionaries dict)
		{
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x709E", Offset = "0x709E", VA = "0x709E")]
		public void Init(ResourceSet resourceSet, Protocol.Consts.Resources resourceId, Dictionaries dict)
		{
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x1D14", Offset = "0x1D14", VA = "0x1D14")]
		public void Init(RewardInfo rewardInfo)
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x709F", Offset = "0x709F", VA = "0x709F")]
		private void DetermineIcon(RewardTypes type)
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x70A0", Offset = "0x70A0", VA = "0x70A0")]
		public SmallGamesResourceRenderer()
		{
		}

		// Token: 0x040010F2 RID: 4338
		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarIconValueView _iconValueView;

		// Token: 0x040010F3 RID: 4339
		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x040010F4 RID: 4340
		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _darkSprite;
	}
}
