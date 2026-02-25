using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000784 RID: 1924
	[Token(Token = "0x2000784")]
	public class ArtikulTagView : MonoBehaviour
	{
		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008CD")]
		public ArtikulView View
		{
			[Token(Token = "0x6002DC9")]
			[Address(RVA = "0x7E47", Offset = "0x7E47", VA = "0x7E47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x7E48", Offset = "0x7E48", VA = "0x7E48")]
		public ArtikulTagView()
		{
		}

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtikulView _view;
	}
}
