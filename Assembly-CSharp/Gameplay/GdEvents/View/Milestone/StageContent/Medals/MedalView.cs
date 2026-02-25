using System;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Medals
{
	// Token: 0x0200072A RID: 1834
	[Token(Token = "0x200072A")]
	public class MedalView : MonoBehaviour
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000858")]
		public MedalView Medal
		{
			[Token(Token = "0x6002BD5")]
			[Address(RVA = "0x7C66", Offset = "0x7C66", VA = "0x7C66")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000859")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002BD6")]
			[Address(RVA = "0x7C67", Offset = "0x7C67", VA = "0x7C67")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x7C68", Offset = "0x7C68", VA = "0x7C68")]
		public MedalView()
		{
		}

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MedalView _medal;
	}
}
