using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.RatingElements
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public class TopLeader : MonoBehaviour
	{
		// Token: 0x140000EC RID: 236
		// (add) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D58 RID: 3416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EC")]
		private event Action OnClick
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x603A", Offset = "0x603A", VA = "0x603A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x603B", Offset = "0x603B", VA = "0x603B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x603C", Offset = "0x603C", VA = "0x603C")]
		private void Awake()
		{
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x603D", Offset = "0x603D", VA = "0x603D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x603E", Offset = "0x603E", VA = "0x603E")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x603F", Offset = "0x603F", VA = "0x603F")]
		public void Init(UserData userData)
		{
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x6040", Offset = "0x6040", VA = "0x6040")]
		public void Init(CultDic cultDic)
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x6041", Offset = "0x6041", VA = "0x6041")]
		public void Init(ClanData clanData, Action<ClanData> callback)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x6042", Offset = "0x6042", VA = "0x6042")]
		public TopLeader()
		{
		}

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _gameImage;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _playerBg;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _cultBg;
	}
}
