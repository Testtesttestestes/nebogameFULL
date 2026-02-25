using System;
using System.Collections.Generic;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Elements.RightPanel.TitledList;
using UnityEngine;

namespace Gameplay.School.View
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	public class TitledListWithSpellTitle : TitledListWithCustomTitle<SpellTitle>, IDiscountTarget
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700074A")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x60026E3")]
			[Address(RVA = "0x7818", Offset = "0x7818", VA = "0x7818", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E4")]
		[Address(RVA = "0x7819", Offset = "0x7819", VA = "0x7819", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x781A", Offset = "0x781A", VA = "0x781A")]
		public TitledListWithSpellTitle()
		{
		}

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;
	}
}
