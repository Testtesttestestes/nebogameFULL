using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4D RID: 3405
	[Token(Token = "0x2000D4D")]
	public class AprDiscountView : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010EE")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6005361")]
			[Address(RVA = "0xA120", Offset = "0xA120", VA = "0xA120", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010EF")]
		public AprData AprData
		{
			[Token(Token = "0x6005362")]
			[Address(RVA = "0xA121", Offset = "0xA121", VA = "0xA121")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005363")]
			[Address(RVA = "0xA122", Offset = "0xA122", VA = "0xA122")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005364")]
		[Address(RVA = "0xA123", Offset = "0xA123", VA = "0xA123")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005365")]
		[Address(RVA = "0xA124", Offset = "0xA124", VA = "0xA124", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005366")]
		[Address(RVA = "0xA125", Offset = "0xA125", VA = "0xA125")]
		public AprDiscountView()
		{
		}

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private DiscountGroup _discountGroup;
	}
}
