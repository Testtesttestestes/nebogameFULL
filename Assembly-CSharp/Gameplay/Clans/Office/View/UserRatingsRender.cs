using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x02000A01 RID: 2561
	[Token(Token = "0x2000A01")]
	public class UserRatingsRender : MonoBehaviour
	{
		// Token: 0x06003CF0 RID: 15600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x8BB0", Offset = "0x8BB0", VA = "0x8BB0")]
		public void RenderRatings(UserData user, Dictionaries dict)
		{
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x8BB1", Offset = "0x8BB1", VA = "0x8BB1")]
		public UserRatingsRender()
		{
		}

		// Token: 0x040021CE RID: 8654
		[Token(Token = "0x40021CE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackground _ratingPointsRowPrefab;

		// Token: 0x040021CF RID: 8655
		[Token(Token = "0x40021CF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _ratingPointsContainer;

		// Token: 0x040021D0 RID: 8656
		[Token(Token = "0x40021D0")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<GameObject> _instances;
	}
}
