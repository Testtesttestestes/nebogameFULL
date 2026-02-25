using System;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Combat.View
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	public class ClanTitle : MonoBehaviour
	{
		// Token: 0x0600410B RID: 16651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x8FC2", Offset = "0x8FC2", VA = "0x8FC2")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x8FC3", Offset = "0x8FC3", VA = "0x8FC3")]
		public void SetCount(int value)
		{
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x8FC4", Offset = "0x8FC4", VA = "0x8FC4")]
		public void SetCult(ClanData clan)
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x8FC5", Offset = "0x8FC5", VA = "0x8FC5")]
		public ClanTitle()
		{
		}

		// Token: 0x0400241B RID: 9243
		[Token(Token = "0x400241B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400241C RID: 9244
		[Token(Token = "0x400241C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _count;

		// Token: 0x0400241D RID: 9245
		[Token(Token = "0x400241D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CultView _cult;
	}
}
