using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Core;
using Il2CppDummyDll;

namespace Gameplay.Competition.Model
{
	// Token: 0x020008F5 RID: 2293
	[Token(Token = "0x20008F5")]
	public class OwnerRating
	{
		// Token: 0x14000173 RID: 371
		// (add) Token: 0x06003602 RID: 13826 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003603 RID: 13827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000173")]
		public event ChangedFromTo<OwnerRating> ChangedEvent
		{
			[Token(Token = "0x6003602")]
			[Address(RVA = "0x860F", Offset = "0x860F", VA = "0x860F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003603")]
			[Address(RVA = "0x8610", Offset = "0x8610", VA = "0x8610")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003604 RID: 13828 RVA: 0x0000AEC0 File Offset: 0x000090C0
		// (set) Token: 0x06003605 RID: 13829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABA")]
		public int Place
		{
			[Token(Token = "0x6003604")]
			[Address(RVA = "0x8611", Offset = "0x8611", VA = "0x8611")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003605")]
			[Address(RVA = "0x8612", Offset = "0x8612", VA = "0x8612")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x0000AED8 File Offset: 0x000090D8
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ABB")]
		public ulong Value
		{
			[Token(Token = "0x6003606")]
			[Address(RVA = "0x8613", Offset = "0x8613", VA = "0x8613")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6003607")]
			[Address(RVA = "0x8614", Offset = "0x8614", VA = "0x8614")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003608 RID: 13832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003608")]
		[Address(RVA = "0x8615", Offset = "0x8615", VA = "0x8615")]
		public void SetPlace(int value)
		{
		}

		// Token: 0x06003609 RID: 13833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003609")]
		[Address(RVA = "0x8616", Offset = "0x8616", VA = "0x8616")]
		public void SetValue(ulong value)
		{
		}

		// Token: 0x0600360A RID: 13834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360A")]
		[Address(RVA = "0x8617", Offset = "0x8617", VA = "0x8617")]
		public void SetValueWhitHistory(ulong value, IList<ulong> history)
		{
		}

		// Token: 0x0600360B RID: 13835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360B")]
		[Address(RVA = "0x8618", Offset = "0x8618", VA = "0x8618")]
		public void Fill(int place, ulong value)
		{
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600360C")]
		[Address(RVA = "0x8619", Offset = "0x8619", VA = "0x8619")]
		public OwnerRating()
		{
		}

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x18")]
		public ReadOnlyCollection<ulong> ValueHistory;
	}
}
