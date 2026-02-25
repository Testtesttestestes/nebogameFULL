using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Elements.RatingElements
{
	// Token: 0x02000217 RID: 535
	[Token(Token = "0x2000217")]
	public class TopLeaders : MonoBehaviour
	{
		// Token: 0x06000D62 RID: 3426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D62")]
		[Address(RVA = "0x6045", Offset = "0x6045", VA = "0x6045")]
		public void Init(IEnumerable<UserData> users)
		{
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D63")]
		[Address(RVA = "0x6046", Offset = "0x6046", VA = "0x6046")]
		public void Init(IEnumerable<ClanData> clans, Action<ClanData> callback)
		{
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D64")]
		[Address(RVA = "0x6047", Offset = "0x6047", VA = "0x6047")]
		public void Init(IEnumerable<CultDic> cults)
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D65")]
		[Address(RVA = "0x6048", Offset = "0x6048", VA = "0x6048")]
		public TopLeaders()
		{
		}

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TopLeader _firstLeader;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TopLeader _secondLeader;

		// Token: 0x040006A9 RID: 1705
		[Token(Token = "0x40006A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TopLeader _thirdLeader;
	}
}
