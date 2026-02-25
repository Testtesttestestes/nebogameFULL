using System;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000787 RID: 1927
	[Token(Token = "0x2000787")]
	public class MedalTagView : MonoBehaviour
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008CF")]
		public MedalView MedalView
		{
			[Token(Token = "0x6002DCF")]
			[Address(RVA = "0x7E4D", Offset = "0x7E4D", VA = "0x7E4D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD0")]
		[Address(RVA = "0x7E4E", Offset = "0x7E4E", VA = "0x7E4E")]
		public MedalTagView()
		{
		}

		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MedalView _medalView;
	}
}
