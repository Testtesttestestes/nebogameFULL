using System;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009FF RID: 2559
	[Token(Token = "0x20009FF")]
	public class ClanVacanciesBasicInfo : MonoBehaviour
	{
		// Token: 0x06003CEA RID: 15594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x8BAA", Offset = "0x8BAA", VA = "0x8BAA")]
		public void Init(ClanOfficeData isleData)
		{
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x8BAB", Offset = "0x8BAB", VA = "0x8BAB")]
		public ClanVacanciesBasicInfo()
		{
		}

		// Token: 0x040021C9 RID: 8649
		[Token(Token = "0x40021C9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ClanTitle _title;

		// Token: 0x040021CA RID: 8650
		[Token(Token = "0x40021CA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _vacancies;

		// Token: 0x040021CB RID: 8651
		[Token(Token = "0x40021CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _totalMembers;
	}
}
