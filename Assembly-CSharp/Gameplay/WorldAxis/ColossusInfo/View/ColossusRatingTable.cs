using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.WorldAxis.Office.Model;
using Gameplay.WorldAxis.Office.View;
using Gameplay.WorldAxis.Office.View.Schedule;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x0200031F RID: 799
	[Token(Token = "0x200031F")]
	public class ColossusRatingTable : MonoBehaviour
	{
		// Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x646D", Offset = "0x646D", VA = "0x646D")]
		public void Init(IList<WorldAxisOfficeModel.ColossusClanRating> clanRatings, UserData user)
		{
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x646E", Offset = "0x646E", VA = "0x646E")]
		public ColossusRatingTable()
		{
		}

		// Token: 0x040009ED RID: 2541
		[Token(Token = "0x40009ED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TitleIconValueBackgroundPlace _rowPrefab;

		// Token: 0x040009EE RID: 2542
		[Token(Token = "0x40009EE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MyRatingRender _myRating;

		// Token: 0x040009EF RID: 2543
		[Token(Token = "0x40009EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x040009F0 RID: 2544
		[Token(Token = "0x40009F0")]
		[FieldOffset(Offset = "0x1C")]
		private ColossusRatingRender _render;
	}
}
