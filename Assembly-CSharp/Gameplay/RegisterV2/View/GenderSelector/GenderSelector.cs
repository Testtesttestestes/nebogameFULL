using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RegisterV2.View.GenderSelector
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	public class GenderSelector : MonoBehaviour
	{
		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x0600214A RID: 8522 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x17000618")]
		public int SelectedIndex
		{
			[Token(Token = "0x600214A")]
			[Address(RVA = "0x72AC", Offset = "0x72AC", VA = "0x72AC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214B")]
		[Address(RVA = "0x72AD", Offset = "0x72AD", VA = "0x72AD")]
		public void Init(IList<GenderListElement.GenderListElementArgs> args)
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600214C")]
		[Address(RVA = "0x72AE", Offset = "0x72AE", VA = "0x72AE")]
		public GenderSelector()
		{
		}

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GenderListElement[] _genders;
	}
}
