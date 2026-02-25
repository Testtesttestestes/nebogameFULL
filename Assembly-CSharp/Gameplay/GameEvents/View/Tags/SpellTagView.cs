using System;
using Il2CppDummyDll;
using UI.Elements.Buildings;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000788 RID: 1928
	[Token(Token = "0x2000788")]
	public class SpellTagView : MonoBehaviour
	{
		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008D0")]
		public SpellItem SpellView
		{
			[Token(Token = "0x6002DD1")]
			[Address(RVA = "0x7E4F", Offset = "0x7E4F", VA = "0x7E4F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x7E50", Offset = "0x7E50", VA = "0x7E50")]
		public SpellTagView()
		{
		}

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SpellItem _spellView;
	}
}
