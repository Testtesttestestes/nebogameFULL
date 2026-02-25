using System;
using Gameplay.UserInfo.View;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.History
{
	// Token: 0x02000317 RID: 791
	[Token(Token = "0x2000317")]
	public class ParticipantRow : TitleIconValueBackground
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x6445", Offset = "0x6445", VA = "0x6445")]
		public void Init(HistoryModel.Participant participant)
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x6446", Offset = "0x6446", VA = "0x6446")]
		public ParticipantRow()
		{
		}

		// Token: 0x040009BF RID: 2495
		[Token(Token = "0x40009BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _deadObject;

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _dollIcon;
	}
}
